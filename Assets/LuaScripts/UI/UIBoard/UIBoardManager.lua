--[[
-- Author:passion
-- Date:2019-11-14 16:43:03
-- Desc: 游戏对象的Board面板，如血条，昵称等
-- 	例子：统一在UserAgent中
--	打开面板：UIBoardManager:GetInstance():Open(self,boardType)
--	关闭/销毁面板：UIBoardManager:GetInstance():Close(self)/Destroy(self)
--	刷新面板数据：UIBoardManager:GetInstance():Refresh(self)
--]]


local UIBoardManager = BaseClass("UIBoardManager", Singleton)

EBoardType={
    PLAYER=1,
    MONSTER=2,
	NPC=3,
}

EBoardType.GetName = function (boardType)
		if(boardType == EBoardType.PLAYER)then
			return UIWindowNames.UIBoardPlayer
		elseif(boardType == EBoardType.MONSTER)then
			return UIWindowNames.UIBoardMonster
		elseif(boardType == EBoardType.NPC)then
			return UIWindowNames.UIBoardNPC
		end
	end

-- 构造函数
local function __init(self)
	self.windows = {}
end

--打开面板或者创建（预制体是异步加载，所以不要放到update中持续open）
local function Open(self, owner, boardType, height, msg)
    Logger.Log("UIBoardManager.Open");
	
	--先赋值名字，方便多个同类型UI
	owner.id = owner.id or EBoardType.GetName(boardType);
	self:OpenWindow(owner, EBoardType.GetName(boardType), height, msg);
end

--刷新面板数据
local function Refresh(self, owner, boardType)
    Logger.Log("UIBoardManager.Refresh");

	local window = self:GetWindow(owner, EBoardType.GetName(boardType))
	if window then
		window.View:Refresh()
	end	
end

--关闭，隐藏，可再次打开
local function Close(self, owenr, boardType)
    Logger.Log("UIBoardManager.Close");

	self:CloseWindow(owenr, EBoardType.GetName(boardType))
end

--销毁面板
local function Destroy(self, owenr, boardType)
    Logger.Log("UIBoardManager.Destroy");

	self:CloseWindow(owenr, EBoardType.GetName(boardType), true)
end

-- 初始化窗口
local function InitWindow(self, ui_owner, ui_name, window)
	local config = UIConfig[ui_name]
	assert(config, "No window named : "..ui_name..".You should add it to UIConfig first!")
	
	local layer = UIManager.Instance.layers[config.Layer.Name]
	assert(layer, "No layer named : "..config.Layer.Name..".You should create it first!")
	
	window.Name = ui_name..ui_owner.id
	if config.Model then
		window.Model = config.Model.New(ui_name)
	end
	if config.Ctrl then
		window.Ctrl = config.Ctrl.New(window.Model)
	end
	if config.View then
		window.View = config.View.New(layer, window.Name, window.Model, window.Ctrl)
	end
	window.Active = false
	window.Layer = layer
	window.PrefabPath = config.PrefabPath
	
	UIManager.Instance:Broadcast(UIMessageNames.UIFRAME_ON_WINDOW_CREATE, window)
	return window
end

-- 激活窗口
local function ActivateWindow(self, target, owner, ...)
	assert(target)
	assert(target.IsLoading == false, "You can only activate window after prefab locaded!")
	target.Model:Activate(owner, ...)
	target.View:SetActive(true)
	target.View:Refresh()
	UIManager.Instance:Broadcast(UIMessageNames.UIFRAME_ON_WINDOW_OPEN, target)
end

-- 反激活窗口
local function Deactivate(self, target)
	target.Model:Deactivate()
	target.View:SetActive(false)
	UIManager.Instance:Broadcast(UIMessageNames.UIFRAME_ON_WINDOW_CLOSE, target)
end

-- 打开窗口：私有，必要时准备资源
local function InnerOpenWindow(self, target, owner, ...)
	assert(target)
	assert(target.Model)
	assert(target.Ctrl)
	assert(target.View)
	assert(target.Active == false, "You should close window before open again!")
	
	target.Active = true
	local has_view = target.View ~= UIBaseView
	local has_prefab_res = target.PrefabPath and #target.PrefabPath > 0
	local has_loaded = not IsNull(target.View.gameObject)
	local need_load = has_view and has_prefab_res and not has_loaded
	if not need_load then
		ActivateWindow(self, target, owner, ...)
	elseif not target.IsLoading then
		target.IsLoading = true
		local params = SafePack(...)
		GameObjectPool:GetInstance():GetGameObjectAsync(target.PrefabPath, function(go)
			if IsNull(go) then
				return
			end
			
			local trans = go.transform
			trans:SetParent(target.Layer.transform, false)
			trans.name = target.Name
			
			target.IsLoading = false
			target.View:OnCreate()
			if target.Active then
				ActivateWindow(self, target, owner, SafeUnpack(params))
			end
		end)
	end
end

-- 关闭窗口：私有
local function InnerCloseWindow(self, target)
	assert(target)
	assert(target.Model)
	assert(target.Ctrl)
	assert(target.View)
	if target.Active then
		Deactivate(self, target)
		target.Active = false
	end
end

local function InnerDelete(plugin)
	if plugin.__ctype == ClassType.instance then
		plugin:Delete()
	end
end

local function InnerDestroyWindow(self, owner, ui_name, target)
	UIManager.Instance:Broadcast(UIMessageNames.UIFRAME_ON_WINDOW_DESTROY, target)
	-- 说明：一律缓存，如果要真的清理，那是清理缓存时需要管理的功能
	GameObjectPool:GetInstance():RecycleGameObject(target.PrefabPath, target.View.gameObject)
	
	InnerDelete(target.Model)
	InnerDelete(target.Ctrl)
	InnerDelete(target.View)

	self.windows[owner][ui_name]=nil
end

-- 打开窗口：公有
local function OpenWindow(self, ui_owner, ui_name, ...)
	local target = self:GetWindow(ui_owner, ui_name)
	if not target then
        local window = UIWindow.New()
        self:SetWindow(ui_owner, ui_name, window)
		target = InitWindow(self, ui_owner, ui_name, window)
	end
	
	-- 先关闭
	InnerCloseWindow(self, target)
	InnerOpenWindow(self, target, ui_owner, ...)
end

-- 关闭窗口：公有
local function CloseWindow(self, owner, ui_name, destroy)
	local target = self:GetWindow(owner, ui_name)
	if not target then
		return
	end
	
	InnerCloseWindow(self, target)

	if(destroy)then
		InnerDestroyWindow(self, owner, ui_name, target)
	end
end

-- 获取窗口
local function GetWindow(self, ui_owner, ui_name)
    local target = self.windows[ui_owner]
    if(target == nil)then
        return nil
    end

	local window = target[ui_name]
	if window == nil then
		return nil
    end
    
	return window
end

local function SetWindow(self, ui_owner, ui_name, window)
    local target = self.windows[ui_owner]
    if(target == nil)then
        self.windows[ui_owner]={}
    end

    self.windows[ui_owner][ui_name] = window
end

local function ClearAllWindows(self)
	for owner,tb in pairs(self.windows) do
		for k,v in pairs(tb) do
			InnerCloseWindow(self, v)
			InnerDestroyWindow(self, owner, k, v)
		end
	end
end

UIBoardManager.__init = __init
UIBoardManager.Open = Open
UIBoardManager.Refresh = Refresh
UIBoardManager.Close = Close
UIBoardManager.Destroy = Destroy
UIBoardManager.InitWindow = InitWindow
UIBoardManager.ActivateWindow = ActivateWindow
UIBoardManager.Deactivate = Deactivate
UIBoardManager.OpenWindow = OpenWindow
UIBoardManager.CloseWindow = CloseWindow
UIBoardManager.GetWindow = GetWindow
UIBoardManager.SetWindow = SetWindow
UIBoardManager.ClearAllWindows = ClearAllWindows

return UIBoardManager;
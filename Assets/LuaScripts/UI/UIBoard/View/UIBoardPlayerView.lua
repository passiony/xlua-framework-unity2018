--[[
-- added by passion @ 2019/11/14 16:39:51
-- UIBoard视图层
-- 注意：
-- 1、成员变量最好预先在__init函数声明，提高代码可读性
-- 2、OnEnable函数每次在窗口打开时调用，直接刷新
-- 3、组件命名参考代码规范
--]]
local UIBoardPlayerView = BaseClass("UIBoardPlayerView", UIBaseView)
local base = UIBaseView
local nickname_path = "nickName";


local function OnCreate(self)
	base.OnCreate(self)
	-- 窗口生命周期内保持的成员变量放这
	self.nickName = self:AddComponent(UITextMeshPro, nickname_path)
end

-- 打开
local function OnEnable(self)
	base.OnEnable(self)
end

-- 关闭
local function OnDestroy(self)
	base.OnDestroy(self)
	-- 清理成员变量
end

local function LateUpdate(self)
	Logger.Log("LateUpdate");
	if (self.model.target == null)then
		return;
	end

	self:UpdatePosition();
end

local function UpdatePosition(self)
	local pos_3d = self.model.target.position;
	pos_3d.y = pos_3d.y + self.model.height
	
	Logger.Log(self.model.height)
	self.transform.position = pos_3d;
	self.transform:LookAt(Camera.main.transform);
	
	--3d->ui
	-- local pos_screen = CS.UnityEngine.Camera.main:WorldToScreenPoint(pos_3d);
	-- local pos_ui = UIManager.Instance.UICamera:ScreenToWorldPoint(pos_screen);
    -- self.transform.position = pos_ui;
end

local function Refresh(self)
	if(self.model.owner.id)then
		self.nickName:SetText(self.model.owner.nickName)
	end
end


UIBoardPlayerView.OnCreate = OnCreate
UIBoardPlayerView.OnEnable = OnEnable
UIBoardPlayerView.OnDestroy = OnDestroy
UIBoardPlayerView.LateUpdate = LateUpdate
UIBoardPlayerView.Refresh = Refresh
UIBoardPlayerView.UpdatePosition = UpdatePosition

return UIBoardPlayerView



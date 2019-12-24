--[[
-- added by passion @ 2019/11/14 16:39:51
-- UIBoard视图层
-- 注意：
-- 1、成员变量最好预先在__init函数声明，提高代码可读性
-- 2、OnEnable函数每次在窗口打开时调用，直接刷新
-- 3、组件命名参考代码规范
--]]
local UIBoardNPCView = BaseClass("UIBoardNPCView", UIBaseView)
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
	if (self.model.target == null)then
		return;
	end

	self:UpdatePosition();
end

local function UpdatePosition(self)
	local pos_3d = self.model.target.position;
	pos_3d.y = pos_3d.y + self.model.height
	self.transform.position = pos_3d;
	self.transform:LookAt(CAMERA_MAIN_TRANS);

	-- 3d -> ui
	-- local pos_screen = CAMERA_MAIN:WorldToScreenPoint(pos_3d);
	-- local pos_ui = UIManager.Instance.UICamera:ScreenToWorldPoint(pos_screen);
	-- self.transform.position = pos_ui;

	-- --根据远近计算board大小
	-- local offset = Vector3(pos_3d.x-CAMERA_MAIN_TRANS.position.x,pos_3d.y-CAMERA_MAIN_TRANS.position.y,pos_3d.z-CAMERA_MAIN_TRANS.position.z);
	-- local value = offset:Magnitude()
	-- value = math.min(10/value, 1.5)
	-- self.transform.localScale = Vector3.one * value;
end

local function Refresh(self)
	if(self.model.owner.id)then
		self.nickName:SetText(self.model.owner.nickName)
	end
end


UIBoardNPCView.OnCreate = OnCreate
UIBoardNPCView.OnEnable = OnEnable
UIBoardNPCView.OnDestroy = OnDestroy
UIBoardNPCView.LateUpdate = LateUpdate
UIBoardNPCView.Refresh = Refresh
UIBoardNPCView.UpdatePosition = UpdatePosition

return UIBoardNPCView



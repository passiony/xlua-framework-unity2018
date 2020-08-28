--[[
-- added by passion @ 2019-11-29
-- Lua侧UIPointerDrag
-- 注意：
-- 1、按钮一般会带有其他的组件，如带一个UIText、或者一个UIImange标识说明按钮功能，所以这里是一个容器类
-- 2、UIPointerDrag组件必须挂载在根节点，其下某个子节点有个Unity侧原生Button即可，如果有多个，需要指派相对路径
-- 使用方式：
-- self.xxx_btn = self:AddComponent(UIPointerDrag, var_arg)--添加孩子，各种重载方式查看UIBaseContainer
--]]

local UIPointerDrag = BaseClass("UIPointerDrag", UIBaseContainer)
local base = UIBaseContainer

-- 创建
local function OnCreate(self, relative_path)
	base.OnCreate(self)
	-- Unity侧原生组件
	self.unity_uidrag = UIUtil.FindComponent(self.transform, typeof(CS.UIPointerDrag), relative_path)
	-- 记录点击回调
	self.__onbeginDrag = nil
	self.__ondrag = nil
	self.__onbendDrag = nil
end

-- 点击回调
local function SetOnBeginDrag(self, ...)
	self.__onbeginDrag = BindCallback(...)
	self.unity_uidrag.onBeginDrag:AddListener(self.__onbeginDrag)
end
local function SetOnDrag(self, ...)
	self.__ondrag = BindCallback(...)
	self.unity_uidrag.onDrag:AddListener(self.__ondrag)
end
local function SetOnEndDrag(self, ...)
	self.__onbendDrag = BindCallback(...)
	self.unity_uidrag.onEndDrag:AddListener(self.__onbendDrag)
end

-- 资源释放
local function OnDestroy(self)
	if self.__onbeginDrag ~= nil then
		self.unity_uidrag.onBeginDrag:RemoveListener(self.__onbeginDrag)
	end
	if self.__ondrag ~= nil then
		self.unity_uidrag.onDrag:RemoveListener(self.__ondrag)
	end
	if self.__onbendDrag ~= nil then
		self.unity_uidrag.onEndDrag:RemoveListener(self.__onbendDrag)
	end

	self.unity_uidrag = nil
	
	self.__onbeginDrag = nil
	self.__ondrag = nil
	self.__onbendDrag = nil
	base.OnDestroy(self)
end

UIPointerDrag.OnCreate = OnCreate
UIPointerDrag.SetOnBeginDrag = SetOnBeginDrag
UIPointerDrag.SetOnDrag = SetOnDrag
UIPointerDrag.SetOnEndDrag = SetOnEndDrag
UIPointerDrag.OnDestroy = OnDestroy

return UIPointerDrag
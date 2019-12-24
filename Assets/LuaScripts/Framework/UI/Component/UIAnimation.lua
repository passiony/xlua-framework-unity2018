--[[
-- Author:passion
-- Date:2019-12-04 17:23:55
-- Desc: Lua侧UIAnimation
-- 注意：
-- 1.UIAnimation组件必须挂载到UI根节点上
-- 2.UI根节点上有CS侧的脚本UIBaseAnimation和Animator组件
-- 使用方式：
-- self.xxx_anim = self:AddComponent(UIAnimation)--添加
--]]

local UIAnimation = BaseClass("UIAnimation", UIBaseContainer)
local base = UIBaseContainer

-- 创建
local function OnCreate(self, relative_path)
	base.OnCreate(self)
	-- Unity侧原生组件
	self.ui_animation = UIUtil.FindComponent(self.transform, typeof(CS.UIBaseAnimation))
	self.unity_animator = UIUtil.FindComponent(self.transform, typeof(CS.UnityEngine.Animator))
	-- 记录点击回调
	self.__onopen = nil
	self.__onclose = nil
	
	if IsNull(self.ui_animation) and IsNull(self.gameObject) then
		self.gameObject = self.ui_animation.gameObject
		self.transform = self.ui_animation.transform
	end
end

local function PlayOpen(self)
	self.unity_animator:Play("Open")
end

local function PlayClose(self)
	self.unity_animator:Play("Close")
end

-- 设置回调
local function SetOnOpen(self, ...)
	self.__onopen = BindCallback(...)
	self.ui_animation.onOpen:AddListener(self.__onopen)
end
-- 设置
local function SetOnClose(self, ...)
	self.__onclose = BindCallback(...)
	self.ui_animation.onClose:AddListener(self.__onclose)
end

-- 资源释放
local function OnDestroy(self)
	if self.__onopen ~= nil then
		self.ui_animation.onOpen:RemoveListener(self.__onopen)
    end
    if self.__onclose ~= nil then
		self.ui_animation.onClose:RemoveListener(self.__onclose)
    end
    
	self.ui_animation = nil
	self.onOpen = nil
	self.onClose = nil
	base.OnDestroy(self)
end

local function SetDisable(self,isDisable)
	self.ui_animation.interactable = not isDisable
end

UIAnimation.OnCreate = OnCreate
UIAnimation.SetOnOpen = SetOnOpen
UIAnimation.SetOnClose = SetOnClose
UIAnimation.PlayOpen = PlayOpen
UIAnimation.PlayClose = PlayClose
UIAnimation.OnDestroy = OnDestroy
UIAnimation.SetDisable = SetDisable

return UIAnimation
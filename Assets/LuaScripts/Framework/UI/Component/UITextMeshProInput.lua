--[[
-- added by wsh @ 2017-12-08
-- Lua侧UITextMeshProInput
-- 使用方式：
-- self.xxx_input = self:AddComponent(UITextMeshProInput, var_arg)--添加孩子，各种重载方式查看UIBaseContainer
--]]

local UITextMeshProInput = BaseClass("UITextMeshProInput", UIBaseComponent)
local base = UIBaseComponent

-- 创建
local function OnCreate(self)
	base.OnCreate(self)
	-- Unity侧原生组件
	self.unity_UITextMeshProInput = UIUtil.FindComponent(self.transform, typeof(CS.TMPro.TMP_InputField))

	self.__onendedit = nil
	self.__onvaluechange = nil
	self.__onselect = nil
	self.__ondeselect = nil

	if not IsNull(self.unity_UITextMeshProInput) and IsNull(self.gameObject) then
		self.gameObject = self.unity_UITextMeshProInput.gameObject
		self.transform = self.unity_UITextMeshProInput.transform
	end
end

-- 获取文本
local function GetText(self)
	if not IsNull(self.unity_UITextMeshProInput) then
		return self.unity_UITextMeshProInput.text
	end
end

-- 设置文本
local function SetText(self, text)
	if not IsNull(self.unity_UITextMeshProInput) then
		self.unity_UITextMeshProInput.text = text
	end
end

-- 设置光标
local function ActivateInputField(self)
	self.unity_UITextMeshProInput:ActivateInputField()
end

-- 值改变时回调
local function SetOnValueChanged(self, ...)
	self.__onvaluechanged = BindCallback(...)
	self.unity_UITextMeshProInput.onValueChanged:AddListener(self.__onvaluechanged)
end

-- 结束编辑回调
local function SetOnEndEdit(self, ...)
	self.__onendedit = BindCallback(...)
	self.unity_UITextMeshProInput.onEndEdit:AddListener(self.__onendedit)
end

local function SetOnSelect(self, ...)
	self.__onselect = BindCallback(...)
	self.unity_UITextMeshProInput.onSelect:AddListener(self.__onselect)
end

local function SetOnDeselect(self, ...)
	self.__ondeselect = BindCallback(...)
	self.unity_UITextMeshProInput.onDeselect:AddListener(self.__ondeselect)
end

-- 销毁
local function OnDestroy(self)
	self.unity_UITextMeshProInput = nil
	self.__onendedit = nil
	self.__onvaluechange = nil
	self.__onselect = nil
	self.__ondeselect = nil
	base.OnDestroy(self)
end

UITextMeshProInput.OnCreate = OnCreate
UITextMeshProInput.GetText = GetText
UITextMeshProInput.SetText = SetText
UITextMeshProInput.SetOnSelect = SetOnSelect
UITextMeshProInput.SetOnDeselect = SetOnDeselect
UITextMeshProInput.SetOnEndEdit = SetOnEndEdit
UITextMeshProInput.SetOnValueChanged = SetOnValueChanged
UITextMeshProInput.ActivateInputField = ActivateInputField
UITextMeshProInput.OnDestroy = OnDestroy


return UITextMeshProInput
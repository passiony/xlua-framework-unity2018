--[[
-- Author:passion
-- Date:2019-11-24 15:41:38
-- Desc: self.xxx_text = self:AddComponent(UITextMeshProUGUI, var_arg)--添加孩子，各种重载方式查看UIBaseContainer
--]]

local UITextMeshProUGUI = BaseClass("UITextMeshProUGUI", UIBaseComponent)
local base = UIBaseComponent

-- 创建
local function OnCreate(self)
	base.OnCreate(self)
	-- Unity侧原生组件
	self.unity_uitext = UIUtil.FindComponent(self.transform, typeof(CS.TMPro.TextMeshProUGUI))
	
	if IsNull(self.unity_uitext) and not IsNull(self.gameObject) then
		self.gameObject = self.unity_uitext.gameObject
		self.transform = self.unity_uitext.transform
	end
end

-- 获取文本
local function GetText(self)
	if not IsNull(self.unity_uitext) then
		return self.unity_uitext.text
	end
end

-- 设置文本
local function SetText(self, text)
	if not IsNull(self.unity_uitext) then
		self.unity_uitext.text = text
	end
end

-- 设置文本颜色
local function SetColor(self,r, g, b, a)
	-- body
	if not IsNull(self.unity_uitext) then		
		self.unity_uitext.color = CS.UnityEngine.Color(r, g, b, a)
	end
end

-- 销毁
local function OnDestroy(self)
	self.unity_uitext = nil
	base.OnDestroy(self)
end

UITextMeshProUGUI.OnCreate = OnCreate
UITextMeshProUGUI.GetText = GetText
UITextMeshProUGUI.SetText = SetText
UITextMeshProUGUI.SetColor = SetColor
UITextMeshProUGUI.OnDestroy = OnDestroy

return UITextMeshProUGUI
--[[
-- added by passion @ 2019/11/14 16:39:51
-- UIBoard模块窗口配置，要使用还需要导出到UI.Config.UIConfig.lua
-- 窗口配置
--]]

local UIBoardPlayer= {
	Name = UIWindowNames.UIBoardPlayer,
	Layer = UILayers.BackgroudLayer,
	Model = require "UI.UIBoard.Model.UIBoardPlayerModel",
	Ctrl =  nil,
	View = require "UI.UIBoard.View.UIBoardPlayerView",
	PrefabPath = "UI/Prefabs/UIBoard/UIBoardPlayer.prefab",
}

local UIBoardNPC= {
	Name = UIWindowNames.UIBoardNPC,
	Layer = UILayers.BackgroudLayer,
	Model = require "UI.UIBoard.Model.UIBoardNPCModel",
	Ctrl =  nil,
	View = require "UI.UIBoard.View.UIBoardNPCView",
	PrefabPath = "UI/Prefabs/UIBoard/UIBoardNPC.prefab",
}

return {
	UIBoardPlayer=UIBoardPlayer,
	UIBoardNPC=UIBoardNPC,
}

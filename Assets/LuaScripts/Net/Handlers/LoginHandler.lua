--[[
-- Author: passion
-- Date: 2019-09-20 12:00:54
-- LastEditors: passion
-- LastEditTime: 2019-09-26 13:37:31
-- Description: 大厅网络连接器
--]]

local LoginHandler = BaseClass("LoginHandler")
local MsgIDDefine = require "Net.Config.MsgIDDefine"
local pb = require("pb");

local function OnLogin(self, msg_id, msg)
    Logger.Log(table.log_table(msg));
end

local function OnLogout(self, msg_id, msg)
    Logger.Log(table.log_table(msg));
end

--回调绑定，放到最下面，否则找不到函数
local function Init(self, handlers)
    handlers[MsgIDDefine.LOGIN_RSP_LOGIN] = Bind(self, OnLogin);
    handlers[MsgIDDefine.LOGIN_NTF_LOGOUT] = Bind(self, OnLogout);
end

LoginHandler.Init = Init
LoginHandler.OnLogin = OnLogin
LoginHandler.OnOtherLogin = OnOtherLogin
LoginHandler.OnLogout = OnLogout

return LoginHandler;
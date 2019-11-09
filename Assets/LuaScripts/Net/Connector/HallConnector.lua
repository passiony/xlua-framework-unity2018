--[[
-- Author: passion
-- Date: 2019-09-20 12:00:54
-- LastEditors: passion
-- LastEditTime: 2019-09-26 13:38:32
-- Description: 大厅网络连接器，socket长连接
--]]

local HallConnector = BaseClass("HallConnector", Singleton)
local MsgIDMap = require("Net/Config/MsgIDMap");
local pb = require("pb");
local LoginHandler = require("Net/Handlers/LoginHandler")

local ConnStatus = {
	Init = 0,
	Connecting = 1,
	WaitLogin = 2,
	Done = 3,
}

local function __init(self)
	self.hallSocket = nil
	self.handlers = {}

	local login = LoginHandler.New();
	login:Init(self.handlers);

	self:LoadPB();
end

local function LoadPB()

	local pbFiles={
		"Net/Proto/common.pb",
		"Net/Proto/login.pb",
		"Net/Proto/room.pb",
		"Net/Proto/user.pb",
	};
	
	--编辑器下和移动端，加载位置不同
	if(CS.GameUtility.GetPlatform() == "WindowsEditor")then
		table.walk(pbFiles,function(i,path)
			print(path.." pb load success")
			assert(pb.loadfile("Assets/LuaScripts/"..path))
		end)
	else
		table.walk(pbFiles,function(i,path)
			ResourcesManager:GetInstance():LoadAsync("Lua/"..path..".bytes", typeof(CS.UnityEngine.TextAsset), function(data)
				print(path.." pb load success")
				assert(pb.load(data.bytes))
			end)
		end)
	end
end

--接受数据
local function OnReceivePackage(self, receive_bytes)
	local receive = CS.ByteBuffer(receive_bytes);

	local msg_id = receive:ReadShort();
	local msg_bytes = receive:ReadBytes();
	
	Logger.Log("msg_id:"..msg_id.." | msg_bytes.len:"..#msg_bytes);
	if(msg_bytes ~= nil)then
		local msg = pb.decode(MsgIDMap[msg_id], msg_bytes)
	end
	
	if(self.handlers[msg_id]~=nil)then
		self.handlers[msg_id](msg_id, msg)
	else
		Logger.LogError("msg_id 未绑定函数"..msg_id);
	end
end

--连接服务器
local function Connect(self, host_ip, host_port, on_connect, on_close)
	if not self.hallSocket then
		self.hallSocket = CS.Networks.HjTcpNetwork()
		self.hallSocket.ReceivePkgHandle = Bind(self, OnReceivePackage)
	end
	self.hallSocket.OnConnect = on_connect
	self.hallSocket.OnClosed = on_close
	self.hallSocket:SetHostPort(host_ip, host_port)
	self.hallSocket:Connect()
	Logger.Log("Connect to "..host_ip..", port : "..host_port)

	return self.hallSocket
end

local function SendMessage(self, msg_id, msg)
	local send = CS.ByteBuffer();
	send:WriteShort(msg_id);
	if(msg)then
		local msg_bytes=pb.encode(MsgIDMap[msg_id], msg)
		send:WriteBytes(msg_bytes);
	end
	
	local bytes=send:ToBytes();
	Logger.Log("send messge："..msg_id.."；byte count："..#bytes);

	self.hallSocket:SendMessage(bytes);
end

local function Update(self)
	if self.hallSocket then
		self.hallSocket:UpdateNetwork()
	end
end

local function Disconnect(self)
	if self.hallSocket then
		self.hallSocket:Disconnect()
	end
end

local function Dispose(self)
	if self.hallSocket then
		self.hallSocket:Dispose()
	end
	self.hallSocket = nil
end

HallConnector.__init = __init
HallConnector.Connect = Connect
HallConnector.SendMessage = SendMessage
HallConnector.Update = Update
HallConnector.Disconnect = Disconnect
HallConnector.Dispose = Dispose
HallConnector.LoadPB = LoadPB

return HallConnector

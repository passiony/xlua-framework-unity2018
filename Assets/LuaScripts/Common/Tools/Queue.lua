--[[
-- Author:passion
-- Date:2019-12-09 15:10:52
-- Desc: 双向链表
--]]

local Queue = {}
Queue.__index = Queue

local function new()
	local t = {first = 0, last = -1}
	return setmetatable(t, Queue)
end

local function pushFront(self, value)
    local first = self.first - 1
    self.first = first
    self[first] = value
end

local function pushBack(self, value)
    local last = self.last + 1
    self.last = last
    self[last] = value
end

local function popFront(self)
    local first = self.first
    if first > self.last then
        return nil
    end
    local value = self[first]
    self[first] = nil
    self.first = first + 1
    return value
end

local function popBack(self)
    local last = self.last
    if self.first > last then
        return nil
    end
    local value = self[last]
    self[last] = nil
    self.last = last - 1
    return value
end

local function count(self)
    return table.count(self)-2
end

local function clear(self)
    repeat
        local dt = self:popFront()
    until(dt == nil)
end

Queue.new=new;
Queue.pushFront=pushFront;
Queue.pushBack=pushBack;
Queue.popFront=popFront;
Queue.popBack=popBack;
Queue.count=count;
Queue.clear=clear;

return Queue
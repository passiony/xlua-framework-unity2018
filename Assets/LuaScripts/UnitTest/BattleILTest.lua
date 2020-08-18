--[[
-- added by passion @ 2019/11/14 16:39:51
-- UIBoard模块窗口配置，要使用还需要导出到UI.Config.UIConfig.lua
-- 窗口配置
--]]

function Test0(transform)
    local t = os.clock()

    for i = 1, 2000000 do
        transform.position = {x = 1, y = 1, z = 1}
    end

    print("Test0 elapsed time: " .. (os.clock() - t) * 1000)
end

function Test1(transform)
    local t = os.clock()
    for i = 1, 2000000 do
        -- transform:SetAsFirstSibling()
        -- transform:Rotate(Vector3.up, 1)
        transform.rotation = Quaternion.identity
    end

    print("Test1 elapsed time: " .. (os.clock() - t) * 1000)
end

function Test2()
    local t = os.clock()

    for i = 1, 2000000 do
        local v = Vector3(i, i, i)
        local x, y, z = v.x, v.y, v.z
    end

    print("Test2 elapsed time: " .. (os.clock() - t) * 1000)
end

function Test3()
    local t = os.clock()

    for i = 1, 20000 do
        local go = GameObject()
    end

    print("Test3 elapsed time: " .. (os.clock() - t) * 1000)
end

function Test4()
    local t = os.clock()
    local tp = typeof(CS.UnityEngine.SkinnedMeshRenderer)

    for i = 1, 20000 do
        local go = GameObject()
        go:AddComponent(tp)
        local c = go:GetComponent(tp)
        c.receiveShadows = false
    end

    print("Test4 elapsed time: " .. (os.clock() - t) * 1000)
end

function Test5()
    local t = os.clock()

    for i = 1, 2000000 do
        local p = CS.UnityEngine.Input.mousePosition
        --Physics.RayCast
    end

    print("Test5 elapsed time: " .. (os.clock() - t) * 1000)
end

function Test6()
    local Vector3 = Vector3
    local t = os.clock()

    for i = 1, 2000000 do
        local v = Vector3(i, i, i)
        Vector3.Normalize(v)
    end

    print("Test6 elapsed time: " .. (os.clock() - t) * 1000)
end

function Test7()
    local Quaternion = Quaternion
    local t = os.clock()

    for i = 1, 2000000 do
        local q1 = Quaternion.Euler(i, i, i)
        local q2 = Quaternion.Euler(i * 2, i * 2, i * 2)
        Quaternion.Slerp(Quaternion.identity, q1, 0.5)
    end

    print("Test7 elapsed time: " .. (os.clock() - t) * 1000)
end

function Test8()
    local total = 0
    local t = os.clock()

    for i = 0, 2000000, 1 do
        total = total + i - (i / 2) * (i + 3) / (i + 5)
    end

    print("Test8 elapsed time: " .. (os.clock() - t) * 1000)
end

function Test9()
    local array = {}

    for i = 1, 1024 do
        array[i] = i
    end

    local total = 0
    local t = os.clock()

    for j = 1, 20000 do
        for i = 1, 1024 do
            total = total + array[i]
        end
    end

    print("Test9 elapsed time: " .. (os.clock() - t) * 1000)
end

function Test10(trans)
    local t = os.clock()

    for i = 1, 2000000 do
        CS.UserClass.TestFunc1(1, "123", trans.position, trans)
    end

    print("Test10 elapsed time: " .. (os.clock() - t) * 1000)
end

local function Test11()
    local t = os.clock()

    local c = function(o, x)
        local r = o + x
    end

    for i = 0, 1000000, 1 do
        local a = CS.UnityEngine.Vector3(1, 2, 3)
        local b = CS.UnityEngine.Vector3(4, 5, 6)
        c(a, b)
    end

    print("Test11 elapsed time: " .. (os.clock() - t) * 1000)
end

local function Run()
    Test1()
    Test2()
    Test3()
    Test4()
    Test5()
    Test6()
    Test7()
    Test8()
    Test9()
    Test10()
    Test11()
end

return {
    Run = Run
}

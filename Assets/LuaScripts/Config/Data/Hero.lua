--[[

        Hero.lua
        exported by excel2lua.py
        from file:Hero.xlsx

--]]

local Hero = {
    [1] = {
        heroId = 1,
        name = '剑客',
        rare = 11,
        type = 1,
        advance_rate = 0.7,
        attack = 100,
        isOpen = true,
        attributes = {{2001,1,10},{3001,1,10}},
    },
    [2] = {
        heroId = 2,
        name = '法师',
        rare = 10,
        type = 2,
        advance_rate = 0.75,
        attack = 100,
        isOpen = true,
        attributes = {{2001,1,10},{3001,1,10}},
    },
    [3] = {
        heroId = 3,
        name = '圣骑',
        rare = 8,
        type = 3,
        advance_rate = 0.85,
        attack = 100,
        isOpen = false,
        attributes = {{2001,1,10}},
    },
    [4] = {
        heroId = 4,
        name = '刺客',
        rare = 15,
        type = 4,
        advance_rate = ,
        attack = 100,
        isOpen = false,
        attributes = {},
    },
}
return Hero
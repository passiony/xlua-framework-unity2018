#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class ETCAxisWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCAxis);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 41, 41);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitAxis", _m_InitAxis);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateAxis", _m_UpdateAxis);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateButton", _m_UpdateButton);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetAxis", _m_ResetAxis);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DoDirectAction", _m_DoDirectAction);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DoGravity", _m_DoGravity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitDeadCurve", _m_InitDeadCurve);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "directTransform", _g_get_directTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "name", _g_get_name);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoLinkTagPlayer", _g_get_autoLinkTagPlayer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoTag", _g_get_autoTag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "player", _g_get_player);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enable", _g_get_enable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "invertedAxis", _g_get_invertedAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "speed", _g_get_speed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deadValue", _g_get_deadValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "valueMethod", _g_get_valueMethod);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "curveValue", _g_get_curveValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isEnertia", _g_get_isEnertia);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inertia", _g_get_inertia);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inertiaThreshold", _g_get_inertiaThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isAutoStab", _g_get_isAutoStab);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoStabThreshold", _g_get_autoStabThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoStabSpeed", _g_get_autoStabSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isClampRotation", _g_get_isClampRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxAngle", _g_get_maxAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minAngle", _g_get_minAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isValueOverTime", _g_get_isValueOverTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overTimeStep", _g_get_overTimeStep);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxOverTimeValue", _g_get_maxOverTimeValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "axisValue", _g_get_axisValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "axisSpeedValue", _g_get_axisSpeedValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "axisThreshold", _g_get_axisThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isLockinJump", _g_get_isLockinJump);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "axisState", _g_get_axisState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "directAction", _g_get_directAction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "axisInfluenced", _g_get_axisInfluenced);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "actionOn", _g_get_actionOn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "directCharacterController", _g_get_directCharacterController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "directRigidBody", _g_get_directRigidBody);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gravity", _g_get_gravity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentGravity", _g_get_currentGravity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isJump", _g_get_isJump);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "unityAxis", _g_get_unityAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "showGeneralInspector", _g_get_showGeneralInspector);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "showDirectInspector", _g_get_showDirectInspector);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "showInertiaInspector", _g_get_showInertiaInspector);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "showSimulatinInspector", _g_get_showSimulatinInspector);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "directTransform", _s_set_directTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "name", _s_set_name);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoLinkTagPlayer", _s_set_autoLinkTagPlayer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoTag", _s_set_autoTag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "player", _s_set_player);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enable", _s_set_enable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "invertedAxis", _s_set_invertedAxis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "speed", _s_set_speed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "deadValue", _s_set_deadValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "valueMethod", _s_set_valueMethod);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "curveValue", _s_set_curveValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isEnertia", _s_set_isEnertia);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inertia", _s_set_inertia);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inertiaThreshold", _s_set_inertiaThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isAutoStab", _s_set_isAutoStab);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoStabThreshold", _s_set_autoStabThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoStabSpeed", _s_set_autoStabSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isClampRotation", _s_set_isClampRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxAngle", _s_set_maxAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minAngle", _s_set_minAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isValueOverTime", _s_set_isValueOverTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overTimeStep", _s_set_overTimeStep);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxOverTimeValue", _s_set_maxOverTimeValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "axisValue", _s_set_axisValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "axisSpeedValue", _s_set_axisSpeedValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "axisThreshold", _s_set_axisThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isLockinJump", _s_set_isLockinJump);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "axisState", _s_set_axisState);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "directAction", _s_set_directAction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "axisInfluenced", _s_set_axisInfluenced);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "actionOn", _s_set_actionOn);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "directCharacterController", _s_set_directCharacterController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "directRigidBody", _s_set_directRigidBody);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gravity", _s_set_gravity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentGravity", _s_set_currentGravity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isJump", _s_set_isJump);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "unityAxis", _s_set_unityAxis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "showGeneralInspector", _s_set_showGeneralInspector);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "showDirectInspector", _s_set_showDirectInspector);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "showInertiaInspector", _s_set_showInertiaInspector);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "showSimulatinInspector", _s_set_showSimulatinInspector);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string _axisName = LuaAPI.lua_tostring(L, 2);
					
					ETCAxis gen_ret = new ETCAxis(_axisName);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ETCAxis constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitAxis(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.InitAxis(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateAxis(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<ETCBase.ControlType>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    float _realValue = (float)LuaAPI.lua_tonumber(L, 2);
                    bool _isOnDrag = LuaAPI.lua_toboolean(L, 3);
                    ETCBase.ControlType _type;translator.Get(L, 4, out _type);
                    bool _deltaTime = LuaAPI.lua_toboolean(L, 5);
                    
                    gen_to_be_invoked.UpdateAxis( _realValue, _isOnDrag, _type, _deltaTime );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<ETCBase.ControlType>(L, 4)) 
                {
                    float _realValue = (float)LuaAPI.lua_tonumber(L, 2);
                    bool _isOnDrag = LuaAPI.lua_toboolean(L, 3);
                    ETCBase.ControlType _type;translator.Get(L, 4, out _type);
                    
                    gen_to_be_invoked.UpdateAxis( _realValue, _isOnDrag, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ETCAxis.UpdateAxis!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateButton(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.UpdateButton(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetAxis(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ResetAxis(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DoDirectAction(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DoDirectAction(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DoGravity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DoGravity(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitDeadCurve(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.InitDeadCurve(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.directTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.name);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoLinkTagPlayer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.autoLinkTagPlayer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoTag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.autoTag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_player(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.player);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_invertedAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.invertedAxis);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_speed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.speed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deadValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.deadValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_valueMethod(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.valueMethod);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_curveValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.curveValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isEnertia(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isEnertia);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inertia(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.inertia);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inertiaThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.inertiaThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isAutoStab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isAutoStab);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoStabThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.autoStabThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoStabSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.autoStabSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isClampRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isClampRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isValueOverTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isValueOverTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overTimeStep(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.overTimeStep);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxOverTimeValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxOverTimeValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_axisValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.axisValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_axisSpeedValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.axisSpeedValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_axisThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.axisThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isLockinJump(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isLockinJump);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_axisState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.axisState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.directAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_axisInfluenced(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.axisInfluenced);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_actionOn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.actionOn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directCharacterController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.directCharacterController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directRigidBody(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.directRigidBody);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.gravity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentGravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.currentGravity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isJump(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isJump);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_unityAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.unityAxis);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showGeneralInspector(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.showGeneralInspector);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showDirectInspector(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.showDirectInspector);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showInertiaInspector(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.showInertiaInspector);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showSimulatinInspector(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.showSimulatinInspector);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.directTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoLinkTagPlayer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.autoLinkTagPlayer = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoTag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.autoTag = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_player(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.player = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_invertedAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.invertedAxis = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_speed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.speed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_deadValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.deadValue = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_valueMethod(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                ETCAxis.AxisValueMethod gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.valueMethod = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_curveValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.curveValue = (UnityEngine.AnimationCurve)translator.GetObject(L, 2, typeof(UnityEngine.AnimationCurve));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isEnertia(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isEnertia = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inertia(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inertia = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inertiaThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inertiaThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isAutoStab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isAutoStab = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoStabThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.autoStabThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoStabSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.autoStabSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isClampRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isClampRotation = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.minAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isValueOverTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isValueOverTime = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overTimeStep(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.overTimeStep = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxOverTimeValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxOverTimeValue = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_axisValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.axisValue = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_axisSpeedValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.axisSpeedValue = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_axisThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.axisThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isLockinJump(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isLockinJump = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_axisState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                ETCAxis.AxisState gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.axisState = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directAction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                ETCAxis.DirectAction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.directAction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_axisInfluenced(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                ETCAxis.AxisInfluenced gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.axisInfluenced = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_actionOn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                ETCAxis.ActionOn gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.actionOn = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directCharacterController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.directCharacterController = (UnityEngine.CharacterController)translator.GetObject(L, 2, typeof(UnityEngine.CharacterController));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directRigidBody(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.directRigidBody = (UnityEngine.Rigidbody)translator.GetObject(L, 2, typeof(UnityEngine.Rigidbody));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gravity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentGravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.currentGravity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isJump(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isJump = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_unityAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.unityAxis = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showGeneralInspector(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.showGeneralInspector = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showDirectInspector(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.showDirectInspector = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showInertiaInspector(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.showInertiaInspector = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showSimulatinInspector(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCAxis gen_to_be_invoked = (ETCAxis)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.showSimulatinInspector = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

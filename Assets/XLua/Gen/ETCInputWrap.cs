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
    public class ETCInputWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCInput);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterControl", _m_RegisterControl);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnRegisterControl", _m_UnRegisterControl);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Create", _m_Create);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 79, 2, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Register", _m_Register_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnRegister", _m_UnRegister_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetControlVisible", _m_SetControlVisible_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetControlVisible", _m_GetControlVisible_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetControlActivated", _m_SetControlActivated_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetControlActivated", _m_GetControlActivated_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetControlSwipeIn", _m_SetControlSwipeIn_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetControlSwipeIn", _m_GetControlSwipeIn_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetControlSwipeOut", _m_SetControlSwipeOut_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetControlSwipeOut", _m_GetControlSwipeOut_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetDPadAxesCount", _m_SetDPadAxesCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDPadAxesCount", _m_GetDPadAxesCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetControlJoystick", _m_GetControlJoystick_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetControlDPad", _m_GetControlDPad_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetControlTouchPad", _m_GetControlTouchPad_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetControlButton", _m_GetControlButton_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetControlSprite", _m_SetControlSprite_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetJoystickThumbSprite", _m_SetJoystickThumbSprite_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetButtonSprite", _m_SetButtonSprite_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisSpeed", _m_SetAxisSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisGravity", _m_SetAxisGravity_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetTurnMoveSpeed", _m_SetTurnMoveSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ResetAxis", _m_ResetAxis_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisEnabled", _m_SetAxisEnabled_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisEnabled", _m_GetAxisEnabled_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisInverted", _m_SetAxisInverted_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisInverted", _m_GetAxisInverted_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisDeadValue", _m_SetAxisDeadValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisDeadValue", _m_GetAxisDeadValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisSensitivity", _m_SetAxisSensitivity_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisSensitivity", _m_GetAxisSensitivity_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisThreshold", _m_SetAxisThreshold_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisThreshold", _m_GetAxisThreshold_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisInertia", _m_SetAxisInertia_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisInertia", _m_GetAxisInertia_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisInertiaSpeed", _m_SetAxisInertiaSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisInertiaSpeed", _m_GetAxisInertiaSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisInertiaThreshold", _m_SetAxisInertiaThreshold_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisInertiaThreshold", _m_GetAxisInertiaThreshold_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisAutoStabilization", _m_SetAxisAutoStabilization_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisAutoStabilization", _m_GetAxisAutoStabilization_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisAutoStabilizationSpeed", _m_SetAxisAutoStabilizationSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisAutoStabilizationSpeed", _m_GetAxisAutoStabilizationSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisAutoStabilizationThreshold", _m_SetAxisAutoStabilizationThreshold_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisAutoStabilizationThreshold", _m_GetAxisAutoStabilizationThreshold_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisClampRotation", _m_SetAxisClampRotation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisClampRotation", _m_GetAxisClampRotation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisClampRotationValue", _m_SetAxisClampRotationValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisClampRotationMinValue", _m_SetAxisClampRotationMinValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisClampRotationMaxValue", _m_SetAxisClampRotationMaxValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisClampRotationMinValue", _m_GetAxisClampRotationMinValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisClampRotationMaxValue", _m_GetAxisClampRotationMaxValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisDirecTransform", _m_SetAxisDirecTransform_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisDirectTransform", _m_GetAxisDirectTransform_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisDirectAction", _m_SetAxisDirectAction_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisDirectAction", _m_GetAxisDirectAction_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisAffectedAxis", _m_SetAxisAffectedAxis_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisAffectedAxis", _m_GetAxisAffectedAxis_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisOverTime", _m_SetAxisOverTime_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisOverTime", _m_GetAxisOverTime_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisOverTimeStep", _m_SetAxisOverTimeStep_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisOverTimeStep", _m_GetAxisOverTimeStep_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAxisOverTimeMaxValue", _m_SetAxisOverTimeMaxValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisOverTimeMaxValue", _m_GetAxisOverTimeMaxValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxis", _m_GetAxis_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisSpeed", _m_GetAxisSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisDownUp", _m_GetAxisDownUp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisDownDown", _m_GetAxisDownDown_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisDownRight", _m_GetAxisDownRight_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisDownLeft", _m_GetAxisDownLeft_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisPressedUp", _m_GetAxisPressedUp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisPressedDown", _m_GetAxisPressedDown_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisPressedRight", _m_GetAxisPressedRight_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAxisPressedLeft", _m_GetAxisPressedLeft_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetButtonDown", _m_GetButtonDown_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetButton", _m_GetButton_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetButtonUp", _m_GetButtonUp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetButtonValue", _m_GetButtonValue_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "instance", _g_get_instance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "_instance", _g_get__instance);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "_instance", _s_set__instance);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					ETCInput gen_ret = new ETCInput();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ETCInput constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterControl(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCInput gen_to_be_invoked = (ETCInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ETCBase _ctrl = (ETCBase)translator.GetObject(L, 2, typeof(ETCBase));
                    
                    gen_to_be_invoked.RegisterControl( _ctrl );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnRegisterControl(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCInput gen_to_be_invoked = (ETCInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ETCBase _ctrl = (ETCBase)translator.GetObject(L, 2, typeof(ETCBase));
                    
                    gen_to_be_invoked.UnRegisterControl( _ctrl );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCInput gen_to_be_invoked = (ETCInput)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Create(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Register_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    ETCBase _ctrl = (ETCBase)translator.GetObject(L, 1, typeof(ETCBase));
                    
                    ETCInput.Register( _ctrl );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnRegister_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    ETCBase _ctrl = (ETCBase)translator.GetObject(L, 1, typeof(ETCBase));
                    
                    ETCInput.UnRegister( _ctrl );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetControlVisible_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    ETCInput.SetControlVisible( _ctrlName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetControlVisible_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetControlVisible( _ctrlName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetControlActivated_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    ETCInput.SetControlActivated( _ctrlName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetControlActivated_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetControlActivated( _ctrlName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetControlSwipeIn_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    ETCInput.SetControlSwipeIn( _ctrlName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetControlSwipeIn_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetControlSwipeIn( _ctrlName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetControlSwipeOut_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    ETCInput.SetControlSwipeOut( _ctrlName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetControlSwipeOut_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                        bool gen_ret = ETCInput.GetControlSwipeOut( _ctrlName, _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDPadAxesCount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    ETCBase.DPadAxis _value;translator.Get(L, 2, out _value);
                    
                    ETCInput.SetDPadAxesCount( _ctrlName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDPadAxesCount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    
                        ETCBase.DPadAxis gen_ret = ETCInput.GetDPadAxesCount( _ctrlName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetControlJoystick_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    
                        ETCJoystick gen_ret = ETCInput.GetControlJoystick( _ctrlName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetControlDPad_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    
                        ETCDPad gen_ret = ETCInput.GetControlDPad( _ctrlName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetControlTouchPad_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    
                        ETCTouchPad gen_ret = ETCInput.GetControlTouchPad( _ctrlName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetControlButton_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    
                        ETCButton gen_ret = ETCInput.GetControlButton( _ctrlName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetControlSprite_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Sprite _spr = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    UnityEngine.Color _color;translator.Get(L, 3, out _color);
                    
                    ETCInput.SetControlSprite( _ctrlName, _spr, _color );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Sprite>(L, 2)) 
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Sprite _spr = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    
                    ETCInput.SetControlSprite( _ctrlName, _spr );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ETCInput.SetControlSprite!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetJoystickThumbSprite_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Sprite _spr = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    UnityEngine.Color _color;translator.Get(L, 3, out _color);
                    
                    ETCInput.SetJoystickThumbSprite( _ctrlName, _spr, _color );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Sprite>(L, 2)) 
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Sprite _spr = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    
                    ETCInput.SetJoystickThumbSprite( _ctrlName, _spr );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ETCInput.SetJoystickThumbSprite!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetButtonSprite_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& translator.Assignable<UnityEngine.Sprite>(L, 3)&& translator.Assignable<UnityEngine.Color>(L, 4)) 
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Sprite _sprNormal = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    UnityEngine.Sprite _sprPress = (UnityEngine.Sprite)translator.GetObject(L, 3, typeof(UnityEngine.Sprite));
                    UnityEngine.Color _color;translator.Get(L, 4, out _color);
                    
                    ETCInput.SetButtonSprite( _ctrlName, _sprNormal, _sprPress, _color );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Sprite>(L, 2)&& translator.Assignable<UnityEngine.Sprite>(L, 3)) 
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Sprite _sprNormal = (UnityEngine.Sprite)translator.GetObject(L, 2, typeof(UnityEngine.Sprite));
                    UnityEngine.Sprite _sprPress = (UnityEngine.Sprite)translator.GetObject(L, 3, typeof(UnityEngine.Sprite));
                    
                    ETCInput.SetButtonSprite( _ctrlName, _sprNormal, _sprPress );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ETCInput.SetButtonSprite!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _speed = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisSpeed( _axisName, _speed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisGravity_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _gravity = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisGravity( _axisName, _gravity );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTurnMoveSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _ctrlName = LuaAPI.lua_tostring(L, 1);
                    float _speed = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetTurnMoveSpeed( _ctrlName, _speed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetAxis_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                    ETCInput.ResetAxis( _axisName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisEnabled_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    ETCInput.SetAxisEnabled( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisEnabled_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisEnabled( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisInverted_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    ETCInput.SetAxisInverted( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisInverted_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisInverted( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisDeadValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisDeadValue( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisDeadValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisDeadValue( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisSensitivity_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisSensitivity( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisSensitivity_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisSensitivity( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisThreshold_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisThreshold( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisThreshold_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisThreshold( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisInertia_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    ETCInput.SetAxisInertia( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisInertia_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisInertia( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisInertiaSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisInertiaSpeed( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisInertiaSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisInertiaSpeed( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisInertiaThreshold_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisInertiaThreshold( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisInertiaThreshold_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisInertiaThreshold( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisAutoStabilization_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    ETCInput.SetAxisAutoStabilization( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisAutoStabilization_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisAutoStabilization( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisAutoStabilizationSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisAutoStabilizationSpeed( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisAutoStabilizationSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisAutoStabilizationSpeed( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisAutoStabilizationThreshold_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisAutoStabilizationThreshold( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisAutoStabilizationThreshold_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisAutoStabilizationThreshold( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisClampRotation_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    ETCInput.SetAxisClampRotation( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisClampRotation_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisClampRotation( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisClampRotationValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _min = (float)LuaAPI.lua_tonumber(L, 2);
                    float _max = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    ETCInput.SetAxisClampRotationValue( _axisName, _min, _max );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisClampRotationMinValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisClampRotationMinValue( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisClampRotationMaxValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisClampRotationMaxValue( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisClampRotationMinValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisClampRotationMinValue( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisClampRotationMaxValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisClampRotationMaxValue( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisDirecTransform_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Transform _value = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    ETCInput.SetAxisDirecTransform( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisDirectTransform_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.Transform gen_ret = ETCInput.GetAxisDirectTransform( _axisName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisDirectAction_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    ETCAxis.DirectAction _value;translator.Get(L, 2, out _value);
                    
                    ETCInput.SetAxisDirectAction( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisDirectAction_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        ETCAxis.DirectAction gen_ret = ETCInput.GetAxisDirectAction( _axisName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisAffectedAxis_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    ETCAxis.AxisInfluenced _value;translator.Get(L, 2, out _value);
                    
                    ETCInput.SetAxisAffectedAxis( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisAffectedAxis_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        ETCAxis.AxisInfluenced gen_ret = ETCInput.GetAxisAffectedAxis( _axisName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisOverTime_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    ETCInput.SetAxisOverTime( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisOverTime_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisOverTime( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisOverTimeStep_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisOverTimeStep( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisOverTimeStep_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisOverTimeStep( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAxisOverTimeMaxValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    ETCInput.SetAxisOverTimeMaxValue( _axisName, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisOverTimeMaxValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisOverTimeMaxValue( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxis_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxis( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetAxisSpeed( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisDownUp_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisDownUp( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisDownDown_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisDownDown( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisDownRight_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisDownRight( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisDownLeft_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisDownLeft( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisPressedUp_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisPressedUp( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisPressedDown_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisPressedDown( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisPressedRight_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisPressedRight( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAxisPressedLeft_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetAxisPressedLeft( _axisName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetButtonDown_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _buttonName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetButtonDown( _buttonName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetButton_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _buttonName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetButton( _buttonName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetButtonUp_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _buttonName = LuaAPI.lua_tostring(L, 1);
                    
                        bool gen_ret = ETCInput.GetButtonUp( _buttonName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetButtonValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _buttonName = LuaAPI.lua_tostring(L, 1);
                    
                        float gen_ret = ETCInput.GetButtonValue( _buttonName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCInput.instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get__instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ETCInput._instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set__instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    ETCInput._instance = (ETCInput)translator.GetObject(L, 1, typeof(ETCInput));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

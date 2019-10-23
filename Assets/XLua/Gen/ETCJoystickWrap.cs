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
    public class ETCJoystickWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ETCJoystick);
			Utils.BeginObjectRegister(type, L, translator, 0, 11, 30, 30);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Start", _m_Start);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LateUpdate", _m_LateUpdate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerEnter", _m_OnPointerEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerDown", _m_OnPointerDown);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnBeginDrag", _m_OnBeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDrag", _m_OnDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPointerUp", _m_OnPointerUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRadius", _m_GetRadius);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitCurve", _m_InitCurve);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitTurnMoveCurve", _m_InitTurnMoveCurve);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNoReturnThumb", _g_get_IsNoReturnThumb);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNoOffsetThumb", _g_get_IsNoOffsetThumb);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onMoveStart", _g_get_onMoveStart);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onMove", _g_get_onMove);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onMoveSpeed", _g_get_onMoveSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onMoveEnd", _g_get_onMoveEnd);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onTouchStart", _g_get_onTouchStart);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onTouchUp", _g_get_onTouchUp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnDownUp", _g_get_OnDownUp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnDownDown", _g_get_OnDownDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnDownLeft", _g_get_OnDownLeft);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnDownRight", _g_get_OnDownRight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnPressUp", _g_get_OnPressUp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnPressDown", _g_get_OnPressDown);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnPressLeft", _g_get_OnPressLeft);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnPressRight", _g_get_OnPressRight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "joystickType", _g_get_joystickType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowJoystickOverTouchPad", _g_get_allowJoystickOverTouchPad);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "radiusBase", _g_get_radiusBase);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "radiusBaseValue", _g_get_radiusBaseValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "axisX", _g_get_axisX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "axisY", _g_get_axisY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "thumb", _g_get_thumb);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "joystickArea", _g_get_joystickArea);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "userArea", _g_get_userArea);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isTurnAndMove", _g_get_isTurnAndMove);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tmSpeed", _g_get_tmSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tmAdditionnalRotation", _g_get_tmAdditionnalRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tmMoveCurve", _g_get_tmMoveCurve);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tmLockInJump", _g_get_tmLockInJump);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsNoReturnThumb", _s_set_IsNoReturnThumb);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsNoOffsetThumb", _s_set_IsNoOffsetThumb);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onMoveStart", _s_set_onMoveStart);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onMove", _s_set_onMove);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onMoveSpeed", _s_set_onMoveSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onMoveEnd", _s_set_onMoveEnd);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onTouchStart", _s_set_onTouchStart);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "onTouchUp", _s_set_onTouchUp);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnDownUp", _s_set_OnDownUp);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnDownDown", _s_set_OnDownDown);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnDownLeft", _s_set_OnDownLeft);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnDownRight", _s_set_OnDownRight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnPressUp", _s_set_OnPressUp);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnPressDown", _s_set_OnPressDown);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnPressLeft", _s_set_OnPressLeft);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnPressRight", _s_set_OnPressRight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "joystickType", _s_set_joystickType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowJoystickOverTouchPad", _s_set_allowJoystickOverTouchPad);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "radiusBase", _s_set_radiusBase);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "radiusBaseValue", _s_set_radiusBaseValue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "axisX", _s_set_axisX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "axisY", _s_set_axisY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "thumb", _s_set_thumb);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "joystickArea", _s_set_joystickArea);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "userArea", _s_set_userArea);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isTurnAndMove", _s_set_isTurnAndMove);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tmSpeed", _s_set_tmSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tmAdditionnalRotation", _s_set_tmAdditionnalRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tmMoveCurve", _s_set_tmMoveCurve);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tmLockInJump", _s_set_tmLockInJump);
            
			
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
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					ETCJoystick gen_ret = new ETCJoystick();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ETCJoystick constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Start(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Start(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Update(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LateUpdate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.LateUpdate(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPointerEnter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnPointerEnter( _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPointerDown(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnPointerDown( _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnBeginDrag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnBeginDrag( _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDrag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnDrag( _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPointerUp(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    
                    gen_to_be_invoked.OnPointerUp( _eventData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRadius(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        float gen_ret = gen_to_be_invoked.GetRadius(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitCurve(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.InitCurve(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitTurnMoveCurve(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.InitTurnMoveCurve(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNoReturnThumb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNoReturnThumb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNoOffsetThumb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNoOffsetThumb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onMoveStart(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onMoveStart);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onMove(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onMove);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onMoveSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onMoveSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onMoveEnd(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onMoveEnd);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onTouchStart(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onTouchStart);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onTouchUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onTouchUp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnDownUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnDownUp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnDownDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnDownDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnDownLeft(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnDownLeft);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnDownRight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnDownRight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnPressUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnPressUp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnPressDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnPressDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnPressLeft(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnPressLeft);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnPressRight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnPressRight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_joystickType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.joystickType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowJoystickOverTouchPad(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowJoystickOverTouchPad);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_radiusBase(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.radiusBase);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_radiusBaseValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.radiusBaseValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_axisX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.axisX);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_axisY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.axisY);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_thumb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.thumb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_joystickArea(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.joystickArea);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_userArea(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.userArea);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isTurnAndMove(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isTurnAndMove);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tmSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.tmSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tmAdditionnalRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.tmAdditionnalRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tmMoveCurve(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.tmMoveCurve);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tmLockInJump(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.tmLockInJump);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsNoReturnThumb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsNoReturnThumb = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsNoOffsetThumb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsNoOffsetThumb = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onMoveStart(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onMoveStart = (ETCJoystick.OnMoveStartHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnMoveStartHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onMove(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onMove = (ETCJoystick.OnMoveHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnMoveHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onMoveSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onMoveSpeed = (ETCJoystick.OnMoveSpeedHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnMoveSpeedHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onMoveEnd(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onMoveEnd = (ETCJoystick.OnMoveEndHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnMoveEndHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onTouchStart(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onTouchStart = (ETCJoystick.OnTouchStartHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnTouchStartHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onTouchUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.onTouchUp = (ETCJoystick.OnTouchUpHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnTouchUpHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnDownUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnDownUp = (ETCJoystick.OnDownUpHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnDownUpHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnDownDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnDownDown = (ETCJoystick.OnDownDownHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnDownDownHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnDownLeft(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnDownLeft = (ETCJoystick.OnDownLeftHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnDownLeftHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnDownRight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnDownRight = (ETCJoystick.OnDownRightHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnDownRightHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnPressUp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnPressUp = (ETCJoystick.OnDownUpHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnDownUpHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnPressDown(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnPressDown = (ETCJoystick.OnDownDownHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnDownDownHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnPressLeft(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnPressLeft = (ETCJoystick.OnDownLeftHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnDownLeftHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnPressRight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnPressRight = (ETCJoystick.OnDownRightHandler)translator.GetObject(L, 2, typeof(ETCJoystick.OnDownRightHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_joystickType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                ETCJoystick.JoystickType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.joystickType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowJoystickOverTouchPad(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowJoystickOverTouchPad = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_radiusBase(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                ETCJoystick.RadiusBase gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.radiusBase = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_radiusBaseValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.radiusBaseValue = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_axisX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.axisX = (ETCAxis)translator.GetObject(L, 2, typeof(ETCAxis));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_axisY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.axisY = (ETCAxis)translator.GetObject(L, 2, typeof(ETCAxis));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_thumb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.thumb = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_joystickArea(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                ETCJoystick.JoystickArea gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.joystickArea = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_userArea(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.userArea = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isTurnAndMove(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isTurnAndMove = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tmSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tmSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tmAdditionnalRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tmAdditionnalRotation = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tmMoveCurve(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tmMoveCurve = (UnityEngine.AnimationCurve)translator.GetObject(L, 2, typeof(UnityEngine.AnimationCurve));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tmLockInJump(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ETCJoystick gen_to_be_invoked = (ETCJoystick)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tmLockInJump = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

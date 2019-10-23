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
    public class XLuaMessengerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLuaMessenger);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 6, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateDelegate", _m_CreateDelegate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddListener", _m_AddListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveListener", _m_RemoveListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Broadcast", _m_Broadcast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CastType", _m_CastType_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MessageNameTypeMap", _g_get_MessageNameTypeMap);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "MessageNameTypeMap", _s_set_MessageNameTypeMap);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "XLuaMessenger does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateDelegate_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _eventType = LuaAPI.lua_tostring(L, 1);
                    XLua.LuaFunction _func = (XLua.LuaFunction)translator.GetObject(L, 2, typeof(XLua.LuaFunction));
                    
                        System.Delegate gen_ret = XLuaMessenger.CreateDelegate( _eventType, _func );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _eventType = LuaAPI.lua_tostring(L, 1);
                    System.Delegate _handler = translator.GetDelegate<System.Delegate>(L, 2);
                    
                    XLuaMessenger.AddListener( _eventType, _handler );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _eventType = LuaAPI.lua_tostring(L, 1);
                    System.Delegate _handler = translator.GetDelegate<System.Delegate>(L, 2);
                    
                    XLuaMessenger.RemoveListener( _eventType, _handler );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Broadcast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)) 
                {
                    string _eventType = LuaAPI.lua_tostring(L, 1);
                    object _arg1 = translator.GetObject(L, 2, typeof(object));
                    
                    XLuaMessenger.Broadcast( _eventType, _arg1 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    string _eventType = LuaAPI.lua_tostring(L, 1);
                    object _arg1 = translator.GetObject(L, 2, typeof(object));
                    object _arg2 = translator.GetObject(L, 3, typeof(object));
                    
                    XLuaMessenger.Broadcast( _eventType, _arg1, _arg2 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    string _eventType = LuaAPI.lua_tostring(L, 1);
                    object _arg1 = translator.GetObject(L, 2, typeof(object));
                    object _arg2 = translator.GetObject(L, 3, typeof(object));
                    object _arg3 = translator.GetObject(L, 4, typeof(object));
                    
                    XLuaMessenger.Broadcast( _eventType, _arg1, _arg2, _arg3 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLuaMessenger.Broadcast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CastType_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    object _valueObj = translator.GetObject(L, 2, typeof(object));
                    
                        object gen_ret = XLuaMessenger.CastType( _type, _valueObj );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MessageNameTypeMap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XLuaMessenger.MessageNameTypeMap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MessageNameTypeMap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    XLuaMessenger.MessageNameTypeMap = (System.Collections.Generic.Dictionary<string, System.Type>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<string, System.Type>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

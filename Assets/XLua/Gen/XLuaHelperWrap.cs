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
    public class XLuaHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLuaHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateArrayInstance", _m_CreateArrayInstance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateListInstance", _m_CreateListInstance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateDictionaryInstance", _m_CreateDictionaryInstance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateActionDelegate", _m_CreateActionDelegate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateCallbackDelegate", _m_CreateCallbackDelegate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MakeGenericListType", _m_MakeGenericListType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MakeGenericDictionaryType", _m_MakeGenericDictionaryType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MakeGenericActionType", _m_MakeGenericActionType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MakeGenericCallbackType", _m_MakeGenericCallbackType_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "XLuaHelper does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateArrayInstance_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _itemType = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    int _itemCount = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.Array gen_ret = XLuaHelper.CreateArrayInstance( _itemType, _itemCount );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateListInstance_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _itemType = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        System.Collections.IList gen_ret = XLuaHelper.CreateListInstance( _itemType );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateDictionaryInstance_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _keyType = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    System.Type _valueType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        System.Collections.IDictionary gen_ret = XLuaHelper.CreateDictionaryInstance( _keyType, _valueType );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateActionDelegate_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 2&& translator.Assignable<System.Type>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<System.Type>(L, 3))) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    System.Type[] _paramTypes = translator.GetParams<System.Type>(L, 3);
                    
                        System.Delegate gen_ret = XLuaHelper.CreateActionDelegate( _type, _methodName, _paramTypes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<System.Type>(L, 3))) 
                {
                    object _target = translator.GetObject(L, 1, typeof(object));
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    System.Type[] _paramTypes = translator.GetParams<System.Type>(L, 3);
                    
                        System.Delegate gen_ret = XLuaHelper.CreateActionDelegate( _target, _methodName, _paramTypes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLuaHelper.CreateActionDelegate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateCallbackDelegate_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 2&& translator.Assignable<System.Type>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<System.Type>(L, 3))) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    System.Type[] _paramTypes = translator.GetParams<System.Type>(L, 3);
                    
                        System.Delegate gen_ret = XLuaHelper.CreateCallbackDelegate( _type, _methodName, _paramTypes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<System.Type>(L, 3))) 
                {
                    object _target = translator.GetObject(L, 1, typeof(object));
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    System.Type[] _paramTypes = translator.GetParams<System.Type>(L, 3);
                    
                        System.Delegate gen_ret = XLuaHelper.CreateCallbackDelegate( _target, _methodName, _paramTypes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLuaHelper.CreateCallbackDelegate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeGenericListType_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _itemType = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        System.Type gen_ret = XLuaHelper.MakeGenericListType( _itemType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeGenericDictionaryType_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _keyType = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    System.Type _valueType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        System.Type gen_ret = XLuaHelper.MakeGenericDictionaryType( _keyType, _valueType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeGenericActionType_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type[] _paramTypes = translator.GetParams<System.Type>(L, 1);
                    
                        System.Type gen_ret = XLuaHelper.MakeGenericActionType( _paramTypes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeGenericCallbackType_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type[] _paramTypes = translator.GetParams<System.Type>(L, 1);
                    
                        System.Type gen_ret = XLuaHelper.MakeGenericCallbackType( _paramTypes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}

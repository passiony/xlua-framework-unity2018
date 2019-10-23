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
    public class SystemActivatorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Activator);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateInstance", _m_CreateInstance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateInstanceFrom", _m_CreateInstanceFrom_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateComInstanceFrom", _m_CreateComInstanceFrom_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetObject", _m_GetObject_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "System.Activator does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateInstance_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<System.Type>(L, 1)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        object gen_ret = System.Activator.CreateInstance( _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.ActivationContext>(L, 1)) 
                {
                    System.ActivationContext _activationContext = (System.ActivationContext)translator.GetObject(L, 1, typeof(System.ActivationContext));
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstance( _activationContext );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    bool _nonPublic = LuaAPI.lua_toboolean(L, 2);
                    
                        object gen_ret = System.Activator.CreateInstance( _type, _nonPublic );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 1&& translator.Assignable<System.Type>(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    object[] _args = translator.GetParams<object>(L, 2);
                    
                        object gen_ret = System.Activator.CreateInstance( _type, _args );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _assemblyName = LuaAPI.lua_tostring(L, 1);
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstance( _assemblyName, _typeName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.ActivationContext>(L, 1)&& translator.Assignable<string[]>(L, 2)) 
                {
                    System.ActivationContext _activationContext = (System.ActivationContext)translator.GetObject(L, 1, typeof(System.ActivationContext));
                    string[] _activationCustomData = (string[])translator.GetObject(L, 2, typeof(string[]));
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstance( _activationContext, _activationCustomData );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 1)&& translator.Assignable<object[]>(L, 2)&& translator.Assignable<object[]>(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    object[] _args = (object[])translator.GetObject(L, 2, typeof(object[]));
                    object[] _activationAttributes = (object[])translator.GetObject(L, 3, typeof(object[]));
                    
                        object gen_ret = System.Activator.CreateInstance( _type, _args, _activationAttributes );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object[]>(L, 3)) 
                {
                    string _assemblyName = LuaAPI.lua_tostring(L, 1);
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    object[] _activationAttributes = (object[])translator.GetObject(L, 3, typeof(object[]));
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstance( _assemblyName, _typeName, _activationAttributes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.AppDomain>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.AppDomain _domain = (System.AppDomain)translator.GetObject(L, 1, typeof(System.AppDomain));
                    string _assemblyName = LuaAPI.lua_tostring(L, 2);
                    string _typeName = LuaAPI.lua_tostring(L, 3);
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstance( _domain, _assemblyName, _typeName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Type>(L, 1)&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)&& translator.Assignable<System.Reflection.Binder>(L, 3)&& translator.Assignable<object[]>(L, 4)&& translator.Assignable<System.Globalization.CultureInfo>(L, 5)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 3, typeof(System.Reflection.Binder));
                    object[] _args = (object[])translator.GetObject(L, 4, typeof(object[]));
                    System.Globalization.CultureInfo _culture = (System.Globalization.CultureInfo)translator.GetObject(L, 5, typeof(System.Globalization.CultureInfo));
                    
                        object gen_ret = System.Activator.CreateInstance( _type, _bindingAttr, _binder, _args, _culture );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<System.Type>(L, 1)&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)&& translator.Assignable<System.Reflection.Binder>(L, 3)&& translator.Assignable<object[]>(L, 4)&& translator.Assignable<System.Globalization.CultureInfo>(L, 5)&& translator.Assignable<object[]>(L, 6)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 3, typeof(System.Reflection.Binder));
                    object[] _args = (object[])translator.GetObject(L, 4, typeof(object[]));
                    System.Globalization.CultureInfo _culture = (System.Globalization.CultureInfo)translator.GetObject(L, 5, typeof(System.Globalization.CultureInfo));
                    object[] _activationAttributes = (object[])translator.GetObject(L, 6, typeof(object[]));
                    
                        object gen_ret = System.Activator.CreateInstance( _type, _bindingAttr, _binder, _args, _culture, _activationAttributes );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.Reflection.BindingFlags>(L, 4)&& translator.Assignable<System.Reflection.Binder>(L, 5)&& translator.Assignable<object[]>(L, 6)&& translator.Assignable<System.Globalization.CultureInfo>(L, 7)&& translator.Assignable<object[]>(L, 8)) 
                {
                    string _assemblyName = LuaAPI.lua_tostring(L, 1);
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    bool _ignoreCase = LuaAPI.lua_toboolean(L, 3);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 4, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 5, typeof(System.Reflection.Binder));
                    object[] _args = (object[])translator.GetObject(L, 6, typeof(object[]));
                    System.Globalization.CultureInfo _culture = (System.Globalization.CultureInfo)translator.GetObject(L, 7, typeof(System.Globalization.CultureInfo));
                    object[] _activationAttributes = (object[])translator.GetObject(L, 8, typeof(object[]));
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstance( _assemblyName, _typeName, _ignoreCase, _bindingAttr, _binder, _args, _culture, _activationAttributes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<System.AppDomain>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Reflection.BindingFlags>(L, 5)&& translator.Assignable<System.Reflection.Binder>(L, 6)&& translator.Assignable<object[]>(L, 7)&& translator.Assignable<System.Globalization.CultureInfo>(L, 8)&& translator.Assignable<object[]>(L, 9)) 
                {
                    System.AppDomain _domain = (System.AppDomain)translator.GetObject(L, 1, typeof(System.AppDomain));
                    string _assemblyName = LuaAPI.lua_tostring(L, 2);
                    string _typeName = LuaAPI.lua_tostring(L, 3);
                    bool _ignoreCase = LuaAPI.lua_toboolean(L, 4);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 5, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 6, typeof(System.Reflection.Binder));
                    object[] _args = (object[])translator.GetObject(L, 7, typeof(object[]));
                    System.Globalization.CultureInfo _culture = (System.Globalization.CultureInfo)translator.GetObject(L, 8, typeof(System.Globalization.CultureInfo));
                    object[] _activationAttributes = (object[])translator.GetObject(L, 9, typeof(object[]));
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstance( _domain, _assemblyName, _typeName, _ignoreCase, _bindingAttr, _binder, _args, _culture, _activationAttributes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Activator.CreateInstance!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateInstanceFrom_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _assemblyFile = LuaAPI.lua_tostring(L, 1);
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstanceFrom( _assemblyFile, _typeName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object[]>(L, 3)) 
                {
                    string _assemblyFile = LuaAPI.lua_tostring(L, 1);
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    object[] _activationAttributes = (object[])translator.GetObject(L, 3, typeof(object[]));
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstanceFrom( _assemblyFile, _typeName, _activationAttributes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.AppDomain>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.AppDomain _domain = (System.AppDomain)translator.GetObject(L, 1, typeof(System.AppDomain));
                    string _assemblyFile = LuaAPI.lua_tostring(L, 2);
                    string _typeName = LuaAPI.lua_tostring(L, 3);
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstanceFrom( _domain, _assemblyFile, _typeName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.Reflection.BindingFlags>(L, 4)&& translator.Assignable<System.Reflection.Binder>(L, 5)&& translator.Assignable<object[]>(L, 6)&& translator.Assignable<System.Globalization.CultureInfo>(L, 7)&& translator.Assignable<object[]>(L, 8)) 
                {
                    string _assemblyFile = LuaAPI.lua_tostring(L, 1);
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    bool _ignoreCase = LuaAPI.lua_toboolean(L, 3);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 4, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 5, typeof(System.Reflection.Binder));
                    object[] _args = (object[])translator.GetObject(L, 6, typeof(object[]));
                    System.Globalization.CultureInfo _culture = (System.Globalization.CultureInfo)translator.GetObject(L, 7, typeof(System.Globalization.CultureInfo));
                    object[] _activationAttributes = (object[])translator.GetObject(L, 8, typeof(object[]));
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstanceFrom( _assemblyFile, _typeName, _ignoreCase, _bindingAttr, _binder, _args, _culture, _activationAttributes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<System.AppDomain>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Reflection.BindingFlags>(L, 5)&& translator.Assignable<System.Reflection.Binder>(L, 6)&& translator.Assignable<object[]>(L, 7)&& translator.Assignable<System.Globalization.CultureInfo>(L, 8)&& translator.Assignable<object[]>(L, 9)) 
                {
                    System.AppDomain _domain = (System.AppDomain)translator.GetObject(L, 1, typeof(System.AppDomain));
                    string _assemblyFile = LuaAPI.lua_tostring(L, 2);
                    string _typeName = LuaAPI.lua_tostring(L, 3);
                    bool _ignoreCase = LuaAPI.lua_toboolean(L, 4);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 5, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 6, typeof(System.Reflection.Binder));
                    object[] _args = (object[])translator.GetObject(L, 7, typeof(object[]));
                    System.Globalization.CultureInfo _culture = (System.Globalization.CultureInfo)translator.GetObject(L, 8, typeof(System.Globalization.CultureInfo));
                    object[] _activationAttributes = (object[])translator.GetObject(L, 9, typeof(object[]));
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateInstanceFrom( _domain, _assemblyFile, _typeName, _ignoreCase, _bindingAttr, _binder, _args, _culture, _activationAttributes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Activator.CreateInstanceFrom!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateComInstanceFrom_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _assemblyName = LuaAPI.lua_tostring(L, 1);
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateComInstanceFrom( _assemblyName, _typeName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Configuration.Assemblies.AssemblyHashAlgorithm>(L, 4)) 
                {
                    string _assemblyName = LuaAPI.lua_tostring(L, 1);
                    string _typeName = LuaAPI.lua_tostring(L, 2);
                    byte[] _hashValue = LuaAPI.lua_tobytes(L, 3);
                    System.Configuration.Assemblies.AssemblyHashAlgorithm _hashAlgorithm;translator.Get(L, 4, out _hashAlgorithm);
                    
                        System.Runtime.Remoting.ObjectHandle gen_ret = System.Activator.CreateComInstanceFrom( _assemblyName, _typeName, _hashValue, _hashAlgorithm );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Activator.CreateComInstanceFrom!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    string _url = LuaAPI.lua_tostring(L, 2);
                    
                        object gen_ret = System.Activator.GetObject( _type, _url );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    string _url = LuaAPI.lua_tostring(L, 2);
                    object _state = translator.GetObject(L, 3, typeof(object));
                    
                        object gen_ret = System.Activator.GetObject( _type, _url, _state );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Activator.GetObject!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}

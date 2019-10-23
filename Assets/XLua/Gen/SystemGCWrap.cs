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
    public class SystemGCWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.GC);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 17, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AddMemoryPressure", _m_AddMemoryPressure_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveMemoryPressure", _m_RemoveMemoryPressure_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGeneration", _m_GetGeneration_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Collect", _m_Collect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CollectionCount", _m_CollectionCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "KeepAlive", _m_KeepAlive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WaitForPendingFinalizers", _m_WaitForPendingFinalizers_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SuppressFinalize", _m_SuppressFinalize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReRegisterForFinalize", _m_ReRegisterForFinalize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTotalMemory", _m_GetTotalMemory_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterForFullGCNotification", _m_RegisterForFullGCNotification_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CancelFullGCNotification", _m_CancelFullGCNotification_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WaitForFullGCApproach", _m_WaitForFullGCApproach_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WaitForFullGCComplete", _m_WaitForFullGCComplete_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryStartNoGCRegion", _m_TryStartNoGCRegion_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndNoGCRegion", _m_EndNoGCRegion_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MaxGeneration", _g_get_MaxGeneration);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "System.GC does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddMemoryPressure_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long _bytesAllocated = LuaAPI.lua_toint64(L, 1);
                    
                    System.GC.AddMemoryPressure( _bytesAllocated );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveMemoryPressure_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long _bytesAllocated = LuaAPI.lua_toint64(L, 1);
                    
                    System.GC.RemoveMemoryPressure( _bytesAllocated );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGeneration_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object _obj = translator.GetObject(L, 1, typeof(object));
                    
                        int gen_ret = System.GC.GetGeneration( _obj );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.WeakReference>(L, 1)) 
                {
                    System.WeakReference _wo = (System.WeakReference)translator.GetObject(L, 1, typeof(System.WeakReference));
                    
                        int gen_ret = System.GC.GetGeneration( _wo );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.GC.GetGeneration!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Collect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                    System.GC.Collect(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _generation = LuaAPI.xlua_tointeger(L, 1);
                    
                    System.GC.Collect( _generation );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.GCCollectionMode>(L, 2)) 
                {
                    int _generation = LuaAPI.xlua_tointeger(L, 1);
                    System.GCCollectionMode _mode;translator.Get(L, 2, out _mode);
                    
                    System.GC.Collect( _generation, _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.GCCollectionMode>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int _generation = LuaAPI.xlua_tointeger(L, 1);
                    System.GCCollectionMode _mode;translator.Get(L, 2, out _mode);
                    bool _blocking = LuaAPI.lua_toboolean(L, 3);
                    
                    System.GC.Collect( _generation, _mode, _blocking );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.GCCollectionMode>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    int _generation = LuaAPI.xlua_tointeger(L, 1);
                    System.GCCollectionMode _mode;translator.Get(L, 2, out _mode);
                    bool _blocking = LuaAPI.lua_toboolean(L, 3);
                    bool _compacting = LuaAPI.lua_toboolean(L, 4);
                    
                    System.GC.Collect( _generation, _mode, _blocking, _compacting );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.GC.Collect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CollectionCount_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _generation = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = System.GC.CollectionCount( _generation );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KeepAlive_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _obj = translator.GetObject(L, 1, typeof(object));
                    
                    System.GC.KeepAlive( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitForPendingFinalizers_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    System.GC.WaitForPendingFinalizers(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SuppressFinalize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _obj = translator.GetObject(L, 1, typeof(object));
                    
                    System.GC.SuppressFinalize( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReRegisterForFinalize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _obj = translator.GetObject(L, 1, typeof(object));
                    
                    System.GC.ReRegisterForFinalize( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTotalMemory_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    bool _forceFullCollection = LuaAPI.lua_toboolean(L, 1);
                    
                        long gen_ret = System.GC.GetTotalMemory( _forceFullCollection );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterForFullGCNotification_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _maxGenerationThreshold = LuaAPI.xlua_tointeger(L, 1);
                    int _largeObjectHeapThreshold = LuaAPI.xlua_tointeger(L, 2);
                    
                    System.GC.RegisterForFullGCNotification( _maxGenerationThreshold, _largeObjectHeapThreshold );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelFullGCNotification_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    System.GC.CancelFullGCNotification(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitForFullGCApproach_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                        System.GCNotificationStatus gen_ret = System.GC.WaitForFullGCApproach(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _millisecondsTimeout = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.GCNotificationStatus gen_ret = System.GC.WaitForFullGCApproach( _millisecondsTimeout );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.GC.WaitForFullGCApproach!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitForFullGCComplete_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                        System.GCNotificationStatus gen_ret = System.GC.WaitForFullGCComplete(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _millisecondsTimeout = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.GCNotificationStatus gen_ret = System.GC.WaitForFullGCComplete( _millisecondsTimeout );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.GC.WaitForFullGCComplete!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryStartNoGCRegion_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long _totalSize = LuaAPI.lua_toint64(L, 1);
                    
                        bool gen_ret = System.GC.TryStartNoGCRegion( _totalSize );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))) 
                {
                    long _totalSize = LuaAPI.lua_toint64(L, 1);
                    long _lohSize = LuaAPI.lua_toint64(L, 2);
                    
                        bool gen_ret = System.GC.TryStartNoGCRegion( _totalSize, _lohSize );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    long _totalSize = LuaAPI.lua_toint64(L, 1);
                    bool _disallowFullBlockingGC = LuaAPI.lua_toboolean(L, 2);
                    
                        bool gen_ret = System.GC.TryStartNoGCRegion( _totalSize, _disallowFullBlockingGC );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    long _totalSize = LuaAPI.lua_toint64(L, 1);
                    long _lohSize = LuaAPI.lua_toint64(L, 2);
                    bool _disallowFullBlockingGC = LuaAPI.lua_toboolean(L, 3);
                    
                        bool gen_ret = System.GC.TryStartNoGCRegion( _totalSize, _lohSize, _disallowFullBlockingGC );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.GC.TryStartNoGCRegion!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndNoGCRegion_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    System.GC.EndNoGCRegion(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxGeneration(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.GC.MaxGeneration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}

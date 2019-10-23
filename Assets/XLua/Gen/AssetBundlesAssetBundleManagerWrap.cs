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
    public class AssetBundlesAssetBundleManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(AssetBundles.AssetBundleManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 23, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TestHotfix", _m_TestHotfix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Initialize", _m_Initialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Cleanup", _m_Cleanup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAssetBundleResident", _m_SetAssetBundleResident);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAssetBundleResident", _m_IsAssetBundleResident);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAssetBundleLoaded", _m_IsAssetBundleLoaded);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetBundleCache", _m_GetAssetBundleCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAssetLoaded", _m_IsAssetLoaded);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetCache", _m_GetAssetCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddAssetCache", _m_AddAssetCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddAssetbundleAssetsCache", _m_AddAssetbundleAssetsCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearAssetsCache", _m_ClearAssetsCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetBundleAsyncCreater", _m_GetAssetBundleAsyncCreater);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetBundleAsync", _m_LoadAssetBundleAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownloadWebResourceAsync", _m_DownloadWebResourceAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownloadAssetFileAsync", _m_DownloadAssetFileAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownloadAssetBundleAsync", _m_DownloadAssetBundleAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RequestAssetFileAsync", _m_RequestAssetFileAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RequestAssetBundleAsync", _m_RequestAssetBundleAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadUnusedAssetBundle", _m_UnloadUnusedAssetBundle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadAllUnusedResidentAssetBundles", _m_UnloadAllUnusedResidentAssetBundles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapAssetPath", _m_MapAssetPath);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAssetAsync", _m_LoadAssetAsync);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "curManifest", _g_get_curManifest);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DownloadUrl", _g_get_DownloadUrl);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsProsessRunning", _g_get_IsProsessRunning);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ManifestBundleName", _g_get_ManifestBundleName);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					AssetBundles.AssetBundleManager gen_ret = new AssetBundles.AssetBundleManager();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to AssetBundles.AssetBundleManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TestHotfix(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.TestHotfix(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Initialize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.IEnumerator gen_ret = gen_to_be_invoked.Initialize(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cleanup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.IEnumerator gen_ret = gen_to_be_invoked.Cleanup(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAssetBundleResident(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    bool _resident = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetAssetBundleResident( _assetbundleName, _resident );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsAssetBundleResident(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assebundleName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsAssetBundleResident( _assebundleName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsAssetBundleLoaded(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsAssetBundleLoaded( _assetbundleName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.AssetBundle gen_ret = gen_to_be_invoked.GetAssetBundleCache( _assetbundleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsAssetLoaded(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsAssetLoaded( _assetName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Object gen_ret = gen_to_be_invoked.GetAssetCache( _assetName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddAssetCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Object _asset = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                    gen_to_be_invoked.AddAssetCache( _assetName, _asset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddAssetbundleAssetsCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    string _postfix = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.AddAssetbundleAssetsCache( _assetbundleName, _postfix );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.AddAssetbundleAssetsCache( _assetbundleName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to AssetBundles.AssetBundleManager.AddAssetbundleAssetsCache!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearAssetsCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ClearAssetsCache(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleAsyncCreater(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        AssetBundles.ResourceWebRequester gen_ret = gen_to_be_invoked.GetAssetBundleAsyncCreater( _assetbundleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetBundleAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        AssetBundles.BaseAssetBundleAsyncLoader gen_ret = gen_to_be_invoked.LoadAssetBundleAsync( _assetbundleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownloadWebResourceAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _url = LuaAPI.lua_tostring(L, 2);
                    
                        AssetBundles.ResourceWebRequester gen_ret = gen_to_be_invoked.DownloadWebResourceAsync( _url );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownloadAssetFileAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _filePath = LuaAPI.lua_tostring(L, 2);
                    
                        AssetBundles.ResourceWebRequester gen_ret = gen_to_be_invoked.DownloadAssetFileAsync( _filePath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownloadAssetBundleAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _filePath = LuaAPI.lua_tostring(L, 2);
                    
                        AssetBundles.ResourceWebRequester gen_ret = gen_to_be_invoked.DownloadAssetBundleAsync( _filePath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RequestAssetFileAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _filePath = LuaAPI.lua_tostring(L, 2);
                    bool _streamingAssetsOnly = LuaAPI.lua_toboolean(L, 3);
                    
                        AssetBundles.ResourceWebRequester gen_ret = gen_to_be_invoked.RequestAssetFileAsync( _filePath, _streamingAssetsOnly );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _filePath = LuaAPI.lua_tostring(L, 2);
                    
                        AssetBundles.ResourceWebRequester gen_ret = gen_to_be_invoked.RequestAssetFileAsync( _filePath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to AssetBundles.AssetBundleManager.RequestAssetFileAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RequestAssetBundleAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        AssetBundles.ResourceWebRequester gen_ret = gen_to_be_invoked.RequestAssetBundleAsync( _assetbundleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadUnusedAssetBundle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    bool _unloadAllLoadedObjects = LuaAPI.lua_toboolean(L, 3);
                    bool _unloadDependencies = LuaAPI.lua_toboolean(L, 4);
                    
                        bool gen_ret = gen_to_be_invoked.UnloadUnusedAssetBundle( _assetbundleName, _unloadAllLoadedObjects, _unloadDependencies );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    bool _unloadAllLoadedObjects = LuaAPI.lua_toboolean(L, 3);
                    
                        bool gen_ret = gen_to_be_invoked.UnloadUnusedAssetBundle( _assetbundleName, _unloadAllLoadedObjects );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.UnloadUnusedAssetBundle( _assetbundleName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to AssetBundles.AssetBundleManager.UnloadUnusedAssetBundle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadAllUnusedResidentAssetBundles(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    bool _unloadAllLoadedObjects = LuaAPI.lua_toboolean(L, 2);
                    bool _unloadDependencies = LuaAPI.lua_toboolean(L, 3);
                    
                        int gen_ret = gen_to_be_invoked.UnloadAllUnusedResidentAssetBundles( _unloadAllLoadedObjects, _unloadDependencies );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _unloadAllLoadedObjects = LuaAPI.lua_toboolean(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.UnloadAllUnusedResidentAssetBundles( _unloadAllLoadedObjects );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1) 
                {
                    
                        int gen_ret = gen_to_be_invoked.UnloadAllUnusedResidentAssetBundles(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to AssetBundles.AssetBundleManager.UnloadAllUnusedResidentAssetBundles!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapAssetPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetPath = LuaAPI.lua_tostring(L, 2);
                    string _assetbundleName;
                    string _assetName;
                    
                        bool gen_ret = gen_to_be_invoked.MapAssetPath( _assetPath, out _assetbundleName, out _assetName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushstring(L, _assetbundleName);
                        
                    LuaAPI.lua_pushstring(L, _assetName);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAssetAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetPath = LuaAPI.lua_tostring(L, 2);
                    System.Type _assetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        AssetBundles.BaseAssetAsyncLoader gen_ret = gen_to_be_invoked.LoadAssetAsync( _assetPath, _assetType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ManifestBundleName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, AssetBundles.AssetBundleManager.ManifestBundleName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_curManifest(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.curManifest);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DownloadUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.DownloadUrl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsProsessRunning(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AssetBundles.AssetBundleManager gen_to_be_invoked = (AssetBundles.AssetBundleManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsProsessRunning);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}

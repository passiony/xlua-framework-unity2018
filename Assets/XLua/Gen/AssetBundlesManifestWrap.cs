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
    public class AssetBundlesManifestWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(AssetBundles.Manifest);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadFromAssetbundle", _m_LoadFromAssetbundle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveBytes", _m_SaveBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveToDiskCahce", _m_SaveToDiskCahce);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAssetBundleHash", _m_GetAssetBundleHash);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllAssetBundleNames", _m_GetAllAssetBundleNames);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllAssetBundlesWithVariant", _m_GetAllAssetBundlesWithVariant);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllDependencies", _m_GetAllDependencies);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDirectDependencies", _m_GetDirectDependencies);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTo", _m_CompareTo);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "assetbundleManifest", _g_get_assetbundleManifest);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssetbundleName", _g_get_AssetbundleName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Length", _g_get_Length);
            
			
			
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
					
					AssetBundles.Manifest gen_ret = new AssetBundles.Manifest();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to AssetBundles.Manifest constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromAssetbundle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.AssetBundle _assetbundle = (UnityEngine.AssetBundle)translator.GetObject(L, 2, typeof(UnityEngine.AssetBundle));
                    
                    gen_to_be_invoked.LoadFromAssetbundle( _assetbundle );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
                    
                    gen_to_be_invoked.SaveBytes( _bytes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveToDiskCahce(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SaveToDiskCahce(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAssetBundleHash(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Hash128 gen_ret = gen_to_be_invoked.GetAssetBundleHash( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllAssetBundleNames(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string[] gen_ret = gen_to_be_invoked.GetAllAssetBundleNames(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllAssetBundlesWithVariant(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string[] gen_ret = gen_to_be_invoked.GetAllAssetBundlesWithVariant(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllDependencies(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        string[] gen_ret = gen_to_be_invoked.GetAllDependencies( _assetbundleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDirectDependencies(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _assetbundleName = LuaAPI.lua_tostring(L, 2);
                    
                        string[] gen_ret = gen_to_be_invoked.GetDirectDependencies( _assetbundleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompareTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    AssetBundles.Manifest _otherManifest = (AssetBundles.Manifest)translator.GetObject(L, 2, typeof(AssetBundles.Manifest));
                    
                        System.Collections.Generic.List<string> gen_ret = gen_to_be_invoked.CompareTo( _otherManifest );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_assetbundleManifest(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.assetbundleManifest);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetbundleName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.AssetbundleName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                AssetBundles.Manifest gen_to_be_invoked = (AssetBundles.Manifest)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Length);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}

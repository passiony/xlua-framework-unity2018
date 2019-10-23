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
    public class UnityEngineSceneManagementSceneManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.SceneManagement.SceneManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 16, 2, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetActiveScene", _m_GetActiveScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetActiveScene", _m_SetActiveScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSceneByPath", _m_GetSceneByPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSceneByName", _m_GetSceneByName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSceneByBuildIndex", _m_GetSceneByBuildIndex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSceneAt", _m_GetSceneAt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateScene", _m_CreateScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MergeScenes", _m_MergeScenes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveGameObjectToScene", _m_MoveGameObjectToScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadScene", _m_LoadScene_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadSceneAsync", _m_LoadSceneAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnloadSceneAsync", _m_UnloadSceneAsync_xlua_st_);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "sceneLoaded", _e_sceneLoaded);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "sceneUnloaded", _e_sceneUnloaded);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "activeSceneChanged", _e_activeSceneChanged);
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sceneCount", _g_get_sceneCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sceneCountInBuildSettings", _g_get_sceneCountInBuildSettings);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.SceneManagement.SceneManager gen_ret = new UnityEngine.SceneManagement.SceneManager();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetActiveScene_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        UnityEngine.SceneManagement.Scene gen_ret = UnityEngine.SceneManagement.SceneManager.GetActiveScene(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetActiveScene_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.SceneManagement.Scene _scene;translator.Get(L, 1, out _scene);
                    
                        bool gen_ret = UnityEngine.SceneManagement.SceneManager.SetActiveScene( _scene );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSceneByPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _scenePath = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.SceneManagement.Scene gen_ret = UnityEngine.SceneManagement.SceneManager.GetSceneByPath( _scenePath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSceneByName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.SceneManagement.Scene gen_ret = UnityEngine.SceneManagement.SceneManager.GetSceneByName( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSceneByBuildIndex_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _buildIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.SceneManagement.Scene gen_ret = UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex( _buildIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSceneAt_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.SceneManagement.Scene gen_ret = UnityEngine.SceneManagement.SceneManager.GetSceneAt( _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateScene_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _sceneName = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.SceneManagement.Scene gen_ret = UnityEngine.SceneManagement.SceneManager.CreateScene( _sceneName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SceneManagement.CreateSceneParameters>(L, 2)) 
                {
                    string _sceneName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.SceneManagement.CreateSceneParameters _parameters;translator.Get(L, 2, out _parameters);
                    
                        UnityEngine.SceneManagement.Scene gen_ret = UnityEngine.SceneManagement.SceneManager.CreateScene( _sceneName, _parameters );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager.CreateScene!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MergeScenes_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.SceneManagement.Scene _sourceScene;translator.Get(L, 1, out _sourceScene);
                    UnityEngine.SceneManagement.Scene _destinationScene;translator.Get(L, 2, out _destinationScene);
                    
                    UnityEngine.SceneManagement.SceneManager.MergeScenes( _sourceScene, _destinationScene );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveGameObjectToScene_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.GameObject _go = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    UnityEngine.SceneManagement.Scene _scene;translator.Get(L, 2, out _scene);
                    
                    UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene( _go, _scene );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadScene_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                    UnityEngine.SceneManagement.SceneManager.LoadScene( _sceneBuildIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _sceneName = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.SceneManagement.SceneManager.LoadScene( _sceneName );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneMode>(L, 2)) 
                {
                    int _sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.SceneManagement.LoadSceneMode _mode;translator.Get(L, 2, out _mode);
                    
                    UnityEngine.SceneManagement.SceneManager.LoadScene( _sceneBuildIndex, _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneParameters>(L, 2)) 
                {
                    int _sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.SceneManagement.LoadSceneParameters _parameters;translator.Get(L, 2, out _parameters);
                    
                        UnityEngine.SceneManagement.Scene gen_ret = UnityEngine.SceneManagement.SceneManager.LoadScene( _sceneBuildIndex, _parameters );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneMode>(L, 2)) 
                {
                    string _sceneName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.SceneManagement.LoadSceneMode _mode;translator.Get(L, 2, out _mode);
                    
                    UnityEngine.SceneManagement.SceneManager.LoadScene( _sceneName, _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneParameters>(L, 2)) 
                {
                    string _sceneName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.SceneManagement.LoadSceneParameters _parameters;translator.Get(L, 2, out _parameters);
                    
                        UnityEngine.SceneManagement.Scene gen_ret = UnityEngine.SceneManagement.SceneManager.LoadScene( _sceneName, _parameters );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager.LoadScene!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadSceneAsync_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync( _sceneBuildIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _sceneName = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync( _sceneName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneMode>(L, 2)) 
                {
                    int _sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.SceneManagement.LoadSceneMode _mode;translator.Get(L, 2, out _mode);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync( _sceneBuildIndex, _mode );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneParameters>(L, 2)) 
                {
                    int _sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.SceneManagement.LoadSceneParameters _parameters;translator.Get(L, 2, out _parameters);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync( _sceneBuildIndex, _parameters );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneMode>(L, 2)) 
                {
                    string _sceneName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.SceneManagement.LoadSceneMode _mode;translator.Get(L, 2, out _mode);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync( _sceneName, _mode );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SceneManagement.LoadSceneParameters>(L, 2)) 
                {
                    string _sceneName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.SceneManagement.LoadSceneParameters _parameters;translator.Get(L, 2, out _parameters);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync( _sceneName, _parameters );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager.LoadSceneAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadSceneAsync_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync( _sceneBuildIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _sceneName = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync( _sceneName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.SceneManagement.Scene>(L, 1)) 
                {
                    UnityEngine.SceneManagement.Scene _scene;translator.Get(L, 1, out _scene);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync( _scene );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.SceneManagement.UnloadSceneOptions>(L, 2)) 
                {
                    int _sceneBuildIndex = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.SceneManagement.UnloadSceneOptions _options;translator.Get(L, 2, out _options);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync( _sceneBuildIndex, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SceneManagement.UnloadSceneOptions>(L, 2)) 
                {
                    string _sceneName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.SceneManagement.UnloadSceneOptions _options;translator.Get(L, 2, out _options);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync( _sceneName, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.SceneManagement.Scene>(L, 1)&& translator.Assignable<UnityEngine.SceneManagement.UnloadSceneOptions>(L, 2)) 
                {
                    UnityEngine.SceneManagement.Scene _scene;translator.Get(L, 1, out _scene);
                    UnityEngine.SceneManagement.UnloadSceneOptions _options;translator.Get(L, 2, out _options);
                    
                        UnityEngine.AsyncOperation gen_ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync( _scene, _options );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sceneCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SceneManagement.SceneManager.sceneCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sceneCountInBuildSettings(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_sceneLoaded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> gen_delegate = translator.GetDelegate<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.SceneManagement.SceneManager.sceneLoaded += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.SceneManagement.SceneManager.sceneLoaded -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager.sceneLoaded!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_sceneUnloaded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> gen_delegate = translator.GetDelegate<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.SceneManagement.SceneManager.sceneUnloaded += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.SceneManagement.SceneManager.sceneUnloaded -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager.sceneUnloaded!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_activeSceneChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> gen_delegate = translator.GetDelegate<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.SceneManagement.SceneManager.activeSceneChanged += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.SceneManagement.SceneManager.activeSceneChanged -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SceneManagement.SceneManager.activeSceneChanged!");
        }
        
    }
}

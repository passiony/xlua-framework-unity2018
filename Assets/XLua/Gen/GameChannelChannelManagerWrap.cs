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
    public class GameChannelChannelManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GameChannel.ChannelManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 16, 5, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateChannel", _m_CreateChannel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsInternalVersion", _m_IsInternalVersion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProductName", _m_GetProductName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsGooglePlay", _m_IsGooglePlay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitSDK", _m_InitSDK);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnInitSDKCompleted", _m_OnInitSDKCompleted);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartDownloadGame", _m_StartDownloadGame);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDownloadGameProgressValueChange", _m_OnDownloadGameProgressValueChange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDownloadGameFinished", _m_OnDownloadGameFinished);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InstallGame", _m_InstallGame);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnInstallGameFinished", _m_OnInstallGameFinished);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnLogin", _m_OnLogin);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnLoginOut", _m_OnLoginOut);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSDKPay", _m_OnSDKPay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "channelName", _g_get_channelName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "noticeVersion", _g_get_noticeVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resVersion", _g_get_resVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "appVersion", _g_get_appVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "svnVersion", _g_get_svnVersion);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "noticeVersion", _s_set_noticeVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resVersion", _s_set_resVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "appVersion", _s_set_appVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "svnVersion", _s_set_svnVersion);
            
			
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
					
					GameChannel.ChannelManager gen_ret = new GameChannel.ChannelManager();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to GameChannel.ChannelManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _channelName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Init( _channelName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateChannel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _channelName = LuaAPI.lua_tostring(L, 2);
                    
                        GameChannel.BaseChannel gen_ret = gen_to_be_invoked.CreateChannel( _channelName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsInternalVersion(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.IsInternalVersion(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProductName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.GetProductName(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsGooglePlay(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.IsGooglePlay(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitSDK(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Action _callback = translator.GetDelegate<System.Action>(L, 2);
                    
                    gen_to_be_invoked.InitSDK( _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnInitSDKCompleted(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _msg = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.OnInitSDKCompleted( _msg );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartDownloadGame(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)&& translator.Assignable<System.Action>(L, 4)&& translator.Assignable<System.Action<int>>(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TSTRING)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 2);
                    System.Action _succeed = translator.GetDelegate<System.Action>(L, 3);
                    System.Action _fail = translator.GetDelegate<System.Action>(L, 4);
                    System.Action<int> _progress = translator.GetDelegate<System.Action<int>>(L, 5);
                    string _saveName = LuaAPI.lua_tostring(L, 6);
                    
                    gen_to_be_invoked.StartDownloadGame( _url, _succeed, _fail, _progress, _saveName );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)&& translator.Assignable<System.Action>(L, 4)&& translator.Assignable<System.Action<int>>(L, 5)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 2);
                    System.Action _succeed = translator.GetDelegate<System.Action>(L, 3);
                    System.Action _fail = translator.GetDelegate<System.Action>(L, 4);
                    System.Action<int> _progress = translator.GetDelegate<System.Action<int>>(L, 5);
                    
                    gen_to_be_invoked.StartDownloadGame( _url, _succeed, _fail, _progress );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)&& translator.Assignable<System.Action>(L, 4)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 2);
                    System.Action _succeed = translator.GetDelegate<System.Action>(L, 3);
                    System.Action _fail = translator.GetDelegate<System.Action>(L, 4);
                    
                    gen_to_be_invoked.StartDownloadGame( _url, _succeed, _fail );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 2);
                    System.Action _succeed = translator.GetDelegate<System.Action>(L, 3);
                    
                    gen_to_be_invoked.StartDownloadGame( _url, _succeed );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.StartDownloadGame( _url );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameChannel.ChannelManager.StartDownloadGame!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDownloadGameProgressValueChange(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _progress = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.OnDownloadGameProgressValueChange( _progress );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDownloadGameFinished(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _succeed = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.OnDownloadGameFinished( _succeed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InstallGame(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Action _succeed = translator.GetDelegate<System.Action>(L, 2);
                    System.Action _fail = translator.GetDelegate<System.Action>(L, 3);
                    
                    gen_to_be_invoked.InstallGame( _succeed, _fail );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnInstallGameFinished(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _succeed = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.OnInstallGameFinished( _succeed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnLogin(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _msg = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.OnLogin( _msg );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnLoginOut(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _msg = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.OnLoginOut( _msg );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnSDKPay(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _msg = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.OnSDKPay( _msg );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_channelName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.channelName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_noticeVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.noticeVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_resVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.resVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_appVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.appVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_svnVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.svnVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_noticeVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.noticeVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_resVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.resVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_appVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.appVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_svnVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GameChannel.ChannelManager gen_to_be_invoked = (GameChannel.ChannelManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.svnVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

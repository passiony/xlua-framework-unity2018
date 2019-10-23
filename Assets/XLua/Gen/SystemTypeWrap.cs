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
    public class SystemTypeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Type);
			Utils.BeginObjectRegister(type, L, translator, 1, 43, 60, 0);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakePointerType", _m_MakePointerType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakeByRefType", _m_MakeByRefType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakeArrayType", _m_MakeArrayType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InvokeMember", _m_InvokeMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetArrayRank", _m_GetArrayRank);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetConstructor", _m_GetConstructor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetConstructors", _m_GetConstructors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMethod", _m_GetMethod);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMethods", _m_GetMethods);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetField", _m_GetField);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFields", _m_GetFields);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInterface", _m_GetInterface);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInterfaces", _m_GetInterfaces);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindInterfaces", _m_FindInterfaces);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEvent", _m_GetEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEvents", _m_GetEvents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProperty", _m_GetProperty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetProperties", _m_GetProperties);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNestedTypes", _m_GetNestedTypes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNestedType", _m_GetNestedType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMember", _m_GetMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMembers", _m_GetMembers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDefaultMembers", _m_GetDefaultMembers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindMembers", _m_FindMembers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGenericParameterConstraints", _m_GetGenericParameterConstraints);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakeGenericType", _m_MakeGenericType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetElementType", _m_GetElementType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGenericArguments", _m_GetGenericArguments);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGenericTypeDefinition", _m_GetGenericTypeDefinition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumNames", _m_GetEnumNames);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumValues", _m_GetEnumValues);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumUnderlyingType", _m_GetEnumUnderlyingType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsEnumDefined", _m_IsEnumDefined);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumName", _m_GetEnumName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSubclassOf", _m_IsSubclassOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsInstanceOfType", _m_IsInstanceOfType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAssignableFrom", _m_IsAssignableFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsEquivalentTo", _m_IsEquivalentTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInterfaceMap", _m_GetInterfaceMap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetType", _m_GetType);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "MemberType", _g_get_MemberType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DeclaringType", _g_get_DeclaringType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DeclaringMethod", _g_get_DeclaringMethod);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReflectedType", _g_get_ReflectedType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "StructLayoutAttribute", _g_get_StructLayoutAttribute);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "GUID", _g_get_GUID);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Module", _g_get_Module);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Assembly", _g_get_Assembly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TypeHandle", _g_get_TypeHandle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "FullName", _g_get_FullName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Namespace", _g_get_Namespace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AssemblyQualifiedName", _g_get_AssemblyQualifiedName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BaseType", _g_get_BaseType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TypeInitializer", _g_get_TypeInitializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNested", _g_get_IsNested);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Attributes", _g_get_Attributes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "GenericParameterAttributes", _g_get_GenericParameterAttributes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsVisible", _g_get_IsVisible);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNotPublic", _g_get_IsNotPublic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsPublic", _g_get_IsPublic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNestedPublic", _g_get_IsNestedPublic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNestedPrivate", _g_get_IsNestedPrivate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNestedFamily", _g_get_IsNestedFamily);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNestedAssembly", _g_get_IsNestedAssembly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNestedFamANDAssem", _g_get_IsNestedFamANDAssem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNestedFamORAssem", _g_get_IsNestedFamORAssem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsAutoLayout", _g_get_IsAutoLayout);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsLayoutSequential", _g_get_IsLayoutSequential);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsExplicitLayout", _g_get_IsExplicitLayout);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsClass", _g_get_IsClass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsInterface", _g_get_IsInterface);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsValueType", _g_get_IsValueType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsAbstract", _g_get_IsAbstract);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSealed", _g_get_IsSealed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsEnum", _g_get_IsEnum);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSpecialName", _g_get_IsSpecialName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsImport", _g_get_IsImport);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSerializable", _g_get_IsSerializable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsAnsiClass", _g_get_IsAnsiClass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsUnicodeClass", _g_get_IsUnicodeClass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsAutoClass", _g_get_IsAutoClass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsArray", _g_get_IsArray);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsGenericType", _g_get_IsGenericType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsGenericTypeDefinition", _g_get_IsGenericTypeDefinition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsConstructedGenericType", _g_get_IsConstructedGenericType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsGenericParameter", _g_get_IsGenericParameter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "GenericParameterPosition", _g_get_GenericParameterPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ContainsGenericParameters", _g_get_ContainsGenericParameters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsByRef", _g_get_IsByRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsPointer", _g_get_IsPointer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsPrimitive", _g_get_IsPrimitive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsCOMObject", _g_get_IsCOMObject);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasElementType", _g_get_HasElementType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsContextful", _g_get_IsContextful);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsMarshalByRef", _g_get_IsMarshalByRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "GenericTypeArguments", _g_get_GenericTypeArguments);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSecurityCritical", _g_get_IsSecurityCritical);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSecuritySafeCritical", _g_get_IsSecuritySafeCritical);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsSecurityTransparent", _g_get_IsSecurityTransparent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UnderlyingSystemType", _g_get_UnderlyingSystemType);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 15, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetType", _m_GetType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTypeFromProgID", _m_GetTypeFromProgID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTypeFromCLSID", _m_GetTypeFromCLSID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTypeCode", _m_GetTypeCode_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTypeHandle", _m_GetTypeHandle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTypeArray", _m_GetTypeArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReflectionOnlyGetType", _m_ReflectionOnlyGetType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTypeFromHandle", _m_GetTypeFromHandle_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FilterAttribute", System.Type.FilterAttribute);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FilterName", System.Type.FilterName);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FilterNameIgnoreCase", System.Type.FilterNameIgnoreCase);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Missing", System.Type.Missing);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Delimiter", System.Type.Delimiter);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EmptyTypes", System.Type.EmptyTypes);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "DefaultBinder", _g_get_DefaultBinder);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "System.Type does not have a constructor!");
        }
        
		
        
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<System.Type>(L, 1) && translator.Assignable<System.Type>(L, 2))
				{
					System.Type leftside = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
					System.Type rightside = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need System.Type!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetType_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _typeName = LuaAPI.lua_tostring(L, 1);
                    
                        System.Type gen_ret = System.Type.GetType( _typeName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    string _typeName = LuaAPI.lua_tostring(L, 1);
                    bool _throwOnError = LuaAPI.lua_toboolean(L, 2);
                    
                        System.Type gen_ret = System.Type.GetType( _typeName, _throwOnError );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _typeName = LuaAPI.lua_tostring(L, 1);
                    bool _throwOnError = LuaAPI.lua_toboolean(L, 2);
                    bool _ignoreCase = LuaAPI.lua_toboolean(L, 3);
                    
                        System.Type gen_ret = System.Type.GetType( _typeName, _throwOnError, _ignoreCase );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>>(L, 2)&& translator.Assignable<System.Func<System.Reflection.Assembly, string, bool, System.Type>>(L, 3)) 
                {
                    string _typeName = LuaAPI.lua_tostring(L, 1);
                    System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> _assemblyResolver = translator.GetDelegate<System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>>(L, 2);
                    System.Func<System.Reflection.Assembly, string, bool, System.Type> _typeResolver = translator.GetDelegate<System.Func<System.Reflection.Assembly, string, bool, System.Type>>(L, 3);
                    
                        System.Type gen_ret = System.Type.GetType( _typeName, _assemblyResolver, _typeResolver );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>>(L, 2)&& translator.Assignable<System.Func<System.Reflection.Assembly, string, bool, System.Type>>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    string _typeName = LuaAPI.lua_tostring(L, 1);
                    System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> _assemblyResolver = translator.GetDelegate<System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>>(L, 2);
                    System.Func<System.Reflection.Assembly, string, bool, System.Type> _typeResolver = translator.GetDelegate<System.Func<System.Reflection.Assembly, string, bool, System.Type>>(L, 3);
                    bool _throwOnError = LuaAPI.lua_toboolean(L, 4);
                    
                        System.Type gen_ret = System.Type.GetType( _typeName, _assemblyResolver, _typeResolver, _throwOnError );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>>(L, 2)&& translator.Assignable<System.Func<System.Reflection.Assembly, string, bool, System.Type>>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    string _typeName = LuaAPI.lua_tostring(L, 1);
                    System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> _assemblyResolver = translator.GetDelegate<System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>>(L, 2);
                    System.Func<System.Reflection.Assembly, string, bool, System.Type> _typeResolver = translator.GetDelegate<System.Func<System.Reflection.Assembly, string, bool, System.Type>>(L, 3);
                    bool _throwOnError = LuaAPI.lua_toboolean(L, 4);
                    bool _ignoreCase = LuaAPI.lua_toboolean(L, 5);
                    
                        System.Type gen_ret = System.Type.GetType( _typeName, _assemblyResolver, _typeResolver, _throwOnError, _ignoreCase );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetType!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakePointerType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type gen_ret = gen_to_be_invoked.MakePointerType(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeByRefType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type gen_ret = gen_to_be_invoked.MakeByRefType(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeArrayType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        System.Type gen_ret = gen_to_be_invoked.MakeArrayType(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _rank = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.Type gen_ret = gen_to_be_invoked.MakeArrayType( _rank );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.MakeArrayType!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTypeFromProgID_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _progID = LuaAPI.lua_tostring(L, 1);
                    
                        System.Type gen_ret = System.Type.GetTypeFromProgID( _progID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    string _progID = LuaAPI.lua_tostring(L, 1);
                    bool _throwOnError = LuaAPI.lua_toboolean(L, 2);
                    
                        System.Type gen_ret = System.Type.GetTypeFromProgID( _progID, _throwOnError );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _progID = LuaAPI.lua_tostring(L, 1);
                    string _server = LuaAPI.lua_tostring(L, 2);
                    
                        System.Type gen_ret = System.Type.GetTypeFromProgID( _progID, _server );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _progID = LuaAPI.lua_tostring(L, 1);
                    string _server = LuaAPI.lua_tostring(L, 2);
                    bool _throwOnError = LuaAPI.lua_toboolean(L, 3);
                    
                        System.Type gen_ret = System.Type.GetTypeFromProgID( _progID, _server, _throwOnError );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetTypeFromProgID!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTypeFromCLSID_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<System.Guid>(L, 1)) 
                {
                    System.Guid _clsid;translator.Get(L, 1, out _clsid);
                    
                        System.Type gen_ret = System.Type.GetTypeFromCLSID( _clsid );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Guid>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    System.Guid _clsid;translator.Get(L, 1, out _clsid);
                    bool _throwOnError = LuaAPI.lua_toboolean(L, 2);
                    
                        System.Type gen_ret = System.Type.GetTypeFromCLSID( _clsid, _throwOnError );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Guid>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    System.Guid _clsid;translator.Get(L, 1, out _clsid);
                    string _server = LuaAPI.lua_tostring(L, 2);
                    
                        System.Type gen_ret = System.Type.GetTypeFromCLSID( _clsid, _server );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Guid>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Guid _clsid;translator.Get(L, 1, out _clsid);
                    string _server = LuaAPI.lua_tostring(L, 2);
                    bool _throwOnError = LuaAPI.lua_toboolean(L, 3);
                    
                        System.Type gen_ret = System.Type.GetTypeFromCLSID( _clsid, _server, _throwOnError );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetTypeFromCLSID!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTypeCode_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        System.TypeCode gen_ret = System.Type.GetTypeCode( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InvokeMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)&& translator.Assignable<System.Reflection.Binder>(L, 4)&& translator.Assignable<object>(L, 5)&& translator.Assignable<object[]>(L, 6)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _invokeAttr;translator.Get(L, 3, out _invokeAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 4, typeof(System.Reflection.Binder));
                    object _target = translator.GetObject(L, 5, typeof(object));
                    object[] _args = (object[])translator.GetObject(L, 6, typeof(object[]));
                    
                        object gen_ret = gen_to_be_invoked.InvokeMember( _name, _invokeAttr, _binder, _target, _args );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)&& translator.Assignable<System.Reflection.Binder>(L, 4)&& translator.Assignable<object>(L, 5)&& translator.Assignable<object[]>(L, 6)&& translator.Assignable<System.Globalization.CultureInfo>(L, 7)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _invokeAttr;translator.Get(L, 3, out _invokeAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 4, typeof(System.Reflection.Binder));
                    object _target = translator.GetObject(L, 5, typeof(object));
                    object[] _args = (object[])translator.GetObject(L, 6, typeof(object[]));
                    System.Globalization.CultureInfo _culture = (System.Globalization.CultureInfo)translator.GetObject(L, 7, typeof(System.Globalization.CultureInfo));
                    
                        object gen_ret = gen_to_be_invoked.InvokeMember( _name, _invokeAttr, _binder, _target, _args, _culture );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)&& translator.Assignable<System.Reflection.Binder>(L, 4)&& translator.Assignable<object>(L, 5)&& translator.Assignable<object[]>(L, 6)&& translator.Assignable<System.Reflection.ParameterModifier[]>(L, 7)&& translator.Assignable<System.Globalization.CultureInfo>(L, 8)&& translator.Assignable<string[]>(L, 9)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _invokeAttr;translator.Get(L, 3, out _invokeAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 4, typeof(System.Reflection.Binder));
                    object _target = translator.GetObject(L, 5, typeof(object));
                    object[] _args = (object[])translator.GetObject(L, 6, typeof(object[]));
                    System.Reflection.ParameterModifier[] _modifiers = (System.Reflection.ParameterModifier[])translator.GetObject(L, 7, typeof(System.Reflection.ParameterModifier[]));
                    System.Globalization.CultureInfo _culture = (System.Globalization.CultureInfo)translator.GetObject(L, 8, typeof(System.Globalization.CultureInfo));
                    string[] _namedParameters = (string[])translator.GetObject(L, 9, typeof(string[]));
                    
                        object gen_ret = gen_to_be_invoked.InvokeMember( _name, _invokeAttr, _binder, _target, _args, _modifiers, _culture, _namedParameters );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.InvokeMember!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTypeHandle_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _o = translator.GetObject(L, 1, typeof(object));
                    
                        System.RuntimeTypeHandle gen_ret = System.Type.GetTypeHandle( _o );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetArrayRank(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetArrayRank(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetConstructor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Type[]>(L, 2)) 
                {
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 2, typeof(System.Type[]));
                    
                        System.Reflection.ConstructorInfo gen_ret = gen_to_be_invoked.GetConstructor( _types );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)&& translator.Assignable<System.Reflection.Binder>(L, 3)&& translator.Assignable<System.Type[]>(L, 4)&& translator.Assignable<System.Reflection.ParameterModifier[]>(L, 5)) 
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 3, typeof(System.Reflection.Binder));
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 4, typeof(System.Type[]));
                    System.Reflection.ParameterModifier[] _modifiers = (System.Reflection.ParameterModifier[])translator.GetObject(L, 5, typeof(System.Reflection.ParameterModifier[]));
                    
                        System.Reflection.ConstructorInfo gen_ret = gen_to_be_invoked.GetConstructor( _bindingAttr, _binder, _types, _modifiers );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)&& translator.Assignable<System.Reflection.Binder>(L, 3)&& translator.Assignable<System.Reflection.CallingConventions>(L, 4)&& translator.Assignable<System.Type[]>(L, 5)&& translator.Assignable<System.Reflection.ParameterModifier[]>(L, 6)) 
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 3, typeof(System.Reflection.Binder));
                    System.Reflection.CallingConventions _callConvention;translator.Get(L, 4, out _callConvention);
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 5, typeof(System.Type[]));
                    System.Reflection.ParameterModifier[] _modifiers = (System.Reflection.ParameterModifier[])translator.GetObject(L, 6, typeof(System.Reflection.ParameterModifier[]));
                    
                        System.Reflection.ConstructorInfo gen_ret = gen_to_be_invoked.GetConstructor( _bindingAttr, _binder, _callConvention, _types, _modifiers );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetConstructor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetConstructors(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        System.Reflection.ConstructorInfo[] gen_ret = gen_to_be_invoked.GetConstructors(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)) 
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.ConstructorInfo[] gen_ret = gen_to_be_invoked.GetConstructors( _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetConstructors!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMethod(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        System.Reflection.MethodInfo gen_ret = gen_to_be_invoked.GetMethod( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type[]>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 3, typeof(System.Type[]));
                    
                        System.Reflection.MethodInfo gen_ret = gen_to_be_invoked.GetMethod( _name, _types );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    
                        System.Reflection.MethodInfo gen_ret = gen_to_be_invoked.GetMethod( _name, _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type[]>(L, 3)&& translator.Assignable<System.Reflection.ParameterModifier[]>(L, 4)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 3, typeof(System.Type[]));
                    System.Reflection.ParameterModifier[] _modifiers = (System.Reflection.ParameterModifier[])translator.GetObject(L, 4, typeof(System.Reflection.ParameterModifier[]));
                    
                        System.Reflection.MethodInfo gen_ret = gen_to_be_invoked.GetMethod( _name, _types, _modifiers );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)&& translator.Assignable<System.Reflection.Binder>(L, 4)&& translator.Assignable<System.Type[]>(L, 5)&& translator.Assignable<System.Reflection.ParameterModifier[]>(L, 6)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 4, typeof(System.Reflection.Binder));
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 5, typeof(System.Type[]));
                    System.Reflection.ParameterModifier[] _modifiers = (System.Reflection.ParameterModifier[])translator.GetObject(L, 6, typeof(System.Reflection.ParameterModifier[]));
                    
                        System.Reflection.MethodInfo gen_ret = gen_to_be_invoked.GetMethod( _name, _bindingAttr, _binder, _types, _modifiers );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)&& translator.Assignable<System.Reflection.Binder>(L, 4)&& translator.Assignable<System.Reflection.CallingConventions>(L, 5)&& translator.Assignable<System.Type[]>(L, 6)&& translator.Assignable<System.Reflection.ParameterModifier[]>(L, 7)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 4, typeof(System.Reflection.Binder));
                    System.Reflection.CallingConventions _callConvention;translator.Get(L, 5, out _callConvention);
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 6, typeof(System.Type[]));
                    System.Reflection.ParameterModifier[] _modifiers = (System.Reflection.ParameterModifier[])translator.GetObject(L, 7, typeof(System.Reflection.ParameterModifier[]));
                    
                        System.Reflection.MethodInfo gen_ret = gen_to_be_invoked.GetMethod( _name, _bindingAttr, _binder, _callConvention, _types, _modifiers );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetMethod!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMethods(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        System.Reflection.MethodInfo[] gen_ret = gen_to_be_invoked.GetMethods(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)) 
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.MethodInfo[] gen_ret = gen_to_be_invoked.GetMethods( _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetMethods!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetField(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        System.Reflection.FieldInfo gen_ret = gen_to_be_invoked.GetField( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    
                        System.Reflection.FieldInfo gen_ret = gen_to_be_invoked.GetField( _name, _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetField!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFields(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        System.Reflection.FieldInfo[] gen_ret = gen_to_be_invoked.GetFields(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)) 
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.FieldInfo[] gen_ret = gen_to_be_invoked.GetFields( _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetFields!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInterface(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        System.Type gen_ret = gen_to_be_invoked.GetInterface( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    bool _ignoreCase = LuaAPI.lua_toboolean(L, 3);
                    
                        System.Type gen_ret = gen_to_be_invoked.GetInterface( _name, _ignoreCase );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetInterface!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInterfaces(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type[] gen_ret = gen_to_be_invoked.GetInterfaces(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindInterfaces(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.TypeFilter _filter = translator.GetDelegate<System.Reflection.TypeFilter>(L, 2);
                    object _filterCriteria = translator.GetObject(L, 3, typeof(object));
                    
                        System.Type[] gen_ret = gen_to_be_invoked.FindInterfaces( _filter, _filterCriteria );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEvent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        System.Reflection.EventInfo gen_ret = gen_to_be_invoked.GetEvent( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    
                        System.Reflection.EventInfo gen_ret = gen_to_be_invoked.GetEvent( _name, _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetEvent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEvents(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        System.Reflection.EventInfo[] gen_ret = gen_to_be_invoked.GetEvents(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)) 
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.EventInfo[] gen_ret = gen_to_be_invoked.GetEvents( _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetEvents!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProperty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        System.Reflection.PropertyInfo gen_ret = gen_to_be_invoked.GetProperty( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    
                        System.Reflection.PropertyInfo gen_ret = gen_to_be_invoked.GetProperty( _name, _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type[]>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 3, typeof(System.Type[]));
                    
                        System.Reflection.PropertyInfo gen_ret = gen_to_be_invoked.GetProperty( _name, _types );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Type _returnType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        System.Reflection.PropertyInfo gen_ret = gen_to_be_invoked.GetProperty( _name, _returnType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<System.Type[]>(L, 4)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Type _returnType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 4, typeof(System.Type[]));
                    
                        System.Reflection.PropertyInfo gen_ret = gen_to_be_invoked.GetProperty( _name, _returnType, _types );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 3)&& translator.Assignable<System.Type[]>(L, 4)&& translator.Assignable<System.Reflection.ParameterModifier[]>(L, 5)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Type _returnType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 4, typeof(System.Type[]));
                    System.Reflection.ParameterModifier[] _modifiers = (System.Reflection.ParameterModifier[])translator.GetObject(L, 5, typeof(System.Reflection.ParameterModifier[]));
                    
                        System.Reflection.PropertyInfo gen_ret = gen_to_be_invoked.GetProperty( _name, _returnType, _types, _modifiers );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)&& translator.Assignable<System.Reflection.Binder>(L, 4)&& translator.Assignable<System.Type>(L, 5)&& translator.Assignable<System.Type[]>(L, 6)&& translator.Assignable<System.Reflection.ParameterModifier[]>(L, 7)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    System.Reflection.Binder _binder = (System.Reflection.Binder)translator.GetObject(L, 4, typeof(System.Reflection.Binder));
                    System.Type _returnType = (System.Type)translator.GetObject(L, 5, typeof(System.Type));
                    System.Type[] _types = (System.Type[])translator.GetObject(L, 6, typeof(System.Type[]));
                    System.Reflection.ParameterModifier[] _modifiers = (System.Reflection.ParameterModifier[])translator.GetObject(L, 7, typeof(System.Reflection.ParameterModifier[]));
                    
                        System.Reflection.PropertyInfo gen_ret = gen_to_be_invoked.GetProperty( _name, _bindingAttr, _binder, _returnType, _types, _modifiers );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetProperty!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProperties(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        System.Reflection.PropertyInfo[] gen_ret = gen_to_be_invoked.GetProperties(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)) 
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.PropertyInfo[] gen_ret = gen_to_be_invoked.GetProperties( _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetProperties!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNestedTypes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        System.Type[] gen_ret = gen_to_be_invoked.GetNestedTypes(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)) 
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Type[] gen_ret = gen_to_be_invoked.GetNestedTypes( _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetNestedTypes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNestedType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        System.Type gen_ret = gen_to_be_invoked.GetNestedType( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    
                        System.Type gen_ret = gen_to_be_invoked.GetNestedType( _name, _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetNestedType!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        System.Reflection.MemberInfo[] gen_ret = gen_to_be_invoked.GetMember( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.BindingFlags>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    
                        System.Reflection.MemberInfo[] gen_ret = gen_to_be_invoked.GetMember( _name, _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Reflection.MemberTypes>(L, 3)&& translator.Assignable<System.Reflection.BindingFlags>(L, 4)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Reflection.MemberTypes _type;translator.Get(L, 3, out _type);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 4, out _bindingAttr);
                    
                        System.Reflection.MemberInfo[] gen_ret = gen_to_be_invoked.GetMember( _name, _type, _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetMember!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMembers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        System.Reflection.MemberInfo[] gen_ret = gen_to_be_invoked.GetMembers(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Reflection.BindingFlags>(L, 2)) 
                {
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 2, out _bindingAttr);
                    
                        System.Reflection.MemberInfo[] gen_ret = gen_to_be_invoked.GetMembers( _bindingAttr );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.GetMembers!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDefaultMembers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Reflection.MemberInfo[] gen_ret = gen_to_be_invoked.GetDefaultMembers(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindMembers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.MemberTypes _memberType;translator.Get(L, 2, out _memberType);
                    System.Reflection.BindingFlags _bindingAttr;translator.Get(L, 3, out _bindingAttr);
                    System.Reflection.MemberFilter _filter = translator.GetDelegate<System.Reflection.MemberFilter>(L, 4);
                    object _filterCriteria = translator.GetObject(L, 5, typeof(object));
                    
                        System.Reflection.MemberInfo[] gen_ret = gen_to_be_invoked.FindMembers( _memberType, _bindingAttr, _filter, _filterCriteria );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGenericParameterConstraints(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type[] gen_ret = gen_to_be_invoked.GetGenericParameterConstraints(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeGenericType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type[] _typeArguments = translator.GetParams<System.Type>(L, 2);
                    
                        System.Type gen_ret = gen_to_be_invoked.MakeGenericType( _typeArguments );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetElementType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type gen_ret = gen_to_be_invoked.GetElementType(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGenericArguments(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type[] gen_ret = gen_to_be_invoked.GetGenericArguments(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGenericTypeDefinition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type gen_ret = gen_to_be_invoked.GetGenericTypeDefinition(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumNames(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string[] gen_ret = gen_to_be_invoked.GetEnumNames(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumValues(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Array gen_ret = gen_to_be_invoked.GetEnumValues(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumUnderlyingType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type gen_ret = gen_to_be_invoked.GetEnumUnderlyingType(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsEnumDefined(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _value = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.IsEnumDefined( _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _value = translator.GetObject(L, 2, typeof(object));
                    
                        string gen_ret = gen_to_be_invoked.GetEnumName( _value );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSubclassOf(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _c = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool gen_ret = gen_to_be_invoked.IsSubclassOf( _c );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsInstanceOfType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _o = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.IsInstanceOfType( _o );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsAssignableFrom(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _c = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool gen_ret = gen_to_be_invoked.IsAssignableFrom( _c );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsEquivalentTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _other = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool gen_ret = gen_to_be_invoked.IsEquivalentTo( _other );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTypeArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object[] _args = (object[])translator.GetObject(L, 1, typeof(object[]));
                    
                        System.Type[] gen_ret = System.Type.GetTypeArray( _args );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _o = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _o );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _o = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _o );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Type.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInterfaceMap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _interfaceType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        System.Reflection.InterfaceMapping gen_ret = gen_to_be_invoked.GetInterfaceMap( _interfaceType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type gen_ret = gen_to_be_invoked.GetType(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReflectionOnlyGetType_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _typeName = LuaAPI.lua_tostring(L, 1);
                    bool _throwIfNotFound = LuaAPI.lua_toboolean(L, 2);
                    bool _ignoreCase = LuaAPI.lua_toboolean(L, 3);
                    
                        System.Type gen_ret = System.Type.ReflectionOnlyGetType( _typeName, _throwIfNotFound, _ignoreCase );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTypeFromHandle_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.RuntimeTypeHandle _handle;translator.Get(L, 1, out _handle);
                    
                        System.Type gen_ret = System.Type.GetTypeFromHandle( _handle );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MemberType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.MemberType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DeclaringType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.DeclaringType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DeclaringMethod(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.DeclaringMethod);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReflectedType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ReflectedType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_StructLayoutAttribute(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.StructLayoutAttribute);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GUID(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.GUID);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DefaultBinder(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Type.DefaultBinder);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Module(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Module);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Assembly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Assembly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TypeHandle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.TypeHandle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FullName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.FullName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Namespace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Namespace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssemblyQualifiedName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.AssemblyQualifiedName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BaseType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.BaseType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TypeInitializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.TypeInitializer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNested(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNested);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Attributes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Attributes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GenericParameterAttributes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.GenericParameterAttributes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsVisible(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsVisible);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNotPublic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNotPublic);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsPublic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsPublic);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNestedPublic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNestedPublic);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNestedPrivate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNestedPrivate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNestedFamily(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNestedFamily);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNestedAssembly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNestedAssembly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNestedFamANDAssem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNestedFamANDAssem);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNestedFamORAssem(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNestedFamORAssem);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsAutoLayout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsAutoLayout);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsLayoutSequential(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsLayoutSequential);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsExplicitLayout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsExplicitLayout);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsClass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsClass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsInterface(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsInterface);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsValueType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsValueType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsAbstract(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsAbstract);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSealed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSealed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsEnum(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsEnum);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSpecialName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSpecialName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsImport(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsImport);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSerializable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSerializable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsAnsiClass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsAnsiClass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsUnicodeClass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsUnicodeClass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsAutoClass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsAutoClass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsArray(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsArray);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsGenericType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsGenericType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsGenericTypeDefinition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsGenericTypeDefinition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsConstructedGenericType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsConstructedGenericType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsGenericParameter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsGenericParameter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GenericParameterPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.GenericParameterPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ContainsGenericParameters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ContainsGenericParameters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsByRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsByRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsPointer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsPointer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsPrimitive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsPrimitive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsCOMObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsCOMObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasElementType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.HasElementType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsContextful(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsContextful);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsMarshalByRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsMarshalByRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GenericTypeArguments(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.GenericTypeArguments);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSecurityCritical(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSecurityCritical);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSecuritySafeCritical(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSecuritySafeCritical);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSecurityTransparent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsSecurityTransparent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UnderlyingSystemType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                System.Type gen_to_be_invoked = (System.Type)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.UnderlyingSystemType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}

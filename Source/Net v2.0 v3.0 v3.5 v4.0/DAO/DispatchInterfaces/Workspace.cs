//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.DAOApi
{
	///<summary>
	/// DispatchInterface Workspace SupportByLibraryAttribute DAO, 6,12
	///</summary>
	[SupportByLibraryAttribute("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Workspace : _DAO
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Workspace);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workspace(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workspace(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workspace(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workspace() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workspace(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public string UserName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UserName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public string _30_UserName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_30_UserName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "_30_UserName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public string _30_Password
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_30_Password", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "_30_Password", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public Int16 IsolateODBCTrans
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsolateODBCTrans", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IsolateODBCTrans", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Databases Databases
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Databases", paramsArray);
				NetOffice.DAOApi.Databases newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Databases.LateBindingApiWrapperType) as NetOffice.DAOApi.Databases;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Users Users
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Users", paramsArray);
				NetOffice.DAOApi.Users newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Users.LateBindingApiWrapperType) as NetOffice.DAOApi.Users;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Groups Groups
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Groups", paramsArray);
				NetOffice.DAOApi.Groups newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Groups.LateBindingApiWrapperType) as NetOffice.DAOApi.Groups;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public Int32 LoginTimeout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LoginTimeout", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LoginTimeout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public Int32 DefaultCursorDriver
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultCursorDriver", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultCursorDriver", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public Int32 hEnv
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "hEnv", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public Int32 Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Connections Connections
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connections", paramsArray);
				NetOffice.DAOApi.Connections newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Connections.LateBindingApiWrapperType) as NetOffice.DAOApi.Connections;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public void BeginTrans()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "BeginTrans", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public void CommitTrans(Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options);
			Invoker.Method(this, "CommitTrans", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public void Rollback()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Rollback", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="Connect">optional object Connect</param>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Database OpenDatabase(string name, object options, object readOnly, object connect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, options, readOnly, connect);
			object returnItem = Invoker.MethodReturn(this, "OpenDatabase", paramsArray);
			NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Database.LateBindingApiWrapperType) as NetOffice.DAOApi.Database;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Database OpenDatabase(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "OpenDatabase", paramsArray);
			NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Database.LateBindingApiWrapperType) as NetOffice.DAOApi.Database;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Options">optional object Options</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Database OpenDatabase(string name, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, options);
			object returnItem = Invoker.MethodReturn(this, "OpenDatabase", paramsArray);
			NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Database.LateBindingApiWrapperType) as NetOffice.DAOApi.Database;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Database OpenDatabase(string name, object options, object readOnly)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, options, readOnly);
			object returnItem = Invoker.MethodReturn(this, "OpenDatabase", paramsArray);
			NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Database.LateBindingApiWrapperType) as NetOffice.DAOApi.Database;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Connect">string Connect</param>
		/// <param name="Option">optional object Option</param>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Database CreateDatabase(string name, string connect, object option)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, connect, option);
			object returnItem = Invoker.MethodReturn(this, "CreateDatabase", paramsArray);
			NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Database.LateBindingApiWrapperType) as NetOffice.DAOApi.Database;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Connect">string Connect</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Database CreateDatabase(string name, string connect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, connect);
			object returnItem = Invoker.MethodReturn(this, "CreateDatabase", paramsArray);
			NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Database.LateBindingApiWrapperType) as NetOffice.DAOApi.Database;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="PID">optional object PID</param>
		/// <param name="Password">optional object Password</param>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.User CreateUser(object name, object pID, object password)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, pID, password);
			object returnItem = Invoker.MethodReturn(this, "CreateUser", paramsArray);
			NetOffice.DAOApi.User newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.User.LateBindingApiWrapperType) as NetOffice.DAOApi.User;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.User CreateUser()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateUser", paramsArray);
			NetOffice.DAOApi.User newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.User.LateBindingApiWrapperType) as NetOffice.DAOApi.User;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.User CreateUser(object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "CreateUser", paramsArray);
			NetOffice.DAOApi.User newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.User.LateBindingApiWrapperType) as NetOffice.DAOApi.User;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="PID">optional object PID</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.User CreateUser(object name, object pID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, pID);
			object returnItem = Invoker.MethodReturn(this, "CreateUser", paramsArray);
			NetOffice.DAOApi.User newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.User.LateBindingApiWrapperType) as NetOffice.DAOApi.User;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="PID">optional object PID</param>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Group CreateGroup(object name, object pID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, pID);
			object returnItem = Invoker.MethodReturn(this, "CreateGroup", paramsArray);
			NetOffice.DAOApi.Group newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Group.LateBindingApiWrapperType) as NetOffice.DAOApi.Group;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Group CreateGroup()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateGroup", paramsArray);
			NetOffice.DAOApi.Group newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Group.LateBindingApiWrapperType) as NetOffice.DAOApi.Group;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Group CreateGroup(object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "CreateGroup", paramsArray);
			NetOffice.DAOApi.Group newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Group.LateBindingApiWrapperType) as NetOffice.DAOApi.Group;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="Connect">optional object Connect</param>
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Connection OpenConnection(string name, object options, object readOnly, object connect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, options, readOnly, connect);
			object returnItem = Invoker.MethodReturn(this, "OpenConnection", paramsArray);
			NetOffice.DAOApi.Connection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Connection.LateBindingApiWrapperType) as NetOffice.DAOApi.Connection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Connection OpenConnection(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "OpenConnection", paramsArray);
			NetOffice.DAOApi.Connection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Connection.LateBindingApiWrapperType) as NetOffice.DAOApi.Connection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Options">optional object Options</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Connection OpenConnection(string name, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, options);
			object returnItem = Invoker.MethodReturn(this, "OpenConnection", paramsArray);
			NetOffice.DAOApi.Connection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Connection.LateBindingApiWrapperType) as NetOffice.DAOApi.Connection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("DAO", 6,12)]
		public NetOffice.DAOApi.Connection OpenConnection(string name, object options, object readOnly)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, options, readOnly);
			object returnItem = Invoker.MethodReturn(this, "OpenConnection", paramsArray);
			NetOffice.DAOApi.Connection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Connection.LateBindingApiWrapperType) as NetOffice.DAOApi.Connection;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _ExchangeDistributionList 
	/// SupportByVersion Outlook, 12,14,15
	///</summary>
	[SupportByVersionAttribute("Outlook", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _ExchangeDistributionList : COMObject
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
                    _type = typeof(_ExchangeDistributionList);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public _ExchangeDistributionList(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeDistributionList(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869431.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff864183.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff867847.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff866786.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868105.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public string Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Address", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Address", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869657.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Enums.OlDisplayType DisplayType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlDisplayType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862195.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public string ID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.OutlookApi.AddressEntry Manager
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Manager", paramsArray);
				NetOffice.OutlookApi.AddressEntry newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get/Set
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object MAPIOBJECT
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MAPIOBJECT", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MAPIOBJECT", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NetOffice.OutlookApi.AddressEntries Members
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Members", paramsArray);
				NetOffice.OutlookApi.AddressEntries newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.AddressEntries.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863619.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869520.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public string Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff864700.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.Enums.OlAddressEntryUserType AddressEntryUserType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressEntryUserType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlAddressEntryUserType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865847.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.PropertyAccessor PropertyAccessor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyAccessor", paramsArray);
				NetOffice.OutlookApi.PropertyAccessor newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.PropertyAccessor.LateBindingApiWrapperType) as NetOffice.OutlookApi.PropertyAccessor;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868232.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public string Alias
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Alias", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff867840.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public string Comments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Comments", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Comments", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869982.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public string PrimarySmtpAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrimarySmtpAddress", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869867.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869569.aspx
		/// </summary>
		/// <param name="hWnd">optional object HWnd</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Details(object hWnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hWnd);
			Invoker.Method(this, "Details", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869569.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Details()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Details", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868720.aspx
		/// </summary>
		/// <param name="start">DateTime Start</param>
		/// <param name="minPerChar">Int32 MinPerChar</param>
		/// <param name="completeFormat">optional object CompleteFormat</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public string GetFreeBusy(DateTime start, Int32 minPerChar, object completeFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, minPerChar, completeFormat);
			object returnItem = Invoker.MethodReturn(this, "GetFreeBusy", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868720.aspx
		/// </summary>
		/// <param name="start">DateTime Start</param>
		/// <param name="minPerChar">Int32 MinPerChar</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public string GetFreeBusy(DateTime start, Int32 minPerChar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, minPerChar);
			object returnItem = Invoker.MethodReturn(this, "GetFreeBusy", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863058.aspx
		/// </summary>
		/// <param name="makePermanent">optional object MakePermanent</param>
		/// <param name="refresh">optional object Refresh</param>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Update(object makePermanent, object refresh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(makePermanent, refresh);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863058.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863058.aspx
		/// </summary>
		/// <param name="makePermanent">optional object MakePermanent</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void Update(object makePermanent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(makePermanent);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// 
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public void UpdateFreeBusy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdateFreeBusy", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869769.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi._ContactItem GetContact()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetContact", paramsArray);
			NetOffice.OutlookApi._ContactItem newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._ContactItem;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868347.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.ExchangeUser GetExchangeUser()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeUser", paramsArray);
			NetOffice.OutlookApi.ExchangeUser newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.ExchangeUser.LateBindingApiWrapperType) as NetOffice.OutlookApi.ExchangeUser;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869506.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.ExchangeDistributionList GetExchangeDistributionList()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeDistributionList", paramsArray);
			NetOffice.OutlookApi.ExchangeDistributionList newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.ExchangeDistributionList.LateBindingApiWrapperType) as NetOffice.OutlookApi.ExchangeDistributionList;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869428.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.AddressEntries GetMemberOfList()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetMemberOfList", paramsArray);
			NetOffice.OutlookApi.AddressEntries newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntries.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntries;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869746.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.AddressEntries GetExchangeDistributionListMembers()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeDistributionListMembers", paramsArray);
			NetOffice.OutlookApi.AddressEntries newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntries.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntries;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869842.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 12,14,15)]
		public NetOffice.OutlookApi.AddressEntries GetOwners()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetOwners", paramsArray);
			NetOffice.OutlookApi.AddressEntries newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntries.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntries;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}
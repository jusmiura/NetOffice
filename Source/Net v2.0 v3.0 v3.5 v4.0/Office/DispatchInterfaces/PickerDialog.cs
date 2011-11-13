//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface PickerDialog SupportByLibraryAttribute Office, 14
	///</summary>
	[SupportByLibraryAttribute("Office", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PickerDialog : _IMsoDispObj
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
                    _type = typeof(PickerDialog);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerDialog(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerDialog(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerDialog(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerDialog() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PickerDialog(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
		public string DataHandlerId
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataHandlerId", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataHandlerId", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
		public string Title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Title", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Title", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
		public NetOffice.OfficeApi.PickerProperties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.OfficeApi.PickerProperties newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.PickerProperties.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerProperties;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
		public NetOffice.OfficeApi.PickerResults CreatePickerResults()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreatePickerResults", paramsArray);
			NetOffice.OfficeApi.PickerResults newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PickerResults.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerResults;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		/// <param name="IsMultiSelect">bool IsMultiSelect</param>
		/// <param name="ExistingResults">NetOffice.OfficeApi.PickerResults ExistingResults</param>
		[SupportByLibraryAttribute("Office", 14)]
		public NetOffice.OfficeApi.PickerResults Show(bool isMultiSelect, NetOffice.OfficeApi.PickerResults existingResults)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(isMultiSelect, existingResults);
			object returnItem = Invoker.MethodReturn(this, "Show", paramsArray);
			NetOffice.OfficeApi.PickerResults newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PickerResults.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerResults;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		/// <param name="TokenText">string TokenText</param>
		/// <param name="duplicateDlgMode">Int32 duplicateDlgMode</param>
		[SupportByLibraryAttribute("Office", 14)]
		public NetOffice.OfficeApi.PickerResults Resolve(string tokenText, Int32 duplicateDlgMode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tokenText, duplicateDlgMode);
			object returnItem = Invoker.MethodReturn(this, "Resolve", paramsArray);
			NetOffice.OfficeApi.PickerResults newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PickerResults.LateBindingApiWrapperType) as NetOffice.OfficeApi.PickerResults;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}
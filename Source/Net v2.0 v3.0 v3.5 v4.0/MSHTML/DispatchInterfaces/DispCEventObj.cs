//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// DispatchInterface DispCEventObj SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DispCEventObj : COMObject
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
                    _type = typeof(DispCEventObj);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispCEventObj(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispCEventObj(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispCEventObj(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispCEventObj() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispCEventObj(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object returnValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "returnValue", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "returnValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool cancelBubble
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "cancelBubble", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "cancelBubble", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 keyCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "keyCode", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "keyCode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string propertyName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "propertyName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "propertyName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLBookmarkCollection bookmarks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "bookmarks", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLBookmarkCollection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSHTMLApi.IHTMLBookmarkCollection.LateBindingApiWrapperType) as LateBindingApi.MSHTMLApi.IHTMLBookmarkCollection;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "bookmarks", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject recordset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "recordset", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "recordset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string dataFld
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "dataFld", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "dataFld", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLElementCollection boundElements
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "boundElements", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLElementCollection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLElementCollection;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "boundElements", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool repeat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "repeat", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "repeat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string srcUrn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "srcUrn", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "srcUrn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLElement srcElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "srcElement", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLElement;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "srcElement", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool altKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "altKey", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "altKey", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool ctrlKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ctrlKey", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ctrlKey", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool shiftKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "shiftKey", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "shiftKey", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLElement fromElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "fromElement", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLElement;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "fromElement", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLElement toElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "toElement", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLElement;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "toElement", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 button
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "button", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "button", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "type", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string qualifier
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "qualifier", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "qualifier", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 reason
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "reason", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "reason", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 x
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "x", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "x", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 y
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "y", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "y", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 clientX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "clientX", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "clientX", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 clientY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "clientY", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "clientY", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 offsetX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offsetX", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "offsetX", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 offsetY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offsetY", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "offsetY", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 screenX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "screenX", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "screenX", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 screenY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "screenY", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "screenY", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject srcFilter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "srcFilter", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "srcFilter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDataTransfer dataTransfer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "dataTransfer", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDataTransfer newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSHTMLApi.IHTMLDataTransfer.LateBindingApiWrapperType) as LateBindingApi.MSHTMLApi.IHTMLDataTransfer;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool contentOverflow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "contentOverflow", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool shiftLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "shiftLeft", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "shiftLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool altLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "altLeft", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "altLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool ctrlLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ctrlLeft", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ctrlLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 imeCompositionChange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "imeCompositionChange", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 imeNotifyCommand
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "imeNotifyCommand", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 imeNotifyData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "imeNotifyData", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 imeRequest
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "imeRequest", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 imeRequestData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "imeRequestData", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 keyboardLayout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "keyboardLayout", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 behaviorCookie
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "behaviorCookie", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 behaviorPart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "behaviorPart", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string nextPage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "nextPage", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 wheelDelta
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "wheelDelta", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string url
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "url", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "url", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string data
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "data", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "data", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject source
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "source", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string origin
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "origin", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "origin", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool issession
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "issession", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "issession", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject constructor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "constructor", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string actionURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "actionURL", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 buttonID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "buttonID", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="strAttributeName">string strAttributeName</param>
		/// <param name="AttributeValue">object AttributeValue</param>
		/// <param name="lFlags">Int32 lFlags</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setAttribute(string strAttributeName, object attributeValue, Int32 lFlags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(strAttributeName, attributeValue, lFlags);
			Invoker.Method(this, "setAttribute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="strAttributeName">string strAttributeName</param>
		/// <param name="lFlags">Int32 lFlags</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object getAttribute(string strAttributeName, Int32 lFlags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(strAttributeName, lFlags);
			object returnItem = Invoker.MethodReturn(this, "getAttribute", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="strAttributeName">string strAttributeName</param>
		/// <param name="lFlags">Int32 lFlags</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool removeAttribute(string strAttributeName, Int32 lFlags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(strAttributeName, lFlags);
			object returnItem = Invoker.MethodReturn(this, "removeAttribute", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}
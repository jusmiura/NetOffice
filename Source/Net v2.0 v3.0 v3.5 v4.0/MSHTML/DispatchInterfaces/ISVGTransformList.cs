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
	/// DispatchInterface ISVGTransformList SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ISVGTransformList : COMObject
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
                    _type = typeof(ISVGTransformList);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGTransformList(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGTransformList(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGTransformList(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGTransformList() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGTransformList(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 numberOfItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "numberOfItems", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "numberOfItems", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newItem">LateBindingApi.MSHTMLApi.ISVGTransform newItem</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGTransform initialize(LateBindingApi.MSHTMLApi.ISVGTransform newItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newItem);
			object returnItem = Invoker.MethodReturn(this, "initialize", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGTransform newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGTransform;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGTransform getItem(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "getItem", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGTransform newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGTransform;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newItem">LateBindingApi.MSHTMLApi.ISVGTransform newItem</param>
		/// <param name="index">Int32 index</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGTransform insertItemBefore(LateBindingApi.MSHTMLApi.ISVGTransform newItem, Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newItem, index);
			object returnItem = Invoker.MethodReturn(this, "insertItemBefore", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGTransform newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGTransform;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newItem">LateBindingApi.MSHTMLApi.ISVGTransform newItem</param>
		/// <param name="index">Int32 index</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGTransform replaceItem(LateBindingApi.MSHTMLApi.ISVGTransform newItem, Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newItem, index);
			object returnItem = Invoker.MethodReturn(this, "replaceItem", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGTransform newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGTransform;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGTransform removeItem(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "removeItem", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGTransform newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGTransform;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newItem">LateBindingApi.MSHTMLApi.ISVGTransform newItem</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGTransform appendItem(LateBindingApi.MSHTMLApi.ISVGTransform newItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newItem);
			object returnItem = Invoker.MethodReturn(this, "appendItem", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGTransform newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGTransform;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newItem">LateBindingApi.MSHTMLApi.ISVGMatrix newItem</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGTransform createSVGTransformFromMatrix(LateBindingApi.MSHTMLApi.ISVGMatrix newItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newItem);
			object returnItem = Invoker.MethodReturn(this, "createSVGTransformFromMatrix", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGTransform newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGTransform;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGTransform consolidate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "consolidate", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGTransform newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGTransform;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}
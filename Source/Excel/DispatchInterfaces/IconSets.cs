using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface IconSets 
	/// SupportByVersion Excel, 12,14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195046.aspx
	///</summary>
	[SupportByVersionAttribute("Excel", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IconSets : COMObject ,IEnumerable<object>
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
                    _type = typeof(IconSets);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IconSets(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IconSets(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IconSets(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IconSets(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IconSets(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IconSets() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IconSets(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839576.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840270.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.ExcelApi.Enums.XlCreator)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837976.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
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
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff196334.aspx
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public object this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion

       #region IEnumerable<object> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
       public IEnumerator<object> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (object item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 12,14,15
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}
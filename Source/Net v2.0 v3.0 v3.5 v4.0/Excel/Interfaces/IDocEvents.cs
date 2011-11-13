//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IDocEvents SupportByLibraryAttribute Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IDocEvents : COMObject
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
                    _type = typeof(IDocEvents);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocEvents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocEvents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocEvents(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocEvents() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDocEvents(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 SelectionChange(NetOffice.ExcelApi.Range target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "SelectionChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 BeforeDoubleClick(NetOffice.ExcelApi.Range target, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target, cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforeDoubleClick", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 BeforeRightClick(NetOffice.ExcelApi.Range target, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target, cancel);
			object returnItem = Invoker.MethodReturn(this, "BeforeRightClick", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 Activate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Activate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 Deactivate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Deactivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 Calculate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Calculate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 Change(NetOffice.ExcelApi.Range target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "Change", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.Hyperlink Target</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 FollowHyperlink(NetOffice.ExcelApi.Hyperlink target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "FollowHyperlink", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public Int32 PivotTableUpdate(NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "PivotTableUpdate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="TargetRange">NetOffice.ExcelApi.Range TargetRange</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 PivotTableAfterValueChange(NetOffice.ExcelApi.PivotTable targetPivotTable, NetOffice.ExcelApi.Range targetRange)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetPivotTable, targetRange);
			object returnItem = Invoker.MethodReturn(this, "PivotTableAfterValueChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 PivotTableBeforeAllocateChanges(NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetPivotTable, valueChangeStart, valueChangeEnd, cancel);
			object returnItem = Invoker.MethodReturn(this, "PivotTableBeforeAllocateChanges", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 PivotTableBeforeCommitChanges(NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetPivotTable, valueChangeStart, valueChangeEnd, cancel);
			object returnItem = Invoker.MethodReturn(this, "PivotTableBeforeCommitChanges", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 PivotTableBeforeDiscardChanges(NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetPivotTable, valueChangeStart, valueChangeEnd);
			object returnItem = Invoker.MethodReturn(this, "PivotTableBeforeDiscardChanges", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 PivotTableChangeSync(NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target);
			object returnItem = Invoker.MethodReturn(this, "PivotTableChangeSync", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}
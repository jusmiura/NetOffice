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
	/// DispatchInterface Shape SupportByLibraryAttribute Office, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Shape : _IMsoDispObj
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
                    _type = typeof(Shape);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shape(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Adjustments Adjustments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Adjustments", paramsArray);
				NetOffice.OfficeApi.Adjustments newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.Adjustments.LateBindingApiWrapperType) as NetOffice.OfficeApi.Adjustments;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoAutoShapeType AutoShapeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoShapeType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoAutoShapeType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoShapeType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoBlackWhiteMode BlackWhiteMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BlackWhiteMode", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoBlackWhiteMode)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BlackWhiteMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CalloutFormat Callout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Callout", paramsArray);
				NetOffice.OfficeApi.CalloutFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CalloutFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.CalloutFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public Int32 ConnectionSiteCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConnectionSiteCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Connector
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connector", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.ConnectorFormat ConnectorFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConnectorFormat", paramsArray);
				NetOffice.OfficeApi.ConnectorFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ConnectorFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.ConnectorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.FillFormat Fill
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fill", paramsArray);
				NetOffice.OfficeApi.FillFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.FillFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.FillFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.GroupShapes GroupItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GroupItems", paramsArray);
				NetOffice.OfficeApi.GroupShapes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.GroupShapes.LateBindingApiWrapperType) as NetOffice.OfficeApi.GroupShapes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public Single Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState HorizontalFlip
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HorizontalFlip", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public Single Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.LineFormat Line
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Line", paramsArray);
				NetOffice.OfficeApi.LineFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.LineFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.LineFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState LockAspectRatio
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockAspectRatio", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockAspectRatio", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
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
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.ShapeNodes Nodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Nodes", paramsArray);
				NetOffice.OfficeApi.ShapeNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ShapeNodes.LateBindingApiWrapperType) as NetOffice.OfficeApi.ShapeNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public Single Rotation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Rotation", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Rotation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.PictureFormat PictureFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PictureFormat", paramsArray);
				NetOffice.OfficeApi.PictureFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.PictureFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.PictureFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.ShadowFormat Shadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shadow", paramsArray);
				NetOffice.OfficeApi.ShadowFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ShadowFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.ShadowFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.TextEffectFormat TextEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextEffect", paramsArray);
				NetOffice.OfficeApi.TextEffectFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextEffectFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextEffectFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.TextFrame TextFrame
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextFrame", paramsArray);
				NetOffice.OfficeApi.TextFrame newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextFrame.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextFrame;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.ThreeDFormat ThreeD
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ThreeD", paramsArray);
				NetOffice.OfficeApi.ThreeDFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ThreeDFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.ThreeDFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public Single Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoShapeType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoShapeType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState VerticalFlip
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VerticalFlip", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public object Vertices
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Vertices", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public Single Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public Int32 ZOrderPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ZOrderPosition", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Script Script
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Script", paramsArray);
				NetOffice.OfficeApi.Script newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.Script.LateBindingApiWrapperType) as NetOffice.OfficeApi.Script;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public string AlternativeText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlternativeText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlternativeText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasDiagram
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasDiagram", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.IMsoDiagram Diagram
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Diagram", paramsArray);
				NetOffice.OfficeApi.IMsoDiagram newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.IMsoDiagram.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoDiagram;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasDiagramNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasDiagramNode", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.DiagramNode DiagramNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DiagramNode", paramsArray);
				NetOffice.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.DiagramNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Child
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Child", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape ParentGroup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentGroup", paramsArray);
				NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.CanvasShapes CanvasItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CanvasItems", paramsArray);
				NetOffice.OfficeApi.CanvasShapes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CanvasShapes.LateBindingApiWrapperType) as NetOffice.OfficeApi.CanvasShapes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public Int32 Id
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Id", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public string RTF
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RTF", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RTF", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.TextFrame2 TextFrame2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextFrame2", paramsArray);
				NetOffice.OfficeApi.TextFrame2 newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextFrame2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextFrame2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasChart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasChart", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoChart Chart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Chart", paramsArray);
				NetOffice.OfficeApi.IMsoChart newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.IMsoChart.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoChart;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoShapeStyleIndex ShapeStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShapeStyle", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoShapeStyleIndex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShapeStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoBackgroundStyleIndex BackgroundStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackgroundStyle", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoBackgroundStyleIndex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackgroundStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.SoftEdgeFormat SoftEdge
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SoftEdge", paramsArray);
				NetOffice.OfficeApi.SoftEdgeFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SoftEdgeFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.SoftEdgeFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.GlowFormat Glow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Glow", paramsArray);
				NetOffice.OfficeApi.GlowFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.GlowFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.GlowFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.ReflectionFormat Reflection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Reflection", paramsArray);
				NetOffice.OfficeApi.ReflectionFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.ReflectionFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.ReflectionFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasSmartArt
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasSmartArt", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
		public NetOffice.OfficeApi.SmartArt SmartArt
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartArt", paramsArray);
				NetOffice.OfficeApi.SmartArt newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SmartArt.LateBindingApiWrapperType) as NetOffice.OfficeApi.SmartArt;
				return newObject;
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void Apply()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Apply", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Shape Duplicate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Duplicate", paramsArray);
			NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.Shape.LateBindingApiWrapperType) as NetOffice.OfficeApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="FlipCmd">NetOffice.OfficeApi.Enums.MsoFlipCmd FlipCmd</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void Flip(NetOffice.OfficeApi.Enums.MsoFlipCmd flipCmd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(flipCmd);
			Invoker.Method(this, "Flip", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void IncrementLeft(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementLeft", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void IncrementRotation(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotation", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void IncrementTop(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementTop", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void PickUp()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PickUp", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void RerouteConnections()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RerouteConnections", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Factor">Single Factor</param>
		/// <param name="RelativeToOriginalSize">NetOffice.OfficeApi.Enums.MsoTriState RelativeToOriginalSize</param>
		/// <param name="fScale">NetOffice.OfficeApi.Enums.MsoScaleFrom fScale</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void ScaleHeight(Single factor, NetOffice.OfficeApi.Enums.MsoTriState relativeToOriginalSize, NetOffice.OfficeApi.Enums.MsoScaleFrom fScale)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(factor, relativeToOriginalSize, fScale);
			Invoker.Method(this, "ScaleHeight", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Factor">Single Factor</param>
		/// <param name="RelativeToOriginalSize">NetOffice.OfficeApi.Enums.MsoTriState RelativeToOriginalSize</param>
		/// <param name="fScale">NetOffice.OfficeApi.Enums.MsoScaleFrom fScale</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void ScaleWidth(Single factor, NetOffice.OfficeApi.Enums.MsoTriState relativeToOriginalSize, NetOffice.OfficeApi.Enums.MsoScaleFrom fScale)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(factor, relativeToOriginalSize, fScale);
			Invoker.Method(this, "ScaleWidth", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Replace">optional object Replace</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void Select(object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(replace);
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void SetShapesDefaultProperties()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetShapesDefaultProperties", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.ShapeRange Ungroup()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Ungroup", paramsArray);
			NetOffice.OfficeApi.ShapeRange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.OfficeApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ZOrderCmd">NetOffice.OfficeApi.Enums.MsoZOrderCmd ZOrderCmd</param>
		[SupportByLibraryAttribute("Office", 9,10,11,12,14)]
		public void ZOrder(NetOffice.OfficeApi.Enums.MsoZOrderCmd zOrderCmd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(zOrderCmd);
			Invoker.Method(this, "ZOrder", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public void CanvasCropLeft(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "CanvasCropLeft", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public void CanvasCropTop(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "CanvasCropTop", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public void CanvasCropRight(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "CanvasCropRight", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibraryAttribute("Office", 10,11,12,14)]
		public void CanvasCropBottom(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "CanvasCropBottom", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 12,14)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		/// <param name="Layout">NetOffice.OfficeApi.SmartArtLayout Layout</param>
		[SupportByLibraryAttribute("Office", 14)]
		public void ConvertTextToSmartArt(NetOffice.OfficeApi.SmartArtLayout layout)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(layout);
			Invoker.Method(this, "ConvertTextToSmartArt", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}
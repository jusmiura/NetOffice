//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void OutlookBarShortcuts_ShortcutAddEventHandler(NetOffice.OutlookApi.OutlookBarShortcut NewShortcut);
	public delegate void OutlookBarShortcuts_BeforeShortcutAddEventHandler(ref bool Cancel);
	public delegate void OutlookBarShortcuts_BeforeShortcutRemoveEventHandler(NetOffice.OutlookApi.OutlookBarShortcut Shortcut, ref bool Cancel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass OutlookBarShortcuts SupportByLibraryAttribute Outlook, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class OutlookBarShortcuts : _OutlookBarShortcuts, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		OutlookBarShortcutsEvents_SinkHelper _outlookBarShortcutsEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(OutlookBarShortcuts);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public OutlookBarShortcuts(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OutlookBarShortcuts(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OutlookBarShortcuts(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of OutlookBarShortcuts 
        /// </summary>		
		public OutlookBarShortcuts():base("Outlook.OutlookBarShortcuts")
		{
		}
		
		/// <summary>
        /// creates a new instance of OutlookBarShortcuts
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public OutlookBarShortcuts(string progId):base(progId)
		{
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, OutlookBarShortcutsEvents_SinkHelper.Id);


			if(OutlookBarShortcutsEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_outlookBarShortcutsEvents_SinkHelper = new OutlookBarShortcutsEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event OutlookBarShortcuts_ShortcutAddEventHandler _ShortcutAddEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event OutlookBarShortcuts_ShortcutAddEventHandler ShortcutAddEvent
		{
			add
			{
				CreateEventBridge();
				_ShortcutAddEvent += value;
			}
			remove
			{
				_ShortcutAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event OutlookBarShortcuts_BeforeShortcutAddEventHandler _BeforeShortcutAddEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event OutlookBarShortcuts_BeforeShortcutAddEventHandler BeforeShortcutAddEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeShortcutAddEvent += value;
			}
			remove
			{
				_BeforeShortcutAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event OutlookBarShortcuts_BeforeShortcutRemoveEventHandler _BeforeShortcutRemoveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event OutlookBarShortcuts_BeforeShortcutRemoveEventHandler BeforeShortcutRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeShortcutRemoveEvent += value;
			}
			remove
			{
				_BeforeShortcutRemoveEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _outlookBarShortcutsEvents_SinkHelper)
			{
				_outlookBarShortcutsEvents_SinkHelper.Dispose();
				_outlookBarShortcutsEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}
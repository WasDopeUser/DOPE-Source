using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Ace.Networking;
using Ace.Networking.Entanglement;
using Ace.Networking.Entanglement.Extensions;
using Ace.Networking.Entanglement.Packets;
using Ace.Networking.Entanglement.Services;
using Ace.Networking.Handlers;
using Ace.Networking.Services;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Licensing;
using DOPE.Common;
using Dope.Common;
using DOPE.Common.Models;
using DOPE.Common.Packets;
using NLog;

namespace DOPE.Core
{
	public class Controller : INotifyPropertyChanged, IDopeServiceProxy
	{
		public Controller(string string_2, string string_3)
		{
			Class13.lOBHd9Nzn7x2T();
			this.dateTimeOffset_1 = DateTimeOffset.MinValue;
			this.dateTimeOffset_2 = DateTimeOffset.MinValue;
			this.object_0 = new object();
			this.PropertyChanged = new PropertyChangedEventHandler(Controller.<>c.<>c_0.method_0);
			base..ctor();
			this.entanglementHostService_0 = new EntanglementHostService();
			this.entanglementHostService_0.Register<GInterface8, GClass923>(EntanglementAccess.Global).Register<IBotController, GClass922>(EntanglementAccess.Manual);
			this.Control = (GClass923)this.entanglementHostService_0.GetHostedObject(this.entanglementHostService_0.GetInstance(typeof(GInterface8).GUID, null).Value);
			this.Control.Parent = this;
			this.Control.Type = string_2;
			this.Control.Version = string_3;
			this.timer_0 = new Timer(new TimerCallback(this.method_4), null, 100, -1);
		}

		public IConnection Connection
		{
			[CompilerGenerated]
			get
			{
				return this.iconnection_0;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.iconnection_0, value))
				{
					return;
				}
				this.iconnection_0 = value;
				this.method_18(Class10.Connection);
			}
		}

		public IDopeService Service
		{
			[CompilerGenerated]
			get
			{
				return this.idopeService_0;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.idopeService_0, value))
				{
					return;
				}
				this.idopeService_0 = value;
				this.method_18(Class10.propertyChangedEventArgs_16);
				this.method_18(Class10.propertyChangedEventArgs_53);
			}
		}

		public DopeServiceStatus ServiceStatus
		{
			[CompilerGenerated]
			get
			{
				return this.dopeServiceStatus_0;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.dopeServiceStatus_0, value))
				{
					return;
				}
				this.dopeServiceStatus_0 = value;
				this.method_18(Class10.ServiceStatus);
			}
		}

		public GEnum12 Status
		{
			[CompilerGenerated]
			get
			{
				return this.genum12_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.genum12_0 == value)
				{
					return;
				}
				this.genum12_0 = value;
				this.method_1();
				this.method_18(Class10.Status);
			}
		}

		public string Email
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_0, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_0 = value;
				this.method_18(Class10.Email);
			}
		}

		public GClass923 Control
		{
			[CompilerGenerated]
			get
			{
				return this.gclass923_0;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.gclass923_0, value))
				{
					return;
				}
				this.gclass923_0 = value;
				this.method_18(Class10.propertyChangedEventArgs_11);
			}
		}

		ICoreDopeService IDopeServiceProxy.Service
		{
			get
			{
				return this.Service;
			}
		}

		public string Key
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_1, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_1 = value;
				this.method_18(Class10.propertyChangedEventArgs_30);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void method_1()
		{
			if (this.Status == GEnum12.Disconnected)
			{
				this.dateTimeOffset_0 = DateTimeOffset.Now;
			}
		}

		[CompilerGenerated]
		public void method_2(EventHandler<S2C_ConnectionClosed> eventHandler_1)
		{
			EventHandler<S2C_ConnectionClosed> eventHandler = this.eventHandler_0;
			EventHandler<S2C_ConnectionClosed> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<S2C_ConnectionClosed> value = (EventHandler<S2C_ConnectionClosed>)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler<S2C_ConnectionClosed>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		[CompilerGenerated]
		public void method_3(EventHandler<S2C_ConnectionClosed> eventHandler_1)
		{
			EventHandler<S2C_ConnectionClosed> eventHandler = this.eventHandler_0;
			EventHandler<S2C_ConnectionClosed> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<S2C_ConnectionClosed> value = (EventHandler<S2C_ConnectionClosed>)Delegate.Remove(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler<S2C_ConnectionClosed>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		private void method_4(object object_1)
		{
			Controller.<Monitor>d__46 <Monitor>d__;
			<Monitor>d__.<>4__this = this;
			<Monitor>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Monitor>d__.<>1__state = -1;
			<Monitor>d__.<>t__builder.Start<Controller.<Monitor>d__46>(ref <Monitor>d__);
		}

		private Task method_5()
		{
			Controller.<MonitorBot>d__47 <MonitorBot>d__;
			<MonitorBot>d__.<>4__this = this;
			<MonitorBot>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<MonitorBot>d__.<>1__state = -1;
			<MonitorBot>d__.<>t__builder.Start<Controller.<MonitorBot>d__47>(ref <MonitorBot>d__);
			return <MonitorBot>d__.<>t__builder.Task;
		}

		public void Stop()
		{
			Controller.logger_0.Info("Stopping...");
			this.timer_0.Change(-1, -1);
			foreach (GClass922 gclass in this.Control.Bots)
			{
				this.Control.ForceStopBot(gclass.BotId).GetAwaiter().GetResult();
			}
			IConnection connection = this.Connection;
			if (connection != null && connection.Connected)
			{
				this.Connection.Close();
			}
		}

		public void method_6(string string_2)
		{
			if (this.Key != string_2)
			{
				this.Key = string_2;
				this.Control.Invalidate().ContinueWith(new Action<Task>(this.method_13));
			}
		}

		public bool method_7(string string_2)
		{
			if (this.bool_0)
			{
				return false;
			}
			string text;
			if (string_2 == null)
			{
				text = null;
			}
			else
			{
				string text2 = string_2.Trim();
				text = ((text2 != null) ? text2.ToLower() : null);
			}
			string_2 = text;
			if (!string.IsNullOrWhiteSpace(string_2))
			{
				if (string_2.Length == 36)
				{
					object obj = this.object_0;
					lock (obj)
					{
						IConnection connection = this.Connection;
						if (connection != null)
						{
							connection.Close();
						}
						Controller.logger_0.Info("Connecting to DOPE service...");
						this.bool_0 = true;
						this.dateTimeOffset_2 = DateTimeOffset.Now;
						this.Status = GEnum12.Connecting;
						this.Email = null;
						this.Key = string_2;
						try
						{
							TcpClient client = new TcpClient(Constants.Endpoint, 42169);
							this.Connection = new ConnectionBuilder(DopeProtocol.Instance).UseServices(new Func<IServicesBuilder<IConnection>, IServicesBuilder<IConnection>>(this.method_14)).Build(client);
							this.Connection.ClientDisconnected += this.method_11;
							this.Connection.On<SC_Ping>(new GenericPayloadHandler<SC_Ping>(this.method_9));
							this.Connection.On<S2C_ConnectionClosed>(new GenericPayloadHandler<S2C_ConnectionClosed>(this.method_15));
							this.Connection.On<S2C_AccountInfo>(new GenericPayloadHandler<S2C_AccountInfo>(this.method_16));
							this.Connection.Initialize();
							this.Connection.Send<C2S_AuthorizationKey>(new C2S_AuthorizationKey
							{
								Key = string_2
							});
							return true;
						}
						catch (Exception ex)
						{
							this.dateTimeOffset_0 = DateTimeOffset.Now;
							this.Status = GEnum12.Disconnected;
							EventHandler<S2C_ConnectionClosed> eventHandler = this.eventHandler_0;
							if (eventHandler != null)
							{
								eventHandler(this, new S2C_ConnectionClosed
								{
									Reason = ConnectionClosedReason.ServiceUnreachable
								});
							}
							Controller.logger_0.Error(ex, "Error establishing connection ({exception})", new object[]
							{
								ex.Message
							});
						}
						finally
						{
							this.bool_0 = false;
						}
					}
					return false;
				}
			}
			return false;
		}

		private void method_8(IConnection iconnection_1, object object_1, Type type_0)
		{
			Controller.logger_0.Info("Sent payload of type {type}", type_0.FullName);
			ExecuteMethod executeMethod = object_1 as ExecuteMethod;
			if (executeMethod != null)
			{
				Controller.logger_0.Info("method: {method}", executeMethod.Method);
				return;
			}
			EntangleResult entangleResult = object_1 as EntangleResult;
			if (entangleResult != null)
			{
				Controller.logger_0.Info<Guid?>("Entangled type: {type}", entangleResult.Eid);
			}
		}

		private object method_9(IConnection iconnection_1, SC_Ping sc_Ping_0)
		{
			return SC_Ping.Instance;
		}

		private void method_10(IConnection iconnection_1, object object_1, Type type_0)
		{
			Controller.logger_0.Info("Received payload of type {type}", type_0.FullName);
			ExecuteMethod executeMethod = object_1 as ExecuteMethod;
			if (executeMethod != null)
			{
				Controller.logger_0.Info("method: {method}", executeMethod.Method);
				return;
			}
			EntangleResult entangleResult = object_1 as EntangleResult;
			if (entangleResult != null)
			{
				Controller.logger_0.Info<Guid?>("Entangled type: {type}", entangleResult.Eid);
			}
		}

		private void method_11(IConnection iconnection_1, Exception exception_0)
		{
			if (iconnection_1 != this.Connection)
			{
				return;
			}
			this.Service = null;
			this.Status = GEnum12.Disconnected;
			this.dateTimeOffset_0 = DateTimeOffset.Now;
			Controller.logger_0.Warn("Disconnected from DOPE service -- {exception}", (exception_0 != null) ? exception_0.ToString() : null);
		}

		public Task<DollConfig> method_12(string string_2, byte[] byte_0, string string_3, int int_0)
		{
			IConnection connection = this.Connection;
			if (connection != null && connection.Connected)
			{
				return this.Connection.SendRequest<C2S_DollRequest, DollConfig>(new C2S_DollRequest
				{
					Checksum = string_2,
					Data = byte_0,
					UserId = string_3,
					ServerId = int_0
				}, null);
			}
			return Task.FromResult<DollConfig>(null);
		}

		// Note: this type is marked as 'beforefieldinit'.
		static Controller()
		{
			Class13.lOBHd9Nzn7x2T();
			Controller.logger_0 = LogManager.GetLogger("Core-Controller");
		}

		[CompilerGenerated]
		private void method_13(Task task_0)
		{
			this.method_7(this.Key);
		}

		[CompilerGenerated]
		private IServicesBuilder<IConnection> method_14(IServicesBuilder<IConnection> iservicesBuilder_0)
		{
			return iservicesBuilder_0.AddInstance<IEntanglementHostService, EntanglementHostService>(this.entanglementHostService_0, null).AddEntanglementClient(null);
		}

		[CompilerGenerated]
		private object method_15(IConnection iconnection_1, S2C_ConnectionClosed s2C_ConnectionClosed_0)
		{
			Controller.logger_0.Error<ConnectionClosedReason>("Connection closed: {reason}", s2C_ConnectionClosed_0.Reason);
			EventHandler<S2C_ConnectionClosed> eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, s2C_ConnectionClosed_0);
			}
			return null;
		}

		[CompilerGenerated]
		private object method_16(IConnection iconnection_1, S2C_AccountInfo s2C_AccountInfo_0)
		{
			Controller.logger_0.Info("Connected to DOPE as {email}", this.Email = s2C_AccountInfo_0.Email);
			Task.Run(new Func<Task>(this.method_17));
			return null;
		}

		[CompilerGenerated]
		private Task method_17()
		{
			Controller.<<Init>b__50_3>d <<Init>b__50_3>d;
			<<Init>b__50_3>d.<>4__this = this;
			<<Init>b__50_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<Init>b__50_3>d.<>1__state = -1;
			<<Init>b__50_3>d.<>t__builder.Start<Controller.<<Init>b__50_3>d>(ref <<Init>b__50_3>d);
			return <<Init>b__50_3>d.<>t__builder.Task;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		protected void method_18(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}

		private static readonly Logger logger_0;

		private readonly EntanglementHostService entanglementHostService_0;

		private readonly Timer timer_0;

		private volatile bool bool_0;

		private DateTimeOffset dateTimeOffset_0;

		public DateTimeOffset dateTimeOffset_1;

		private DateTimeOffset dateTimeOffset_2;

		public object object_0;

		[CompilerGenerated]
		private IConnection iconnection_0;

		[CompilerGenerated]
		private IDopeService idopeService_0;

		[CompilerGenerated]
		private DopeServiceStatus dopeServiceStatus_0;

		[CompilerGenerated]
		private GEnum12 genum12_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private GClass923 gclass923_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private EventHandler<S2C_ConnectionClosed> eventHandler_0;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Licensing;

namespace DarkorbitAPI
{
	public class ConnectionManager : INotifyPropertyChanged, GInterface5
	{
		public GInterface5 ProxySocket
		{
			[CompilerGenerated]
			get
			{
				return this.<ProxySocket>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ProxySocket>k__BackingField, value))
				{
					return;
				}
				this.<ProxySocket>k__BackingField = value;
				this.method_19(Class5.propertyChangedEventArgs_75);
			}
		}

		public byte[] InjectedEncoder
		{
			[CompilerGenerated]
			get
			{
				return this.<InjectedEncoder>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<InjectedEncoder>k__BackingField, value))
				{
					return;
				}
				this.<InjectedEncoder>k__BackingField = value;
				this.method_19(Class5.propertyChangedEventArgs_30);
			}
		}

		public byte[] SecretKey
		{
			[CompilerGenerated]
			get
			{
				return this.<SecretKey>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SecretKey>k__BackingField, value))
				{
					return;
				}
				this.<SecretKey>k__BackingField = value;
				this.method_19(Class5.propertyChangedEventArgs_89);
			}
		}

		public uint InjectedLen
		{
			[CompilerGenerated]
			get
			{
				return this.<InjectedLen>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<InjectedLen>k__BackingField == value)
				{
					return;
				}
				this.<InjectedLen>k__BackingField = value;
				this.method_19(Class5.propertyChangedEventArgs_31);
			}
		}

		public string Host
		{
			[CompilerGenerated]
			get
			{
				return this.<Host>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<Host>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Host>k__BackingField = value;
				this.method_19(Class5.propertyChangedEventArgs_28);
			}
		}

		public int Port { get; }

		public GClass93 Socket
		{
			[CompilerGenerated]
			get
			{
				return this.<Socket>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Socket>k__BackingField, value))
				{
					return;
				}
				this.<Socket>k__BackingField = value;
				this.method_19(Class5.propertyChangedEventArgs_98);
			}
		}

		public Queue<GInterface0> CommandQueue { get; }

		public bool IsAuthenticated
		{
			[CompilerGenerated]
			get
			{
				return this.<IsAuthenticated>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				if (this.<IsAuthenticated>k__BackingField == value)
				{
					return;
				}
				this.<IsAuthenticated>k__BackingField = value;
				this.method_19(Class5.propertyChangedEventArgs_35);
			}
		}

		public int PingMs
		{
			get
			{
				if (!this.PingMeasurements.Any<int>())
				{
					return 0;
				}
				return (int)this.PingMeasurements.Average();
			}
		}

		private void method_0(object object_0)
		{
			GClass93 socket = this.Socket;
			if (socket != null && socket.method_2() && (this._keepAlive || !this.IsAuthenticated))
			{
				try
				{
					if ((!this.IsAuthenticated || this._sentPings > 0) && (DateTime.Now - this._lastKeepAlive).TotalSeconds > 10.0)
					{
						this.Socket.Disconnect(ErrorReason.Timeout, null, false);
					}
					else if (this.IsAuthenticated)
					{
						this.method_11();
					}
				}
				catch
				{
				}
			}
		}

		public GClass88 Server
		{
			[CompilerGenerated]
			get
			{
				return this.<Server>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Server>k__BackingField, value))
				{
					return;
				}
				this.<Server>k__BackingField = value;
				this.method_19(Class5.propertyChangedEventArgs_91);
			}
		}

		public GameManager Game
		{
			[CompilerGenerated]
			get
			{
				return this.<Game>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Game>k__BackingField, value))
				{
					return;
				}
				this.<Game>k__BackingField = value;
				this.method_19(Class5.Game);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public event GClass82.GDelegate4 MessageSent;

		public event GClass82.GDelegate4 MessageReceived;

		public ConnectionManager(GameManager gameManager_0)
		{
			Class13.plZSWFPzBWWEZ();
			this.Port = 8080;
			this.CommandQueue = new Queue<GInterface0>();
			this._lastKeepAlive = DateTime.Now;
			this._lastSentPing = DateTime.Now;
			this.PingMeasurements = new MaxStack<int>(5);
			base..ctor();
			ConnectionManager.Instance.Value = this;
			this.Game = gameManager_0;
			this.Server = new GClass88(this);
			this._keepAliveTimer = new Timer(new TimerCallback(this.method_0), null, 0, 1000);
			this.method_3();
		}

		private bool tvhUcPeePn(int int_0)
		{
			if (int_0 <= 6199)
			{
				if (int_0 == 666 || int_0 == 6199)
				{
					return true;
				}
			}
			else
			{
				if (int_0 == 11263 || int_0 == 20379)
				{
					return true;
				}
				if (int_0 == 32298)
				{
					return true;
				}
			}
			return false;
		}

		public void method_1(params string[] cmd)
		{
			this.SendMessage(new GClass269(string.Join("|", cmd)));
		}

		public void SendMessage(GInterface0 ginterface0_0)
		{
			if (ginterface0_0 == null)
			{
				return;
			}
			Trace.WriteLine(string.Format("Sending command id={0} {1}", ginterface0_0.Id, ginterface0_0.GetType().Name));
			if (!this.IsAuthenticated)
			{
				if (this.tvhUcPeePn((int)ginterface0_0.Id))
				{
					GClass93 socket = this.Socket;
					if (socket == null)
					{
						return;
					}
					socket.method_14(ginterface0_0);
					return;
				}
				else
				{
					Queue<GInterface0> commandQueue = this.CommandQueue;
					if (commandQueue == null)
					{
						return;
					}
					commandQueue.Enqueue(ginterface0_0);
					return;
				}
			}
			else
			{
				GClass93 socket2 = this.Socket;
				if (socket2 == null)
				{
					return;
				}
				socket2.method_14(ginterface0_0);
				return;
			}
		}

		public void method_2()
		{
			if (this.IsAuthenticated)
			{
				while (this.CommandQueue.Count > 0)
				{
					this.SendMessage(this.CommandQueue.Dequeue());
				}
			}
		}

		private void method_3()
		{
			this.Socket = new GClass93(this);
			this.Socket.Connected += this.method_5;
			this.Socket.Disconnected += this.method_4;
		}

		private void method_4(GClass91 gclass91_0, ErrorReason errorReason_0, Exception exception_0)
		{
			this.PingMeasurements.Clear();
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs("PingMs"));
			}
			this.IsAuthenticated = false;
			this._sentPings = 0;
			this._keepAlive = false;
		}

		private void method_5(GClass91 gclass91_0)
		{
			this.PingMeasurements.Clear();
			this._lastKeepAlive = DateTime.Now;
			this._keepAlive = false;
			this._sentPings = 0;
			this.IsAuthenticated = false;
			this.method_6();
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs("PingMs"));
		}

		private void method_6()
		{
			this.IsAuthenticated = false;
			this.SendMessage(new GClass279(0, 147, 1));
		}

		internal void method_7(bool bool_0, int int_0, int int_1, int int_2)
		{
			GClass279 gclass = new GClass279(0, 147, 1);
			if (bool_0 && gclass.int_0 == int_0 && gclass.int_1 == int_1 && int_2 == gclass.int_2)
			{
				this.SendMessage(new GClass253());
				return;
			}
			this.Socket.Disconnect(ErrorReason.VersionMismatch, new Exception(string.Format("client version: {0}.{1}.{2}; remote {3}.{4}.{5}", new object[]
			{
				gclass.int_0,
				gclass.int_1,
				gclass.int_2,
				int_0,
				int_1,
				int_2
			})), false);
		}

		internal async void method_8(byte[] byte_0, uint uint_0)
		{
			this.InjectedEncoder = byte_0;
			this.InjectedLen = uint_0;
			string hash = "";
			using (MD5 md = MD5.Create())
			{
				hash = new string(md.ComputeHash(byte_0).SelectMany(new Func<byte, IEnumerable<char>>(ConnectionManager.<>c.CpiUoZssRI.method_0)).ToArray<char>());
			}
			try
			{
				ICoreDopeService service = this.Game.Dope.Service;
				TaskAwaiter<bool> taskAwaiter = ((service != null) ? service.IsDollKnown(hash) : null).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter<bool> taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<bool>);
				}
				if (taskAwaiter.GetResult())
				{
					byte_0 = null;
				}
			}
			catch
			{
			}
			try
			{
				ICoreDopeService service2 = this.Game.Dope.Service;
				object obj;
				if (service2 == null)
				{
					obj = null;
				}
				else
				{
					string checksum = hash;
					byte[] data = byte_0;
					string userId = this.Game.Settings.FlashSettings.userID.ToString();
					FlashSettings flashSettings = this.Game.Settings.FlashSettings;
					obj = service2.GetDoll(checksum, data, userId, (flashSettings != null) ? flashSettings.pid : 0);
				}
				DollConfig dollConfig = await obj;
				if (dollConfig != null && dollConfig.DollId != 0)
				{
					if (dollConfig.DollId == -1)
					{
						this.Socket.Disconnect(ErrorReason.NoLicense, null, false);
					}
					else
					{
						this.Socket.method_5().method_4().vmethod_3(dollConfig, new Action(this.method_9));
					}
				}
				else
				{
					this.Socket.Disconnect(ErrorReason.RemoteServiceFailure, null, false);
				}
			}
			catch (Exception ex)
			{
				this.Socket.Disconnect(ErrorReason.RemoteServiceFailure, ex, false);
			}
		}

		internal void method_9()
		{
			this.method_10();
		}

		private void method_10()
		{
			byte[] byte_ = this.Socket.method_5().method_4().vmethod_4();
			this.SendMessage(new GClass215(new ByteArray(byte_)));
		}

		internal void method_11()
		{
			Trace.WriteLine("Sending ping");
			if (!this._keepAlive)
			{
				this._lastKeepAlive = DateTime.Now;
			}
			this._lastSentPing = DateTime.Now;
			this._keepAlive = true;
			this._sentPings++;
			this.SendMessage(new GClass238());
		}

		internal void method_12(byte[] byte_0)
		{
			this.SecretKey = byte_0;
			this.Socket.method_5().method_4().vmethod_2(byte_0);
		}

		public void method_13()
		{
			this.Socket.Disconnect(ErrorReason.GracefullyDisconnected, null, false);
		}

		public GClass241 method_14()
		{
			FlashSettings flashSettings = this.Game.Settings.FlashSettings;
			GClass241 result = new GClass241(0, 0, "", "", 0)
			{
				int_2 = flashSettings.factionID,
				int_1 = flashSettings.pid,
				string_0 = flashSettings.sessionID.Trim(),
				int_0 = flashSettings.userID,
				string_1 = "8.3.2"
			};
			if (!this.method_18())
			{
				result = null;
			}
			return result;
		}

		internal void method_15()
		{
			GClass241 ginterface0_ = this.method_14();
			this.SendMessage(ginterface0_);
		}

		public void Connect(string host, ProxySettings proxy)
		{
			this._keepAlive = false;
			this._sentPings = 0;
			this._receivedPings = 0;
			this.Game.LogManager.Get("Base-Connection").Warn<string, string>("Connecting to {ip} via proxy {proxy}", host, (proxy != null) ? proxy.ToString() : null);
			this.Socket.Connect(host, this.Port, true, proxy);
		}

		public void Connect(int mapId, ProxySettings proxy)
		{
			this.Game.Settings.MapId = mapId;
			this.Connect(this.Game.Settings.MapHosts[mapId], proxy);
		}

		internal void method_16()
		{
			this._lastKeepAlive = DateTime.Now;
			int f4BpfAIAsn0WsSuxDaA = (int)(this._lastKeepAlive - this._lastSentPing).TotalMilliseconds;
			if (this._keepAlive)
			{
				this.PingMeasurements.method_0(f4BpfAIAsn0WsSuxDaA);
			}
			this._receivedPings++;
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs("PingMs"));
		}

		internal void method_17()
		{
		}

		public bool method_18()
		{
			bool result = true;
			FlashSettings flashSettings = this.Game.Settings.FlashSettings;
			DateTimeOffset licenseExpiration;
			GClass783.GEnum9 licenseState;
			if (!GClass783.smethod_0(flashSettings.pid, flashSettings.userID, this.Game.Dope.Key, out licenseExpiration, out licenseState, "basic"))
			{
				GClass93 socket = this.Socket;
				if (socket != null)
				{
					socket.Disconnect(ErrorReason.NoLicense, null, false);
				}
				result = false;
			}
			this.Game.LicenseExpiration = licenseExpiration;
			this.Game.LicenseState = licenseState;
			return result;
		}

		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionManager()
		{
			Class13.plZSWFPzBWWEZ();
			ConnectionManager.Instance = new ThreadLocal<ConnectionManager>();
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
		protected void method_19(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}

		private bool _keepAlive;

		private Timer _keepAliveTimer;

		private DateTime _lastKeepAlive;

		private DateTime _lastSentPing;

		private int _sentPings;

		private int _receivedPings;

		private MaxStack<int> PingMeasurements;

		public static ThreadLocal<ConnectionManager> Instance;
	}
}

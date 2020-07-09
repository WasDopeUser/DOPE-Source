using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using DarkorbitAPI.CommonStructures;

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
				this.method_20(Class5.propertyChangedEventArgs_83);
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
				this.method_20(Class5.propertyChangedEventArgs_34);
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
				this.method_20(Class5.propertyChangedEventArgs_97);
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
				this.method_20(Class5.propertyChangedEventArgs_35);
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
				this.method_20(Class5.propertyChangedEventArgs_31);
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
				this.method_20(Class5.propertyChangedEventArgs_106);
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
				this.method_20(Class5.propertyChangedEventArgs_39);
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
						this.method_12();
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
				this.method_20(Class5.propertyChangedEventArgs_99);
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
				this.method_20(Class5.Game);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public event GClass82.GDelegate4 MessageSent;

		public event GClass82.GDelegate4 MessageReceived;

		public ConnectionManager(GameManager gameManager_0)
		{
			Class13.lOBHd9Nzn7x2T();
			this.Port = 5001;
			this.CommandQueue = new Queue<GInterface0>();
			this._lastKeepAlive = DateTime.Now;
			this._lastSentPing = DateTime.Now;
			this.PingMeasurements = new MaxStack<int>(5);
			base..ctor();
			ConnectionManager.Instance.Value = this;
			this.Game = gameManager_0;
			this.Server = new GClass88(this);
			this._keepAliveTimer = new Timer(new TimerCallback(this.method_0), null, 0, 1000);
			this.method_4();
		}

		private bool method_1(int int_0)
		{
			if (int_0 != 2 && int_0 != 7)
			{
				if (int_0 != 666)
				{
					return false;
				}
			}
			return true;
		}

		public void method_2(params string[] cmd)
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
				if (this.method_1((int)ginterface0_0.Id))
				{
					GClass93 socket = this.Socket;
					if (socket == null)
					{
						return;
					}
					socket.method_15(ginterface0_0);
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
				socket2.method_15(ginterface0_0);
				return;
			}
		}

		public void method_3()
		{
			if (this.IsAuthenticated)
			{
				while (this.CommandQueue.Count > 0)
				{
					this.SendMessage(this.CommandQueue.Dequeue());
				}
			}
		}

		private void method_4()
		{
			this.Socket = new GClass93(this);
			this.Socket.Connected += this.method_6;
			this.Socket.Disconnected += this.method_5;
		}

		private void method_5(GClass91 gclass91_0, ErrorReason errorReason_0, Exception exception_0)
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

		private void method_6(GClass91 gclass91_0)
		{
			gclass91_0.method_3().GetStream().WriteByte(0);
			this.PingMeasurements.Clear();
			this._lastKeepAlive = DateTime.Now;
			this._keepAlive = false;
			this._sentPings = 0;
			this.IsAuthenticated = false;
			this.method_7();
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs("PingMs"));
		}

		private void method_7()
		{
			this.IsAuthenticated = false;
			this.SendMessage(new GClass279("99e62eb0ce99bc68ab3912dae14869ba"));
		}

		internal void method_8(bool bool_0, string string_0)
		{
			if (bool_0 && string_0 == "99e62eb0ce99bc68ab3912dae14869ba")
			{
				this.IsAuthenticated = true;
				this.method_16();
				return;
			}
			this.Socket.Disconnect(ErrorReason.VersionMismatch, new Exception("client version: 99e62eb0ce99bc68ab3912dae14869ba; remote " + string_0), false);
		}

		internal void method_9(byte[] byte_0, uint uint_0)
		{
			ConnectionManager.<InjectObfuscation>d__77 <InjectObfuscation>d__;
			<InjectObfuscation>d__.<>4__this = this;
			<InjectObfuscation>d__.code = byte_0;
			<InjectObfuscation>d__.size = uint_0;
			<InjectObfuscation>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<InjectObfuscation>d__.<>1__state = -1;
			<InjectObfuscation>d__.<>t__builder.Start<ConnectionManager.<InjectObfuscation>d__77>(ref <InjectObfuscation>d__);
		}

		internal void method_10()
		{
			this.method_11();
		}

		private void method_11()
		{
		}

		internal void method_12()
		{
			Trace.WriteLine("Sending ping");
			if (!this._keepAlive)
			{
				this._lastKeepAlive = DateTime.Now;
			}
			this._lastSentPing = DateTime.Now;
			this._keepAlive = true;
			this._sentPings++;
			this.SendMessage(new GClass236());
		}

		internal void method_13(byte[] byte_0)
		{
			this.SecretKey = byte_0;
			this.Socket.method_5().method_4().vmethod_2(byte_0);
		}

		public void method_14()
		{
			this.Socket.Disconnect(ErrorReason.GracefullyDisconnected, null, false);
		}

		public GClass239 method_15()
		{
			FlashSettings flashSettings = this.Game.Settings.FlashSettings;
			GClass239 result = new GClass239(0, 0, "", "", 0)
			{
				int_1 = flashSettings.factionID,
				int_2 = flashSettings.pid,
				string_0 = flashSettings.sessionID.Trim(),
				int_0 = flashSettings.userID,
				string_1 = "8.3.2"
			};
			if (!this.method_19())
			{
				result = null;
			}
			return result;
		}

		internal void method_16()
		{
			GClass239 ginterface0_ = this.method_15();
			this.SendMessage(ginterface0_);
			this.method_12();
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

		internal void method_17()
		{
			this._lastKeepAlive = DateTime.Now;
			int eaB5m4QLO3HqtTVTcfT = (int)(this._lastKeepAlive - this._lastSentPing).TotalMilliseconds;
			if (this._keepAlive)
			{
				this.PingMeasurements.method_0(eaB5m4QLO3HqtTVTcfT);
			}
			this._receivedPings++;
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs("PingMs"));
		}

		internal void method_18()
		{
		}

		public bool method_19()
		{
			bool result = true;
			FlashSettings flashSettings = this.Game.Settings.FlashSettings;
			DateTimeOffset licenseExpiration;
			GClass849.GEnum9 licenseState;
			if (!GClass849.smethod_0(flashSettings.pid, flashSettings.userID, this.Game.Dope.Key, out licenseExpiration, out licenseState, "basic"))
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
			Class13.lOBHd9Nzn7x2T();
			ConnectionManager.Instance = new ThreadLocal<ConnectionManager>();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		protected void method_20(PropertyChangedEventArgs propertyChangedEventArgs_0)
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

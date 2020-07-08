using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Licensing;
using DarkorbitAPI.NativeWrappers;
using DarkorbitAPI.Structures;
using NLog;

namespace DarkorbitAPI
{
	public class GameManager : INotifyPropertyChanged
	{
		public ConnectionManager Connection
		{
			[CompilerGenerated]
			get
			{
				return this.<Connection>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Connection>k__BackingField, value))
				{
					return;
				}
				this.<Connection>k__BackingField = value;
				this.method_10(Class5.Connection);
			}
		}

		public Hero Hero
		{
			[CompilerGenerated]
			get
			{
				return this.<Hero>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Hero>k__BackingField, value))
				{
					return;
				}
				this.<Hero>k__BackingField = value;
				this.method_10(Class5.Hero);
			}
		}

		public Map Map
		{
			[CompilerGenerated]
			get
			{
				return this.<Map>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Map>k__BackingField, value))
				{
					return;
				}
				this.<Map>k__BackingField = value;
				this.method_10(Class5.Map);
			}
		}

		public SecurityManager Security
		{
			[CompilerGenerated]
			get
			{
				return this.<Security>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Security>k__BackingField, value))
				{
					return;
				}
				this.<Security>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_96);
			}
		}

		public DarkOrbitWebAPI Web
		{
			[CompilerGenerated]
			get
			{
				return this.<Web>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Web>k__BackingField, value))
				{
					return;
				}
				this.<Web>k__BackingField = value;
				this.method_10(Class5.Web);
			}
		}

		public Settings Settings
		{
			[CompilerGenerated]
			get
			{
				return this.<Settings>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Settings>k__BackingField, value))
				{
					return;
				}
				this.<Settings>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_98);
			}
		}

		public int NextMapId
		{
			[CompilerGenerated]
			get
			{
				return this.<NextMapId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<NextMapId>k__BackingField == value)
				{
					return;
				}
				this.<NextMapId>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_75);
			}
		}

		public DateTime LastJumped
		{
			[CompilerGenerated]
			get
			{
				return this.<LastJumped>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<LastJumped>k__BackingField, value))
				{
					return;
				}
				this.<LastJumped>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_58);
			}
		}

		public DateTimeOffset LastDied
		{
			[CompilerGenerated]
			get
			{
				return this.<LastDied>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<LastDied>k__BackingField, value))
				{
					return;
				}
				this.<LastDied>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_56);
			}
		}

		public DateTimeOffset LastDailyLogin
		{
			[CompilerGenerated]
			get
			{
				return this.<LastDailyLogin>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<LastDailyLogin>k__BackingField, value))
				{
					return;
				}
				this.<LastDailyLogin>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_55);
			}
		}

		public DateTimeOffset EventGateOpening
		{
			[CompilerGenerated]
			get
			{
				return this.<EventGateOpening>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<EventGateOpening>k__BackingField, value))
				{
					return;
				}
				this.<EventGateOpening>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_21);
			}
		}

		public DateTimeOffset EventGateClosing
		{
			[CompilerGenerated]
			get
			{
				return this.<EventGateClosing>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<EventGateClosing>k__BackingField, value))
				{
					return;
				}
				this.<EventGateClosing>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_19);
			}
		}

		public DateTimeOffset EventGateGoal
		{
			[CompilerGenerated]
			get
			{
				return this.<EventGateGoal>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<EventGateGoal>k__BackingField, value))
				{
					return;
				}
				this.<EventGateGoal>k__BackingField = value;
				this.method_10(Class5.ehOwktwZfVR);
			}
		}

		public GClass848.GEnum9 LicenseState
		{
			[CompilerGenerated]
			get
			{
				return this.<LicenseState>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				if (this.<LicenseState>k__BackingField == value)
				{
					return;
				}
				this.<LicenseState>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_68);
			}
		}

		public DateTimeOffset LicenseExpiration
		{
			[CompilerGenerated]
			get
			{
				return this.<LicenseExpiration>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				if (DateTimeOffset.Equals(this.<LicenseExpiration>k__BackingField, value))
				{
					return;
				}
				this.<LicenseExpiration>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_67);
			}
		}

		public IDopeServiceProxy Dope
		{
			[CompilerGenerated]
			get
			{
				return this.<Dope>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Dope>k__BackingField, value))
				{
					return;
				}
				this.<Dope>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_15);
			}
		}

		public ILogManager LogManager
		{
			[CompilerGenerated]
			get
			{
				return this.<LogManager>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<LogManager>k__BackingField, value))
				{
					return;
				}
				this.<LogManager>k__BackingField = value;
				this.method_10(Class5.eiQwkWcPfad);
				this.method_10(Class5.propertyChangedEventArgs_70);
			}
		}

		private Logger Log
		{
			get
			{
				return this.LogManager.Get("Game");
			}
		}

		public bool IsLoggedIn
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoggedIn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsLoggedIn>k__BackingField == value)
				{
					return;
				}
				this.<IsLoggedIn>k__BackingField = value;
				this.method_10(Class5.IsLoggedIn);
			}
		}

		public bool IsLoggedOut
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoggedOut>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsLoggedOut>k__BackingField == value)
				{
					return;
				}
				this.<IsLoggedOut>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_45);
			}
		}

		public Random Random { get; }

		public ProxySettings ProxySettings
		{
			[CompilerGenerated]
			get
			{
				return this.<ProxySettings>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<ProxySettings>k__BackingField, value))
				{
					return;
				}
				this.<ProxySettings>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_80);
			}
		}

		public GameManager(IDopeServiceProxy idopeServiceProxy_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
			GameManager.Instance.Value = this;
			this.Connection = new ConnectionManager(this);
			this.Connection.Socket.Connected += this.method_0;
			this.Connection.Socket.Disconnected += this.method_1;
			this.Hero = new Hero(this);
			this.Map = new Map(this);
			this.Security = new SecurityManager(this);
			this.Settings = new Settings();
			this.Web = new DarkOrbitWebAPI(this);
			this.Dope = idopeServiceProxy_0;
			this.LogManager = NullLogManager.Instance;
			this.Random = new Random();
		}

		private void method_0(GClass91 gclass91_0)
		{
			this.IsLoggedOut = false;
		}

		private void method_1(GClass91 gclass91_0, ErrorReason errorReason_0, Exception exception_0 = null)
		{
			this.Hero.Clear();
			this.Map.Clear();
		}

		public void method_2()
		{
			this.Settings = (this.Settings ?? new Settings());
			this.Settings.MapHosts = this.Web.GetMapHosts();
			this.Settings.SpacemapConfig = this.Web.GetSpacemapConfig();
			try
			{
				this.Settings.UIString = this.Web.method_0();
			}
			catch
			{
			}
			if (this.Settings.SpacemapConfig != null)
			{
				MapUtils.smethod_9(this.Settings.SpacemapConfig);
			}
			DarkOrbitWebAPI.NpcConstants npcList = this.Web.GetNpcList();
			if (npcList != null)
			{
				NpcUtils.smethod_1(npcList);
			}
			DarkOrbitWebAPI.MapConstants mapList = this.Web.GetMapList();
			if (mapList != null)
			{
				MapUtils.smethod_5(mapList, false);
			}
		}

		public void method_3()
		{
			if (this.IsLoggedIn)
			{
				this.Log.Info("Grabbing daily login");
				if (this.Web.Get(GClass879.smethod_7(this.Web.Server), null).Data.IsSuccessStatusCode)
				{
					this.LastDailyLogin = DateTimeOffset.Now;
				}
			}
		}

		public bool method_4(string string_0, string string_1, string string_2, ProxySettings proxySettings_0 = null)
		{
			if (!this.Web.Login(string_0, string_1, string_2, proxySettings_0))
			{
				this.IsLoggedIn = false;
				return false;
			}
			this.method_3();
			this.method_2();
			this.Settings.FlashSettings = this.Web.GetFlashSettings();
			this.IsLoggedIn = true;
			return true;
		}

		public bool method_5(string string_0)
		{
			this.Web.Server = string_0;
			this.method_2();
			this.Settings.IsClient = false;
			return true;
		}

		public void Start()
		{
			Settings settings = this.Settings;
			int? num;
			if (settings == null)
			{
				num = null;
			}
			else
			{
				FlashSettings flashSettings = settings.FlashSettings;
				num = ((flashSettings != null) ? new int?(flashSettings.mapID) : null);
			}
			int num2 = num ?? 1;
			if (this.Map.MapId != 0)
			{
				num2 = this.Map.MapId;
			}
			if (this.NextMapId != 0)
			{
				num2 = this.NextMapId;
			}
			if (num2 == 0)
			{
				num2 = 1;
			}
			this.Connection.Connect(num2, this.ProxySettings);
		}

		internal void method_6(GClass216 gclass216_0)
		{
			this.Hero.Init(gclass216_0);
			GameManager.GClass77.GDelegate1 heroInit = this.HeroInit;
			if (heroInit == null)
			{
				return;
			}
			heroInit(this, this.Hero);
		}

		internal void method_7(GClass214 gclass214_0)
		{
			bool isInitialized = this.Hero.IsInitialized;
			this.Hero.Hp = 0;
			this.Hero.Clear();
			this.Hero.IsInitialized = false;
			this.LastDied = DateTimeOffset.Now;
			this.IsLoggedOut = true;
			GameManager.GClass77.GDelegate2 heroDied = this.HeroDied;
			if (heroDied == null)
			{
				return;
			}
			heroDied(this, this.Hero, gclass214_0, isInitialized);
		}

		internal void method_8(bool bool_0 = false)
		{
			if (bool_0 || (this.Settings.MapHosts.ContainsKey(this.Map.MapId) && this.Settings.MapHosts.ContainsKey(this.NextMapId) && this.Settings.MapHosts[this.NextMapId] != this.Settings.MapHosts[this.Map.MapId]))
			{
				this.Log.Info<int, int>("Changing game server {oldMap} -> {newMap}", this.Map.MapId, this.NextMapId);
				this.Connection.Socket.Disconnect(ErrorReason.ConnectionOverridden, null, false);
			}
		}

		public void method_9(GClass268 gclass268_0)
		{
			string[] array = gclass268_0.string_0.Split(new char[]
			{
				'|'
			});
			Hero hero = this.Hero;
			try
			{
				if (gclass268_0.string_0 == "0|l")
				{
					this.IsLoggedOut = true;
					this.Connection.Socket.Disconnect(ErrorReason.LoggedOut, null, false);
				}
				else if (array[0] == "ERR")
				{
					this.Log.Warn("Error {msg}", gclass268_0.string_0);
					if (array[1] == "41")
					{
						this.IsLoggedIn = false;
					}
					this.Connection.Socket.Disconnect(ErrorReason.ConnectionLost, null, false);
				}
				if (array.Length >= 3 && array[1] == "A")
				{
					if (array[2] == "C")
					{
						hero.Credits = double.Parse(array[3]);
						hero.Uridium = double.Parse(array[4]);
					}
					else if (array[2] == "BK")
					{
						hero.BootyKeys = (double)int.Parse(array[3]);
					}
					else if (array[2] == "STD")
					{
						this.Log.Info(array[3]);
					}
				}
				string text = array[1];
				if (text != null)
				{
					if (!(text == "i"))
					{
						if (!(text == "S"))
						{
							if (!(text == "LM"))
							{
								if (!(text == "n"))
								{
									if (text == "7" && array.Length > 2 && array[2] == "HS")
									{
										this.Connection.method_2(new string[]
										{
											"JCPU",
											"GET"
										});
									}
								}
								else
								{
									string text2 = array[2];
									if (text2 != null)
									{
										if (!(text2 == "INV"))
										{
											if (!(text2 == "LSH"))
											{
												if (!(text2 == "USH"))
												{
													if (text2 == "fx")
													{
														string string_ = array[4];
														Ship ship = this.Map.method_4(int.Parse(array[5]));
														if (ship != null)
														{
															if (array[3] == "start")
															{
																ship.StartEffect(string_);
															}
															else
															{
																ship.EndEffect(string_);
															}
														}
													}
												}
												else
												{
													Ship ship2 = this.Map.method_4(int.Parse(array[3]));
													if (ship2 != null)
													{
														NpcShip npcShip = ship2 as NpcShip;
														if (npcShip != null)
														{
															npcShip.LeashedBy = 0;
														}
													}
												}
											}
											else
											{
												Ship ship3 = this.Map.method_4(int.Parse(array[3]));
												if (ship3 != null)
												{
													NpcShip npcShip2 = ship3 as NpcShip;
													if (npcShip2 != null)
													{
														npcShip2.LeashedBy = int.Parse(array[4]);
														if (npcShip2.LeashedBy == this.Hero.Id)
														{
															npcShip2.LeashedBy = -1;
														}
														else
														{
															Ship ship4 = this.Map.method_4(npcShip2.LeashedBy);
															if (ship4 != null)
															{
																ship4.TargetId = ship3.Id;
															}
														}
													}
												}
											}
										}
										else
										{
											Ship ship5 = this.Map.method_4(int.Parse(array[3]));
											if (ship5 != null)
											{
												ship5.Cloaked = (array[4] == "1");
											}
										}
									}
								}
							}
							else if (array[2] == "ST" && array.Length > 5)
							{
								double num = double.Parse(array[5], CultureInfo.InvariantCulture);
								string text2 = array[3];
								if (text2 != null)
								{
									if (!(text2 == "EP"))
									{
										if (!(text2 == "HON"))
										{
											if (!(text2 == "CRE"))
											{
												if (text2 == "URI")
												{
													this.Hero.Uridium = num;
												}
											}
											else
											{
												this.Hero.Credits = num;
											}
										}
										else
										{
											this.Hero.Honor = num;
										}
									}
									else
									{
										this.Hero.Experience = num;
										this.Hero.Level = int.Parse(array[6]);
									}
								}
							}
						}
						else
						{
							string text2 = array[2];
							if (text2 != null && text2 == "CFG")
							{
								this.Hero.Config = int.Parse(array[3]);
							}
						}
					}
					else
					{
						this.NextMapId = int.Parse(array[2]);
						this.Connection.SendMessage(new GClass145(true));
						this.method_8(false);
					}
				}
			}
			catch
			{
			}
			GameManager.GClass77.GDelegate3 logMessage = this.LogMessage;
			if (logMessage == null)
			{
				return;
			}
			logMessage(this, gclass268_0);
		}

		public event GameManager.GClass77.GDelegate2 HeroDied;

		public event GameManager.GClass77.GDelegate1 HeroInit;

		public event GameManager.GClass77.GDelegate3 LogMessage;

		public event PropertyChangedEventHandler PropertyChanged;

		// Note: this type is marked as 'beforefieldinit'.
		static GameManager()
		{
			Class13.xnk8ImWzpOt04();
			GameManager.Instance = new ThreadLocal<GameManager>();
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
		protected void method_10(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}

		public static ThreadLocal<GameManager> Instance;

		public sealed class GClass77
		{
			public GClass77()
			{
				Class13.xnk8ImWzpOt04();
				base..ctor();
			}

			public delegate void GDelegate1(GameManager game, Hero hero);

			public delegate void GDelegate2(GameManager game, Hero hero, GClass214 e, bool wasAlive);

			public delegate void GDelegate3(GameManager game, GClass268 e);
		}
	}
}

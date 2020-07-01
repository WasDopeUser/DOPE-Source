using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Ace.Networking;
using Ace.Networking.Entanglement.ProxyImpl;
using Ace.Networking.Entanglement.Reflection;
using Ace.Networking.Entanglement.Services;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using Dope.Common;
using DOPE.Common;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using DOPE.Core;
using NLog;

public class GClass923 : EntangledHostedObjectBase, INotifyPropertyChanged, GInterface8
{
	public string Type
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
			this.OnPropertyChanged("Type");
		}
	}

	public string Version
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
			this.OnPropertyChanged("Version");
		}
	}

	public IConnection Connection
	{
		get
		{
			return base._Context.Host as IConnection;
		}
	}

	public Controller Parent
	{
		[CompilerGenerated]
		get
		{
			return this.controller_0;
		}
		[CompilerGenerated]
		internal set
		{
			if (object.Equals(this.controller_0, value))
			{
				return;
			}
			this.controller_0 = value;
			this.OnPropertyChanged("Parent");
		}
	}

	public ConcurrentDictionary<string, BotProfile> ProfileMap
	{
		[CompilerGenerated]
		get
		{
			return this.concurrentDictionary_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.concurrentDictionary_0, value))
			{
				return;
			}
			this.concurrentDictionary_0 = value;
			this.OnPropertyChanged("ProfileMap");
		}
	}

	public ICollection<GClass922> Bots
	{
		[CompilerGenerated]
		get
		{
			return this.icollection_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.icollection_0, value))
			{
				return;
			}
			this.icollection_0 = value;
			this.OnPropertyChanged("Bots");
		}
	}

	public Thread AccountManagerThread
	{
		[CompilerGenerated]
		get
		{
			return this.thread_0;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.thread_0, value))
			{
				return;
			}
			this.thread_0 = value;
			this.OnPropertyChanged("AccountManagerThread");
		}
	}

	public GClass923(Guid guid_0, InterfaceDescriptor interfaceDescriptor_0, ICommon icommon_0)
	{
		Class13.F93tSdiz1aNIA();
		this.BotControllers = new ConcurrentDictionary<string, GClass922>();
		this.concurrentDictionary_0 = new ConcurrentDictionary<string, BotProfile>();
		base..ctor(guid_0, interfaceDescriptor_0, icommon_0);
		this.Bots = new List<GClass922>();
		this.AccountManagerThread = new Thread(new ThreadStart(this.method_2))
		{
			IsBackground = true
		};
		this.AccountManagerThread.Start();
	}

	private void method_2()
	{
		DateTimeOffset date = DateTimeOffset.MinValue;
		for (;;)
		{
			foreach (KeyValuePair<string, GClass922> keyValuePair in this.BotControllers)
			{
				GClass923.<>c__DisplayClass29_0 CS$<>8__locals1 = new GClass923.<>c__DisplayClass29_0();
				GClass922 value = keyValuePair.Value;
				CS$<>8__locals1.gclass890_0 = ((value != null) ? value.Context : null);
				if (CS$<>8__locals1.gclass890_0 != null)
				{
					GClass923.<>c__DisplayClass29_0 CS$<>8__locals2 = CS$<>8__locals1;
					string str = "Core-MainBotController-";
					GClass890 gclass890_ = CS$<>8__locals1.gclass890_0;
					string str2;
					if (gclass890_ == null)
					{
						str2 = null;
					}
					else
					{
						AccountSettings account = gclass890_.Account;
						str2 = ((account != null) ? account.BotId : null);
					}
					CS$<>8__locals2.logger_0 = LogManager.GetLogger(str + str2);
					try
					{
						bool flag = CS$<>8__locals1.gclass890_0.Game.Connection.Socket.method_1();
						if (CS$<>8__locals1.gclass890_0.ShouldBeDisabled && !flag && CS$<>8__locals1.gclass890_0.Game.IsLoggedOut)
						{
							CS$<>8__locals1.gclass890_0.IsEnabled = false;
							CS$<>8__locals1.gclass890_0.ShouldBeDisabled = false;
							CS$<>8__locals1.gclass890_0.Stop();
							foreach (GClass892 gclass in CS$<>8__locals1.gclass890_0.Scheduler.list_0)
							{
								gclass.ForceStop();
							}
						}
						if (CS$<>8__locals1.gclass890_0.IsEnabled)
						{
							CS$<>8__locals1.gclass890_0.Game.Settings.Use3D = true;
							if (CS$<>8__locals1.gclass890_0.LastLogin.Cooldown(60000) && date.Cooldown(5000))
							{
								Task loginTask = CS$<>8__locals1.gclass890_0.LoginTask;
								if (loginTask == null || loginTask.IsCompleted)
								{
									CS$<>8__locals1.gclass890_0.LoginTask = Task.Run(new Action(CS$<>8__locals1.gclass890_0.method_62));
									date = DateTimeOffset.Now;
								}
							}
							if (CS$<>8__locals1.gclass890_0.Game.IsLoggedIn)
							{
								if (CS$<>8__locals1.gclass890_0.LastDisconnectReason == ErrorReason.CantLogin)
								{
									CS$<>8__locals1.gclass890_0.LastDisconnectReason = ErrorReason.Unknown;
								}
								if (CS$<>8__locals1.gclass890_0.BackgroundQueue != null && CS$<>8__locals1.gclass890_0.BackgroundQueue.Any<Func<DarkOrbitWebAPI, object>>())
								{
									for (;;)
									{
										GClass923.<>c__DisplayClass29_1 CS$<>8__locals3 = new GClass923.<>c__DisplayClass29_1();
										CS$<>8__locals3.<>c__DisplayClass29_0_0 = CS$<>8__locals1;
										if (!CS$<>8__locals3.<>c__DisplayClass29_0_0.gclass890_0.BackgroundQueue.TryDequeue(out CS$<>8__locals3.func_0))
										{
											break;
										}
										Task lastBackgroundAction = CS$<>8__locals3.<>c__DisplayClass29_0_0.gclass890_0.LastBackgroundAction;
										if (lastBackgroundAction != null && !lastBackgroundAction.IsCompleted)
										{
											break;
										}
										CS$<>8__locals3.<>c__DisplayClass29_0_0.gclass890_0.LastBackgroundAction = Task.Run<object>(new Func<object>(CS$<>8__locals3.method_0));
									}
								}
								foreach (GInterface9 ginterface in CS$<>8__locals1.gclass890_0.method_60())
								{
									Task lastBackgroundHandlerAction = CS$<>8__locals1.gclass890_0.LastBackgroundHandlerAction;
									if ((lastBackgroundHandlerAction == null || lastBackgroundHandlerAction.IsCompleted) && ginterface.imethod_0())
									{
										CS$<>8__locals1.gclass890_0.LastBackgroundHandlerAction = Task.Run(new Action(ginterface.Execute));
									}
								}
								string activeHangarName = CS$<>8__locals1.gclass890_0.Game.Web.Equipment.ActiveHangarName;
								if (!string.IsNullOrWhiteSpace(activeHangarName))
								{
									GClass892 gclass2 = CS$<>8__locals1.gclass890_0.Scheduler.method_13();
									bool flag2 = CS$<>8__locals1.gclass890_0.IsPaused || gclass2.ShouldBeInGame();
									if (activeHangarName != null && gclass2.ShouldChangeHangar(out CS$<>8__locals1.string_0) && CS$<>8__locals1.string_0 != activeHangarName)
									{
										if (CS$<>8__locals1.gclass890_0.Game.IsLoggedOut && !CS$<>8__locals1.gclass890_0.dateTimeOffset_4.Cooldown(900000))
										{
											flag2 = false;
											if (CS$<>8__locals1.gclass890_0.Cooldowns.method_2(BotAction.ChangeHangar, 10000.0))
											{
												bool flag3;
												CS$<>8__locals1.gclass890_0.method_10<bool>("ChangeHangar", new Func<DarkOrbitWebAPI, bool>(CS$<>8__locals1.method_0), out flag3);
											}
										}
										else
										{
											flag2 = true;
											CS$<>8__locals1.gclass890_0.ForceLogout = true;
										}
									}
									if (!flag)
									{
										if (flag2 && CS$<>8__locals1.gclass890_0.LastMapLogin.Cooldown(10000) && CS$<>8__locals1.gclass890_0.dateTime_2.Cooldown(1000))
										{
											CS$<>8__locals1.gclass890_0.LastMapLogin = DateTime.Now;
											CS$<>8__locals1.gclass890_0.Game.Settings.IsClient = (CS$<>8__locals1.gclass890_0.Game.Connection.ProxySocket == null);
											CS$<>8__locals1.gclass890_0.Game.Start();
										}
									}
									else if (!CS$<>8__locals1.gclass890_0.Run)
									{
										CS$<>8__locals1.gclass890_0.Start(true);
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						CS$<>8__locals1.logger_0.Error("Exception in main loop: {exception}", ex.ToString());
					}
				}
			}
			Thread.Sleep(50);
		}
	}

	private void method_3(AccountSettings accountSettings_0)
	{
		if (!this.BotControllers.ContainsKey(accountSettings_0.BotId))
		{
			IEntanglementHostService entanglementHostService = this.Connection.Services.Get<IEntanglementHostService>();
			GClass890 gclass = new GClass890(this.Parent, accountSettings_0);
			GClass922 gclass2 = entanglementHostService.GetHostedObject(entanglementHostService.GetInstance(typeof(IBotController).GUID, null).Value) as GClass922;
			gclass.Controller = gclass2;
			gclass2.Context = gclass;
			gclass2.Controller = this;
			this.Bots.Add(gclass2);
			this.BotControllers[gclass.Account.BotId] = gclass2;
		}
		else
		{
			this.BotControllers[accountSettings_0.BotId].Context.Account = accountSettings_0;
		}
		this.BotControllers[accountSettings_0.BotId].Context.Scheduler.method_1(accountSettings_0.ProfileName);
	}

	public void method_4(ICollection<GClass922> icollection_1)
	{
		foreach (GClass922 item in this.Bots)
		{
			icollection_1.Add(item);
		}
		ICollection<GClass922> bots = this.Bots;
		this.Bots = icollection_1;
		if (bots == null)
		{
			return;
		}
		bots.Clear();
	}

	private Task<XiHQiID9PuRot1OrPrF> method_5<XiHQiID9PuRot1OrPrF>(string string_2, Func<GClass922, Task<XiHQiID9PuRot1OrPrF>> func_0)
	{
		GClass922 gclass = this.Bot(string_2);
		if (gclass == null)
		{
			return Task.FromResult<XiHQiID9PuRot1OrPrF>(default(XiHQiID9PuRot1OrPrF));
		}
		return func_0(gclass);
	}

	private GClass922 Bot(string id)
	{
		GClass922 result;
		if (!this.BotControllers.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	public Task Init(List<AccountSettings> accounts, List<BotProfile> profiles)
	{
		GClass923.<Init>d__34 <Init>d__;
		<Init>d__.<>4__this = this;
		<Init>d__.accounts = accounts;
		<Init>d__.profiles = profiles;
		<Init>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<GClass923.<Init>d__34>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	public Task<AccountSettings> CreateNewBot(string username, string password, string server, string userAgent)
	{
		DarkOrbitWebAPI darkOrbitWebAPI = new DarkOrbitWebAPI(null)
		{
			ForcedUserAgent = userAgent
		};
		if (!darkOrbitWebAPI.Login(username, password, server, null))
		{
			return Task.FromResult<AccountSettings>(null);
		}
		AccountSettings accountSettings = new AccountSettings
		{
			Username = username,
			Password = password,
			Server = server,
			UserId = darkOrbitWebAPI.Uid,
			UserAgent = userAgent
		};
		accountSettings.Fill();
		string botId = accountSettings.BotId;
		GClass922 gclass;
		if (this.BotControllers.TryGetValue(botId, out gclass))
		{
			return Task.FromResult<AccountSettings>(gclass.Context.Account);
		}
		this.method_3(accountSettings);
		return Task.FromResult<AccountSettings>(accountSettings);
	}

	public Task<List<string>> GetAvailableBots()
	{
		return Task.FromResult<List<string>>(this.BotControllers.Keys.ToList<string>());
	}

	public Task<List<BotProfile>> GetBotProfiles()
	{
		return Task.FromResult<List<BotProfile>>(this.ProfileMap.Values.ToList<BotProfile>());
	}

	public Task<bool> UpdateBotProfile(BotProfile profile)
	{
		this.ProfileMap[profile.Name] = profile.Fill();
		foreach (GClass922 gclass in this.Bots)
		{
			string a;
			if (gclass == null)
			{
				a = null;
			}
			else
			{
				GClass890 context = gclass.Context;
				if (context == null)
				{
					a = null;
				}
				else
				{
					AccountSettings account = context.Account;
					a = ((account != null) ? account.ProfileName : null);
				}
			}
			if (a == profile.Name)
			{
				gclass.Context.Scheduler.method_1(profile.Name);
			}
		}
		return Task.FromResult<bool>(true);
	}

	public Task<bool> DeleteBotProfile(string profileName)
	{
		BotProfile botProfile;
		return Task.FromResult<bool>(this.ProfileMap.TryRemove(profileName, out botProfile));
	}

	public Task<bool> UpdateAccount(AccountSettings account)
	{
		GClass922 gclass;
		if (!this.BotControllers.TryGetValue(account.BotId, out gclass))
		{
			return Task.FromResult<bool>(false);
		}
		gclass.Context.Account = account;
		return Task.FromResult<bool>(true);
	}

	public Task<AccountSettings> GetAccount(string botId)
	{
		GClass922 gclass;
		return Task.FromResult<AccountSettings>(this.BotControllers.TryGetValue(botId, out gclass) ? gclass.Context.Account : null);
	}

	public Task<bool> DeleteAccount(string botId)
	{
		GClass922 gclass;
		GClass922 gclass2;
		return Task.FromResult<bool>(this.BotControllers.TryGetValue(botId, out gclass) && !gclass.Context.IsEnabled && this.BotControllers.TryRemove(botId, out gclass2));
	}

	public Task<List<BasicBotStateInfo>> GetBasicBotStateInfos(CancellationToken? token = null)
	{
		GClass923.<GetBasicBotStateInfos>d__43 <GetBasicBotStateInfos>d__;
		<GetBasicBotStateInfos>d__.<>4__this = this;
		<GetBasicBotStateInfos>d__.<>t__builder = AsyncTaskMethodBuilder<List<BasicBotStateInfo>>.Create();
		<GetBasicBotStateInfos>d__.<>1__state = -1;
		<GetBasicBotStateInfos>d__.<>t__builder.Start<GClass923.<GetBasicBotStateInfos>d__43>(ref <GetBasicBotStateInfos>d__);
		return <GetBasicBotStateInfos>d__.<>t__builder.Task;
	}

	public Task<BotStats> GetBotStats(string id)
	{
		GClass922 gclass = this.Bot(id);
		if (gclass != null)
		{
			return gclass.GetStats();
		}
		return Task.FromResult<BotStats>(null);
	}

	public Task<bool> StartBot(string id)
	{
		return this.method_5<bool>(id, new Func<GClass922, Task<bool>>(GClass923.<>c.<>c_0.method_0));
	}

	public Task<bool> PauseBot(string id)
	{
		return this.method_5<bool>(id, new Func<GClass922, Task<bool>>(GClass923.<>c.<>c_0.method_1));
	}

	[Obsolete("Delete 'disable' parameter")]
	public Task<bool> StopBot(string id, bool disable)
	{
		return this.method_5<bool>(id, new Func<GClass922, Task<bool>>(GClass923.<>c.<>c_0.method_2));
	}

	public Task<bool> ForceStopBot(string id)
	{
		return this.method_5<bool>(id, new Func<GClass922, Task<bool>>(GClass923.<>c.<>c_0.method_3));
	}

	public Task<bool> SetBotProfile(string id, string name)
	{
		GClass923.<>c__DisplayClass49_0 CS$<>8__locals1 = new GClass923.<>c__DisplayClass49_0();
		CS$<>8__locals1.string_0 = name;
		return this.method_5<bool>(id, new Func<GClass922, Task<bool>>(CS$<>8__locals1.method_0));
	}

	public Task<BotSummaryViewModel> GetBotSummary(string id)
	{
		return this.method_5<BotSummaryViewModel>(id, new Func<GClass922, Task<BotSummaryViewModel>>(GClass923.<>c.<>c_0.method_4));
	}

	public Task Invalidate()
	{
		GClass923.<Invalidate>d__51 <Invalidate>d__;
		<Invalidate>d__.<>4__this = this;
		<Invalidate>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<Invalidate>d__.<>1__state = -1;
		<Invalidate>d__.<>t__builder.Start<GClass923.<Invalidate>d__51>(ref <Invalidate>d__);
		return <Invalidate>d__.<>t__builder.Task;
	}

	public Task<BotDetailedViewModel> GetBotDetailedView(string id, CancellationToken? token = null)
	{
		return this.method_5<BotDetailedViewModel>(id, new Func<GClass922, Task<BotDetailedViewModel>>(GClass923.<>c.<>c_0.method_5));
	}

	public Task<BotDetailedViewModel> GetBotDetailedView(string id, int lastMapId, bool includeCachable, CancellationToken? token = null)
	{
		GClass923.<>c__DisplayClass53_0 CS$<>8__locals1 = new GClass923.<>c__DisplayClass53_0();
		CS$<>8__locals1.int_0 = lastMapId;
		CS$<>8__locals1.bool_0 = includeCachable;
		return this.method_5<BotDetailedViewModel>(id, new Func<GClass922, Task<BotDetailedViewModel>>(CS$<>8__locals1.method_0));
	}

	public Task OnSpacemapClicked(string botId, float x, float y, string mode)
	{
		GClass923.<>c__DisplayClass54_0 CS$<>8__locals1 = new GClass923.<>c__DisplayClass54_0();
		CS$<>8__locals1.float_0 = x;
		CS$<>8__locals1.float_1 = y;
		CS$<>8__locals1.string_0 = mode;
		return this.method_5<bool>(botId, new Func<GClass922, Task<bool>>(CS$<>8__locals1.method_0));
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass923()
	{
		Class13.F93tSdiz1aNIA();
		GClass923.logger_0 = LogManager.GetLogger("Core-MainBotController");
	}

	private static Logger logger_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	public ConcurrentDictionary<string, GClass922> BotControllers;

	[CompilerGenerated]
	private Controller controller_0;

	[CompilerGenerated]
	private ConcurrentDictionary<string, BotProfile> concurrentDictionary_0;

	[CompilerGenerated]
	private ICollection<GClass922> icollection_0;

	[CompilerGenerated]
	private Thread thread_0;
}

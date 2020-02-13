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

public class GClass855 : EntangledHostedObjectBase, INotifyPropertyChanged, GInterface8
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

	public ICollection<GClass854> Bots
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
			return this.eatoHvZdegS;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.eatoHvZdegS, value))
			{
				return;
			}
			this.eatoHvZdegS = value;
			this.OnPropertyChanged("AccountManagerThread");
		}
	}

	public GClass855(Guid guid_0, InterfaceDescriptor interfaceDescriptor_0, ICommon icommon_0)
	{
		Class13.igxcIukzfpare();
		this.BotControllers = new ConcurrentDictionary<string, GClass854>();
		this.concurrentDictionary_0 = new ConcurrentDictionary<string, BotProfile>();
		base..ctor(guid_0, interfaceDescriptor_0, icommon_0);
		this.Bots = new List<GClass854>();
		this.AccountManagerThread = new Thread(new ThreadStart(this.method_1))
		{
			IsBackground = true
		};
		this.AccountManagerThread.Start();
	}

	private void method_1()
	{
		for (;;)
		{
			foreach (KeyValuePair<string, GClass854> keyValuePair in this.BotControllers)
			{
				GClass855.<>c__DisplayClass29_0 CS$<>8__locals1 = new GClass855.<>c__DisplayClass29_0();
				GClass854 value = keyValuePair.Value;
				CS$<>8__locals1.gclass824_0 = ((value != null) ? value.Context : null);
				if (CS$<>8__locals1.gclass824_0 != null)
				{
					GClass855.<>c__DisplayClass29_0 CS$<>8__locals2 = CS$<>8__locals1;
					string str = "Core-MainBotController-";
					GClass824 gclass824_ = CS$<>8__locals1.gclass824_0;
					string str2;
					if (gclass824_ == null)
					{
						str2 = null;
					}
					else
					{
						AccountSettings account = gclass824_.Account;
						str2 = ((account != null) ? account.BotId : null);
					}
					CS$<>8__locals2.logger_0 = LogManager.GetLogger(str + str2);
					try
					{
						bool flag = CS$<>8__locals1.gclass824_0.Game.Connection.Socket.method_2();
						if (CS$<>8__locals1.gclass824_0.ShouldBeDisabled && !flag && CS$<>8__locals1.gclass824_0.Game.IsLoggedOut)
						{
							CS$<>8__locals1.gclass824_0.IsEnabled = false;
							CS$<>8__locals1.gclass824_0.ShouldBeDisabled = false;
							CS$<>8__locals1.gclass824_0.Stop();
							foreach (GClass826 gclass in CS$<>8__locals1.gclass824_0.Scheduler.list_0)
							{
								gclass.ForceStop();
							}
						}
						if (CS$<>8__locals1.gclass824_0.IsEnabled)
						{
							CS$<>8__locals1.gclass824_0.Game.Settings.Use3D = true;
							if (CS$<>8__locals1.gclass824_0.LastLogin.Cooldown(60000))
							{
								Task loginTask = CS$<>8__locals1.gclass824_0.LoginTask;
								if (loginTask == null || loginTask.IsCompleted)
								{
									CS$<>8__locals1.gclass824_0.LoginTask = Task.Run(new Action(CS$<>8__locals1.gclass824_0.method_62));
								}
							}
							if (CS$<>8__locals1.gclass824_0.Game.IsLoggedIn)
							{
								if (CS$<>8__locals1.gclass824_0.LastDisconnectReason == ErrorReason.CantLogin)
								{
									CS$<>8__locals1.gclass824_0.LastDisconnectReason = ErrorReason.Unknown;
								}
								if (CS$<>8__locals1.gclass824_0.BackgroundQueue != null && CS$<>8__locals1.gclass824_0.BackgroundQueue.Any<Func<DarkOrbitWebAPI, object>>())
								{
									for (;;)
									{
										GClass855.<>c__DisplayClass29_1 CS$<>8__locals3 = new GClass855.<>c__DisplayClass29_1();
										CS$<>8__locals3.<>c__DisplayClass29_0_0 = CS$<>8__locals1;
										if (!CS$<>8__locals3.<>c__DisplayClass29_0_0.gclass824_0.BackgroundQueue.TryDequeue(out CS$<>8__locals3.func_0))
										{
											break;
										}
										Task lastBackgroundAction = CS$<>8__locals3.<>c__DisplayClass29_0_0.gclass824_0.LastBackgroundAction;
										if (lastBackgroundAction != null && !lastBackgroundAction.IsCompleted)
										{
											break;
										}
										CS$<>8__locals3.<>c__DisplayClass29_0_0.gclass824_0.LastBackgroundAction = Task.Run<object>(new Func<object>(CS$<>8__locals3.method_0));
									}
								}
								foreach (GInterface9 ginterface in CS$<>8__locals1.gclass824_0.method_60())
								{
									Task lastBackgroundHandlerAction = CS$<>8__locals1.gclass824_0.LastBackgroundHandlerAction;
									if ((lastBackgroundHandlerAction == null || lastBackgroundHandlerAction.IsCompleted) && ginterface.imethod_0())
									{
										CS$<>8__locals1.gclass824_0.LastBackgroundHandlerAction = Task.Run(new Action(ginterface.Execute));
									}
								}
								string activeHangarName = CS$<>8__locals1.gclass824_0.Game.Web.Equipment.ActiveHangarName;
								if (!string.IsNullOrWhiteSpace(activeHangarName))
								{
									GClass826 gclass2 = CS$<>8__locals1.gclass824_0.Scheduler.method_12();
									bool flag2 = CS$<>8__locals1.gclass824_0.IsPaused || gclass2.ShouldBeInGame();
									if (activeHangarName != null && gclass2.ShouldChangeHangar(out CS$<>8__locals1.string_0) && CS$<>8__locals1.string_0 != activeHangarName)
									{
										if (CS$<>8__locals1.gclass824_0.Game.IsLoggedOut && !CS$<>8__locals1.gclass824_0.wdvoKamvDiv.Cooldown(900000))
										{
											flag2 = false;
											if (CS$<>8__locals1.gclass824_0.Cooldowns.method_2(BotAction.ChangeHangar, 10000.0))
											{
												bool flag3;
												CS$<>8__locals1.gclass824_0.method_10<bool>("ChangeHangar", new Func<DarkOrbitWebAPI, bool>(CS$<>8__locals1.method_0), out flag3);
											}
										}
										else
										{
											flag2 = true;
											CS$<>8__locals1.gclass824_0.ForceLogout = true;
										}
									}
									if (!flag)
									{
										if (flag2 && CS$<>8__locals1.gclass824_0.LastMapLogin.Cooldown(10000) && CS$<>8__locals1.gclass824_0.dateTime_2.Cooldown(1000))
										{
											CS$<>8__locals1.gclass824_0.LastMapLogin = DateTime.Now;
											CS$<>8__locals1.gclass824_0.Game.Settings.IsClient = (CS$<>8__locals1.gclass824_0.Game.Connection.ProxySocket == null);
											CS$<>8__locals1.gclass824_0.Game.Start();
										}
									}
									else if (!CS$<>8__locals1.gclass824_0.Run)
									{
										CS$<>8__locals1.gclass824_0.Start(true);
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

	private void method_2(AccountSettings accountSettings_0)
	{
		if (!this.BotControllers.ContainsKey(accountSettings_0.BotId))
		{
			IEntanglementHostService entanglementHostService = this.Connection.Services.Get<IEntanglementHostService>();
			GClass824 gclass = new GClass824(this.Parent, accountSettings_0);
			GClass854 gclass2 = entanglementHostService.GetHostedObject(entanglementHostService.GetInstance(typeof(IBotController).GUID, null).Value) as GClass854;
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

	public void method_3(ICollection<GClass854> icollection_1)
	{
		foreach (GClass854 item in this.Bots)
		{
			icollection_1.Add(item);
		}
		ICollection<GClass854> bots = this.Bots;
		this.Bots = icollection_1;
		if (bots == null)
		{
			return;
		}
		bots.Clear();
	}

	private Task<cFp2T3LqjVdrpVceeKr> method_4<cFp2T3LqjVdrpVceeKr>(string string_2, Func<GClass854, Task<cFp2T3LqjVdrpVceeKr>> func_0)
	{
		GClass854 gclass = this.Bot(string_2);
		if (gclass == null)
		{
			return Task.FromResult<cFp2T3LqjVdrpVceeKr>(default(cFp2T3LqjVdrpVceeKr));
		}
		return func_0(gclass);
	}

	private GClass854 Bot(string id)
	{
		GClass854 result;
		if (!this.BotControllers.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	public async Task Init(List<AccountSettings> accounts, List<BotProfile> profiles)
	{
		GClass855.logger_0.Info(string.Format("Initializing {0} accounts and {1} profiles", (accounts != null) ? accounts.Count : 0, (profiles != null) ? profiles.Count : 0));
		if (this.Parent != null)
		{
			this.Parent.Status = GEnum12.Connected;
		}
		HashSet<GClass854> hashSet = new HashSet<GClass854>(this.BotControllers.Values);
		foreach (AccountSettings accountSettings in accounts)
		{
			this.method_2(accountSettings);
			hashSet.Remove(this.BotControllers[accountSettings.BotId]);
		}
		foreach (GClass854 r in hashSet)
		{
			this.Bots.Remove(r);
			ConcurrentDictionary<string, GClass854> botControllers = this.BotControllers;
			AccountSettings account = r.Context.Account;
			if (account == null)
			{
				goto IL_15B;
			}
			string key;
			if ((key = account.BotId) == null)
			{
				goto IL_15B;
			}
			IL_161:
			GClass854 gclass;
			botControllers.TryRemove(key, out gclass);
			TaskAwaiter<bool> taskAwaiter = r.ForceStop().GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<bool> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<bool>);
			}
			taskAwaiter.GetResult();
			r.Controller = null;
			r = null;
			continue;
			IL_15B:
			key = "";
			goto IL_161;
		}
		HashSet<GClass854>.Enumerator enumerator2 = default(HashSet<GClass854>.Enumerator);
		foreach (BotProfile botProfile in profiles)
		{
			this.ProfileMap[botProfile.Name] = botProfile.Fill();
		}
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
		GClass854 gclass;
		if (this.BotControllers.TryGetValue(botId, out gclass))
		{
			return Task.FromResult<AccountSettings>(gclass.Context.Account);
		}
		this.method_2(accountSettings);
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
		foreach (GClass854 gclass in this.Bots)
		{
			string a;
			if (gclass == null)
			{
				a = null;
			}
			else
			{
				GClass824 context = gclass.Context;
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
		GClass854 gclass;
		if (!this.BotControllers.TryGetValue(account.BotId, out gclass))
		{
			return Task.FromResult<bool>(false);
		}
		gclass.Context.Account = account;
		return Task.FromResult<bool>(true);
	}

	public Task<AccountSettings> GetAccount(string botId)
	{
		GClass854 gclass;
		return Task.FromResult<AccountSettings>(this.BotControllers.TryGetValue(botId, out gclass) ? gclass.Context.Account : null);
	}

	public Task<bool> DeleteAccount(string botId)
	{
		GClass854 gclass;
		GClass854 gclass2;
		return Task.FromResult<bool>(this.BotControllers.TryGetValue(botId, out gclass) && !gclass.Context.IsEnabled && this.BotControllers.TryRemove(botId, out gclass2));
	}

	public async Task<List<BasicBotStateInfo>> GetBasicBotStateInfos(CancellationToken? token = null)
	{
		List<BasicBotStateInfo> list = new List<BasicBotStateInfo>();
		foreach (KeyValuePair<string, GClass854> keyValuePair in this.BotControllers)
		{
			List<BasicBotStateInfo> list2 = list;
			TaskAwaiter<BasicBotStateInfo> taskAwaiter = keyValuePair.Value.GetBasicBotStateInfo().GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<BasicBotStateInfo> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<BasicBotStateInfo>);
			}
			BasicBotStateInfo result = taskAwaiter.GetResult();
			list2.Add(result);
			list2 = null;
		}
		IEnumerator<KeyValuePair<string, GClass854>> enumerator = null;
		return list;
	}

	public Task<BotStats> GetBotStats(string id)
	{
		GClass854 gclass = this.Bot(id);
		if (gclass != null)
		{
			return gclass.GetStats();
		}
		return Task.FromResult<BotStats>(null);
	}

	public Task<bool> StartBot(string id)
	{
		return this.method_4<bool>(id, new Func<GClass854, Task<bool>>(GClass855.<>c.<>c_0.method_0));
	}

	public Task<bool> PauseBot(string id)
	{
		return this.method_4<bool>(id, new Func<GClass854, Task<bool>>(GClass855.<>c.<>c_0.method_1));
	}

	[Obsolete("Delete 'disable' parameter")]
	public Task<bool> StopBot(string id, bool disable)
	{
		return this.method_4<bool>(id, new Func<GClass854, Task<bool>>(GClass855.<>c.<>c_0.method_2));
	}

	public Task<bool> ForceStopBot(string id)
	{
		return this.method_4<bool>(id, new Func<GClass854, Task<bool>>(GClass855.<>c.<>c_0.method_3));
	}

	public Task<bool> SetBotProfile(string id, string name)
	{
		GClass855.<>c__DisplayClass49_0 CS$<>8__locals1 = new GClass855.<>c__DisplayClass49_0();
		CS$<>8__locals1.string_0 = name;
		return this.method_4<bool>(id, new Func<GClass854, Task<bool>>(CS$<>8__locals1.method_0));
	}

	public Task<BotSummaryViewModel> GetBotSummary(string id)
	{
		return this.method_4<BotSummaryViewModel>(id, new Func<GClass854, Task<BotSummaryViewModel>>(GClass855.<>c.<>c_0.method_4));
	}

	public async Task Invalidate()
	{
		GClass855.logger_0.Warn("Invalidating current controller...");
		await this.Init(new List<AccountSettings>(), new List<BotProfile>());
	}

	public Task<BotDetailedViewModel> GetBotDetailedView(string id, CancellationToken? token = null)
	{
		return this.method_4<BotDetailedViewModel>(id, new Func<GClass854, Task<BotDetailedViewModel>>(GClass855.<>c.<>c_0.method_5));
	}

	public Task<BotDetailedViewModel> GetBotDetailedView(string id, int lastMapId, bool includeCachable, CancellationToken? token = null)
	{
		GClass855.<>c__DisplayClass53_0 CS$<>8__locals1 = new GClass855.<>c__DisplayClass53_0();
		CS$<>8__locals1.int_0 = lastMapId;
		CS$<>8__locals1.bool_0 = includeCachable;
		return this.method_4<BotDetailedViewModel>(id, new Func<GClass854, Task<BotDetailedViewModel>>(CS$<>8__locals1.ArWoxeAday6));
	}

	public Task OnSpacemapClicked(string botId, float x, float y, string mode)
	{
		GClass855.<>c__DisplayClass54_0 CS$<>8__locals1 = new GClass855.<>c__DisplayClass54_0();
		CS$<>8__locals1.float_0 = x;
		CS$<>8__locals1.float_1 = y;
		CS$<>8__locals1.string_0 = mode;
		return this.method_4<bool>(botId, new Func<GClass854, Task<bool>>(CS$<>8__locals1.method_0));
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass855()
	{
		Class13.igxcIukzfpare();
		GClass855.logger_0 = LogManager.GetLogger("Core-MainBotController");
	}

	private static Logger logger_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	public ConcurrentDictionary<string, GClass854> BotControllers;

	[CompilerGenerated]
	private Controller controller_0;

	[CompilerGenerated]
	private ConcurrentDictionary<string, BotProfile> concurrentDictionary_0;

	[CompilerGenerated]
	private ICollection<GClass854> icollection_0;

	[CompilerGenerated]
	private Thread eatoHvZdegS;
}

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Ace.Networking;
using Ace.Networking.Entanglement.ProxyImpl;
using Ace.Networking.Entanglement.Reflection;
using DOPE.Common;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using DOPE.Common.Models.Spacemap;
using NLog;

public class GClass835 : EntangledHostedObjectBase, INotifyPropertyChanged, IBotController
{
	public GClass836 Controller
	{
		[CompilerGenerated]
		get
		{
			return this.gclass836_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.gclass836_0, value))
			{
				return;
			}
			this.gclass836_0 = value;
			this.OnPropertyChanged("Controller");
		}
	}

	public GClass810 Context
	{
		[CompilerGenerated]
		get
		{
			return this.gclass810_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.gclass810_0, value))
			{
				return;
			}
			this.gclass810_0 = value;
			this.OnPropertyChanged("BotId");
			this.OnPropertyChanged("Log");
			this.OnPropertyChanged("Context");
		}
	}

	public string BotId
	{
		get
		{
			GClass810 context = this.Context;
			string result;
			if (context != null)
			{
				AccountSettings account = context.Account;
				if (account != null)
				{
					if ((result = account.BotId) != null)
					{
						return result;
					}
				}
			}
			result = "";
			return result;
		}
	}

	private Logger Log
	{
		get
		{
			return LogManager.GetLogger("Core-BotController-" + this.BotId);
		}
	}

	public Task<BasicBotStateInfo> GetBasicBotStateInfo()
	{
		BotControlState botControlState = BotControlState.Running;
		if (this.Context.IsPaused)
		{
			botControlState = BotControlState.Paused;
		}
		if (!this.Context.IsEnabled && !this.Context.Game.Connection.Socket.BdaNsdwBbq())
		{
			botControlState = BotControlState.Stopped;
		}
		string text = botControlState.ToString();
		if (botControlState == BotControlState.Running)
		{
			if (this.Context.Scheduler.CurrentProfile == null)
			{
				text += " (Waiting for bot profile)";
			}
			else if (this.Context.Scheduler.Module is GClass813)
			{
				text += " (Waiting for valid maps)";
			}
			else if (this.Context.IsStopping)
			{
				text += " (Stopping)";
			}
		}
		BasicBotStateInfo basicBotStateInfo = new BasicBotStateInfo();
		basicBotStateInfo.BotStateName = this.Context.State.ToString();
		basicBotStateInfo.SessionId = this.Context.Game.Web.Sid;
		basicBotStateInfo.BotId = this.BotId;
		AccountSettings account = this.Context.Account;
		basicBotStateInfo.BotName = ((account != null) ? account.BotName : null);
		basicBotStateInfo.MapName = this.Context.Map.MapName;
		AccountSettings account2 = this.Context.Account;
		basicBotStateInfo.ProfileName = ((account2 != null) ? account2.ProfileName : null);
		basicBotStateInfo.BotControlState = text;
		basicBotStateInfo.NextProfileName = this.Context.Scheduler.NextBot;
		basicBotStateInfo.HasNextProfile = this.Context.Scheduler.HasNextProfile;
		basicBotStateInfo.LastError = this.Context.LastDisconnectReason.ToString();
		AccountSettings account3 = this.Context.Account;
		basicBotStateInfo.TimeTableActive = (account3 != null && account3.EnableTimeTable);
		return Task.FromResult<BasicBotStateInfo>(basicBotStateInfo);
	}

	public Task<BotProfile> GetCurrentBotProfile()
	{
		return Task.FromResult<BotProfile>(this.Context.Scheduler.CurrentProfile);
	}

	public Task<BotStats> GetStats()
	{
		return Task.FromResult<BotStats>(new BotStats(this.Context.Stats));
	}

	private void method_0()
	{
		object object_ = this.Context.object_0;
		lock (object_)
		{
			if (this.Context.State == BotState.Travel)
			{
				this.Context.method_60(BotState.Default);
			}
		}
	}

	public Task<bool> Start()
	{
		this.Log.Info("Starting context");
		this.Context.ShouldBeDisabled = false;
		this.Context.IsEnabled = true;
		this.Context.IsPaused = false;
		this.Context.LastMapLogin = DateTime.MinValue;
		this.Context.dateTime_2 = DateTime.Now;
		this.method_0();
		foreach (GClass812 gclass in this.Context.Scheduler.list_0)
		{
			gclass.ClearCooldown();
		}
		return Task.FromResult<bool>(true);
	}

	public Task<bool> Pause()
	{
		this.Log.Info("Pausing context");
		this.Context.IsPaused = true;
		this.method_0();
		return Task.FromResult<bool>(true);
	}

	public Task<bool> SetCurrentBotProfile(string profileName)
	{
		int result;
		if (profileName != null)
		{
			BotProfile botProfile;
			if ((result = (this.Controller.ProfileMap.TryGetValue(profileName, out botProfile) ? 1 : 0)) == 0)
			{
				goto IL_2D;
			}
		}
		else
		{
			result = 1;
		}
		this.Context.Scheduler.method_1(profileName);
		IL_2D:
		return Task.FromResult<bool>(result != 0);
	}

	public Task<bool> Stop()
	{
		this.Log.Info("Stopping context");
		this.Context.IsPaused = false;
		this.Context.ShouldBeDisabled = true;
		this.method_0();
		return Task.FromResult<bool>(true);
	}

	public Task<bool> ForceStop()
	{
		this.Log.Info("Killing context");
		this.Context.IsEnabled = false;
		this.Context.IsPaused = false;
		this.Context.ShouldBeDisabled = false;
		this.Context.Stop();
		if (this.Context.Game.Connection.Socket.BdaNsdwBbq())
		{
			this.Context.Game.Connection.method_14();
		}
		return Task.FromResult<bool>(true);
	}

	public Task<MapProfile> GetCurrentMapProfile()
	{
		return Task.FromResult<MapProfile>(this.Context.MapProfile);
	}

	public Task<BotSummaryViewModel> method_1()
	{
		return Task.FromResult<BotSummaryViewModel>(new BotSummaryViewModel(this.Context.Hero, this.Context.Stats, this.Context.Stats.RunTime));
	}

	public GClass835(Guid guid_0, InterfaceDescriptor interfaceDescriptor_0, ICommon icommon_0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(guid_0, interfaceDescriptor_0, icommon_0);
	}

	public Task<BotDetailedViewModel> method_2()
	{
		return this.method_3(0, true);
	}

	public Task<BotDetailedViewModel> method_3(int int_0, bool bool_0)
	{
		MapViewData spacemap = GClass811.smethod_22(this.Context, bool_0 | this.Context.Map.MapId != int_0);
		BotSummaryViewModel summary = new BotSummaryViewModel(this.Context.Hero, this.Context.Stats, this.Context.Stats.RunTime);
		BotDetailedViewModel botDetailedViewModel = new BotDetailedViewModel();
		botDetailedViewModel.Spacemap = spacemap;
		GClass810 context = this.Context;
		string botId;
		if (context == null)
		{
			botId = null;
		}
		else
		{
			AccountSettings account = context.Account;
			botId = ((account != null) ? account.BotId : null);
		}
		botDetailedViewModel.BotId = botId;
		botDetailedViewModel.Summary = summary;
		return Task.FromResult<BotDetailedViewModel>(botDetailedViewModel);
	}

	[CompilerGenerated]
	private GClass836 gclass836_0;

	[CompilerGenerated]
	private GClass810 gclass810_0;
}

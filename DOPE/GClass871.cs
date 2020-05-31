using System;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Ace.Networking;
using Ace.Networking.Entanglement.ProxyImpl;
using Ace.Networking.Entanglement.Reflection;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Structures;
using DarkorbitAPI.Structures.Pathing;
using DOPE.Common;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using DOPE.Common.Models.Spacemap;
using NLog;

public class GClass871 : EntangledHostedObjectBase, INotifyPropertyChanged, IBotController
{
	public GClass872 Controller
	{
		[CompilerGenerated]
		get
		{
			return this.gclass872_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.gclass872_0, value))
			{
				return;
			}
			this.gclass872_0 = value;
			this.OnPropertyChanged("Controller");
		}
	}

	public GClass839 Context
	{
		[CompilerGenerated]
		get
		{
			return this.gclass839_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.gclass839_0, value))
			{
				return;
			}
			this.gclass839_0 = value;
			this.OnPropertyChanged("BotId");
			this.OnPropertyChanged("Log");
			this.OnPropertyChanged("Context");
		}
	}

	public string BotId
	{
		get
		{
			GClass839 context = this.Context;
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
		if (!this.Context.IsEnabled && !this.Context.Game.Connection.Socket.method_2())
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
			else if (this.Context.Scheduler.Module is GClass842)
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
				this.Context.method_65(BotState.Default);
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
		foreach (GClass841 gclass in this.Context.Scheduler.list_0)
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
		if (this.Context.Game.Connection.Socket.method_2())
		{
			this.Context.Game.Connection.method_13();
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

	public GClass871(Guid guid_0, InterfaceDescriptor interfaceDescriptor_0, ICommon icommon_0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(guid_0, interfaceDescriptor_0, icommon_0);
	}

	public Task<BotDetailedViewModel> method_2()
	{
		return this.method_3(0, true);
	}

	public Task<BotDetailedViewModel> method_3(int int_0, bool bool_0)
	{
		MapViewData spacemap = GClass840.smethod_24(this.Context, bool_0 | this.Context.Map.MapId != int_0);
		BotSummaryViewModel summary = new BotSummaryViewModel(this.Context.Hero, this.Context.Stats, this.Context.Stats.RunTime);
		BotDetailedViewModel botDetailedViewModel = new BotDetailedViewModel();
		botDetailedViewModel.Spacemap = spacemap;
		GClass839 context = this.Context;
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

	public async Task<bool> method_4(float float_0, float float_1, string string_0)
	{
		Size mapSize = this.Context.Map.MapSize;
		float_0 *= (float)mapSize.Width;
		float_1 *= (float)mapSize.Height;
		if (string_0 != null)
		{
			if (string_0 == "left")
			{
				return this.method_5(float_0, float_1);
			}
			if (string_0 == "right")
			{
				return this.method_6(float_0, float_1);
			}
		}
		return false;
	}

	private bool method_5(float float_0, float float_1)
	{
		GClass871.<>c__DisplayClass27_0 CS$<>8__locals1 = new GClass871.<>c__DisplayClass27_0();
		CS$<>8__locals1.gclass871_0 = this;
		CS$<>8__locals1.float_0 = float_0;
		CS$<>8__locals1.float_1 = float_1;
		CS$<>8__locals1.gclass839_0 = this.Context;
		if (CS$<>8__locals1.gclass839_0.Map.Grid.RdVucjMuSW(CS$<>8__locals1.float_0, CS$<>8__locals1.float_1))
		{
			return false;
		}
		if (Map.Navigators.method_4(new Action<MapNavigator>(CS$<>8__locals1.method_0), -1) && this.Context.CurrentPath != null)
		{
			Vector2 vector = this.Context.CurrentPath.Path.Skip(1).FirstOrDefault<Vector2>();
			CS$<>8__locals1.gclass839_0.Server.method_6(vector.X, vector.Y, true);
		}
		return true;
	}

	private bool method_6(float float_0, float float_1)
	{
		GClass839 context = this.Context;
		SecurityManager security = context.Map.Game.Security;
		Vector2 vector2_ = new Vector2(float_0, float_1);
		Gate gate = context.Map.method_5<Gate>(vector2_, null, null, 0);
		if (gate == null)
		{
			return false;
		}
		if (security.method_3(vector2_, gate.Position, 0) && security.method_3(gate.Position, context.Map.Hero.Position, 0))
		{
			context.Map.Game.Connection.Server.method_2(gate.Id);
			return true;
		}
		if (this.Context.Run && !this.Context.IsPaused)
		{
			context.method_35(gate.Position, gate, 15, false);
		}
		return false;
	}

	[CompilerGenerated]
	private GClass872 gclass872_0;

	[CompilerGenerated]
	private GClass839 gclass839_0;
}

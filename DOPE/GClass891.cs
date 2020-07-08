using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DOPE.Common;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using NLog;

public abstract class GClass891 : INotifyPropertyChanged
{
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return this.string_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (string.Equals(this.string_0, value, StringComparison.Ordinal))
			{
				return;
			}
			this.string_0 = value;
			this.method_0(Class10.propertyChangedEventArgs_37);
			this.method_0(Class10.Name);
		}
	}

	public GClass889 Context
	{
		[CompilerGenerated]
		get
		{
			return this.gclass889_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (object.Equals(this.gclass889_0, value))
			{
				return;
			}
			this.gclass889_0 = value;
			this.method_0(Class10.propertyChangedEventArgs_8);
			this.method_0(Class10.propertyChangedEventArgs_37);
			this.method_0(Class10.Context);
		}
	}

	protected GClass889 C
	{
		get
		{
			return this.Context;
		}
	}

	public BotProfile Profile
	{
		[CompilerGenerated]
		get
		{
			return this.botProfile_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (object.Equals(this.botProfile_0, value))
			{
				return;
			}
			this.botProfile_0 = value;
			this.method_0(Class10.propertyChangedEventArgs_43);
		}
	}

	public MapProfile MapProfile
	{
		[CompilerGenerated]
		get
		{
			return this.mapProfile_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (object.Equals(this.mapProfile_0, value))
			{
				return;
			}
			this.mapProfile_0 = value;
			this.method_0(Class10.propertyChangedEventArgs_40);
		}
	}

	public int Priority
	{
		[CompilerGenerated]
		get
		{
			return this.int_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (this.int_0 == value)
			{
				return;
			}
			this.int_0 = value;
			this.method_0(Class10.propertyChangedEventArgs_42);
		}
	}

	public ModuleState State
	{
		[CompilerGenerated]
		get
		{
			return this.moduleState_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (this.moduleState_0 == value)
			{
				return;
			}
			this.moduleState_0 = value;
			this.method_0(Class10.State);
		}
	}

	public DateTimeOffset Started
	{
		[CompilerGenerated]
		get
		{
			return this.dateTimeOffset_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (DateTimeOffset.Equals(this.dateTimeOffset_0, value))
			{
				return;
			}
			this.dateTimeOffset_0 = value;
			this.method_0(Class10.Started);
		}
	}

	public DateTimeOffset Cooldown
	{
		[CompilerGenerated]
		get
		{
			return this.dateTimeOffset_1;
		}
		[CompilerGenerated]
		protected set
		{
			if (DateTimeOffset.Equals(this.dateTimeOffset_1, value))
			{
				return;
			}
			this.dateTimeOffset_1 = value;
			this.method_0(Class10.propertyChangedEventArgs_12);
		}
	}

	public virtual bool IsInterruptible
	{
		get
		{
			return false;
		}
	}

	public int Deaths
	{
		[CompilerGenerated]
		get
		{
			return this.int_1;
		}
		[CompilerGenerated]
		set
		{
			if (this.int_1 == value)
			{
				return;
			}
			this.int_1 = value;
			this.method_0(Class10.Deaths);
		}
	}

	protected Logger Log
	{
		get
		{
			return this.Context.method_70("Module-" + this.Name);
		}
	}

	public GClass891(GClass889 gclass889_1, string string_1, int int_2 = -2147483648)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.Name = string_1;
		this.Context = gclass889_1;
		this.Priority = int_2;
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public virtual void Update(BotProfile botProfile_1)
	{
		this.Profile = botProfile_1;
		this.MapProfile = this.UpdateProfile(botProfile_1);
	}

	public abstract MapProfile UpdateProfile(BotProfile botProfile_1);

	public virtual bool ShouldChangeHangar(out string string_1)
	{
		AccountSettings account = this.C.Account;
		string_1 = ((account != null) ? account.HangarDefault : null);
		return string_1 != null;
	}

	public virtual bool ShouldBeInGame()
	{
		return this.Profile != null;
	}

	public virtual void Start()
	{
		this.ChangeState(ModuleState.Started);
	}

	public virtual void Stop()
	{
		if (this.State != ModuleState.Stopped)
		{
			this.ChangeState(ModuleState.Stopping);
		}
	}

	public virtual void ForceStop()
	{
		this.ChangeState(ModuleState.Stopped);
	}

	public virtual void ChangeState(ModuleState moduleState_1)
	{
		if (this.State == moduleState_1)
		{
			return;
		}
		this.State = moduleState_1;
		if (moduleState_1 == ModuleState.Started)
		{
			this.OnStarted();
			return;
		}
		if (moduleState_1 == ModuleState.Stopping)
		{
			this.OnStopping();
			return;
		}
		if (moduleState_1 == ModuleState.Stopped)
		{
			this.OnStopped();
		}
	}

	protected virtual void OnBind()
	{
	}

	protected virtual void OnUnbind()
	{
	}

	protected virtual void OnStarted()
	{
		this.Log.Info("Started");
		this.ClearStats();
		this.Started = DateTimeOffset.Now;
		this.OnBind();
	}

	protected virtual void OnStopping()
	{
		this.Log.Info("Stopping");
	}

	protected virtual void OnStopped()
	{
		this.Log.Info("Stopped");
		this.ClearStats();
		this.OnUnbind();
	}

	public virtual bool CheckStopped()
	{
		return true;
	}

	public virtual int UpdatePriority()
	{
		if (this.MapProfile == null || !this.MapProfile.Enabled)
		{
			return int.MinValue;
		}
		if (DateTimeOffset.Now < this.Cooldown)
		{
			return int.MinValue;
		}
		return this.MapProfile.Priority;
	}

	public virtual void ClearStats()
	{
		this.Deaths = 0;
		this.Started = default(DateTimeOffset);
	}

	public virtual void UpdateForSchedule()
	{
		MapProfile mapProfile = this.MapProfile;
		if (mapProfile != null && mapProfile.MapCooldown > 0 && ((mapProfile.MaxDeaths > 0 && this.Deaths >= mapProfile.MaxDeaths) | (this.Started != default(DateTimeOffset) && mapProfile.MapDuration > 0 && (DateTimeOffset.Now - this.Started).TotalMinutes > (double)mapProfile.MapDuration)))
		{
			this.SetCooldown(TimeSpan.FromMinutes((double)mapProfile.MapCooldown), false);
		}
		this.UpdateState();
		this.Priority = this.UpdatePriority();
	}

	public virtual void UpdateState()
	{
		if (this.State == ModuleState.Stopping && this.CheckStopped())
		{
			this.ChangeState(ModuleState.Stopped);
		}
	}

	public virtual GClass903 GetBehavior()
	{
		if (this.C.Map.IsGG)
		{
			return this.C.gclass913_0;
		}
		if (this.C.Map.MapName.StartsWith("4-"))
		{
			return this.C.gclass911_0;
		}
		if (this.C.Map.MapId == 92)
		{
			return this.C.gclass908_0;
		}
		MapGroup mapGroup = MapUtils.smethod_2(this.C.Map.MapId);
		if (mapGroup == MapGroup.FrozenLabyrinth)
		{
			return this.C.gclass905_0;
		}
		if (mapGroup == MapGroup.PayloadEscort)
		{
			return this.C.gclass906_0;
		}
		return this.C.gclass903_0;
	}

	public virtual MapProfile GetMapProfile()
	{
		return this.MapProfile;
	}

	public virtual bool GetNextState(out BotState botState_0)
	{
		botState_0 = (BotState)0;
		return false;
	}

	public virtual void SetCooldown(TimeSpan timeSpan_0, bool bool_0 = false)
	{
		if (bool_0 && (int)timeSpan_0.TotalMilliseconds == 0)
		{
			timeSpan_0 = TimeSpan.FromSeconds(10.0);
		}
		DateTimeOffset dateTimeOffset = DateTimeOffset.Now.Add(timeSpan_0);
		if (dateTimeOffset >= this.Cooldown)
		{
			this.Cooldown = dateTimeOffset;
		}
	}

	public virtual void ClearCooldown()
	{
		this.Cooldown = DateTimeOffset.MinValue;
	}

	public virtual bool TrySwitchMap(out int int_2)
	{
		int_2 = this.C.MapProfile.TargetMap.Resolve(this.C.Hero.FactionId);
		return int_2 != this.C.Map.MapId;
	}

	public virtual void OnDeath(GClass214 gclass214_0)
	{
		int deaths = this.Deaths;
		this.Deaths = deaths + 1;
		MapProfile mapProfile = this.Context.MapProfile;
		int num = (mapProfile != null) ? mapProfile.MaxDeaths : 0;
		MapProfile mapProfile2 = this.Context.MapProfile;
		int num2 = (mapProfile2 != null) ? mapProfile2.MapCooldown : 1;
		if (num > 0 && this.Deaths >= num)
		{
			TimeSpan timeSpan_ = TimeSpan.FromMinutes((double)num2);
			this.SetCooldown(timeSpan_, true);
		}
	}

	public virtual void HandleError(GClass891.GEnum10 genum10_0)
	{
		this.SetCooldown(TimeSpan.FromMinutes(3.0), false);
		this.C.method_66(BotState.Default);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
	protected void method_0(PropertyChangedEventArgs propertyChangedEventArgs_0)
	{
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged != null)
		{
			propertyChanged(this, propertyChangedEventArgs_0);
		}
	}

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private GClass889 gclass889_0;

	[CompilerGenerated]
	private BotProfile botProfile_0;

	[CompilerGenerated]
	private MapProfile mapProfile_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private ModuleState moduleState_0;

	[CompilerGenerated]
	private DateTimeOffset dateTimeOffset_0;

	[CompilerGenerated]
	private DateTimeOffset dateTimeOffset_1;

	[CompilerGenerated]
	private int int_1;

	public enum GEnum10
	{
		Unknown
	}
}

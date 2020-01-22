using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;
using DOPE.Common;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using NLog;

public class GClass820 : INotifyPropertyChanged
{
	public GClass853 Controller
	{
		get
		{
			GClass822 context = this.Context;
			if (context == null)
			{
				return null;
			}
			return context.MainController;
		}
	}

	public GClass822 Context
	{
		[CompilerGenerated]
		get
		{
			return this.gclass822_0;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.gclass822_0, value))
			{
				return;
			}
			this.gclass822_0 = value;
			this.method_12(Class10.Controller);
			this.method_12(Class10.propertyChangedEventArgs_15);
			this.method_12(Class10.propertyChangedEventArgs_5);
			this.method_12(Class10.propertyChangedEventArgs_58);
			this.method_12(Class10.propertyChangedEventArgs_37);
			this.method_12(Class10.propertyChangedEventArgs_57);
			this.method_12(Class10.Context);
		}
	}

	public BotProfile CurrentProfile
	{
		get
		{
			BotProfile result = null;
			GClass853 controller = this.Controller;
			bool? flag;
			if (controller == null)
			{
				flag = null;
			}
			else
			{
				ConcurrentDictionary<string, BotProfile> profileMap = controller.ProfileMap;
				if (profileMap == null)
				{
					flag = null;
				}
				else
				{
					AccountSettings account = this.Context.Account;
					string key;
					if (account != null)
					{
						if ((key = account.ProfileName) != null)
						{
							goto IL_4B;
						}
					}
					key = "";
					IL_4B:
					flag = new bool?(profileMap.TryGetValue(key, out result));
				}
			}
			bool? flag2 = flag;
			if (!flag2.GetValueOrDefault())
			{
				return null;
			}
			return result;
		}
	}

	public IDictionary<string, BotProfile> BotProfiles
	{
		get
		{
			return this.Controller.ProfileMap;
		}
	}

	public string NextBot
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
			this.method_12(Class10.propertyChangedEventArgs_41);
		}
	}

	public bool HasNextProfile
	{
		get
		{
			return this.bool_1;
		}
	}

	private Logger Log
	{
		get
		{
			string str = "Core-Scheduler-";
			GClass822 context = this.Context;
			string str2;
			if (context == null)
			{
				str2 = null;
			}
			else
			{
				AccountSettings account = context.Account;
				str2 = ((account != null) ? account.BotId : null);
			}
			return LogManager.GetLogger(str + str2);
		}
	}

	private string TimeTableProfile
	{
		get
		{
			AccountSettings account = this.Context.Account;
			if (account != null && account.EnableTimeTable)
			{
				AccountSettings account2 = this.Context.Account;
				DateTime dateTime = (account2 != null && account2.TimeTableUseUtc) ? DateTime.UtcNow : DateTime.Now;
				int index = (int)((dateTime.DayOfWeek + 6) % (DayOfWeek)7);
				string text = this.Context.Account.TimeTable[index].Schedule[dateTime.Hour];
				BotProfile botProfile;
				if (!string.IsNullOrWhiteSpace(text) && this.BotProfiles.TryGetValue(text, out botProfile))
				{
					return text;
				}
			}
			return null;
		}
	}

	private bool TimeTableActive
	{
		get
		{
			AccountSettings account = this.Context.Account;
			return account != null && account.EnableTimeTable;
		}
	}

	public GClass824 Module
	{
		[CompilerGenerated]
		get
		{
			return this.gclass824_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (object.Equals(this.gclass824_0, value))
			{
				return;
			}
			this.gclass824_0 = value;
			this.method_12(Class10.Module);
		}
	}

	public GClass820(GClass822 gclass822_1)
	{
		Class13.plZSWFPzBWWEZ();
		this.dictionary_0 = new Dictionary<string, DateTimeOffset>();
		this.random_0 = new Random();
		this.list_0 = new List<GClass824>();
		this.object_0 = new object();
		base..ctor();
		this.Context = gclass822_1;
		this.list_0.Add(this.Module = new GClass825(gclass822_1));
		foreach (object obj in Enum.GetValues(typeof(TargetMap)))
		{
			TargetMap targetMap = (TargetMap)obj;
			GClass824 gclass = null;
			if (MapUtils.smethod_4((int)targetMap))
			{
				if (MapUtils.jEjnZuoyqO((int)targetMap))
				{
					gclass = new GClass831(gclass822_1, targetMap);
				}
				else if (MapUtils.smethod_5((int)targetMap))
				{
					gclass = new GClass832(gclass822_1, targetMap);
				}
			}
			else
			{
				gclass = new GClass828(gclass822_1, targetMap);
			}
			if (gclass != null)
			{
				this.list_0.Add(gclass);
			}
		}
		this.list_0.Add(new GClass826(gclass822_1));
		if (Constants.bool_0)
		{
			this.list_0.Add(new GClass833(gclass822_1));
		}
		this.list_0.Add(new GClass829(gclass822_1));
		if (Constants.FrozenLabirynthEnabled)
		{
			this.list_0.Add(new GClass830(gclass822_1));
		}
		this.list_0.Add(new GClass834(gclass822_1));
		this.Module.Start();
	}

	public void method_0()
	{
		foreach (GClass824 gclass in this.list_0)
		{
			gclass.Update(this.CurrentProfile);
			gclass.UpdateForSchedule();
		}
	}

	public void method_1(string string_2)
	{
		if (string_2 != this.string_1)
		{
			this.Log.Info("Scheduled new profile {profile}", string_2);
		}
		this.NextBot = string_2;
		this.bool_1 = true;
		this.string_1 = string_2;
	}

	public bool method_2()
	{
		return this.Module.ShouldBeInGame();
	}

	public bool hnyqwrQcimP()
	{
		return true;
	}

	internal void method_3()
	{
		this.bool_0 = false;
		this.Log.Debug("Resuming");
	}

	internal void method_4()
	{
		this.bool_0 = true;
		this.Log.Debug("Freezing");
	}

	public void method_5()
	{
		this.method_6();
	}

	public void method_6()
	{
		if (this.TimeTableActive)
		{
			string timeTableProfile = this.TimeTableProfile;
			string a = timeTableProfile;
			AccountSettings account = this.Context.Account;
			if (a != ((account != null) ? account.ProfileName : null))
			{
				this.method_1(timeTableProfile);
			}
		}
		if (this.bool_1)
		{
			if (this.Context.Account.ProfileName != this.NextBot)
			{
				this.Module.Stop();
				if (this.Module.State == ModuleState.Stopped)
				{
					this.bool_1 = false;
					this.Context.Stats.Reset();
					this.Context.Account.ProfileName = this.NextBot;
					this.method_0();
					return;
				}
			}
			else
			{
				this.bool_1 = false;
				this.method_0();
			}
		}
	}

	protected GClass824 method_7()
	{
		int num = int.MinValue;
		GClass824 gclass = null;
		foreach (GClass824 gclass2 in this.list_0)
		{
			if (gclass2.Priority > num || gclass == null)
			{
				num = gclass2.Priority;
				gclass = gclass2;
			}
		}
		return gclass;
	}

	protected GClass824 method_8(GClass835 gclass835_0)
	{
		int num = int.MinValue;
		GClass824 gclass = null;
		foreach (GClass824 gclass2 in this.list_0)
		{
			if (gclass835_0.vmethod_19(gclass2) && (gclass2.Priority > num || gclass == null))
			{
				num = gclass2.Priority;
				gclass = gclass2;
			}
		}
		return gclass;
	}

	protected void method_9()
	{
		GClass824 gclass = this.method_7();
		GClass835 behavior = gclass.GetBehavior();
		while (!behavior.vmethod_19(gclass))
		{
			gclass = this.method_8(behavior);
			behavior = gclass.GetBehavior();
		}
		if (!this.Module.GetBehavior().vmethod_19(this.Module))
		{
			this.Module.ForceStop();
		}
		else if (gclass.Priority > this.Module.Priority)
		{
			this.Module.Stop();
		}
		if (this.Module.State == ModuleState.Stopped)
		{
			this.Module = gclass;
		}
		if (this.Module.State == ModuleState.Stopped)
		{
			this.Module.Start();
		}
	}

	public void method_10()
	{
		if (this.Context.Game.Web.GgInfo == null)
		{
			return;
		}
		foreach (GClass824 gclass in this.list_0)
		{
			gclass.UpdateForSchedule();
		}
		this.method_5();
		this.method_9();
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public GClass824 method_11()
	{
		object obj = this.object_0;
		GClass824 module;
		lock (obj)
		{
			this.method_10();
			module = this.Module;
		}
		return module;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
	protected void method_12(PropertyChangedEventArgs propertyChangedEventArgs_0)
	{
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged != null)
		{
			propertyChanged(this, propertyChangedEventArgs_0);
		}
	}

	[CompilerGenerated]
	private GClass822 gclass822_0;

	[CompilerGenerated]
	private string string_0;

	public Dictionary<string, DateTimeOffset> dictionary_0;

	private readonly Random random_0;

	private volatile bool bool_0;

	private volatile bool bool_1;

	public readonly List<GClass824> list_0;

	[CompilerGenerated]
	private GClass824 gclass824_0;

	private string string_1;

	private readonly object object_0;
}

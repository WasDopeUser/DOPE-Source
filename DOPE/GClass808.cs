using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using NLog;

public class GClass808 : INotifyPropertyChanged
{
	public GClass836 Controller
	{
		get
		{
			GClass810 context = this.Context;
			if (context == null)
			{
				return null;
			}
			return context.Controller;
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
		private set
		{
			if (object.Equals(this.gclass810_0, value))
			{
				return;
			}
			this.gclass810_0 = value;
			this.method_12(Class5.Controller);
			this.method_12(Class5.propertyChangedEventArgs_13);
			this.method_12(Class5.propertyChangedEventArgs_4);
			this.method_12(Class5.propertyChangedEventArgs_53);
			this.method_12(Class5.propertyChangedEventArgs_32);
			this.method_12(Class5.propertyChangedEventArgs_52);
			this.method_12(Class5.Context);
		}
	}

	public BotProfile CurrentProfile
	{
		get
		{
			BotProfile result = null;
			GClass836 controller = this.Controller;
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
			this.method_12(Class5.propertyChangedEventArgs_35);
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
			GClass810 context = this.Context;
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

	public GClass812 Module
	{
		[CompilerGenerated]
		get
		{
			return this.gclass812_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (object.Equals(this.gclass812_0, value))
			{
				return;
			}
			this.gclass812_0 = value;
			this.method_12(Class5.Module);
		}
	}

	public GClass808(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		this.dictionary_0 = new Dictionary<string, DateTimeOffset>();
		this.random_0 = new Random();
		this.list_0 = new List<GClass812>();
		this.object_0 = new object();
		base..ctor();
		this.Context = gclass810_1;
		this.list_0.Add(this.Module = new GClass813(gclass810_1));
		foreach (object obj in Enum.GetValues(typeof(TargetMap)))
		{
			TargetMap targetMap = (TargetMap)obj;
			GClass812 gclass = null;
			if (MapUtils.smethod_4((int)targetMap))
			{
				gclass = new GClass818(gclass810_1, targetMap);
			}
			else if (!MapUtils.IsGG((int)targetMap))
			{
				gclass = new GClass816(gclass810_1, targetMap);
			}
			if (gclass != null)
			{
				this.list_0.Add(gclass);
			}
		}
		this.list_0.Add(new GClass814(gclass810_1));
		this.list_0.Add(new GClass817(gclass810_1));
		this.Module.Start();
	}

	public void method_0()
	{
		foreach (GClass812 gclass in this.list_0)
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

	public bool HmLiAjwBmZt()
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

	protected GClass812 method_7()
	{
		int num = int.MinValue;
		GClass812 gclass = null;
		foreach (GClass812 gclass2 in this.list_0)
		{
			if (gclass2.Priority > num || gclass == null)
			{
				num = gclass2.Priority;
				gclass = gclass2;
			}
		}
		return gclass;
	}

	protected GClass812 method_8(GClass820 gclass820_0)
	{
		int num = int.MinValue;
		GClass812 gclass = null;
		foreach (GClass812 gclass2 in this.list_0)
		{
			if (gclass820_0.vmethod_15(gclass2) && (gclass2.Priority > num || gclass == null))
			{
				num = gclass2.Priority;
				gclass = gclass2;
			}
		}
		return gclass;
	}

	protected void method_9()
	{
		GClass812 gclass = this.method_7();
		GClass820 behavior = gclass.GetBehavior();
		while (!behavior.vmethod_15(gclass))
		{
			gclass = this.method_8(behavior);
			behavior = gclass.GetBehavior();
		}
		if (!this.Module.GetBehavior().vmethod_15(this.Module))
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
		foreach (GClass812 gclass in this.list_0)
		{
			gclass.UpdateForSchedule();
		}
		this.method_5();
		this.method_9();
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public GClass812 method_11()
	{
		object obj = this.object_0;
		GClass812 module;
		lock (obj)
		{
			this.method_10();
			module = this.Module;
		}
		return module;
	}

	protected void method_12(PropertyChangedEventArgs propertyChangedEventArgs_0)
	{
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged != null)
		{
			propertyChanged(this, propertyChangedEventArgs_0);
		}
	}

	[CompilerGenerated]
	private GClass810 gclass810_0;

	[CompilerGenerated]
	private string string_0;

	public Dictionary<string, DateTimeOffset> dictionary_0;

	private readonly Random random_0;

	private volatile bool bool_0;

	private volatile bool bool_1;

	public readonly List<GClass812> list_0;

	[CompilerGenerated]
	private GClass812 gclass812_0;

	private string string_1;

	private readonly object object_0;
}

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

public class GClass888 : INotifyPropertyChanged
{
	public GClass923 Controller
	{
		get
		{
			GClass890 context = this.Context;
			if (context == null)
			{
				return null;
			}
			return context.MainController;
		}
	}

	public GClass890 Context
	{
		[CompilerGenerated]
		get
		{
			return this.gclass890_0;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.gclass890_0, value))
			{
				return;
			}
			this.gclass890_0 = value;
			this.method_14(Class10.Controller);
			this.method_14(Class10.propertyChangedEventArgs_15);
			this.method_14(Class10.propertyChangedEventArgs_5);
			this.method_14(Class10.propertyChangedEventArgs_58);
			this.method_14(Class10.propertyChangedEventArgs_36);
			this.method_14(Class10.propertyChangedEventArgs_57);
			this.method_14(Class10.Context);
		}
	}

	public BotProfile CurrentProfile
	{
		get
		{
			BotProfile result = null;
			GClass923 controller = this.Controller;
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
			this.method_14(Class10.propertyChangedEventArgs_40);
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
			GClass890 context = this.Context;
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

	public GClass892 Module
	{
		[CompilerGenerated]
		get
		{
			return this.gclass892_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (object.Equals(this.gclass892_0, value))
			{
				return;
			}
			this.gclass892_0 = value;
			this.method_14(Class10.Module);
		}
	}

	public GClass888(GClass890 gclass890_1)
	{
		Class13.lOBHd9Nzn7x2T();
		this.dictionary_0 = new Dictionary<string, DateTimeOffset>();
		this.random_0 = new Random();
		this.list_0 = new List<GClass892>();
		this.object_0 = new object();
		base..ctor();
		this.Context = gclass890_1;
		this.list_0.Add(this.Module = new GClass893(gclass890_1));
		foreach (object obj in Enum.GetValues(typeof(TargetMap)))
		{
			TargetMap targetMap = (TargetMap)obj;
			if (targetMap != TargetMap.PayloadEscort)
			{
				GClass892 gclass = null;
				if (MapUtils.smethod_6((int)targetMap))
				{
					if (MapUtils.smethod_7((int)targetMap))
					{
						gclass = new GClass900(gclass890_1, targetMap);
					}
					else if (MapUtils.smethod_8((int)targetMap))
					{
						gclass = new GClass901(gclass890_1, targetMap);
					}
				}
				else
				{
					gclass = new GClass896(gclass890_1, targetMap);
				}
				if (gclass != null)
				{
					this.list_0.Add(gclass);
				}
			}
		}
		this.list_0.Add(new GClass894(gclass890_1));
		if (Constants.bool_0)
		{
			this.list_0.Add(new GClass902(gclass890_1));
		}
		this.list_0.Add(new GClass897(gclass890_1));
		if (Constants.FrozenLabirynthEnabled)
		{
			this.list_0.Add(new GClass898(gclass890_1));
		}
		if (Constants.PayloadEscortEnabled)
		{
			this.list_0.Add(new GClass899(gclass890_1));
		}
		this.list_0.Add(new GClass903(gclass890_1));
		this.Module.Start();
	}

	public void method_0()
	{
		foreach (GClass892 gclass in this.list_0)
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

	public bool method_3()
	{
		return true;
	}

	internal void method_4()
	{
		this.bool_0 = false;
		this.Log.Debug("Resuming");
	}

	internal void method_5()
	{
		this.bool_0 = true;
		this.Log.Debug("Freezing");
	}

	public void method_6()
	{
		this.method_7();
	}

	public void method_7()
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

	protected GClass892 method_8()
	{
		int num = int.MinValue;
		GClass892 gclass = null;
		foreach (GClass892 gclass2 in this.list_0)
		{
			if (gclass2.Priority > num || gclass == null)
			{
				num = gclass2.Priority;
				gclass = gclass2;
			}
		}
		return gclass;
	}

	protected GClass892 method_9(GClass904 gclass904_0)
	{
		int num = int.MinValue;
		GClass892 gclass = null;
		foreach (GClass892 gclass2 in this.list_0)
		{
			if (gclass904_0.vmethod_18(gclass2) && (gclass2.Priority > num || gclass == null))
			{
				num = gclass2.Priority;
				gclass = gclass2;
			}
		}
		return gclass;
	}

	protected void method_10()
	{
		GClass892 gclass = this.method_8();
		GClass904 behavior = gclass.GetBehavior();
		while (!behavior.vmethod_18(gclass))
		{
			gclass = this.method_9(behavior);
			behavior = gclass.GetBehavior();
		}
		if (!this.Module.GetBehavior().vmethod_18(this.Module))
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

	public void method_11(GClass892 gclass892_1)
	{
		GClass892 module = this.Module;
		if (module != null && module != gclass892_1 && gclass892_1.Priority >= module.Priority && module.State == ModuleState.Stopping && module.IsInterruptible)
		{
			module.ForceStop();
		}
	}

	public void method_12()
	{
		if (this.Context.Game.Web.GgInfo == null)
		{
			return;
		}
		foreach (GClass892 gclass in this.list_0)
		{
			gclass.UpdateForSchedule();
		}
		this.method_6();
		this.method_10();
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public GClass892 method_13()
	{
		object obj = this.object_0;
		GClass892 module;
		lock (obj)
		{
			this.method_12();
			module = this.Module;
		}
		return module;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
	protected void method_14(PropertyChangedEventArgs propertyChangedEventArgs_0)
	{
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged != null)
		{
			propertyChanged(this, propertyChangedEventArgs_0);
		}
	}

	[CompilerGenerated]
	private GClass890 gclass890_0;

	[CompilerGenerated]
	private string string_0;

	public Dictionary<string, DateTimeOffset> dictionary_0;

	private readonly Random random_0;

	private volatile bool bool_0;

	private volatile bool bool_1;

	public readonly List<GClass892> list_0;

	[CompilerGenerated]
	private GClass892 gclass892_0;

	private string string_1;

	private readonly object object_0;
}

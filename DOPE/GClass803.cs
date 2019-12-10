using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.Structures;
using DOPE.Common.Models.Bot;

public class GClass803 : BotStats, INotifyPropertyChanged
{
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
			this.<>OnPropertyChanged(Class5.Context);
		}
	}

	public TimeSpan RunTime
	{
		get
		{
			if (this.Started == null)
			{
				return TimeSpan.Zero;
			}
			return (this.Stopped ?? DateTime.Now) - this.Started.Value;
		}
	}

	public double UridiumHourly
	{
		get
		{
			if (!(this.RunTime == TimeSpan.Zero))
			{
				return base.EarnedUridium / this.RunTime.TotalSeconds * 3600.0;
			}
			return 0.0;
		}
	}

	public double CreditsHourly
	{
		get
		{
			if (!(this.RunTime == TimeSpan.Zero))
			{
				return base.EarnedCredits / this.RunTime.TotalSeconds * 3600.0;
			}
			return 0.0;
		}
	}

	public GClass803(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Context = gclass810_1;
		base.HeroStats = (this.YmDirmxfFsA = new GClass806(gclass810_1.Hero, this));
		base.PetStats = (this.gclass807_0 = new GClass807(gclass810_1.Hero.Pet, this));
		base.GgStats = (this.gclass805_0 = new GClass805(gclass810_1.Game.Web));
		this.dictionary_0 = new Dictionary<string, int>();
		base.NpcStats = (this.gclass804_0 = new GClass804("NPCs", this.dictionary_0));
		this.dictionary_1 = new Dictionary<string, int>();
		base.BoxStats = (this.gclass804_1 = new GClass804("Boxes", this.dictionary_1));
		gclass810_1.Game.LogMessage += this.method_2;
		gclass810_1.Game.Map.ShipDestroyed += this.method_1;
		gclass810_1.Game.Map.CollectibleCollected += this.method_0;
	}

	private void method_0(Map map_0, string string_0, Collectible collectible_0, bool bool_0)
	{
		if (collectible_0 != null && bool_0 && this.Context.IsCollecting && this.Context.string_0 == string_0)
		{
			Dictionary<string, int> obj = this.dictionary_1;
			lock (obj)
			{
				if (!this.dictionary_1.ContainsKey(collectible_0.Type))
				{
					this.dictionary_1.Add(collectible_0.Type, 0);
				}
				Dictionary<string, int> dictionary = this.dictionary_1;
				string type = collectible_0.Type;
				int num = dictionary[type];
				dictionary[type] = num + 1;
			}
		}
	}

	private void method_1(Map map_0, Ship ship_0)
	{
		if (ship_0 == null)
		{
			return;
		}
		if (ship_0 != this.Context.Game.Hero)
		{
			if (ship_0.Id == this.Context.Game.Hero.Pet.Id && this.Context.Game.Hero.Pet.Hp == 0)
			{
				int num = base.PetDeaths;
				base.PetDeaths = num + 1;
				return;
			}
			NpcShip npcShip = ship_0 as NpcShip;
			if (npcShip != null && (this.Context.Map.IsGG || !npcShip.LastTookDamageHero.Cooldown(5000)))
			{
				Dictionary<string, int> obj = this.dictionary_0;
				lock (obj)
				{
					string text = NpcUtils.NpcType.smethod_0(ship_0.Name);
					if (!this.dictionary_0.ContainsKey(text))
					{
						this.dictionary_0.Add(text, 0);
					}
					Dictionary<string, int> dictionary = this.dictionary_0;
					string key = text;
					int num = dictionary[key];
					dictionary[key] = num + 1;
				}
			}
		}
	}

	public DateTime? Started
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			if (Nullable.Equals<DateTime>(this.nullable_0, value))
			{
				return;
			}
			this.nullable_0 = value;
			this.<>OnPropertyChanged(Class5.RunTime);
			this.<>OnPropertyChanged(Class5.UridiumHourly);
			this.<>OnPropertyChanged(Class5.CreditsHourly);
			this.<>OnPropertyChanged(Class5.Started);
		}
	}

	private void method_2(GameManager gameManager_0, GClass255 gclass255_0)
	{
		string[] array = gclass255_0.string_0.Split(new char[]
		{
			'|'
		});
		if (array[1] == "LM" && array[2] == "ST" && array.Length > 4)
		{
			double num2;
			double num = double.TryParse(array[4], out num2) ? num2 : 0.0;
			string text = array[3];
			if (text != null)
			{
				uint num3 = <PrivateImplementationDetails>{5F838C85-FA2B-4B99-BAD9-50DFDAC6D328}.ComputeStringHash(text);
				if (num3 <= 1746879935U)
				{
					if (num3 != 583800688U)
					{
						if (num3 != 1702788290U)
						{
							if (num3 != 1746879935U)
							{
								return;
							}
							if (!(text == "CRE"))
							{
								return;
							}
							base.EarnedCredits += num;
							return;
						}
						else
						{
							if (!(text == "JPA"))
							{
								return;
							}
							base.EarnedJackpot += num;
							return;
						}
					}
					else
					{
						if (!(text == "EP"))
						{
							return;
						}
						base.EarnedExp += num;
						return;
					}
				}
				else if (num3 <= 2053729053U)
				{
					if (num3 != 1805517074U)
					{
						if (num3 != 2053729053U)
						{
							return;
						}
						if (!(text == "URI"))
						{
							return;
						}
						base.EarnedUridium += num;
						return;
					}
					else
					{
						if (!(text == "HON"))
						{
							return;
						}
						base.EarnedHonor += num;
					}
				}
				else if (num3 != 3043894024U)
				{
					if (num3 != 4214671512U)
					{
						return;
					}
					if (!(text == "XEN"))
					{
						return;
					}
					base.EarnedEnergy += num;
					return;
				}
				else
				{
					if (!(text == "BAT"))
					{
						return;
					}
					num = double.Parse(array[5]);
					string text2 = array[4];
					if (text2 != null)
					{
						if (text2 == "ammunition_laser_lcb-10")
						{
							base.EarnedX1 += num;
							return;
						}
						if (text2 == "ammunition_laser_mcb-25")
						{
							base.EarnedX2 += num;
							return;
						}
						if (text2 == "ammunition_laser_mcb-50")
						{
							base.EarnedX3 += num;
							return;
						}
						if (text2 == "ammunition_laser_ucb-100")
						{
							base.EarnedX4 += num;
							return;
						}
						if (!(text2 == "ammunition_laser_sab-50"))
						{
							return;
						}
						base.Double_0 += num;
						return;
					}
				}
			}
		}
	}

	public DateTime? Stopped
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_1;
		}
		[CompilerGenerated]
		internal set
		{
			if (Nullable.Equals<DateTime>(this.nullable_1, value))
			{
				return;
			}
			this.nullable_1 = value;
			this.<>OnPropertyChanged(Class5.RunTime);
			this.<>OnPropertyChanged(Class5.UridiumHourly);
			this.<>OnPropertyChanged(Class5.CreditsHourly);
			this.<>OnPropertyChanged(Class5.Stopped);
		}
	}

	public void Reset()
	{
		base.PetDeaths = 0;
		base.Spins = 0;
		base.Resets = 0;
		base.Deaths = 0;
		base.Boxes = 0;
		double earnedX = (double)0f;
		double num = (double)0f;
		base.EarnedX4 = earnedX;
		double earnedX2 = num;
		double num2 = (double)0f;
		base.EarnedX3 = earnedX2;
		double earnedX3 = num2;
		double num3 = (double)0f;
		base.EarnedX2 = earnedX3;
		double earnedX4 = num3;
		double num4 = (double)0f;
		base.EarnedX1 = earnedX4;
		double earnedUridium = num4;
		double num5 = (double)0f;
		base.EarnedUridium = earnedUridium;
		double double_ = num5;
		double num6 = (double)0f;
		base.Double_0 = double_;
		double earnedJackpot = num6;
		double num7 = (double)0f;
		base.EarnedJackpot = earnedJackpot;
		double earnedHonor = num7;
		double num8 = (double)0f;
		base.EarnedHonor = earnedHonor;
		double earnedExp = num8;
		double num9 = (double)0f;
		base.EarnedExp = earnedExp;
		double earnedEnergy = num9;
		double earnedCredits = (double)0f;
		base.EarnedEnergy = earnedEnergy;
		base.EarnedCredits = earnedCredits;
		base.NpcStats.ScheduleClear();
		base.BoxStats.ScheduleClear();
		Dictionary<string, int> obj = this.dictionary_1;
		lock (obj)
		{
			this.dictionary_1.Clear();
		}
		obj = this.dictionary_0;
		lock (obj)
		{
			this.dictionary_0.Clear();
		}
		DateTime? dateTime = null;
		this.Stopped = dateTime;
		this.Started = dateTime;
		if (this.Context.Run)
		{
			this.Context.Stats.Started = new DateTime?(DateTime.Now);
		}
	}

	public void method_3()
	{
		base.InternalRaiseChanged("RunTime", GClass803.propertyChangedEventArgs_0);
		base.InternalRaiseChanged("UridiumHourly", GClass803.propertyChangedEventArgs_1);
		base.InternalRaiseChanged("CreditsHourly", GClass803.propertyChangedEventArgs_2);
		int num = this.int_0;
		this.int_0 = num + 1;
		if (num % 20 == 0)
		{
			base.HeroStats.Update();
			base.PetStats.Update();
			this.gclass805_0.Update();
			base.NpcStats.Update();
			base.BoxStats.Update();
		}
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass803()
	{
		Class8.xDph7tozmh5WD();
		GClass803.propertyChangedEventArgs_0 = new PropertyChangedEventArgs("RunTime");
		GClass803.propertyChangedEventArgs_1 = new PropertyChangedEventArgs("UridiumHourly");
		GClass803.propertyChangedEventArgs_2 = new PropertyChangedEventArgs("CreditsHourly");
	}

	[CompilerGenerated]
	private GClass810 gclass810_0;

	private GClass806 YmDirmxfFsA;

	private GClass807 gclass807_0;

	private GClass805 gclass805_0;

	private GClass804 gclass804_0;

	private GClass804 gclass804_1;

	private Dictionary<string, int> dictionary_0;

	private Dictionary<string, int> dictionary_1;

	[CompilerGenerated]
	private DateTime? nullable_0;

	[CompilerGenerated]
	private DateTime? nullable_1;

	private int int_0;

	private static readonly PropertyChangedEventArgs propertyChangedEventArgs_0;

	private static readonly PropertyChangedEventArgs propertyChangedEventArgs_1;

	private static readonly PropertyChangedEventArgs propertyChangedEventArgs_2;
}

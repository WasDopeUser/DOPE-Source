using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.Structures;
using DOPE.Common.Models.Bot;

namespace xcwaDuiebvuNrIkSlmL
{
	public class GClass881 : BotStats, INotifyPropertyChanged
	{
		public GClass889 Context
		{
			[CompilerGenerated]
			get
			{
				return this.gclass889_0;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.gclass889_0, value))
				{
					return;
				}
				this.gclass889_0 = value;
				this.<>OnPropertyChanged(Class10.Context);
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

		public Dictionary<string, GClass883.GStruct0> DeathLog
		{
			[CompilerGenerated]
			get
			{
				return this.dictionary_2;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.dictionary_2, value))
				{
					return;
				}
				this.dictionary_2 = value;
				this.<>OnPropertyChanged(Class10.propertyChangedEventArgs_17);
			}
		}

		public GClass881(GClass889 gclass889_1)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
			this.Context = gclass889_1;
			base.HeroStats = (this.gclass885_0 = new GClass885(gclass889_1.Hero, this));
			base.PetStats = (this.gclass886_0 = new GClass886(gclass889_1.Hero.Pet, this));
			base.GgStats = (this.gclass884_0 = new GClass884(gclass889_1.Game.Web));
			this.DeathLog = new Dictionary<string, GClass883.GStruct0>();
			base.DeathStats = (this.gclass883_0 = new GClass883(this.DeathLog));
			this.dictionary_0 = new Dictionary<string, int>();
			base.NpcStats = (this.gclass882_0 = new GClass882("NPCs", this.dictionary_0));
			this.dictionary_1 = new Dictionary<string, int>();
			base.BoxStats = (this.gclass882_1 = new GClass882("Boxes", this.dictionary_1));
			gclass889_1.Game.LogMessage += this.method_2;
			gclass889_1.Game.Map.ShipDestroyed += this.method_1;
			gclass889_1.Game.Map.CollectibleCollected += this.method_0;
		}

		private void method_0(Map map_0, string string_0, Collectible collectible_0, bool bool_0)
		{
			if (collectible_0 != null && bool_0 && this.Context.IsCollecting && this.Context.FmowrcKoFu8 == string_0)
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

		private void method_1(Map map_0, Ship ship_0, bool bool_0)
		{
			if (ship_0 != null && bool_0)
			{
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
				return;
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
				this.<>OnPropertyChanged(Class10.RunTime);
				this.<>OnPropertyChanged(Class10.UridiumHourly);
				this.<>OnPropertyChanged(Class10.CreditsHourly);
				this.<>OnPropertyChanged(Class10.Started);
			}
		}

		private void method_2(GameManager gameManager_0, GClass268 gclass268_0)
		{
			string[] array = gclass268_0.string_0.Split(new char[]
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
					uint num3 = <PrivateImplementationDetails>{48ACEDDC-453F-4AC2-AD88-67AF852DC3FF}.ComputeStringHash(text);
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
				this.<>OnPropertyChanged(Class10.RunTime);
				this.<>OnPropertyChanged(Class10.UridiumHourly);
				this.<>OnPropertyChanged(Class10.CreditsHourly);
				this.<>OnPropertyChanged(Class10.Stopped);
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
			base.DeathStats.ScheduleClear();
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
			Dictionary<string, GClass883.GStruct0> deathLog = this.DeathLog;
			lock (deathLog)
			{
				this.DeathLog.Clear();
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
			base.InternalRaiseChanged("RunTime", GClass881.propertyChangedEventArgs_0);
			base.InternalRaiseChanged("UridiumHourly", GClass881.propertyChangedEventArgs_1);
			base.InternalRaiseChanged("CreditsHourly", GClass881.propertyChangedEventArgs_2);
			int num = this.int_0;
			this.int_0 = num + 1;
			if (num % 20 == 0)
			{
				base.HeroStats.Update();
				base.PetStats.Update();
				this.gclass884_0.Update();
				this.gclass883_0.Update();
				base.NpcStats.Update();
				base.BoxStats.Update();
			}
		}

		public void method_4(GClass214 gclass214_0)
		{
			int deaths = base.Deaths;
			base.Deaths = deaths + 1;
			this.gclass883_0.method_0(gclass214_0.string_0);
		}

		// Note: this type is marked as 'beforefieldinit'.
		static GClass881()
		{
			Class13.xnk8ImWzpOt04();
			GClass881.propertyChangedEventArgs_0 = new PropertyChangedEventArgs("RunTime");
			GClass881.propertyChangedEventArgs_1 = new PropertyChangedEventArgs("UridiumHourly");
			GClass881.propertyChangedEventArgs_2 = new PropertyChangedEventArgs("CreditsHourly");
		}

		[CompilerGenerated]
		private GClass889 gclass889_0;

		private GClass885 gclass885_0;

		private GClass886 gclass886_0;

		private GClass884 gclass884_0;

		private GClass882 gclass882_0;

		private GClass882 gclass882_1;

		private GClass883 gclass883_0;

		private Dictionary<string, int> dictionary_0;

		private Dictionary<string, int> dictionary_1;

		[CompilerGenerated]
		private Dictionary<string, GClass883.GStruct0> dictionary_2;

		[CompilerGenerated]
		private DateTime? nullable_0;

		[CompilerGenerated]
		private DateTime? nullable_1;

		private int int_0;

		private static readonly PropertyChangedEventArgs propertyChangedEventArgs_0;

		private static readonly PropertyChangedEventArgs propertyChangedEventArgs_1;

		private static readonly PropertyChangedEventArgs propertyChangedEventArgs_2;
	}
}

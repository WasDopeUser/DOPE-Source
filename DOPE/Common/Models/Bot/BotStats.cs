using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using DOPE.Common.Models.Bot.Stats;

namespace DOPE.Common.Models.Bot
{
	[DataContract]
	[Guid("63669AC1-AF22-4F9E-BDD6-5E73B550D772")]
	public class BotStats : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate(object sender, PropertyChangedEventArgs e)
		{
		};

		[DataMember(Order = 1)]
		public double EarnedCredits
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedCredits>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedCredits>k__BackingField == value)
				{
					return;
				}
				this.<EarnedCredits>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.EarnedCredits);
			}
		}

		[DataMember(Order = 2)]
		public double EarnedExp
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedExp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedExp>k__BackingField == value)
				{
					return;
				}
				this.<EarnedExp>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.EarnedExp);
			}
		}

		[DataMember(Order = 3)]
		public double EarnedUridium
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedUridium>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedUridium>k__BackingField == value)
				{
					return;
				}
				this.<EarnedUridium>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.EarnedUridium);
			}
		}

		[DataMember(Order = 4)]
		public double EarnedHonor
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedHonor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedHonor>k__BackingField == value)
				{
					return;
				}
				this.<EarnedHonor>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.EarnedHonor);
			}
		}

		[DataMember(Order = 5)]
		public double EarnedEnergy
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedEnergy>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedEnergy>k__BackingField == value)
				{
					return;
				}
				this.<EarnedEnergy>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.EarnedEnergy);
			}
		}

		[DataMember(Order = 6)]
		public double EarnedX1
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedX1>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedX1>k__BackingField == value)
				{
					return;
				}
				this.<EarnedX1>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_23);
			}
		}

		[DataMember(Order = 7)]
		public double EarnedX2
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedX2>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedX2>k__BackingField == value)
				{
					return;
				}
				this.<EarnedX2>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_24);
			}
		}

		[DataMember(Order = 8)]
		public double EarnedX3
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedX3>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedX3>k__BackingField == value)
				{
					return;
				}
				this.<EarnedX3>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_25);
			}
		}

		[DataMember(Order = 9)]
		public double EarnedX4
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedX4>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedX4>k__BackingField == value)
				{
					return;
				}
				this.<EarnedX4>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_26);
			}
		}

		[DataMember(Order = 10)]
		public double Double_0
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedSAB>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedSAB>k__BackingField == value)
				{
					return;
				}
				this.<EarnedSAB>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_22);
			}
		}

		[DataMember(Order = 11)]
		public double EarnedJackpot
		{
			[CompilerGenerated]
			get
			{
				return this.<EarnedJackpot>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<EarnedJackpot>k__BackingField == value)
				{
					return;
				}
				this.<EarnedJackpot>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_21);
			}
		}

		[DataMember(Order = 12)]
		public int Boxes
		{
			[CompilerGenerated]
			get
			{
				return this.<Boxes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Boxes>k__BackingField == value)
				{
					return;
				}
				this.<Boxes>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.Boxes);
			}
		}

		[DataMember(Order = 13)]
		public int Deaths
		{
			[CompilerGenerated]
			get
			{
				return this.<Deaths>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Deaths>k__BackingField == value)
				{
					return;
				}
				this.<Deaths>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.Deaths);
			}
		}

		[DataMember(Order = 14)]
		public int Resets
		{
			[CompilerGenerated]
			get
			{
				return this.<Resets>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Resets>k__BackingField == value)
				{
					return;
				}
				this.<Resets>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_79);
			}
		}

		[DataMember(Order = 15)]
		public int Spins
		{
			[CompilerGenerated]
			get
			{
				return this.<Spins>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Spins>k__BackingField == value)
				{
					return;
				}
				this.<Spins>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.Spins);
			}
		}

		[IgnoreDataMember]
		public int PetDeaths
		{
			[CompilerGenerated]
			get
			{
				return this.<PetDeaths>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<PetDeaths>k__BackingField == value)
				{
					return;
				}
				this.<PetDeaths>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_72);
			}
		}

		[IgnoreDataMember]
		public StatisticsCategory HeroStats
		{
			[CompilerGenerated]
			get
			{
				return this.<HeroStats>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<HeroStats>k__BackingField, value))
				{
					return;
				}
				this.<HeroStats>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.HeroStats);
			}
		}

		[IgnoreDataMember]
		public StatisticsCategory PetStats
		{
			[CompilerGenerated]
			get
			{
				return this.<PetStats>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<PetStats>k__BackingField, value))
				{
					return;
				}
				this.<PetStats>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.PetStats);
			}
		}

		[IgnoreDataMember]
		public StatisticsCategory GgStats
		{
			[CompilerGenerated]
			get
			{
				return this.<GgStats>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<GgStats>k__BackingField, value))
				{
					return;
				}
				this.<GgStats>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.GgStats);
			}
		}

		[IgnoreDataMember]
		public StatisticsCategory BoxStats
		{
			[CompilerGenerated]
			get
			{
				return this.<BoxStats>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<BoxStats>k__BackingField, value))
				{
					return;
				}
				this.<BoxStats>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.BoxStats);
			}
		}

		[IgnoreDataMember]
		public StatisticsCategory NpcStats
		{
			[CompilerGenerated]
			get
			{
				return this.<NpcStats>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<NpcStats>k__BackingField, value))
				{
					return;
				}
				this.<NpcStats>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.NpcStats);
			}
		}

		[IgnoreDataMember]
		public StatisticsCategory DeathStats
		{
			[CompilerGenerated]
			get
			{
				return this.<DeathStats>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<DeathStats>k__BackingField, value))
				{
					return;
				}
				this.<DeathStats>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.DeathStats);
			}
		}

		public BotStats()
		{
		}

		public BotStats(BotStats b)
		{
			this.EarnedCredits = b.EarnedCredits;
			this.Boxes = b.Boxes;
			this.Deaths = b.Deaths;
			this.EarnedEnergy = b.EarnedEnergy;
			this.EarnedExp = b.EarnedExp;
			this.EarnedHonor = b.EarnedHonor;
			this.EarnedJackpot = b.EarnedJackpot;
			this.Double_0 = b.Double_0;
			this.EarnedUridium = b.EarnedUridium;
			this.EarnedX1 = b.EarnedX1;
			this.EarnedX2 = b.EarnedX2;
			this.EarnedX3 = b.EarnedX3;
			this.EarnedX4 = b.EarnedX4;
			this.Spins = b.Spins;
		}

		protected void InternalRaiseChanged(string propertyName, PropertyChangedEventArgs args)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, args);
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}
	}
}

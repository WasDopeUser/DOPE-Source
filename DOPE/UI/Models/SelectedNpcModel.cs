using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using DarkorbitAPI;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;

namespace DOPE.UI.Models
{
	[Guid("7481B707-DD1F-45BA-AAC1-BFED30058532")]
	[DataContract]
	public class SelectedNpcModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate(object sender, PropertyChangedEventArgs e)
		{
		};

		[DataMember(Order = 1)]
		public int NpcId
		{
			[CompilerGenerated]
			get
			{
				return this.<NpcId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<NpcId>k__BackingField == value)
				{
					return;
				}
				this.<NpcId>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_61);
			}
		}

		[DataMember(Order = 2)]
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Name>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.Name);
			}
		}

		[DataMember(Order = 3)]
		[Layout(Description = "$Name")]
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return this.<Enabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Enabled>k__BackingField == value)
				{
					return;
				}
				this.<Enabled>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.Enabled);
			}
		}

		[Layout(Parent = "Enabled", Description = "Laser")]
		[DataMember(Order = 4)]
		[Category("Ammo")]
		public virtual LaserType Laser
		{
			[CompilerGenerated]
			get
			{
				return this.<Laser>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Laser>k__BackingField == value)
				{
					return;
				}
				this.<Laser>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_51);
			}
		}

		[DataMember(Order = 5)]
		[Layout(Parent = "Enabled", Description = "Rocket")]
		[Category("Ammo")]
		public virtual RocketType Rocket
		{
			[CompilerGenerated]
			get
			{
				return this.<Rocket>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Rocket>k__BackingField == value)
				{
					return;
				}
				this.<Rocket>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_71);
			}
		}

		[DataMember(Order = 6)]
		[Category("Ammo")]
		[Layout(Parent = "Enabled", Description = "Hellstorm")]
		public virtual HellstormType Hellstorm
		{
			[CompilerGenerated]
			get
			{
				return this.<Hellstorm>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Hellstorm>k__BackingField == value)
				{
					return;
				}
				this.<Hellstorm>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_47);
			}
		}

		[Layout(Description = "Override drone formation", Parent = "Enabled")]
		[DataMember(Order = 8)]
		public GEnum4 DroneFormation
		{
			[CompilerGenerated]
			get
			{
				return this.<DroneFormation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<DroneFormation>k__BackingField == value)
				{
					return;
				}
				this.<DroneFormation>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_20);
			}
		}

		[Layout(Description = "Config", Parent = "Enabled", RightDescription = "Set 0 to use the attack config")]
		[Range(0, 2)]
		[DataMember(Order = 9)]
		public int Config
		{
			[CompilerGenerated]
			get
			{
				return this.<Config>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Config>k__BackingField == value)
				{
					return;
				}
				this.<Config>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.Config);
			}
		}

		[Layout(Description = "Priority", Parent = "Enabled", CustomVisibility = "(obj,p) => p === undefined || !p.Name.startsWith('GG ')")]
		[Range(-1, 100)]
		[DataMember(Order = 10)]
		public int Priority
		{
			[CompilerGenerated]
			get
			{
				return this.<Priority>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Priority>k__BackingField == value)
				{
					return;
				}
				this.<Priority>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_68);
			}
		}

		[DataMember(Order = 11)]
		[Layout(Description = "Circle range", Parent = "Enabled", RightDescription = "Set below 350 to disable circling")]
		[Range(300, 675)]
		public int CircleRange
		{
			[CompilerGenerated]
			get
			{
				return this.<CircleRange>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<CircleRange>k__BackingField == value)
				{
					return;
				}
				this.<CircleRange>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_8);
			}
		}

		[Layout(Description = "Use Kamikaze", Parent = "Enabled", CustomVisibility = "(obj,p) => p !== undefined && p.Name.startsWith('GG ')")]
		[DataMember(Order = 12)]
		public bool UseKamikaze
		{
			[CompilerGenerated]
			get
			{
				return this.<UseKamikaze>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<UseKamikaze>k__BackingField == value)
				{
					return;
				}
				this.<UseKamikaze>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_97);
			}
		}

		[Layout(Description = "Ammo when in corner", CustomVisibility = "(obj,p) => p !== undefined && p.Name.startsWith('GG ')", Parent = "Enabled")]
		[DataMember(Order = 13)]
		public LaserType GgCornerLaser
		{
			[CompilerGenerated]
			get
			{
				return this.<GgCornerLaser>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<GgCornerLaser>k__BackingField == value)
				{
					return;
				}
				this.<GgCornerLaser>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_40);
			}
		}

		[DataMember(Order = 14)]
		[Layout(Description = "Use offensive ship ability", Parent = "Enabled", RightDescription = "Works with Venom and Diminisher")]
		public bool UseOffensiveAbility
		{
			[CompilerGenerated]
			get
			{
				return this.<UseOffensiveAbility>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<UseOffensiveAbility>k__BackingField == value)
				{
					return;
				}
				this.<UseOffensiveAbility>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_99);
			}
		}

		[DataMember(Order = 15)]
		[Layout(Description = "Use SAB-50", Parent = "Enabled")]
		public bool UseSab
		{
			[CompilerGenerated]
			get
			{
				return this.<UseSab>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<UseSab>k__BackingField == value)
				{
					return;
				}
				this.<UseSab>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.propertyChangedEventArgs_104);
			}
		}

		public void Fill()
		{
			if (this.CircleRange < 300 || this.CircleRange > 675)
			{
				this.CircleRange = SecurityManager.smethod_1(NpcUtils.NpcType.smethod_1(this.Name));
			}
		}

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

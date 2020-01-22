using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_63);
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
				this.<>OnPropertyChanged(Class7.Name);
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
				this.<>OnPropertyChanged(Class7.Enabled);
			}
		}

		[DataMember(Order = 4)]
		[Layout(Parent = "Enabled", Description = "Laser")]
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_52);
			}
		}

		[Category("Ammo")]
		[DataMember(Order = 5)]
		[Layout(Parent = "Enabled", Description = "Rocket")]
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_77);
			}
		}

		[DataMember(Order = 6)]
		[Layout(Parent = "Enabled", Description = "Hellstorm")]
		[Category("Ammo")]
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_45);
			}
		}

		[DataMember(Order = 8)]
		[Layout(Description = "Override drone formation", Parent = "Enabled")]
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_19);
			}
		}

		[DataMember(Order = 9)]
		[Layout(Description = "Config", Parent = "Enabled", RightDescription = "Set 0 to use the attack config")]
		[Range(0, 2)]
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
				this.<>OnPropertyChanged(Class7.Config);
			}
		}

		[Layout(Description = "Priority", Parent = "Enabled")]
		[DataMember(Order = 10)]
		[Range(-1, 100)]
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_70);
			}
		}

		[DataMember(Order = 11)]
		[Range(300, 675)]
		[Layout(Description = "Circle range", Parent = "Enabled", RightDescription = "Set below 350 to disable circling")]
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_8);
			}
		}

		[Layout(Description = "Use Kamikaze", Parent = "Enabled")]
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_102);
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_38);
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_104);
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_109);
			}
		}

		[DataMember(Order = 16)]
		[Layout(Description = "Ignore ownership", Parent = "Enabled")]
		public bool IgnoreOwnership
		{
			[CompilerGenerated]
			get
			{
				return this.<IgnoreOwnership>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IgnoreOwnership>k__BackingField == value)
				{
					return;
				}
				this.<IgnoreOwnership>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_47);
			}
		}

		[Layout(Description = "Use PET locator", Parent = "Enabled", RightDescription = "PET has to be already running", CustomVisibility = "(obj,p) => p === undefined || !p.Name.startsWith('GG ')")]
		[DataMember(Order = 17)]
		public bool UsePetLocator
		{
			[CompilerGenerated]
			get
			{
				return this.<UsePetLocator>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<UsePetLocator>k__BackingField == value)
				{
					return;
				}
				this.<UsePetLocator>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.eNkqwmwAyEm);
			}
		}

		[Layout(Description = "Group attack", Parent = "Enabled", RightDescription = "Assist will help group members with the NPC.\nIt also sets its priority to 50", CustomVisibility = "(obj,p) => p === undefined || !p.Name.startsWith('GG ')")]
		[DataMember(Order = 18)]
		public GroupAttackMode GroupAttackMode
		{
			[CompilerGenerated]
			get
			{
				return this.<GroupAttackMode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<GroupAttackMode>k__BackingField == value)
				{
					return;
				}
				this.<GroupAttackMode>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_39);
			}
		}

		[DataMember(Order = 19)]
		[Layout(Description = "Chase if fleeing", Parent = "Enabled", RightDescription = "Keeps attacking the NPC even if its HP drops below 25%.\nIts priority is set to +1", CustomVisibility = "(obj,p) => p !== undefined && p.Name.startsWith('GG ')")]
		public bool GG_ChaseFleeing
		{
			[CompilerGenerated]
			get
			{
				return this.<GG_ChaseFleeing>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<GG_ChaseFleeing>k__BackingField == value)
				{
					return;
				}
				this.<GG_ChaseFleeing>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_35);
			}
		}

		public void Fill()
		{
			if (this.CircleRange < 300 || this.CircleRange > 675)
			{
				this.CircleRange = SecurityManager.smethod_1(NpcUtils.NpcType.smethod_3(this.Name));
			}
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

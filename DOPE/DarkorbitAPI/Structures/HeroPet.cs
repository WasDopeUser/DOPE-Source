using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;

namespace DarkorbitAPI.Structures
{
	public class HeroPet : Pet
	{
		public bool IsEnabled
		{
			[CompilerGenerated]
			get
			{
				return this.<IsEnabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsEnabled>k__BackingField == value)
				{
					return;
				}
				this.<IsEnabled>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_32);
			}
		}

		public bool IsRepairNeeded
		{
			[CompilerGenerated]
			get
			{
				return this.<IsRepairNeeded>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsRepairNeeded>k__BackingField == value)
				{
					return;
				}
				this.<IsRepairNeeded>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_37);
			}
		}

		public bool IsAvailable
		{
			[CompilerGenerated]
			get
			{
				return this.<IsAvailable>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsAvailable>k__BackingField == value)
				{
					return;
				}
				this.<IsAvailable>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_30);
			}
		}

		public bool IsControlDisabled
		{
			[CompilerGenerated]
			get
			{
				return this.<IsControlDisabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsControlDisabled>k__BackingField == value)
				{
					return;
				}
				this.<IsControlDisabled>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_31);
			}
		}

		public int Fuel
		{
			[CompilerGenerated]
			get
			{
				return this.<Fuel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Fuel>k__BackingField == value)
				{
					return;
				}
				this.<Fuel>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_19);
			}
		}

		public double Experience
		{
			[CompilerGenerated]
			get
			{
				return this.<Experience>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Experience>k__BackingField == value)
				{
					return;
				}
				this.<Experience>k__BackingField = value;
				this.method_11(Class1.Experience);
			}
		}

		public PetMode Mode
		{
			[CompilerGenerated]
			get
			{
				return this.<Mode>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Mode>k__BackingField == value)
				{
					return;
				}
				this.<Mode>k__BackingField = value;
				this.method_11(Class1.Mode);
			}
		}

		public Dictionary<PetMode, GClass243> Modes
		{
			[CompilerGenerated]
			get
			{
				return this.<Modes>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Modes>k__BackingField, value))
				{
					return;
				}
				this.<Modes>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_59);
			}
		}

		public CooldownTracker<HeroPet.CooldownType> Cooldowns
		{
			[CompilerGenerated]
			get
			{
				return this.<Cooldowns>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Cooldowns>k__BackingField, value))
				{
					return;
				}
				this.<Cooldowns>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_11);
			}
		}

		public DateTimeOffset? EnabledSince
		{
			[CompilerGenerated]
			get
			{
				return this.<EnabledSince>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (Nullable.Equals<DateTimeOffset>(this.<EnabledSince>k__BackingField, value))
				{
					return;
				}
				this.<EnabledSince>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_14);
			}
		}

		public void method_13()
		{
			if (this.IsEnabled && this.EnabledSince == null)
			{
				this.EnabledSince = new DateTimeOffset?(DateTimeOffset.Now);
				return;
			}
			if (!this.IsEnabled)
			{
				this.EnabledSince = null;
			}
		}

		public void AjDviCwchL(GClass213 gclass213_0)
		{
			base.ClanTag = gclass213_0.string_0;
			base.FactionId = gclass213_0.int_2;
			base.Id = gclass213_0.emTnBfukst;
			base.OwnerId = gclass213_0.int_5;
			base.Name = gclass213_0.Name;
			base.Level = gclass213_0.int_1;
			this.PosX = gclass213_0.int_3;
			this.PosY = gclass213_0.XnanpDfuYR;
		}

		public bool method_14(PetMode petMode_0)
		{
			GClass243 gclass;
			return this.Modes.TryGetValue(petMode_0, out gclass) && gclass.Enabled;
		}

		public void method_15(GClass216 gclass216_0)
		{
			this.IsAvailable = true;
			this.Mode = (PetMode)gclass216_0.Mode.Mode;
		}

		public void method_16(GClass210 gclass210_0)
		{
			this.IsAvailable = true;
			this.Fuel = gclass210_0.int_0;
			base.Hp = gclass210_0.int_1;
		}

		public void method_17(GClass242 gclass242_0)
		{
			this.IsAvailable = true;
			this.IsEnabled = true;
			base.Hp = gclass242_0.int_2;
			base.HpMax = gclass242_0.int_5;
			base.Shield = gclass242_0.int_6;
			base.ShieldMax = gclass242_0.int_7;
			base.Level = gclass242_0.int_4;
			this.Experience = gclass242_0.Experience;
			this.Fuel = gclass242_0.int_8;
			base.Name = gclass242_0.Name;
			base.Id = gclass242_0.int_3;
		}

		public event Action KamikazeDeath;

		internal void method_18()
		{
			Action kamikazeDeath = this.KamikazeDeath;
			if (kamikazeDeath == null)
			{
				return;
			}
			kamikazeDeath();
		}

		internal void Clear()
		{
			this.IsAvailable = false;
			this.IsEnabled = false;
			this.IsControlDisabled = false;
			this.Modes.Clear();
			this.Mode = PetMode.Off;
			this.IsRepairNeeded = false;
		}

		public HeroPet()
		{
			Class8.xDph7tozmh5WD();
			this.<Modes>k__BackingField = new Dictionary<PetMode, GClass243>();
			this.<Cooldowns>k__BackingField = new CooldownTracker<HeroPet.CooldownType>();
			base..ctor();
		}

		public enum CooldownType
		{
			Kamikaze = 5
		}
	}
}

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.CommonStructures.Containers;
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
				this.method_10(Class5.propertyChangedEventArgs_5);
				this.method_10(Class5.propertyChangedEventArgs_41);
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
				this.method_10(Class5.propertyChangedEventArgs_47);
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
				this.method_10(Class5.propertyChangedEventArgs_38);
			}
		}

		public bool IsControlDisabled
		{
			get
			{
				return this._isControlDisabled;
			}
			set
			{
				if (this._isControlDisabled == value)
				{
					return;
				}
				this._isControlDisabled = value;
				this.method_10(Class5.propertyChangedEventArgs_40);
				if (value)
				{
					this.LastControlDisabled = DateTimeOffset.Now;
				}
			}
		}

		public DateTimeOffset LastControlDisabled
		{
			[CompilerGenerated]
			get
			{
				return this.<LastControlDisabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<LastControlDisabled>k__BackingField, value))
				{
					return;
				}
				this.<LastControlDisabled>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_54);
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
				this.method_10(Class5.propertyChangedEventArgs_25);
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
				this.method_10(Class5.Experience);
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
				this.method_10(Class5.Mode);
			}
		}

		public int ModeExtra
		{
			[CompilerGenerated]
			get
			{
				return this.<ModeExtra>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ModeExtra>k__BackingField == value)
				{
					return;
				}
				this.<ModeExtra>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_73);
			}
		}

		public Dictionary<PetMode, HeroPet.PetModeData> Modes
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
				this.method_10(Class5.propertyChangedEventArgs_5);
				this.method_10(Class5.propertyChangedEventArgs_74);
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
				this.method_10(Class5.propertyChangedEventArgs_5);
				this.method_10(Class5.propertyChangedEventArgs_13);
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
				this.method_10(Class5.propertyChangedEventArgs_16);
			}
		}

		public HeroPet.EnemyLocatorResult EnemyLocated
		{
			[CompilerGenerated]
			get
			{
				return this.<EnemyLocated>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<EnemyLocated>k__BackingField, value))
				{
					return;
				}
				this.<EnemyLocated>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_17);
			}
		}

		public EnemyLocatorResultCollection EnemyLocatedList { get; }

		public bool CanKamikaze
		{
			get
			{
				bool flag = this.Cooldowns.method_0(HeroPet.CooldownType.Kamikaze);
				if (this.IsEnabled)
				{
					flag &= (this.method_14(PetMode.Kamikaze) && base.HpPercentage <= 10f);
				}
				return flag;
			}
		}

		public HeroPet()
		{
			Class13.xnk8ImWzpOt04();
			this.<Modes>k__BackingField = new Dictionary<PetMode, HeroPet.PetModeData>();
			this.<Cooldowns>k__BackingField = new CooldownTracker<HeroPet.CooldownType>();
			this.EnemyLocatedList = new EnemyLocatorResultCollection();
			base..ctor();
		}

		public void method_12()
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

		public void method_13(GClass220 gclass220_0)
		{
			base.ClanTag = gclass220_0.string_0;
			base.FactionId = gclass220_0.int_4;
			base.Id = gclass220_0.int_1;
			base.OwnerId = gclass220_0.int_0;
			base.Name = gclass220_0.Name;
			base.Level = gclass220_0.int_6;
			this.PosX = gclass220_0.int_7;
			this.PosY = gclass220_0.int_8;
		}

		public bool method_14(PetMode petMode_0)
		{
			HeroPet.PetModeData petModeData;
			return this.Modes.TryGetValue(petMode_0, out petModeData) && petModeData.Data.Enabled;
		}

		public void method_15(GClass226 gclass226_0)
		{
			this.IsAvailable = true;
			if (this.Mode != (PetMode)gclass226_0.Mode.Mode)
			{
				this.ModeExtra = 0;
			}
			this.Mode = (PetMode)gclass226_0.Mode.Mode;
		}

		public void method_16(GClass217 gclass217_0)
		{
			this.IsAvailable = true;
			this.Fuel = gclass217_0.int_0;
		}

		public void method_17(GClass254 gclass254_0)
		{
			this.IsAvailable = true;
			this.IsEnabled = true;
			base.Hp = gclass254_0.int_2;
			base.HpMax = gclass254_0.int_3;
			base.Shield = gclass254_0.int_4;
			base.ShieldMax = gclass254_0.int_5;
			base.Level = gclass254_0.int_1;
			this.Experience = gclass254_0.Experience;
			this.Fuel = gclass254_0.int_6;
			base.Name = gclass254_0.Name;
			base.Id = gclass254_0.int_0;
		}

		public void method_18(GClass255 gclass255_0)
		{
			PetMode mode = (PetMode)gclass255_0.gclass256_0.Mode;
			HeroPet.PetModeData petModeData;
			if (!this.Modes.TryGetValue(mode, out petModeData))
			{
				petModeData = (this.Modes[mode] = new HeroPet.PetModeData(gclass255_0, mode));
			}
			petModeData.Data = gclass255_0;
		}

		public void method_19(GClass223 gclass223_0)
		{
			PetMode mode = (PetMode)gclass223_0.Mode.Mode;
			HeroPet.PetModeData petModeData;
			if (!this.Modes.TryGetValue(mode, out petModeData))
			{
				return;
			}
			petModeData.Extra = gclass223_0.vector_0;
		}

		public bool method_20(PetMode petMode_0, int int_0)
		{
			HeroPet.PetModeData petModeData;
			return this.Modes.TryGetValue(petMode_0, out petModeData) && petModeData.Extra.Contains(int_0);
		}

		internal void method_21(GClass222 gclass222_0)
		{
			this.EnemyLocated = new HeroPet.EnemyLocatorResult((this.Mode == PetMode.EnemyLocator) ? this.ModeExtra : 0, gclass222_0);
			this.EnemyLocatedList.method_0(this.EnemyLocated);
			Action<HeroPet, HeroPet.EnemyLocatorResult> enemyLocatorTick = this.EnemyLocatorTick;
			if (enemyLocatorTick == null)
			{
				return;
			}
			enemyLocatorTick(this, this.EnemyLocated);
		}

		public event Action KamikazeDeath;

		public event Action<HeroPet, HeroPet.EnemyLocatorResult> EnemyLocatorTick;

		internal void method_22()
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
			this.ModeExtra = 0;
			this.IsRepairNeeded = false;
		}

		private bool _isControlDisabled;

		public enum CooldownType
		{
			Kamikaze = 5
		}

		public class PetModeData
		{
			public PetMode Mode { get; set; }

			public List<int> Extra { get; set; }

			public GClass255 Data { get; set; }

			public PetModeData(GClass255 gclass255_0, PetMode petMode_0)
			{
				Class13.xnk8ImWzpOt04();
				base..ctor();
				this.Extra = new List<int>();
				this.Data = gclass255_0;
				this.Mode = petMode_0;
			}
		}

		public class EnemyLocatorResult
		{
			public DateTimeOffset Timestamp { get; private set; }

			public Vector2 Position { get; protected set; }

			public int Id { get; private set; }

			public bool Found { get; private set; }

			public NpcUtils.NpcType Type
			{
				get
				{
					return NpcUtils.NpcType.smethod_1(this.Id);
				}
			}

			public EnemyLocatorResult(int int_0, GClass222 gclass222_0)
			{
				Class13.xnk8ImWzpOt04();
				base..ctor();
				this.Timestamp = DateTimeOffset.Now;
				this.Id = int_0;
				if (gclass222_0.int_0 != -1 || gclass222_0.int_1 != -1)
				{
					this.Position = new Vector2((float)gclass222_0.int_0, (float)gclass222_0.int_1);
					this.Found = true;
				}
			}
		}
	}
}

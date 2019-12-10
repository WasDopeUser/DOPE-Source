using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Packets.Static;

namespace DarkorbitAPI.Structures
{
	public class Ship : MovingEntity, INotifyPropertyChanged
	{
		public Ship(int int_0, int int_1)
		{
			Class8.xDph7tozmh5WD();
			this.Modifiers = new ConcurrentDictionary<uint, GClass179>();
			base..ctor(int_0, int_1);
		}

		public Ship()
		{
			Class8.xDph7tozmh5WD();
			this..ctor(0, 0);
		}

		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Id>k__BackingField == value)
				{
					return;
				}
				this.<Id>k__BackingField = value;
				this.method_11(Class1.Id);
			}
		}

		public bool IsNpc
		{
			[CompilerGenerated]
			get
			{
				return this.<IsNpc>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsNpc>k__BackingField == value)
				{
					return;
				}
				this.<IsNpc>k__BackingField = value;
				this.method_11(Class1.ShieldPercentage);
				this.method_11(Class1.propertyChangedEventArgs_36);
			}
		}

		public virtual bool IsPlayer
		{
			get
			{
				return true;
			}
		}

		public int FactionId
		{
			[CompilerGenerated]
			get
			{
				return this.<FactionId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<FactionId>k__BackingField == value)
				{
					return;
				}
				this.<FactionId>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_16);
			}
		}

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
				this.method_11(Class1.Name);
			}
		}

		public bool Cloaked
		{
			[CompilerGenerated]
			get
			{
				return this.<Cloaked>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Cloaked>k__BackingField == value)
				{
					return;
				}
				this.<Cloaked>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_8);
			}
		}

		public string ClanTag
		{
			[CompilerGenerated]
			get
			{
				return this.<ClanTag>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ClanTag>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ClanTag>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_7);
			}
		}

		public string TypeId
		{
			[CompilerGenerated]
			get
			{
				return this.<TypeId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<TypeId>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<TypeId>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_88);
			}
		}

		public int ClanDiplomacy
		{
			[CompilerGenerated]
			get
			{
				return this.<ClanDiplomacy>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ClanDiplomacy>k__BackingField == value)
				{
					return;
				}
				this.<ClanDiplomacy>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_6);
			}
		}

		public DateTimeOffset LastStatUpdate
		{
			[CompilerGenerated]
			get
			{
				return this.<LastStatUpdate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<LastStatUpdate>k__BackingField, value))
				{
					return;
				}
				this.<LastStatUpdate>k__BackingField = value;
				this.method_11(Class1.eksiVioaupG);
			}
		}

		public DateTimeOffset LastTookDamage
		{
			[CompilerGenerated]
			get
			{
				return this.<LastTookDamage>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<LastTookDamage>k__BackingField, value))
				{
					return;
				}
				this.<LastTookDamage>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_48);
			}
		}

		public DateTimeOffset LastTookDamageHero
		{
			[CompilerGenerated]
			get
			{
				return this.<LastTookDamageHero>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<LastTookDamageHero>k__BackingField, value))
				{
					return;
				}
				this.<LastTookDamageHero>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_50);
			}
		}

		public DateTimeOffset LastAttacked
		{
			[CompilerGenerated]
			get
			{
				return this.<LastAttacked>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<LastAttacked>k__BackingField, value))
				{
					return;
				}
				this.<LastAttacked>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_41);
			}
		}

		public DateTimeOffset LastAttackedHero
		{
			[CompilerGenerated]
			get
			{
				return this.<LastAttackedHero>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<LastAttackedHero>k__BackingField, value))
				{
					return;
				}
				this.<LastAttackedHero>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_42);
			}
		}

		public int LastAttackedHeroDamage
		{
			[CompilerGenerated]
			get
			{
				return this.<LastAttackedHeroDamage>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<LastAttackedHeroDamage>k__BackingField == value)
				{
					return;
				}
				this.<LastAttackedHeroDamage>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_43);
			}
		}

		public DateTimeOffset LastTookDamageEnemy
		{
			[CompilerGenerated]
			get
			{
				return this.<LastTookDamageEnemy>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTimeOffset.Equals(this.<LastTookDamageEnemy>k__BackingField, value))
				{
					return;
				}
				this.<LastTookDamageEnemy>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_49);
			}
		}

		public int ShieldMax
		{
			[CompilerGenerated]
			get
			{
				return this.<ShieldMax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<ShieldMax>k__BackingField == value)
				{
					return;
				}
				this.<ShieldMax>k__BackingField = value;
				this.method_11(Class1.ShieldPercentage);
				this.method_11(Class1.ShieldDisplay);
				this.method_11(Class1.propertyChangedEventArgs_82);
			}
		}

		public int Shield
		{
			[CompilerGenerated]
			get
			{
				return this.<Shield>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Shield>k__BackingField == value)
				{
					return;
				}
				this.<Shield>k__BackingField = value;
				this.method_11(Class1.ShieldPercentage);
				this.method_11(Class1.ShieldDisplay);
				this.method_11(Class1.propertyChangedEventArgs_81);
			}
		}

		public int HpMax
		{
			[CompilerGenerated]
			get
			{
				return this.<HpMax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<HpMax>k__BackingField == value)
				{
					return;
				}
				this.<HpMax>k__BackingField = value;
				this.method_11(Class1.HpPercentage);
				this.method_11(Class1.HpDisplay);
				this.method_11(Class1.propertyChangedEventArgs_25);
			}
		}

		public int Hp
		{
			[CompilerGenerated]
			get
			{
				return this.<Hp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Hp>k__BackingField == value)
				{
					return;
				}
				this.<Hp>k__BackingField = value;
				this.method_11(Class1.HpPercentage);
				this.method_11(Class1.HpDisplay);
				this.method_11(Class1.propertyChangedEventArgs_24);
			}
		}

		public float HpPercentage
		{
			get
			{
				if (this.Hp != this.HpMax)
				{
					return (float)this.Hp * 100f / (float)(this.HpMax + 1);
				}
				return 100f;
			}
		}

		public float ShieldPercentage
		{
			get
			{
				if (this.Shield + (this.IsNpc ? 1 : 0) != this.ShieldMax)
				{
					return (float)this.Shield * 100f / (float)(this.ShieldMax + 1);
				}
				return 100f;
			}
		}

		public string HpDisplay
		{
			get
			{
				return string.Format("{0}/{1}", this.Hp, this.HpMax);
			}
		}

		public string ShieldDisplay
		{
			get
			{
				return string.Format("{0}/{1}", this.Shield, this.ShieldMax);
			}
		}

		public bool IsTaken
		{
			[CompilerGenerated]
			get
			{
				return this.<IsTaken>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				if (this.<IsTaken>k__BackingField == value)
				{
					return;
				}
				this.<IsTaken>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_38);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public virtual void Init(GClass251 gclass251_0)
		{
			this.PosX = gclass251_0.int_4;
			this.PosY = gclass251_0.int_1;
			this.IsNpc = gclass251_0.bool_1;
			this.FactionId = gclass251_0.int_7;
			this.Id = gclass251_0.int_8;
			this.TypeId = gclass251_0.string_3;
			this.ClanTag = gclass251_0.string_0;
			this.Cloaked = gclass251_0.bool_2;
			this.Name = gclass251_0.string_1;
			this.ClanDiplomacy = (int)gclass251_0.OgZjSfgjs8.uint_0;
			this.Modifiers.Clear();
			foreach (GClass179 gclass179_ in gclass251_0.vector_0)
			{
				this.ApplyModifier(gclass179_);
			}
			this.LastStatUpdate = DateTimeOffset.Now;
		}

		public virtual void ApplyModifier(GClass179 gclass179_0)
		{
			this.Modifiers[gclass179_0.uint_0] = gclass179_0;
		}

		public virtual bool HasModifier(uint uint_0, out GClass179 gclass179_0)
		{
			return this.Modifiers.TryGetValue(uint_0, out gclass179_0) && gclass179_0.Count > 0 && gclass179_0.bool_0;
		}

		public virtual bool HasModifier(EntityModifierType entityModifierType_0, out GClass179 gclass179_0)
		{
			return this.HasModifier((uint)entityModifierType_0, out gclass179_0);
		}

		public virtual void Init(GClass209 gclass209_0)
		{
			this.PosX = gclass209_0.VbQnreasOv;
			this.PosY = gclass209_0.int_8;
			this.IsNpc = false;
			this.FactionId = gclass209_0.int_5;
			this.Id = gclass209_0.int_6;
			this.TypeId = gclass209_0.string_1;
			this.ClanTag = gclass209_0.string_2;
			this.Cloaked = gclass209_0.bool_2;
			this.Hp = gclass209_0.int_2;
			this.HpMax = gclass209_0.int_13;
			this.Shield = gclass209_0.int_4;
			this.ShieldMax = gclass209_0.int_7;
			this.Name = gclass209_0.string_0;
			foreach (GClass179 gclass179_ in gclass209_0.vector_0)
			{
				this.ApplyModifier(gclass179_);
			}
			this.LastStatUpdate = DateTimeOffset.Now;
		}

		public bool method_8(Hero hero_0)
		{
			if (this.IsPlayer)
			{
				if (this.FactionId != hero_0.FactionId && this.ClanDiplomacy != 1)
				{
					if (this.ClanDiplomacy != 2)
					{
						return true;
					}
				}
				return this.ClanDiplomacy == 3;
			}
			return false;
		}

		public bool method_9(Hero hero_0)
		{
			return this.IsNpc || this.method_8(hero_0);
		}

		internal void method_10(Map map_0, Ship ship_0, Ship ship_1, int int_0, uint uint_0)
		{
			Map.Delegates.ShipAttackHandler shipAttacked = this.ShipAttacked;
			if (shipAttacked == null)
			{
				return;
			}
			shipAttacked(map_0, ship_0, ship_1, int_0, uint_0);
		}

		protected void method_11(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, propertyChangedEventArgs_0);
		}

		public event Map.Delegates.ShipAttackHandler ShipAttacked;

		// Note: this type is marked as 'beforefieldinit'.
		static Ship()
		{
			Class8.xDph7tozmh5WD();
			Ship.Default = new Ship();
		}

		public static Ship Default;

		public readonly ConcurrentDictionary<uint, GClass179> Modifiers;
	}
}

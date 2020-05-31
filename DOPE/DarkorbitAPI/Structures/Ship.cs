using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Packets.Static;

namespace DarkorbitAPI.Structures
{
	public class Ship : MovingEntity, INotifyPropertyChanged
	{
		public Ship(int int_0, int int_1)
		{
			Class13.NP5bWyNzLwONS();
			this.Modifiers = new ConcurrentDictionary<uint, GClass187>();
			this.Effects = new HashSet<string>();
			base..ctor(int_0, int_1);
		}

		public Ship()
		{
			Class13.NP5bWyNzLwONS();
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
				this.method_10(Class5.Id);
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
				this.method_10(Class5.ShieldPercentage);
				this.method_10(Class5.propertyChangedEventArgs_45);
			}
		}

		public virtual bool IsPlayer
		{
			get
			{
				return true;
			}
		}

		public override bool CanMove
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
				this.method_10(Class5.propertyChangedEventArgs_23);
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
				this.method_10(Class5.Name);
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
				this.method_10(Class5.propertyChangedEventArgs_11);
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
				this.method_10(Class5.propertyChangedEventArgs_10);
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
				this.method_10(Class5.propertyChangedEventArgs_108);
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
				this.method_10(Class5.propertyChangedEventArgs_9);
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
				this.method_10(Class5.propertyChangedEventArgs_58);
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
				this.method_10(Class5.propertyChangedEventArgs_59);
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
				this.method_10(Class5.propertyChangedEventArgs_62);
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
				this.method_10(Class5.propertyChangedEventArgs_48);
			}
		}

		public int LastTookDamageFrom
		{
			[CompilerGenerated]
			get
			{
				return this.<LastTookDamageFrom>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<LastTookDamageFrom>k__BackingField == value)
				{
					return;
				}
				this.<LastTookDamageFrom>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_61);
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
				this.method_10(Class5.propertyChangedEventArgs_49);
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
				this.method_10(Class5.propertyChangedEventArgs_50);
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
				this.method_10(Class5.propertyChangedEventArgs_60);
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
				this.method_10(Class5.ShieldPercentage);
				this.method_10(Class5.ShieldDisplay);
				this.method_10(Class5.propertyChangedEventArgs_99);
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
				this.method_10(Class5.ShieldPercentage);
				this.method_10(Class5.ShieldDisplay);
				this.method_10(Class5.propertyChangedEventArgs_98);
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
				this.method_10(Class5.HpPercentage);
				this.method_10(Class5.HpDisplay);
				this.method_10(Class5.propertyChangedEventArgs_31);
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
				this.method_10(Class5.HpPercentage);
				this.method_10(Class5.HpDisplay);
				this.method_10(Class5.propertyChangedEventArgs_30);
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

		public int TargetId
		{
			[CompilerGenerated]
			get
			{
				return this.<TargetId>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				if (this.<TargetId>k__BackingField == value)
				{
					return;
				}
				this.<TargetId>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_106);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public virtual void Init(GClass269 gclass269_0)
		{
			this.PosX = gclass269_0.int_1;
			this.PosY = gclass269_0.int_6;
			this.IsNpc = gclass269_0.bool_0;
			this.FactionId = gclass269_0.int_8;
			this.Id = gclass269_0.int_2;
			this.TypeId = gclass269_0.string_0;
			this.ClanTag = gclass269_0.string_2;
			this.Cloaked = gclass269_0.bool_3;
			this.Name = gclass269_0.string_1;
			this.ClanDiplomacy = (int)gclass269_0.gclass139_0.uint_0;
			this.Modifiers.Clear();
			this.Effects.Clear();
			foreach (GClass187 gclass187_ in gclass269_0.vector_0)
			{
				this.ApplyModifier(gclass187_);
			}
			this.LastStatUpdate = DateTimeOffset.Now;
		}

		public virtual void ApplyModifier(GClass187 gclass187_0)
		{
			this.Modifiers[gclass187_0.uint_0] = gclass187_0;
		}

		public virtual void StartEffect(string string_0)
		{
			this.Effects.Add(string_0);
		}

		public virtual void EndEffect(string string_0)
		{
			this.Effects.Remove(string_0);
		}

		public virtual bool HasModifier(uint uint_0, out GClass187 gclass187_0)
		{
			return this.Modifiers.TryGetValue(uint_0, out gclass187_0) && gclass187_0.Count > 0 && gclass187_0.bool_0;
		}

		public virtual bool HasModifier(EntityModifierType entityModifierType_0, out GClass187 gclass187_0)
		{
			return this.HasModifier((uint)entityModifierType_0, out gclass187_0);
		}

		public virtual void Init(GClass220 gclass220_0)
		{
			this.PosX = gclass220_0.int_13;
			this.PosY = gclass220_0.int_17;
			this.IsNpc = false;
			this.FactionId = gclass220_0.int_0;
			this.Id = gclass220_0.int_7;
			this.TypeId = gclass220_0.string_0;
			this.ClanTag = gclass220_0.PqfpYrsegr;
			this.Cloaked = gclass220_0.bool_1;
			this.Hp = gclass220_0.int_2;
			this.HpMax = gclass220_0.int_14;
			this.Shield = gclass220_0.int_12;
			this.ShieldMax = gclass220_0.int_1;
			this.Name = gclass220_0.string_1;
			this.Modifiers.Clear();
			this.Effects.Clear();
			foreach (GClass187 gclass187_ in gclass220_0.vector_0)
			{
				this.ApplyModifier(gclass187_);
			}
			this.LastStatUpdate = DateTimeOffset.Now;
		}

		public bool method_7(Hero hero_0)
		{
			return this.IsPlayer && ((this.FactionId != hero_0.FactionId && this.ClanDiplomacy != 1 && this.ClanDiplomacy != 2) || this.ClanDiplomacy == 3) && !hero_0.Group.jYrndIqmin(this.Id);
		}

		public bool method_8(Hero hero_0)
		{
			return this.IsNpc || this.method_7(hero_0);
		}

		internal void method_9(Map map_0, Ship ship_0, Ship ship_1, int int_0, uint uint_0)
		{
			Map.Delegates.ShipAttackHandler shipAttacked = this.ShipAttacked;
			if (shipAttacked == null)
			{
				return;
			}
			shipAttacked(map_0, ship_0, ship_1, int_0, uint_0);
		}

		protected void method_10(PropertyChangedEventArgs propertyChangedEventArgs_0)
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
			Class13.NP5bWyNzLwONS();
			Ship.Default = new Ship();
		}

		public static Ship Default;

		public readonly ConcurrentDictionary<uint, GClass187> Modifiers;

		public readonly HashSet<string> Effects;
	}
}

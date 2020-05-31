using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace DarkorbitAPI.Structures
{
	public class NpcShip : Ship
	{
		public NpcUtils.NpcType Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Type>k__BackingField, value))
				{
					return;
				}
				this.<Type>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_107);
			}
		}

		public int LeashedBy
		{
			get
			{
				if (this._leashedBy == 0 && base.LastTookDamage.smethod_0(5000))
				{
					return base.LastTookDamageFrom;
				}
				return this._leashedBy;
			}
			set
			{
				if (this._leashedBy == value)
				{
					return;
				}
				this._leashedBy = value;
				this.method_10(Class5.propertyChangedEventArgs_63);
			}
		}

		public int Range
		{
			[CompilerGenerated]
			get
			{
				return this.<Range>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Range>k__BackingField == value)
				{
					return;
				}
				this.<Range>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_81);
			}
		}

		public int RangeFix
		{
			[CompilerGenerated]
			get
			{
				return this.<RangeFix>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<RangeFix>k__BackingField == value)
				{
					return;
				}
				this.<RangeFix>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_82);
			}
		}

		public int LastDistance
		{
			[CompilerGenerated]
			get
			{
				return this.<LastDistance>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<LastDistance>k__BackingField == value)
				{
					return;
				}
				this.<LastDistance>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_55);
			}
		}

		public override bool IsPlayer
		{
			get
			{
				return false;
			}
		}

		public Vector2 MovementSource
		{
			get
			{
				return base.StartPosition;
			}
		}

		public override void Init(GClass269 gclass269_0)
		{
			base.Init(gclass269_0);
			if (gclass269_0.bool_0)
			{
				this.Type = NpcUtils.NpcType.smethod_4(base.Name);
			}
			this.Range = SecurityManager.smethod_3(this);
		}

		public NpcShip()
		{
			Class13.NP5bWyNzLwONS();
			base..ctor();
		}

		private int _leashedBy;
	}
}

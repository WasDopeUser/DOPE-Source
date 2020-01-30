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
				this.method_11(Class5.propertyChangedEventArgs_108);
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
				this.method_11(Class5.propertyChangedEventArgs_64);
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
				this.method_11(Class5.propertyChangedEventArgs_82);
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
				this.method_11(Class5.propertyChangedEventArgs_83);
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
				this.method_11(Class5.propertyChangedEventArgs_56);
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

		public override void Init(GClass265 gclass265_0)
		{
			base.Init(gclass265_0);
			if (gclass265_0.bool_3)
			{
				this.Type = NpcUtils.NpcType.smethod_3(base.Name);
			}
			this.Range = SecurityManager.smethod_3(this);
		}

		public NpcShip()
		{
			Class13.Gj4N3WdzaR1LY();
			base..ctor();
		}

		private int _leashedBy;
	}
}

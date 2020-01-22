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
				this.LmrdRxWejv(Class5.propertyChangedEventArgs_101);
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
				this.LmrdRxWejv(Class5.propertyChangedEventArgs_59);
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
				this.LmrdRxWejv(Class5.propertyChangedEventArgs_76);
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
				this.LmrdRxWejv(Class5.propertyChangedEventArgs_77);
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
				this.LmrdRxWejv(Class5.yrFqpDhyfno);
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
			if (gclass265_0.bool_0)
			{
				this.Type = NpcUtils.NpcType.smethod_3(base.Name);
			}
			this.Range = SecurityManager.smethod_3(this);
		}

		public NpcShip()
		{
			Class13.plZSWFPzBWWEZ();
			base..ctor();
		}

		private int _leashedBy;
	}
}

using System;
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
				this.method_11(Class1.propertyChangedEventArgs_87);
			}
		}

		public int LeashedBy
		{
			[CompilerGenerated]
			get
			{
				return this.<LeashedBy>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<LeashedBy>k__BackingField == value)
				{
					return;
				}
				this.<LeashedBy>k__BackingField = value;
				this.method_11(Class1.propertyChangedEventArgs_51);
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
				this.method_11(Class1.propertyChangedEventArgs_65);
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
				this.method_11(Class1.propertyChangedEventArgs_66);
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
				this.method_11(Class1.jjEiuzciDnu);
			}
		}

		public override bool IsPlayer
		{
			get
			{
				return false;
			}
		}

		public override void Init(GClass251 gclass251_0)
		{
			base.Init(gclass251_0);
			if (gclass251_0.bool_1)
			{
				this.Type = NpcUtils.NpcType.smethod_1(base.Name);
			}
			this.Range = SecurityManager.smethod_3(this);
		}

		public NpcShip()
		{
			Class8.xDph7tozmh5WD();
			base..ctor();
		}
	}
}

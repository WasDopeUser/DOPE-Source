using System;
using System.Runtime.CompilerServices;

namespace DarkorbitAPI.Structures
{
	public class Pet : Ship
	{
		public int OwnerId
		{
			[CompilerGenerated]
			get
			{
				return this.<OwnerId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<OwnerId>k__BackingField == value)
				{
					return;
				}
				this.<OwnerId>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_76);
			}
		}

		public int Level
		{
			[CompilerGenerated]
			get
			{
				return this.<Level>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Level>k__BackingField == value)
				{
					return;
				}
				this.<Level>k__BackingField = value;
				this.method_10(Class5.propertyChangedEventArgs_64);
			}
		}

		public override bool IsPlayer
		{
			get
			{
				return false;
			}
		}

		public void method_11(GClass259 gclass259_0)
		{
			this.OwnerId = gclass259_0.int_5;
			base.Id = gclass259_0.int_3;
			this.Level = gclass259_0.int_7;
			base.Name = gclass259_0.Name;
			this.PosX = gclass259_0.int_1;
			this.PosY = gclass259_0.int_6;
			base.ClanTag = gclass259_0.string_0;
			base.FactionId = gclass259_0.int_8;
		}

		public Pet()
		{
			Class13.NP5bWyNzLwONS();
			base..ctor();
		}
	}
}

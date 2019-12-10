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
				this.method_11(Class1.propertyChangedEventArgs_62);
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
				this.method_11(Class1.propertyChangedEventArgs_52);
			}
		}

		public override bool IsPlayer
		{
			get
			{
				return false;
			}
		}

		public void method_12(GClass241 gclass241_0)
		{
			this.OwnerId = gclass241_0.int_9;
			base.Id = gclass241_0.int_7;
			this.Level = gclass241_0.int_6;
			base.Name = gclass241_0.Name;
			this.PosX = gclass241_0.int_5;
			this.PosY = gclass241_0.int_4;
			base.ClanTag = gclass241_0.string_0;
			base.FactionId = gclass241_0.int_8;
		}

		public Pet()
		{
			Class8.xDph7tozmh5WD();
			base..ctor();
		}
	}
}

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
				this.method_11(Class5.propertyChangedEventArgs_80);
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
				this.method_11(Class5.propertyChangedEventArgs_68);
			}
		}

		public override bool IsPlayer
		{
			get
			{
				return false;
			}
		}

		public void method_12(GClass253 gclass253_0)
		{
			this.OwnerId = gclass253_0.int_0;
			base.Id = gclass253_0.int_1;
			this.Level = gclass253_0.int_6;
			base.Name = gclass253_0.Name;
			this.PosX = gclass253_0.int_7;
			this.PosY = gclass253_0.int_8;
			base.ClanTag = gclass253_0.string_0;
			base.FactionId = gclass253_0.int_4;
		}

		public Pet()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}
	}
}

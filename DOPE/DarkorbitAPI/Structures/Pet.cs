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
				this.method_11(Class5.propertyChangedEventArgs_79);
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
				this.method_11(Class5.propertyChangedEventArgs_67);
			}
		}

		public override bool IsPlayer
		{
			get
			{
				return false;
			}
		}

		public void method_12(GClass254 gclass254_0)
		{
			this.OwnerId = gclass254_0.int_0;
			base.Id = gclass254_0.int_1;
			this.Level = gclass254_0.int_6;
			base.Name = gclass254_0.Name;
			this.PosX = gclass254_0.int_7;
			this.PosY = gclass254_0.int_8;
			base.ClanTag = gclass254_0.string_0;
			base.FactionId = gclass254_0.int_4;
		}

		public Pet()
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor();
		}
	}
}

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
				this.method_11(Class5.propertyChangedEventArgs_74);
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
				this.method_11(Class5.propertyChangedEventArgs_63);
			}
		}

		public override bool IsPlayer
		{
			get
			{
				return false;
			}
		}

		public void method_12(GClass255 gclass255_0)
		{
			this.OwnerId = gclass255_0.int_0;
			base.Id = gclass255_0.int_9;
			this.Level = gclass255_0.int_8;
			base.Name = gclass255_0.Name;
			this.PosX = gclass255_0.int_5;
			this.PosY = gclass255_0.int_6;
			base.ClanTag = gclass255_0.string_0;
			base.FactionId = gclass255_0.int_3;
		}

		public Pet()
		{
			Class13.igxcIukzfpare();
			base..ctor();
		}
	}
}

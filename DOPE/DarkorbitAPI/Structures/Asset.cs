using System;
using System.Drawing;

namespace DarkorbitAPI.Structures
{
	public class Asset : Entity, ICollidable, IInteractible
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string ClanTag { get; set; }

		public int FactionId { get; set; }

		public int ClanDiplomacy { get; set; }

		public AssetType AssetType { get; set; }

		public bool Activatable { get; set; }

		public bool Activated { get; set; }

		public int Shape
		{
			get
			{
				return 2;
			}
		}

		public bool Active
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		protected Rectangle Hitbox { get; set; }

		public Asset(int int_0, int int_1)
		{
			Class8.xDph7tozmh5WD();
			base..ctor(int_0, int_1);
		}

		public void method_0(GClass122 gclass122_0)
		{
			this.PosX = gclass122_0.int_3;
			this.PosY = gclass122_0.int_0;
			this.Id = gclass122_0.int_1;
			this.Name = gclass122_0.string_0;
			this.ClanTag = gclass122_0.string_1;
			this.FactionId = gclass122_0.int_5;
			this.ClanDiplomacy = (int)gclass122_0.gclass135_0.uint_0;
			this.AssetType = (AssetType)gclass122_0.gclass126_0.uint_0;
		}

		public bool method_1(Hero hero_0)
		{
			return this.FactionId != 0 && (this.ClanDiplomacy == 3 || (hero_0.FactionId != this.FactionId && this.ClanDiplomacy != 1 && this.ClanDiplomacy != 2));
		}

		public bool method_2(Hero hero_0)
		{
			return this.FactionId != 0 && this.ClanDiplomacy != 3 && (hero_0.FactionId == this.FactionId || this.ClanDiplomacy == 1 || this.ClanDiplomacy == 2);
		}

		public virtual CollidableType imethod_0(Map map_0)
		{
			return CollidableType.None;
		}

		public virtual Rectangle imethod_1()
		{
			return this.Hitbox;
		}
	}
}

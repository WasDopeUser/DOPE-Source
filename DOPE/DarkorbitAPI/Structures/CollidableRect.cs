using System;
using System.Drawing;
using DarkorbitAPI.Structures.Pathing;

namespace DarkorbitAPI.Structures
{
	public class CollidableRect : Collidable
	{
		public Rectangle Rect { get; set; }

		public CollidableRect(string string_0, bool bool_0, int int_0, int int_1, int int_2, int int_3, CollidableType collidableType_0)
		{
			Class13.NP5bWyNzLwONS();
			base..ctor(collidableType_0, 2, string_0);
			base.Shape = 2;
			base.Active = bool_0;
			base.Name = string_0;
			this.Rect = MapGrid.smethod_2(int_0 - 50, int_1 - 50, int_2 + 100, int_3 + 100);
		}

		public override Rectangle imethod_1()
		{
			return this.Rect;
		}

		public override CollidableType imethod_0(Map map_0)
		{
			if (!base.Active)
			{
				return CollidableType.None;
			}
			return CollidableType.Wall;
		}
	}
}

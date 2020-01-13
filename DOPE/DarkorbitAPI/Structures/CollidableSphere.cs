using System;
using System.Drawing;
using System.Numerics;
using DarkorbitAPI.Structures.Pathing;

namespace DarkorbitAPI.Structures
{
	public class CollidableSphere : Collidable
	{
		public Vector2 Center { get; set; }

		public int Radius { get; set; }

		public CollidableSphere(CollidableType collidableType_0, string string_0, Vector2 vector2_0, int int_0)
		{
			Class13.tMHx78BzgCM8j();
			base..ctor(collidableType_0, 0, string_0);
			this.Center = vector2_0;
			this.Radius = int_0;
		}

		public override Rectangle imethod_1()
		{
			return Rectangle.Empty;
		}

		public override CollidableType imethod_0(Map map_0)
		{
			return CollidableType.None;
		}
	}
}

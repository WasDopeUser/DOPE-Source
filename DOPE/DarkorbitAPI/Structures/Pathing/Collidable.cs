using System;
using System.Drawing;

namespace DarkorbitAPI.Structures.Pathing
{
	public abstract class Collidable : ICollidable
	{
		public string Name { get; set; }

		public int Shape { get; set; }

		public CollidableType Type { get; set; }

		public bool Active { get; set; }

		public Collidable(CollidableType collidableType_0, int int_0, string string_0)
		{
			Class13.igxcIukzfpare();
			base..ctor();
			this.Type = collidableType_0;
			this.Shape = int_0;
			this.Name = string_0;
		}

		public abstract Rectangle imethod_1();

		public virtual CollidableType imethod_0(Map map_0)
		{
			if (!this.Active)
			{
				return CollidableType.None;
			}
			return this.Type;
		}
	}
}

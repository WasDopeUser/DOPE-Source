using System;
using DarkorbitAPI.Structures.Pathing;

namespace DarkorbitAPI.Structures
{
	public class BattlestationModule : Asset
	{
		public BattlestationModule(int int_0, int int_1)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor(int_0, int_1);
			base.Hitbox = MapGrid.smethod_2(int_0 - 650, int_1 - 650, 1300, 1300);
		}

		public override CollidableType imethod_0(Map map_0)
		{
			if (!base.method_1(map_0.Hero))
			{
				return CollidableType.None;
			}
			return CollidableType.EnemyStructure;
		}
	}
}

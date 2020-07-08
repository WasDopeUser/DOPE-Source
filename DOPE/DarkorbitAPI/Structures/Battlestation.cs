using System;
using DarkorbitAPI.Structures.Pathing;

namespace DarkorbitAPI.Structures
{
	public class Battlestation : Asset
	{
		public bool IsDeployed
		{
			get
			{
				return base.AssetType == AssetType.Battlestation;
			}
		}

		public Battlestation(int int_0, int int_1)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor(int_0, int_1);
			base.Hitbox = MapGrid.smethod_2(int_0 - 600, int_1 - 600, 1200, 1200);
		}

		public override CollidableType imethod_0(Map map_0)
		{
			if (base.method_1(map_0.Hero))
			{
				return CollidableType.EnemyStructure;
			}
			return CollidableType.None;
		}
	}
}

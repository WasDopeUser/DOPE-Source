using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;

public class GClass827 : GClass821
{
	private GClass817 Module { get; }

	public GClass827(GClass810 gclass810_1, GClass817 gclass817_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(gclass810_1);
		this.Module = gclass817_1;
	}

	public override bool vmethod_15(GClass812 gclass812_0)
	{
		return gclass812_0 == this.Module;
	}

	public override bool vmethod_6(NpcShip npcShip_0)
	{
		NpcUtils.NpcType type = npcShip_0.Type;
		return (((type != null) ? type.Class : null) == NpcUtils.N_Cubikon || Vector2.Distance(this.Module.BestSpawn, npcShip_0.Position) < 800f) && base.vmethod_6(npcShip_0);
	}

	public override bool vmethod_9(Collectible collectible_0)
	{
		return Vector2.Distance(this.Module.BestSpawn, collectible_0.Position) < 800f && base.vmethod_9(collectible_0);
	}

	public override bool vmethod_19()
	{
		Vector2 position = base.Hero.Position;
		Vector2 bestSpawn = this.Module.BestSpawn;
		base.C.RoamTarget = bestSpawn;
		return Vector2.Distance(position, bestSpawn) < 100f;
	}

	[CompilerGenerated]
	private readonly GClass817 gclass817_0;
}

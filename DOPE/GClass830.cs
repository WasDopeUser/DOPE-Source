using System;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;

public class GClass830 : GClass829
{
	public GClass830(GClass824 gclass824_1, TargetMap targetMap_1)
	{
		Class13.igxcIukzfpare();
		base..ctor(gclass824_1, targetMap_1, "S", int.MinValue);
	}

	protected override void OnStopping()
	{
		if (base.C.State == BotState.Hunt && base.C.EnemyTarget != null)
		{
			this.ship_0 = base.C.EnemyTarget;
		}
		else
		{
			this.ship_0 = null;
		}
		base.OnStopping();
	}

	public override bool CheckStopped()
	{
		return this.ship_0 == null || base.C.EnemyTarget != this.ship_0 || base.C.Map.SelectedShip != this.ship_0;
	}

	private Ship ship_0;
}

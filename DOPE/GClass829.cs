using System;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;

public class GClass829 : GClass828
{
	public GClass829(GClass823 gclass823_1, TargetMap targetMap_1)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(gclass823_1, targetMap_1, "S", int.MinValue);
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

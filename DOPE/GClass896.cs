using System;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;

public class GClass896 : GClass895
{
	public override bool IsInterruptible
	{
		get
		{
			return true;
		}
	}

	public GClass896(GClass890 gclass890_1, TargetMap targetMap_1)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor(gclass890_1, targetMap_1, "S", int.MinValue);
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

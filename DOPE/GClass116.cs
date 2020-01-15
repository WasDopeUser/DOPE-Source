using System;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass116 : GInterface4
{
	public GClass116()
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
	}

	public Map Map
	{
		get
		{
			return ConnectionManager.Instance.Value.Game.Map;
		}
	}

	public void method_0(GClass126 gclass126_0)
	{
		Map map = ConnectionManager.Instance.Value.Game.Map;
		Asset asset;
		if (gclass126_0.gclass130_0.uint_0 != 35U)
		{
			if (gclass126_0.gclass130_0.uint_0 != 36U)
			{
				if (gclass126_0.gclass130_0.uint_0 == 37U)
				{
					asset = new BattlestationModule(gclass126_0.int_5, gclass126_0.UaDsQsiKsT);
					goto IL_89;
				}
				asset = new Asset(gclass126_0.int_5, gclass126_0.UaDsQsiKsT);
				goto IL_89;
			}
		}
		asset = (map.Battlestation = new Battlestation(gclass126_0.int_5, gclass126_0.UaDsQsiKsT));
		IL_89:
		if (asset != null)
		{
			asset.method_0(gclass126_0);
			map.Assets[gclass126_0.int_0] = asset;
			ICollidable collidable = asset;
			if (collidable != null)
			{
				map.Collidables[gclass126_0.string_1] = collidable;
			}
			map.Grid.method_11(asset);
		}
	}

	public void method_1(GClass190 gclass190_0)
	{
		this.Map.method_13(gclass190_0);
	}

	public void method_2(GClass191 gclass191_0)
	{
		this.Map.method_14(gclass191_0);
	}

	public void method_3(GClass246 gclass246_0)
	{
		this.Map.method_21(gclass246_0);
	}

	public void method_4(GClass248 gclass248_0)
	{
		this.Map.method_22(gclass248_0);
	}

	public void method_5(GClass181 gclass181_0)
	{
		this.Map.method_10(gclass181_0);
	}

	public void method_6(GClass268 gclass268_0)
	{
		this.Map.method_17(gclass268_0);
	}

	public void method_7(GClass267 gclass267_0)
	{
		this.Map.method_23(gclass267_0);
	}

	public void method_8(GClass270 gclass270_0)
	{
		this.Map.SelectedShip = null;
	}

	public void method_9(GClass185 gclass185_0)
	{
		GClass116.<>c__DisplayClass12_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass185_0 = gclass185_0;
		Gate iinteractible_;
		if (this.Map.Gates.TryGetValue(CS$<>8__locals1.gclass185_0.Id, out iinteractible_))
		{
			GClass116.smethod_0(iinteractible_, ref CS$<>8__locals1);
		}
		Asset iinteractible_2;
		if (this.Map.Assets.TryGetValue(CS$<>8__locals1.gclass185_0.Id, out iinteractible_2))
		{
			GClass116.smethod_0(iinteractible_2, ref CS$<>8__locals1);
			return;
		}
	}

	public void method_10(GClass186 gclass186_0)
	{
		this.Map.method_19(gclass186_0);
	}

	public void cBsrhsSiu4(GClass180 gclass180_0)
	{
		this.Map.method_9(gclass180_0);
	}

	public void method_11(GClass140 gclass140_0)
	{
		this.Map.method_12(gclass140_0);
	}

	public void method_12(GClass264 gclass264_0)
	{
		this.Map.method_18(gclass264_0);
	}

	public void method_13(GClass266 gclass266_0)
	{
		this.Map.method_16(gclass266_0);
	}

	public void NcGrinjmaP(GClass265 gclass265_0)
	{
		this.Map.method_15(gclass265_0);
	}

	public void method_14(GClass255 gclass255_0)
	{
		this.Map.bMujwOvUqA(gclass255_0);
	}

	public void method_15(GClass240 gclass240_0)
	{
		this.Map.method_24(gclass240_0);
	}

	public void method_16(GClass249 gclass249_0)
	{
		this.Map.method_25(gclass249_0);
		if (gclass249_0.string_0.StartsWith("group_ping"))
		{
			this.Map.Hero.Group.method_0(gclass249_0);
		}
	}

	[CompilerGenerated]
	internal static bool smethod_0(IInteractible iinteractible_0, ref GClass116.<>c__DisplayClass12_0 <>c__DisplayClass12_0_0)
	{
		if (iinteractible_0.Id == <>c__DisplayClass12_0_0.gclass185_0.Id)
		{
			iinteractible_0.Activatable = <>c__DisplayClass12_0_0.gclass185_0.bool_0;
			iinteractible_0.Activated = (<>c__DisplayClass12_0_0.gclass185_0.State == 0U);
			return true;
		}
		return false;
	}
}

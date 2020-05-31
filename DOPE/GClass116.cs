using System;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass116 : GInterface4
{
	public GClass116()
	{
		Class13.NP5bWyNzLwONS();
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
					asset = new BattlestationModule(gclass126_0.int_5, gclass126_0.int_3);
					goto IL_89;
				}
				asset = new Asset(gclass126_0.int_5, gclass126_0.int_3);
				goto IL_89;
			}
		}
		asset = (map.Battlestation = new Battlestation(gclass126_0.int_5, gclass126_0.int_3));
		IL_89:
		if (asset != null)
		{
			asset.method_0(gclass126_0);
			map.Assets[gclass126_0.int_6] = asset;
			ICollidable collidable = asset;
			if (collidable != null)
			{
				map.Collidables[gclass126_0.string_1] = collidable;
			}
			map.Grid.method_9(asset);
		}
	}

	public void method_1(GClass191 gclass191_0)
	{
		this.Map.method_13(gclass191_0);
	}

	public void method_2(GClass192 gclass192_0)
	{
		this.Map.method_14(gclass192_0);
	}

	public void method_3(GClass247 gclass247_0)
	{
		this.Map.method_24(gclass247_0);
	}

	public void method_4(GClass249 gclass249_0)
	{
		this.Map.method_25(gclass249_0);
	}

	public void method_5(GClass182 gclass182_0)
	{
		this.Map.method_10(gclass182_0);
	}

	public void method_6(GClass272 gclass272_0)
	{
		this.Map.method_17(gclass272_0);
	}

	public void method_7(GClass271 gclass271_0)
	{
		this.Map.method_26(gclass271_0);
	}

	public void method_8(GClass274 gclass274_0)
	{
		this.Map.SelectedShip = null;
	}

	public void method_9(GClass186 gclass186_0)
	{
		GClass116.<>c__DisplayClass12_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass186_0 = gclass186_0;
		Gate iinteractible_;
		if (this.Map.Gates.TryGetValue(CS$<>8__locals1.gclass186_0.Id, out iinteractible_))
		{
			GClass116.smethod_0(iinteractible_, ref CS$<>8__locals1);
		}
		Asset iinteractible_2;
		if (this.Map.Assets.TryGetValue(CS$<>8__locals1.gclass186_0.Id, out iinteractible_2))
		{
			GClass116.smethod_0(iinteractible_2, ref CS$<>8__locals1);
			return;
		}
	}

	public void method_10(GClass187 gclass187_0)
	{
		this.Map.method_21(gclass187_0);
	}

	public void method_11(GClass181 gclass181_0)
	{
		this.Map.method_9(gclass181_0);
	}

	public void method_12(GClass140 gclass140_0)
	{
		this.Map.method_12(gclass140_0);
	}

	public void method_13(GClass268 gclass268_0)
	{
		this.Map.method_19(gclass268_0);
	}

	public void method_14(GClass179 gclass179_0)
	{
		this.Map.method_20(gclass179_0);
	}

	public void method_15(GClass270 gclass270_0)
	{
		this.Map.method_16(gclass270_0);
	}

	public void method_16(GClass269 gclass269_0)
	{
		this.Map.method_15(gclass269_0);
	}

	public void method_17(GClass259 gclass259_0)
	{
		this.Map.method_23(gclass259_0);
	}

	public void method_18(GClass241 gclass241_0)
	{
		this.Map.method_27(gclass241_0);
	}

	public void method_19(GClass250 gclass250_0)
	{
		this.Map.method_28(gclass250_0);
		if (gclass250_0.string_0.StartsWith("group_ping"))
		{
			this.Map.Hero.Group.method_0(gclass250_0);
		}
	}

	[CompilerGenerated]
	internal static bool smethod_0(IInteractible iinteractible_0, ref GClass116.<>c__DisplayClass12_0 <>c__DisplayClass12_0_0)
	{
		if (iinteractible_0.Id == <>c__DisplayClass12_0_0.gclass186_0.Id)
		{
			iinteractible_0.Activatable = <>c__DisplayClass12_0_0.gclass186_0.bool_0;
			iinteractible_0.Activated = (<>c__DisplayClass12_0_0.gclass186_0.State == 0U);
			return true;
		}
		return false;
	}
}

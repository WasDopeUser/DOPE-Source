using System;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass115 : GInterface4
{
	public GClass115()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}

	public Map Map
	{
		get
		{
			return ConnectionManager.Instance.Value.Game.Map;
		}
	}

	public void method_0(GClass122 gclass122_0)
	{
		Map map = ConnectionManager.Instance.Value.Game.Map;
		Asset asset;
		if (gclass122_0.gclass126_0.uint_0 != 35U)
		{
			if (gclass122_0.gclass126_0.uint_0 != 36U)
			{
				if (gclass122_0.gclass126_0.uint_0 == 37U)
				{
					asset = new BattlestationModule(gclass122_0.int_3, gclass122_0.int_0);
					goto IL_89;
				}
				asset = new Asset(gclass122_0.int_3, gclass122_0.int_0);
				goto IL_89;
			}
		}
		asset = (map.Battlestation = new Battlestation(gclass122_0.int_3, gclass122_0.int_0));
		IL_89:
		if (asset != null)
		{
			asset.method_0(gclass122_0);
			map.Assets[gclass122_0.int_1] = asset;
			ICollidable collidable = asset;
			if (collidable != null)
			{
				map.Collidables[gclass122_0.string_0] = collidable;
			}
			map.Grid.method_11(asset);
		}
	}

	public void method_1(GClass181 gclass181_0)
	{
		this.Map.method_12(gclass181_0);
	}

	public void method_2(GClass233 gclass233_0)
	{
		this.Map.method_20(gclass233_0);
	}

	public void method_3(GClass174 gclass174_0)
	{
		this.Map.method_9(gclass174_0);
	}

	public void method_4(GClass254 gclass254_0)
	{
		this.Map.method_15(gclass254_0);
	}

	public void method_5(GClass253 gclass253_0)
	{
		this.Map.method_21(gclass253_0);
	}

	public void method_6(GClass256 gclass256_0)
	{
		this.Map.SelectedShip = null;
	}

	public void method_7(GClass178 gclass178_0)
	{
		GClass115.<>c__DisplayClass10_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass178_0 = gclass178_0;
		Gate iinteractible_;
		if (this.Map.Gates.TryGetValue(CS$<>8__locals1.gclass178_0.Id, out iinteractible_))
		{
			GClass115.smethod_0(iinteractible_, ref CS$<>8__locals1);
		}
		Asset iinteractible_2;
		if (this.Map.Assets.TryGetValue(CS$<>8__locals1.gclass178_0.Id, out iinteractible_2))
		{
			GClass115.smethod_0(iinteractible_2, ref CS$<>8__locals1);
			return;
		}
	}

	public void method_8(GClass179 gclass179_0)
	{
		this.Map.method_17(gclass179_0);
	}

	public void method_9(GClass173 gclass173_0)
	{
		this.Map.method_8(gclass173_0);
	}

	public void MjbOguilQe(GClass136 gclass136_0)
	{
		this.Map.method_11(gclass136_0);
	}

	public void method_10(GClass250 gclass250_0)
	{
		this.Map.method_16(gclass250_0);
	}

	public void method_11(GClass252 gclass252_0)
	{
		this.Map.method_14(gclass252_0);
	}

	public void method_12(GClass251 gclass251_0)
	{
		this.Map.method_13(gclass251_0);
	}

	public void method_13(GClass241 gclass241_0)
	{
		this.Map.method_19(gclass241_0);
	}

	[CompilerGenerated]
	internal static bool smethod_0(IInteractible iinteractible_0, ref GClass115.<>c__DisplayClass10_0 <>c__DisplayClass10_0_0)
	{
		if (iinteractible_0.Id == <>c__DisplayClass10_0_0.gclass178_0.Id)
		{
			iinteractible_0.Activatable = <>c__DisplayClass10_0_0.gclass178_0.bool_0;
			iinteractible_0.Activated = (<>c__DisplayClass10_0_0.gclass178_0.State == 0U);
			return true;
		}
		return false;
	}
}

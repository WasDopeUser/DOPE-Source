using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;

public class GClass909 : GClass907
{
	public GClass909(GClass889 gclass889_1)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor(gclass889_1);
		this.list_1 = new List<Rectangle>
		{
			GClass909.list_0[0]
		};
	}

	public override bool vmethod_19(GClass891 gclass891_0)
	{
		return gclass891_0 is GClass893;
	}

	public override List<Rectangle> vmethod_17()
	{
		AccountSettings account = base.Context.Account;
		int num = (account != null) ? account.PalladiumCollectionAreaWidth : 0;
		if (num == this.int_1)
		{
			return this.list_1;
		}
		Rectangle value = GClass909.list_0[0];
		int num2 = (int)((float)((100 - num) * value.Width) / 100f);
		value.Width -= num2;
		value.X += num2;
		this.list_1[0] = value;
		this.int_1 = num;
		return this.list_1;
	}

	public override bool vmethod_8(NpcShip npcShip_0)
	{
		Vector2 position = npcShip_0.Position;
		return this.vmethod_17()[0].Contains((int)position.X, (int)position.Y) && base.vmethod_8(npcShip_0);
	}

	public override Vector2? vmethod_20(Vector2 vector2_1, out Gate gate_0, bool bool_3 = false, bool bool_4 = true)
	{
		gate_0 = null;
		List<KeyValuePair<int, Gate>> list = base.C.Map.Gates.Where(new Func<KeyValuePair<int, Gate>, bool>(this.method_23)).OrderBy(new Func<KeyValuePair<int, Gate>, int>(GClass909.<>c.<>c_0.method_0)).ToList<KeyValuePair<int, Gate>>();
		if (list.Count != 2)
		{
			return null;
		}
		CollidableRect collidableRect = base.C.Map.Collidables.FirstOrDefault(new Func<KeyValuePair<string, ICollidable>, bool>(GClass909.<>c.<>c_0.method_1)).Value as CollidableRect;
		if (collidableRect == null)
		{
			return null;
		}
		Gate value;
		if (vector2_1.X < (float)collidableRect.Rect.X)
		{
			value = list[0].Value;
		}
		else
		{
			value = list[1].Value;
		}
		return new Vector2?(value.Position);
	}

	public override bool vmethod_13(Collectible collectible_0)
	{
		Vector2 position = collectible_0.Position;
		return this.vmethod_17()[0].Contains((int)position.X, (int)position.Y);
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass909()
	{
		Class13.xnk8ImWzpOt04();
		GClass909.list_0 = new List<Rectangle>
		{
			new Rectangle(12000, 18200, 20350, 7300)
		};
	}

	[CompilerGenerated]
	private bool method_23(KeyValuePair<int, Gate> keyValuePair_0)
	{
		return keyValuePair_0.Value.FactionId == base.C.Hero.FactionId;
	}

	public static List<Rectangle> list_0;

	public List<Rectangle> list_1;

	private int int_1;
}

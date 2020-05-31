using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;

public class GClass859 : GClass857
{
	public GClass859(GClass839 gclass839_1)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(gclass839_1);
		this.list_1 = new List<Rectangle>
		{
			GClass859.list_0[0]
		};
	}

	public override bool vmethod_19(GClass841 gclass841_0)
	{
		return gclass841_0 is GClass843;
	}

	public override List<Rectangle> vmethod_17()
	{
		AccountSettings account = base.Context.Account;
		int num = (account != null) ? account.PalladiumCollectionAreaWidth : 0;
		if (num == this.int_1)
		{
			return this.list_1;
		}
		Rectangle value = GClass859.list_0[0];
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
		List<KeyValuePair<int, Gate>> list = base.C.Map.Gates.Where(new Func<KeyValuePair<int, Gate>, bool>(this.method_24)).OrderBy(new Func<KeyValuePair<int, Gate>, int>(GClass859.<>c.<>c_0.method_0)).ToList<KeyValuePair<int, Gate>>();
		if (list.Count != 2)
		{
			return null;
		}
		CollidableRect collidableRect = base.C.Map.Collidables.FirstOrDefault(new Func<KeyValuePair<string, ICollidable>, bool>(GClass859.<>c.<>c_0.method_1)).Value as CollidableRect;
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
	static GClass859()
	{
		Class13.NP5bWyNzLwONS();
		GClass859.list_0 = new List<Rectangle>
		{
			new Rectangle(12000, 18200, 20350, 7300)
		};
	}

	[CompilerGenerated]
	private bool method_24(KeyValuePair<int, Gate> keyValuePair_0)
	{
		return keyValuePair_0.Value.FactionId == base.C.Hero.FactionId;
	}

	public static List<Rectangle> list_0;

	public List<Rectangle> list_1;

	private int int_1;
}

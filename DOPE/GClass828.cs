using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DarkorbitAPI.Structures.Pathing;
using DOPE.Common.Models.Bot;

public class GClass828 : GClass820
{
	public GClass828(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(gclass810_1);
	}

	public override bool vmethod_3(NpcShip npcShip_0)
	{
		return false;
	}

	public virtual bool vmethod_21()
	{
		return base.Map.GG != (GEnum5)300;
	}

	public override bool vmethod_1(Ship ship_0, out Ship ship_1)
	{
		ship_1 = null;
		if (ship_0 == null)
		{
			return false;
		}
		if (base.vmethod_0(ship_0, out ship_1, false))
		{
			return true;
		}
		if (ship_0 != null)
		{
			NpcShip npcShip = base.Context.method_63(200);
			CooldownTracker<BotAction> cooldowns = base.Context.Cooldowns;
			bool flag2;
			bool flag = npcShip != null && base.Map.method_7(ship_0, out flag2) && !base.Map.method_7(npcShip, out flag2);
			int num = (base.Map.GG == (GEnum5)300) ? 150 : 100;
			if (npcShip != null && cooldowns.method_0(BotAction.SelectShip) && cooldowns.method_0(BotAction.TargetQuickSwitch) && npcShip != ship_0 && (flag || Vector2.Distance(npcShip.Position, ship_0.Position) > (float)num) && ((base.Context.Game.Security.IsDragging || flag) ? 0.0 : Math.Abs(SecurityManager.smethod_5(ship_0.Position - base.Context.HeroPosition, npcShip.Position - base.Context.HeroPosition))) < 1.0)
			{
				cooldowns.method_1(BotAction.TargetQuickSwitch, 625.0);
				ship_1 = npcShip;
				return true;
			}
		}
		if (base.C.AttackingId == ship_0.Id && this.vmethod_21() && ship_0.HpPercentage < 24.75f && base.C.float_0 >= 24.75f && base.C.method_64().Any(new Func<NpcShip, bool>(this.method_2)))
		{
			base.C.NpcLockout.method_1(ship_0.Id, 1428.0);
			return true;
		}
		return false;
	}

	public bool method_1()
	{
		return base.C.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(this.method_3)) && !this.vmethod_4(true, false);
	}

	public override bool vmethod_9(Collectible collectible_0)
	{
		return base.vmethod_9(collectible_0) && !this.method_1();
	}

	public override bool vmethod_11()
	{
		return !base.C.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(GClass828.<>c.<>c_0.method_0)) && base.C.Map.Gates.Any<KeyValuePair<int, Gate>>() && !base.C.method_66() && base.C.DormantTargets.Count == 0 && base.C.Game.Web.GgInfo != null;
	}

	public override bool vmethod_12()
	{
		return false;
	}

	public override bool vmethod_4(bool bool_0 = false, bool bool_1 = false)
	{
		Vector2 heroPosition = base.C.HeroPosition;
		if (!bool_0)
		{
			return true;
		}
		if (base.Context.Map.method_2(heroPosition, 100) && !base.Map.Collectibles.Any(new Func<KeyValuePair<string, Collectible>, bool>(this.method_4)))
		{
			return false;
		}
		Ship ship = base.C.Map.method_5<Ship>(heroPosition, new Func<Ship, bool>(GClass828.<>c.<>c_0.method_1), null, 0);
		return ship == null || Vector2.Distance(heroPosition, ship.Position) >= 2000f;
	}

	public override bool vmethod_15(GClass812 gclass812_0)
	{
		if (!base.Context.Map.Gates.Any<KeyValuePair<int, Gate>>())
		{
			GClass818 gclass = gclass812_0 as GClass818;
			return gclass != null && gclass.GalaxyGateType == MapUtils.smethod_6(base.C.Map.MapId);
		}
		return true;
	}

	public override Vector2? vmethod_16(Vector2 vector2_0, out Gate gate_0, bool bool_0 = false, bool bool_1 = true)
	{
		GClass828.<>c__DisplayClass10_0 CS$<>8__locals1 = new GClass828.<>c__DisplayClass10_0();
		Map map = base.C.Map;
		CS$<>8__locals1.int_0 = MapUtils.smethod_9(MapUtils.smethod_6(map.MapId));
		gate_0 = map.Gates.FirstOrDefault(new Func<KeyValuePair<int, Gate>, bool>(CS$<>8__locals1.method_0)).Value;
		Gate gate = gate_0;
		if (gate == null)
		{
			return null;
		}
		return new Vector2?(gate.Position);
	}

	public override Vector2? vmethod_17(bool bool_0)
	{
		GClass828.<>c__DisplayClass11_0 CS$<>8__locals1 = new GClass828.<>c__DisplayClass11_0();
		CS$<>8__locals1.gclass828_0 = this;
		Vector2 value = default(Vector2);
		CS$<>8__locals1.vector2_0 = base.C.HeroPosition;
		if (base.C.Map.method_5<Ship>(CS$<>8__locals1.vector2_0, new Func<Ship, bool>(GClass828.<>c.<>c_0.method_2), null, 0) == null)
		{
			value = base.C.Map.Center;
		}
		else if (base.C.Game.Security.IsDragging)
		{
			value = base.C.Game.Security.method_10(CS$<>8__locals1.vector2_0, base.C.Map.Center, (float)base.C.Map.MapSize.Height * 0.4f, null, base.C.Game.Security.FlipDrag ? -0.5f : 0.5f);
		}
		else
		{
			CS$<>8__locals1.vector2_1 = (base.C.Game.Security.method_8(CS$<>8__locals1.vector2_0, 2250) ?? base.C.Map.Center);
			CS$<>8__locals1.float_0 = Math.Min(Vector2.Distance(base.Hero.Position, CS$<>8__locals1.vector2_1) + 500f, 2500f);
			CS$<>8__locals1.pathSequence_0 = null;
			Map.Navigators.method_4(new Action<MapNavigator>(CS$<>8__locals1.method_0), 0);
			if (CS$<>8__locals1.pathSequence_0 != null)
			{
				base.Map.Grid.method_15(CS$<>8__locals1.pathSequence_0);
			}
			PathSequence pathSequence_ = CS$<>8__locals1.pathSequence_0;
			value = ((pathSequence_ != null) ? pathSequence_.Destination : base.C.Game.Security.method_20(base.Map, this.vmethod_13()));
		}
		return new Vector2?(value);
	}

	public override bool vmethod_8(NpcShip npcShip_0)
	{
		GClass179 gclass;
		return !npcShip_0.HasModifier(EntityModifierType.INVINCIBILITY, out gclass);
	}

	public override int vmethod_7(NpcShip npcShip_0)
	{
		int num = base.vmethod_7(npcShip_0);
		bool flag;
		if (num > -100 && base.Map.method_7(npcShip_0, out flag))
		{
			return -100;
		}
		NpcUtils.NpcClass @class = npcShip_0.Type.Class;
		int result;
		if (@class != null && GClass828.dictionary_0.TryGetValue(@class, out result))
		{
			return result;
		}
		return num;
	}

	public override bool vmethod_6(NpcShip npcShip_0)
	{
		return this.vmethod_8(npcShip_0) && base.C.NpcLockout.method_0(npcShip_0.Id);
	}

	public override bool vmethod_2(NpcShip npcShip_0)
	{
		return true;
	}

	public override bool vmethod_19()
	{
		if (!base.Map.Gates.Any<KeyValuePair<int, Gate>>())
		{
			return !base.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(GClass828.<>c.<>c_0.method_3));
		}
		return false;
	}

	public override void vmethod_20(NpcShip npcShip_0)
	{
		int range;
		if (npcShip_0.Type.Class != null && GClass828.dictionary_1.TryGetValue(npcShip_0.Type.Class, out range))
		{
			npcShip_0.Range = range;
			return;
		}
		base.vmethod_20(npcShip_0);
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass828()
	{
		Class8.xDph7tozmh5WD();
		GClass828.dictionary_0 = new Dictionary<NpcUtils.NpcClass, int>
		{
			{
				NpcUtils.N_StreunerSpecialist,
				900
			},
			{
				NpcUtils.N_StreunerRocketeer,
				1000
			}
		};
		GClass828.dictionary_1 = new Dictionary<NpcUtils.NpcClass, int>
		{
			{
				NpcUtils.N_StreunerTurret,
				595
			}
		};
	}

	[CompilerGenerated]
	private bool method_2(NpcShip npcShip_0)
	{
		bool flag;
		return npcShip_0.HpPercentage > 24.75f && !base.C.Map.method_7(npcShip_0, out flag) && Vector2.Distance(base.C.HeroPosition, npcShip_0.Position) < 1200f;
	}

	[CompilerGenerated]
	private bool method_3(KeyValuePair<int, Ship> keyValuePair_0)
	{
		bool flag;
		return keyValuePair_0.Value.IsNpc && keyValuePair_0.Value.HpPercentage > 24.75f && !base.C.Map.method_7(keyValuePair_0.Value, out flag);
	}

	[CompilerGenerated]
	private bool method_4(KeyValuePair<string, Collectible> keyValuePair_0)
	{
		return Vector2.Distance(keyValuePair_0.Value.Position, base.Hero.Position) < 500f;
	}

	public static Dictionary<NpcUtils.NpcClass, int> dictionary_0;

	public static Dictionary<NpcUtils.NpcClass, int> dictionary_1;
}

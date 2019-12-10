using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using DOPE.UI.Models;
using NLog;

public abstract class GClass820
{
	public GClass810 Context { get; protected set; }

	public GClass810 C
	{
		get
		{
			return this.Context;
		}
	}

	public Map Map
	{
		get
		{
			return this.Context.Map;
		}
	}

	public Hero Hero
	{
		get
		{
			return this.Context.Hero;
		}
	}

	public GClass820(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Context = gclass810_1;
	}

	protected virtual bool vmethod_0(Ship ship_0, out Ship ship_1, bool bool_0 = false)
	{
		GClass820.<>c__DisplayClass11_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass820_0 = this;
		CS$<>8__locals1.ship_0 = ship_0;
		ship_1 = null;
		if (CS$<>8__locals1.ship_0 == null)
		{
			return false;
		}
		GClass179 gclass;
		if (CS$<>8__locals1.ship_0.HasModifier(EntityModifierType.INVINCIBILITY, out gclass))
		{
			return true;
		}
		bool flag = bool_0 && this.C.Map.Grid.method_7(CS$<>8__locals1.ship_0.Position) && Vector2.Distance(this.Map.Hero.Position, CS$<>8__locals1.ship_0.Position) > 1000f;
		bool flag2 = false;
		if (this.C.AttackingId == CS$<>8__locals1.ship_0.Id)
		{
			flag &= CS$<>8__locals1.ship_0.LastTookDamageHero.Cooldown(15000);
		}
		else
		{
			NpcShip npcShip = CS$<>8__locals1.ship_0 as NpcShip;
			if (npcShip != null && !this.vmethod_5(npcShip))
			{
				flag2 = true;
			}
		}
		if (flag || flag2)
		{
			this.method_0(1.0, ref CS$<>8__locals1);
			return true;
		}
		return false;
	}

	public virtual bool vmethod_1(Ship ship_0, out Ship ship_1)
	{
		ship_1 = null;
		return this.vmethod_0(ship_0, out ship_1, false);
	}

	public virtual bool vmethod_2(NpcShip npcShip_0)
	{
		return this.C.MapProfile.CircleNpcs && npcShip_0.Range > 350;
	}

	public virtual bool vmethod_3(NpcShip npcShip_0)
	{
		return this.vmethod_2(npcShip_0) && this.C.MapProfile.SecondaryCircleNpcs;
	}

	public virtual bool vmethod_4(bool bool_0 = false, bool bool_1 = false)
	{
		GClass820.<>c__DisplayClass15_0 CS$<>8__locals1 = new GClass820.<>c__DisplayClass15_0();
		CS$<>8__locals1.gclass820_0 = this;
		CS$<>8__locals1.hero_0 = this.C.Hero;
		Vector2 heroPosition = this.C.HeroPosition;
		if (!bool_1 && CS$<>8__locals1.hero_0.InSafeZone)
		{
			return true;
		}
		if (bool_0 && !CS$<>8__locals1.hero_0.LastTookDamage.Cooldown(5000))
		{
			return false;
		}
		if (!CS$<>8__locals1.hero_0.LastTookDamageEnemy.Cooldown(10000))
		{
			return false;
		}
		Ship ship;
		if (this.C.MapProfile.FleeOnlyFromKnownEnemySeen)
		{
			ship = this.C.Game.Map.method_5<Ship>(heroPosition, new Func<Ship, bool>(CS$<>8__locals1.method_0), null, 0);
		}
		else
		{
			ship = this.C.Game.Map.method_5<Ship>(heroPosition, new Func<Ship, bool>(CS$<>8__locals1.method_1), null, 0);
		}
		return ship == null || Vector2.Distance(heroPosition, ship.Position) > 2500f || !this.C.MapProfile.FleeFromEnemySeen;
	}

	public virtual bool klqPvzeAqVH(NpcShip npcShip_0)
	{
		NpcUtils.NpcClass npcClass;
		if (npcShip_0 == null)
		{
			npcClass = null;
		}
		else
		{
			NpcUtils.NpcType type = npcShip_0.Type;
			npcClass = ((type != null) ? type.Class : null);
		}
		return npcClass == NpcUtils.N_Cubikon;
	}

	public virtual bool vmethod_5(NpcShip npcShip_0)
	{
		return this.klqPvzeAqVH(npcShip_0) || npcShip_0.LeashedBy <= 0;
	}

	public virtual bool vmethod_6(NpcShip npcShip_0)
	{
		return this.vmethod_8(npcShip_0) && this.C.NpcLockout.method_0(npcShip_0.Id) && !this.C.Map.Grid.method_7(npcShip_0.Position);
	}

	public virtual int vmethod_7(NpcShip npcShip_0)
	{
		MapProfile mapProfile = this.C.MapProfile;
		int? num;
		if (mapProfile == null)
		{
			num = null;
		}
		else
		{
			SelectedNpcModel model = mapProfile.GetModel(npcShip_0, null, null, 0);
			num = ((model != null) ? new int?(model.Priority) : null);
		}
		int? num2 = num;
		int num3 = num2.GetValueOrDefault();
		if (num3 < 0)
		{
			if (npcShip_0.LastAttackedHero.Cooldown(5000))
			{
				num3 = -100000;
			}
			else
			{
				num3 = 0;
			}
		}
		return num3;
	}

	public virtual bool vmethod_8(NpcShip npcShip_0)
	{
		GClass179 gclass;
		if (npcShip_0.HasModifier(EntityModifierType.INVINCIBILITY, out gclass))
		{
			return false;
		}
		MapProfile mapProfile = this.C.MapProfile;
		return mapProfile != null && mapProfile.IsValidTarget(npcShip_0);
	}

	public virtual bool vmethod_9(Collectible collectible_0)
	{
		return this.C.Game.Security.qOxDbmibcL(this.C.Map, collectible_0);
	}

	public virtual bool vmethod_10(Ship ship_0, Collectible collectible_0)
	{
		NpcShip npcShip = ship_0 as NpcShip;
		if (npcShip == null)
		{
			return false;
		}
		Vector2 heroPosition = this.C.HeroPosition;
		Vector2 position = collectible_0.Position;
		Vector2 position2 = ship_0.Position;
		float num = Vector2.Distance(heroPosition, collectible_0.Position);
		float num2 = Vector2.Distance(position2, position);
		bool flag = this.vmethod_3(npcShip) && num2 < 1100f;
		return this.vmethod_9(collectible_0) && !flag && num < Vector2.Distance(heroPosition, position2);
	}

	public virtual bool vmethod_11()
	{
		return this.C.Map.Gates.Any<KeyValuePair<int, Gate>>();
	}

	public virtual bool vmethod_12()
	{
		return this.Map.SelectedShip == null;
	}

	public virtual List<Rectangle> vmethod_13()
	{
		return this.C.Map.DefaultWorkArea;
	}

	public virtual BotState vmethod_14()
	{
		return BotState.Roam;
	}

	public virtual bool vmethod_15(GClass812 gclass812_0)
	{
		return true;
	}

	public virtual Vector2? vmethod_16(Vector2 vector2_0, out Gate gate_0, bool bool_0 = false, bool bool_1 = true)
	{
		GClass820.<>c__DisplayClass28_0 CS$<>8__locals1 = new GClass820.<>c__DisplayClass28_0();
		CS$<>8__locals1.vector2_0 = vector2_0;
		CS$<>8__locals1.map_0 = this.C.Map;
		CS$<>8__locals1.int_0 = CS$<>8__locals1.map_0.MapId;
		Vector2? vector = this.vmethod_18();
		if (bool_0)
		{
			GClass820.<>c__DisplayClass28_1 CS$<>8__locals2 = new GClass820.<>c__DisplayClass28_1();
			CS$<>8__locals2.<>c__DisplayClass28_0_0 = CS$<>8__locals1;
			Ship ship = CS$<>8__locals2.<>c__DisplayClass28_0_0.map_0.method_5<Ship>(CS$<>8__locals2.<>c__DisplayClass28_0_0.vector2_0, new Func<Ship, bool>(CS$<>8__locals2.<>c__DisplayClass28_0_0.method_0), null, 0);
			if (ship != null)
			{
				CS$<>8__locals2.vector2_0 = ship.Position;
				gate_0 = CS$<>8__locals2.<>c__DisplayClass28_0_0.map_0.Gates.Where(new Func<KeyValuePair<int, Gate>, bool>(GClass820.<>c.<>c_0.method_0)).OrderByDescending(new Func<KeyValuePair<int, Gate>, float>(CS$<>8__locals2.method_1)).FirstOrDefault<KeyValuePair<int, Gate>>().Value;
				Gate gate = gate_0;
				Vector2? result = (gate != null) ? new Vector2?(gate.Position) : null;
				if (vector != null && CS$<>8__locals2.method_0(vector.Value) >= CS$<>8__locals2.method_0(gate_0.Position))
				{
					gate_0 = null;
					result = new Vector2?(vector.Value);
				}
				return result;
			}
		}
		HashSet<int> hashSet = new HashSet<int>();
		new Dictionary<MapUtils.PortalEdge, MapUtils.MapCheckpoint>();
		CS$<>8__locals1.minHeap_0 = new MinHeap<MapUtils.MapCheckpoint>(MapUtils.DefaultMapCheckpointComparer);
		bool flag = false;
		MapUtils.MapCheckpoint mapCheckpoint = null;
		MapUtils.MapCheckpoint mapCheckpoint2 = new MapUtils.MapCheckpoint
		{
			Distance = 0f,
			MapId = (short)CS$<>8__locals1.int_0,
			Position = CS$<>8__locals1.vector2_0
		};
		CS$<>8__locals1.minHeap_0.method_0(mapCheckpoint2);
		if (vector != null)
		{
			CS$<>8__locals1.minHeap_0.method_0(new MapUtils.MapCheckpoint
			{
				Distance = Vector2.Distance(CS$<>8__locals1.vector2_0, vector.Value) + 1f,
				MapId = (short)CS$<>8__locals1.int_0,
				Position = vector.Value,
				Parent = mapCheckpoint2
			});
		}
		int num = 0;
		while (CS$<>8__locals1.minHeap_0.Any<MapUtils.MapCheckpoint>())
		{
			num++;
			MapUtils.MapCheckpoint mapCheckpoint3 = CS$<>8__locals1.minHeap_0.method_3();
			int mapId = (int)mapCheckpoint3.MapId;
			if (mapCheckpoint3.Edge != null)
			{
				if (mapCheckpoint3.Edge.OtherSide != null)
				{
					hashSet.Add(mapCheckpoint3.Edge.OtherSide.Id);
				}
				if (!hashSet.Add(mapCheckpoint3.Edge.Id))
				{
					continue;
				}
			}
			if (bool_1)
			{
				MapUtils.PortalEdge edge = mapCheckpoint3.Edge;
				if (edge != null)
				{
					MapUtils.PortalEdge otherSide = edge.OtherSide;
				}
			}
			if (!CS$<>8__locals1.map_0.Hero.method_27(mapCheckpoint3.Edge, null))
			{
				if (mapCheckpoint3.Edge != null || mapCheckpoint3.Distance == 0f)
				{
					foreach (MapUtils.PortalEdge portalEdge in MapUtils.SpaceGraph[mapId])
					{
						if (!hashSet.Contains(portalEdge.Id))
						{
							CS$<>8__locals1.method_1(portalEdge, mapCheckpoint3);
						}
					}
					continue;
				}
			}
			flag = true;
			mapCheckpoint = mapCheckpoint3;
			IL_312:
			gate_0 = null;
			if (flag)
			{
				LogManager.GetLogger("Base-Map-GetSafeGate").Info<float, short, int>("Found path to a safe position in {distance:0.0} ({jumps} njumps, {its} its)", mapCheckpoint.Distance, mapCheckpoint.NeutralJumps, num);
				MapUtils.MapCheckpoint mapCheckpoint4 = mapCheckpoint;
				while (mapCheckpoint4.Parent != null)
				{
					if (mapCheckpoint4.Parent == mapCheckpoint2)
					{
						break;
					}
					mapCheckpoint4 = mapCheckpoint4.Parent;
				}
				if (mapCheckpoint4.Edge == null)
				{
					return new Vector2?(mapCheckpoint4.Position);
				}
				if (!bool_1 && mapCheckpoint4 == mapCheckpoint)
				{
					Gate gate2;
					if (!CS$<>8__locals1.map_0.Gates.TryGetValue(mapCheckpoint4.Edge.Id, out gate2))
					{
						return null;
					}
					return new Vector2?(gate2.Position);
				}
				else
				{
					Gate gate3;
					gate_0 = (CS$<>8__locals1.map_0.Gates.TryGetValue(mapCheckpoint4.Edge.Id, out gate3) ? gate3 : null);
				}
			}
			Gate gate4 = gate_0;
			if (gate4 == null)
			{
				return null;
			}
			return new Vector2?(gate4.Position);
		}
		goto IL_312;
	}

	public virtual Vector2? vmethod_17(bool bool_0)
	{
		Gate gate;
		return this.vmethod_16(this.C.Hero.Position, out gate, bool_0, false);
	}

	public virtual Vector2? vmethod_18()
	{
		GClass820.<>c__DisplayClass30_0 CS$<>8__locals1 = new GClass820.<>c__DisplayClass30_0();
		CS$<>8__locals1.hero_0 = this.C.Hero;
		Asset value = this.C.Map.Assets.FirstOrDefault(new Func<KeyValuePair<int, Asset>, bool>(CS$<>8__locals1.method_0)).Value;
		if (value == null)
		{
			return null;
		}
		return new Vector2?(value.Position);
	}

	public virtual bool vmethod_19()
	{
		return false;
	}

	public virtual void vmethod_20(NpcShip npcShip_0)
	{
		MapProfile mapProfile = this.C.MapProfile;
		SelectedNpcModel selectedNpcModel = (mapProfile != null) ? mapProfile.GetModel(npcShip_0, this.Map, null, 0) : null;
		if (selectedNpcModel != null && selectedNpcModel.CircleRange >= 300 && selectedNpcModel.CircleRange <= 625)
		{
			npcShip_0.Range = selectedNpcModel.CircleRange;
			return;
		}
		npcShip_0.Range = SecurityManager.smethod_3(npcShip_0);
	}

	[CompilerGenerated]
	private void method_0(double double_0, ref GClass820.<>c__DisplayClass11_0 <>c__DisplayClass11_0_0)
	{
		this.C.NpcLockout.method_1(<>c__DisplayClass11_0_0.ship_0.Id, double_0 * 10000.0);
	}

	[CompilerGenerated]
	private GClass810 gclass810_0;
}

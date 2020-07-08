using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.CommonStructures.Containers;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using DOPE.UI.Models;
using NLog;

public abstract class GClass903
{
	public GClass889 Context { get; protected set; }

	public GClass889 C
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

	public Logger Log
	{
		get
		{
			return this.Context.method_70("Behavior");
		}
	}

	public GClass903(GClass889 gclass889_1)
	{
		Class13.xnk8ImWzpOt04();
		this.unknownMapObjectsTracker_0 = new UnknownMapObjectsTracker<bool>();
		base..ctor();
		this.Context = gclass889_1;
	}

	protected virtual bool vmethod_0(Ship ship_0, out Ship ship_1, bool bool_3 = false)
	{
		GClass903.<>c__DisplayClass13_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass903_0 = this;
		CS$<>8__locals1.ship_0 = ship_0;
		ship_1 = null;
		if (CS$<>8__locals1.ship_0 == null)
		{
			return false;
		}
		GClass186 gclass;
		if (CS$<>8__locals1.ship_0.HasModifier(EntityModifierType.INVINCIBILITY, out gclass))
		{
			return true;
		}
		bool flag = bool_3 && this.C.Map.Grid.method_7(CS$<>8__locals1.ship_0.Position) && Vector2.Distance(this.Map.Hero.Position, CS$<>8__locals1.ship_0.Position) > 1000f;
		bool flag2 = false;
		if (this.C.AttackingId == CS$<>8__locals1.ship_0.Id)
		{
			flag &= CS$<>8__locals1.ship_0.LastTookDamageHero.Cooldown(15000);
		}
		else
		{
			NpcShip npcShip = CS$<>8__locals1.ship_0 as NpcShip;
			if (npcShip != null && !this.vmethod_7(npcShip))
			{
				flag2 = true;
			}
		}
		if (flag || flag2)
		{
			this.method_18(1.0, ref CS$<>8__locals1);
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
		return this.vmethod_2(npcShip_0) && this.C.MapProfile.SecondaryCircleNpcs && npcShip_0.HpPercentage > 24.75f;
	}

	public virtual bool vmethod_4(bool bool_3 = false, bool bool_4 = false)
	{
		GClass903.<>c__DisplayClass17_0 CS$<>8__locals1 = new GClass903.<>c__DisplayClass17_0();
		CS$<>8__locals1.gclass903_0 = this;
		CS$<>8__locals1.hero_0 = this.C.Hero;
		Vector2 heroPosition = this.C.HeroPosition;
		if (!bool_4 && CS$<>8__locals1.hero_0.InSafeZone)
		{
			return true;
		}
		if (bool_3 && !CS$<>8__locals1.hero_0.LastTookDamage.Cooldown(5000))
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

	public virtual SelectedNpcModel vmethod_5(Ship ship_0)
	{
		MapProfile mapProfile = this.C.MapProfile;
		if (mapProfile == null)
		{
			return null;
		}
		return mapProfile.GetModel(ship_0, this.C.Map, null, 0);
	}

	public virtual bool vmethod_6(NpcShip npcShip_0)
	{
		SelectedNpcModel selectedNpcModel = this.vmethod_5(npcShip_0);
		if (selectedNpcModel != null && selectedNpcModel.IgnoreOwnership)
		{
			return true;
		}
		if (this.method_0() == GroupAttackMode.Assist)
		{
			int? num = (npcShip_0 != null) ? new int?(npcShip_0.Id) : null;
			int num2 = this.method_12();
			return num.GetValueOrDefault() == num2 & num != null;
		}
		return false;
	}

	public virtual bool vmethod_7(NpcShip npcShip_0)
	{
		return this.vmethod_6(npcShip_0) || npcShip_0.LeashedBy <= 0 || this.Hero.Group.method_1(npcShip_0.LeashedBy);
	}

	public virtual bool vmethod_8(NpcShip npcShip_0)
	{
		if (this.method_12() != -1)
		{
			int? num = (npcShip_0 != null) ? new int?(npcShip_0.Id) : null;
			int num2 = this.method_12();
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				return false;
			}
		}
		if (this.vmethod_10(npcShip_0) && this.C.NpcLockout.method_0(npcShip_0.Id))
		{
			return !this.C.Map.Grid.method_7(npcShip_0.Position);
		}
		return false;
	}

	public virtual int vmethod_9(NpcShip npcShip_0)
	{
		SelectedNpcModel selectedNpcModel = this.vmethod_5(npcShip_0);
		int num = (selectedNpcModel != null) ? selectedNpcModel.Priority : 0;
		if (num < 0)
		{
			if (npcShip_0.LastAttackedHero.Cooldown(5000))
			{
				num = -100000;
			}
			else
			{
				num = 0;
			}
		}
		return num;
	}

	public virtual bool vmethod_10(NpcShip npcShip_0)
	{
		GClass186 gclass;
		if (npcShip_0.HasModifier(EntityModifierType.INVINCIBILITY, out gclass))
		{
			return false;
		}
		SelectedNpcModel selectedNpcModel = this.vmethod_5(npcShip_0);
		return selectedNpcModel != null && selectedNpcModel.Enabled;
	}

	public virtual void vmethod_11(NpcShip npcShip_0)
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

	public virtual bool vmethod_12(NpcShip npcShip_0)
	{
		return npcShip_0.HpPercentage <= 24.75f;
	}

	public virtual bool vmethod_13(Collectible collectible_0)
	{
		if (this.method_8())
		{
			if (collectible_0.CollectibleType != (GEnum6)4096)
			{
				return false;
			}
		}
		return this.C.Game.Security.method_0(this.C.Map, collectible_0);
	}

	public virtual bool vmethod_14(Ship ship_0, Collectible collectible_0)
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
		return this.vmethod_13(collectible_0) && !flag && num < Vector2.Distance(heroPosition, position2);
	}

	public virtual bool vmethod_15()
	{
		return this.C.Map.Gates.Any<KeyValuePair<int, Gate>>();
	}

	public virtual bool vmethod_16()
	{
		return this.Map.SelectedShip == null;
	}

	public virtual List<Rectangle> vmethod_17()
	{
		return this.C.Map.DefaultWorkArea;
	}

	public virtual BotState vmethod_18()
	{
		return BotState.Roam;
	}

	public virtual bool vmethod_19(GClass891 gclass891_0)
	{
		return true;
	}

	public virtual Vector2? vmethod_20(Vector2 vector2_1, out Gate gate_0, bool bool_3 = false, bool bool_4 = true)
	{
		GClass903.<>c__DisplayClass33_0 CS$<>8__locals1 = new GClass903.<>c__DisplayClass33_0();
		CS$<>8__locals1.vector2_0 = vector2_1;
		CS$<>8__locals1.map_0 = this.C.Map;
		CS$<>8__locals1.int_0 = CS$<>8__locals1.map_0.MapId;
		Vector2? vector = this.vmethod_22();
		if (bool_3)
		{
			GClass903.<>c__DisplayClass33_1 CS$<>8__locals2 = new GClass903.<>c__DisplayClass33_1();
			CS$<>8__locals2.<>c__DisplayClass33_0_0 = CS$<>8__locals1;
			Ship ship = CS$<>8__locals2.<>c__DisplayClass33_0_0.map_0.method_5<Ship>(CS$<>8__locals2.<>c__DisplayClass33_0_0.vector2_0, new Func<Ship, bool>(CS$<>8__locals2.<>c__DisplayClass33_0_0.method_0), null, 0);
			if (ship != null)
			{
				CS$<>8__locals2.vector2_0 = ship.Position;
				gate_0 = CS$<>8__locals2.<>c__DisplayClass33_0_0.map_0.Gates.Where(new Func<KeyValuePair<int, Gate>, bool>(GClass903.<>c.<>c_0.method_0)).OrderByDescending(new Func<KeyValuePair<int, Gate>, float>(CS$<>8__locals2.method_0)).FirstOrDefault<KeyValuePair<int, Gate>>().Value;
				Gate gate = gate_0;
				Vector2? result = (gate != null) ? new Vector2?(gate.Position) : null;
				if (vector != null && CS$<>8__locals2.uhRwvlAdZxy(vector.Value) >= CS$<>8__locals2.uhRwvlAdZxy(gate_0.Position))
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
			if (bool_4)
			{
				MapUtils.PortalEdge edge = mapCheckpoint3.Edge;
				if (edge != null)
				{
					MapUtils.PortalEdge otherSide = edge.OtherSide;
				}
			}
			if (!CS$<>8__locals1.map_0.Hero.method_28(mapCheckpoint3.Edge, null))
			{
				if (mapCheckpoint3.Edge != null || mapCheckpoint3.Distance == 0f)
				{
					List<MapUtils.PortalEdge> list;
					if (MapUtils.SpaceGraph.TryGetValue(mapId, out list))
					{
						foreach (MapUtils.PortalEdge portalEdge in list)
						{
							if (!hashSet.Contains(portalEdge.Id))
							{
								CS$<>8__locals1.method_1(portalEdge, mapCheckpoint3);
							}
						}
						continue;
					}
					continue;
				}
			}
			flag = true;
			mapCheckpoint = mapCheckpoint3;
			IL_31B:
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
				if (!bool_4 && mapCheckpoint4 == mapCheckpoint)
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
		goto IL_31B;
	}

	public virtual Vector2? vmethod_21(bool bool_3)
	{
		Gate gate;
		return this.vmethod_20(this.C.Hero.Position, out gate, bool_3, false);
	}

	public virtual Vector2? vmethod_22()
	{
		GClass903.<>c__DisplayClass35_0 CS$<>8__locals1 = new GClass903.<>c__DisplayClass35_0();
		CS$<>8__locals1.hero_0 = this.C.Hero;
		Asset value = this.C.Map.Assets.FirstOrDefault(new Func<KeyValuePair<int, Asset>, bool>(CS$<>8__locals1.method_0)).Value;
		if (value == null)
		{
			return null;
		}
		return new Vector2?(value.Position);
	}

	protected virtual IEnumerable<Vector2> vmethod_23()
	{
		if (this.method_0() == GroupAttackMode.Assist)
		{
			yield return this.method_2();
		}
		Vector2 vector = this.vmethod_33();
		if (vector != default(Vector2))
		{
			yield return vector;
		}
		if (this.method_0() == GroupAttackMode.Enabled)
		{
			yield return this.method_2();
		}
		yield break;
	}

	public virtual bool vmethod_24(out Vector2? nullable_0)
	{
		nullable_0 = null;
		Vector2 position = this.Hero.Position;
		foreach (Vector2 vector in this.vmethod_23())
		{
			nullable_0 = new Vector2?(vector);
			if (this.Map.Grid.method_14(position, vector, 30, 0) != null)
			{
				return true;
			}
		}
		return false;
	}

	public virtual Gate vmethod_25(int int_1)
	{
		GClass903.<>c__DisplayClass38_0 CS$<>8__locals1 = new GClass903.<>c__DisplayClass38_0();
		CS$<>8__locals1.gclass903_0 = this;
		bool flag = MapUtils.smethod_2(this.Map.MapId) == MapGroup.FrozenLabyrinth;
		bool flag2 = MapUtils.smethod_2(int_1) == MapGroup.FrozenLabyrinth;
		CS$<>8__locals1.vector2_0 = this.Hero.Position;
		if (flag2)
		{
			if (flag)
			{
				return null;
			}
			if (this.Map.IsX1)
			{
				return this.Map.Gates.FirstOrDefault(new Func<KeyValuePair<int, Gate>, bool>(CS$<>8__locals1.method_1)).Value;
			}
			int_1 = MapUtils.smethod_12(1, this.Hero.FactionId);
		}
		if (flag)
		{
			return this.Map.Gates.FirstOrDefault(new Func<KeyValuePair<int, Gate>, bool>(CS$<>8__locals1.method_2)).Value;
		}
		float num;
		return MapUtils.smethod_15(this.Map, this.Hero.Position, int_1, out num);
	}

	public virtual bool vmethod_26()
	{
		return this.vmethod_27();
	}

	public virtual bool vmethod_27()
	{
		return true;
	}

	public virtual bool vmethod_28()
	{
		bool result = true;
		BotState state = this.C.State;
		int num;
		if (state == BotState.Logout || state == BotState.Travel || state == BotState.Repair || state == BotState.Default || this.C.MxowfnmntQM(out num))
		{
			result = false;
		}
		return result;
	}

	protected virtual KamikazeState vmethod_29()
	{
		HeroPet pet = this.Hero.Pet;
		if (pet.IsControlDisabled && pet.IsEnabled && pet.Mode == PetMode.Kamikaze)
		{
			return KamikazeState.Activated;
		}
		if (!this.vmethod_28() || !this.Hero.Pet.CanKamikaze || !this.vmethod_30())
		{
			return KamikazeState.Uneligible;
		}
		if (!pet.IsEnabled)
		{
			return KamikazeState.CheckingPet;
		}
		return KamikazeState.Activating;
	}

	public virtual bool vmethod_30()
	{
		NpcShip npcShip = this.C.EnemyTarget as NpcShip;
		if (npcShip == null)
		{
			return false;
		}
		SelectedNpcModel selectedNpcModel = this.vmethod_5(npcShip);
		if (selectedNpcModel != null && selectedNpcModel.UseKamikaze)
		{
			Vector2 position = this.Hero.Position;
			return Vector2.Distance(npcShip.Position, position) < 750f && this.C.IsAttacking && this.C.AttackingId == npcShip.Id && (!this.vmethod_12(npcShip) || npcShip.TemporarySpeed == 0f);
		}
		return false;
	}

	public virtual bool vmethod_31(out int int_1)
	{
		GClass903.<>c__DisplayClass44_0 CS$<>8__locals1 = new GClass903.<>c__DisplayClass44_0();
		CS$<>8__locals1.gclass903_0 = this;
		int_1 = 0;
		CS$<>8__locals1.vector2_0 = this.Hero.Position;
		CS$<>8__locals1.enemyLocatorResultCollection_0 = this.Hero.Pet.EnemyLocatedList;
		List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
		using (IEnumerator<SelectedNpcModel> enumerator = this.C.MapProfile.NpcWhitelist.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				GClass903.<>c__DisplayClass44_1 CS$<>8__locals2 = new GClass903.<>c__DisplayClass44_1();
				CS$<>8__locals2.<>c__DisplayClass44_0_0 = CS$<>8__locals1;
				CS$<>8__locals2.selectedNpcModel_0 = enumerator.Current;
				if (CS$<>8__locals2.selectedNpcModel_0.Enabled && CS$<>8__locals2.selectedNpcModel_0.Priority >= 0 && CS$<>8__locals2.selectedNpcModel_0.UsePetLocator)
				{
					if (this.Map.method_7<NpcShip>(CS$<>8__locals2.<>c__DisplayClass44_0_0.vector2_0, new Func<NpcShip, bool>(CS$<>8__locals2.method_0), null, 0).Any<ValueTuple<NpcShip, float, int>>())
					{
						return false;
					}
					NpcUtils.NpcType npcType;
					int item;
					if (NpcUtils.NpcById.TryGetValue(CS$<>8__locals2.selectedNpcModel_0.NpcId, out npcType) && NpcUtils.XmlNpcIds.TryGetValue(npcType.ToString(), out item) && this.Hero.Pet.method_20(PetMode.EnemyLocator, item))
					{
						list.Add(new ValueTuple<int, int>(item, CS$<>8__locals2.selectedNpcModel_0.Priority));
					}
				}
			}
		}
		int_1 = list.OrderByDescending(new Func<ValueTuple<int, int>, bool>(CS$<>8__locals1.method_0)).ThenBy(new Func<ValueTuple<int, int>, DateTimeOffset>(CS$<>8__locals1.method_1)).ThenByDescending(new Func<ValueTuple<int, int>, int>(GClass903.<>c.<>c_0.method_1)).FirstOrDefault<ValueTuple<int, int>>().Item1;
		return int_1 != 0;
	}

	protected virtual bool vmethod_32()
	{
		GClass903.<>c__DisplayClass45_0 CS$<>8__locals1 = new GClass903.<>c__DisplayClass45_0();
		CS$<>8__locals1.gclass903_0 = this;
		CS$<>8__locals1.enemyLocatorResult_0 = this.Hero.Pet.EnemyLocated;
		HeroPet.EnemyLocatorResult enemyLocatorResult_ = CS$<>8__locals1.enemyLocatorResult_0;
		if (enemyLocatorResult_ != null && enemyLocatorResult_.Found)
		{
			HeroPet.EnemyLocatorResult enemyLocatorResult_2 = CS$<>8__locals1.enemyLocatorResult_0;
			if (((enemyLocatorResult_2 != null) ? enemyLocatorResult_2.Type : null) != null && CS$<>8__locals1.enemyLocatorResult_0.Timestamp.smethod_0(3000))
			{
				CS$<>8__locals1.vector2_0 = this.Hero.Position;
				if (this.Map.method_7<NpcShip>(CS$<>8__locals1.vector2_0, new Func<NpcShip, bool>(CS$<>8__locals1.method_0), null, 0).Any<ValueTuple<NpcShip, float, int>>())
				{
					return false;
				}
				CS$<>8__locals1.vector2_1 = CS$<>8__locals1.enemyLocatorResult_0.Position;
				UnknownMapObjectsTracker<bool>.ObjectEntry<bool> objectEntry;
				if (this.method_14().method_2(CS$<>8__locals1.vector2_1, out objectEntry, 1700))
				{
					objectEntry.method_1(CS$<>8__locals1.vector2_1);
					return false;
				}
				NpcShip npcShip = this.Map.method_5<NpcShip>(CS$<>8__locals1.vector2_1, new Func<NpcShip, bool>(CS$<>8__locals1.method_1), null, 0);
				if (npcShip != null && (!this.vmethod_7(npcShip) || !this.vmethod_8(npcShip)))
				{
					this.Log.Warn<string, Vector2>("Blacklisting taken npc {npc} @{pos}", npcShip.Name, CS$<>8__locals1.vector2_1);
					this.method_14().method_1(CS$<>8__locals1.vector2_1, 1700);
					return false;
				}
				this.method_9(true);
				if (this.method_12() == -1)
				{
					this.method_13((npcShip != null) ? npcShip.Id : 0);
				}
				return true;
			}
		}
		return false;
	}

	protected virtual Vector2 vmethod_33()
	{
		HeroPet.EnemyLocatorResult enemyLocated = this.Hero.Pet.EnemyLocated;
		if (!this.method_16())
		{
			return default(Vector2);
		}
		if (enemyLocated == null)
		{
			return default(Vector2);
		}
		return enemyLocated.Position;
	}

	public virtual PetMode vmethod_34(out int int_1)
	{
		int_1 = 0;
		if (!this.vmethod_28())
		{
			return PetMode.Off;
		}
		HeroPet pet = this.Hero.Pet;
		if (this.method_10() >= KamikazeState.Activating)
		{
			return PetMode.Kamikaze;
		}
		if (this.vmethod_31(out int_1))
		{
			return PetMode.EnemyLocator;
		}
		int_1 = 0;
		PetModeSelection petModeSelection = this.C.MapProfile.PetMode;
		DateTimeOffset? dateTimeOffset;
		bool flag = pet.IsEnabled && pet.EnabledSince != null && dateTimeOffset.GetValueOrDefault().smethod_0(50000);
		if (petModeSelection == PetModeSelection.None && flag)
		{
			petModeSelection = PetModeSelection.Passive;
		}
		PetMode petMode = (PetMode)((petModeSelection == PetModeSelection.None) ? PetModeSelection.None : petModeSelection);
		if (petMode == PetMode.Off && (this.method_10() == KamikazeState.CheckingPet || this.method_10() == KamikazeState.PullingEnemies))
		{
			return PetMode.Passive;
		}
		return petMode;
	}

	[CompilerGenerated]
	public GroupAttackMode method_0()
	{
		return this.groupAttackMode_0;
	}

	[CompilerGenerated]
	protected void method_1(GroupAttackMode groupAttackMode_1)
	{
		this.groupAttackMode_0 = groupAttackMode_1;
	}

	[CompilerGenerated]
	public Vector2 method_2()
	{
		return this.vector2_0;
	}

	[CompilerGenerated]
	protected void method_3(Vector2 vector2_1)
	{
		this.vector2_0 = vector2_1;
	}

	protected bool method_4()
	{
		GClass903.<>c__DisplayClass56_0 CS$<>8__locals1 = new GClass903.<>c__DisplayClass56_0();
		CS$<>8__locals1.gclass903_0 = this;
		this.method_9(false);
		this.method_1(GroupAttackMode.Disabled);
		CS$<>8__locals1.vector2_0 = this.Hero.Position;
		List<ValueTuple<GroupManager.GroupMember, SelectedNpcModel>> source = CS$<>8__locals1.method_0().OrderByDescending(new Func<ValueTuple<GroupManager.GroupMember, SelectedNpcModel>, int>(GClass903.<>c.<>c_0.method_2)).ToList<ValueTuple<GroupManager.GroupMember, SelectedNpcModel>>();
		ValueTuple<GroupManager.GroupMember, SelectedNpcModel> valueTuple = source.FirstOrDefault(new Func<ValueTuple<GroupManager.GroupMember, SelectedNpcModel>, bool>(GClass903.<>c.<>c_0.method_3));
		if (valueTuple.Item2 != null)
		{
			Ship ship = this.Map.method_4(valueTuple.Item1.Id);
			int num = (ship != null) ? ship.TargetId : 0;
			Ship ship2 = this.Map.method_4(num);
			if (ship2 != null)
			{
				NpcShip npcShip = ship2 as NpcShip;
				if (npcShip == null || !this.vmethod_8(npcShip))
				{
					goto IL_112;
				}
			}
			this.method_13(num);
			this.method_9(num == 0 || this.Hero.TargetId != num);
			this.method_3(valueTuple.Item1.Position);
			this.method_1(GroupAttackMode.Assist);
			return true;
		}
		IL_112:
		valueTuple = source.FirstOrDefault(new Func<ValueTuple<GroupManager.GroupMember, SelectedNpcModel>, bool>(GClass903.<>c.<>c_0.method_4));
		if (valueTuple.Item2 != null)
		{
			this.method_9(true);
			this.method_3(valueTuple.Item1.Position);
			this.method_1(GroupAttackMode.Enabled);
			return true;
		}
		return false;
	}

	protected virtual float vmethod_35(Vector2 vector2_1)
	{
		float num = 0f;
		if (this.Map.Grid.method_7(vector2_1))
		{
			num -= 1000000f;
		}
		float num2 = this.Map.method_3(vector2_1);
		num -= Math.Max(0f, 900f - num2);
		if (num2 < 150f)
		{
			num -= 10000f;
		}
		return num;
	}

	protected virtual float vmethod_36(Vector2 vector2_1, [TupleElementNames(new string[]
	{
		"pos",
		"range"
	})] List<ValueTuple<Vector2, int>> npcs)
	{
		float num = 0f;
		foreach (ValueTuple<Vector2, int> valueTuple in npcs)
		{
			num -= (float)Math.Sqrt((double)Math.Max(0f, (float)valueTuple.Item2 - Vector2.Distance(valueTuple.Item1, vector2_1)));
		}
		return num;
	}

	protected virtual float vmethod_37(Vector2 vector2_1, Vector2 vector2_2, [TupleElementNames(new string[]
	{
		"pos",
		"range"
	})] List<ValueTuple<Vector2, int>> npcs)
	{
		float num = 0f;
		foreach (ValueTuple<Vector2, int> valueTuple in npcs)
		{
			float num2 = Math.Max(0f, (float)((double)valueTuple.Item2 - GClass877.smethod_13(vector2_1, vector2_2, valueTuple.Item1, true)));
			num -= (float)Math.Sqrt((double)num2);
		}
		return num;
	}

	public virtual Vector2? vmethod_38(Vector2 vector2_1, Vector2 vector2_2, float float_0)
	{
		if (!this.Map.Grid.method_7(vector2_2) && !this.Map.Grid.method_3(vector2_1, vector2_2))
		{
			return new Vector2?(vector2_2);
		}
		return this.vmethod_47(vector2_1, vector2_2, float_0);
	}

	public virtual Vector2? vmethod_39(Vector2 vector2_1, Vector2 vector2_2, float float_0, Vector2? nullable_0 = null, float float_1 = 0.5f)
	{
		Vector2 vector2_3 = GClass872.smethod_0(vector2_1, vector2_2, float_0, nullable_0, float_1);
		return this.vmethod_38(vector2_1, vector2_3, float_0);
	}

	public virtual int vmethod_40(Vector2 vector2_1, Vector2 vector2_2, float float_0, int int_1 = 10)
	{
		GClass903.<>c__DisplayClass62_0 CS$<>8__locals1;
		CS$<>8__locals1.vector2_0 = vector2_2;
		CS$<>8__locals1.float_0 = float_0;
		CS$<>8__locals1.gclass903_0 = this;
		CS$<>8__locals1.float_1 = (float)Math.Atan2((double)(vector2_1.X - CS$<>8__locals1.vector2_0.X), (double)(vector2_1.Y - CS$<>8__locals1.vector2_0.Y));
		float num = 0f;
		float num2 = 0f;
		float num3 = (float)(3.1415926535897931 / (double)int_1);
		CS$<>8__locals1.list_0 = new List<ValueTuple<Vector2, int>>();
		foreach (KeyValuePair<int, Ship> keyValuePair in this.Map.Ships)
		{
			NpcShip npcShip = keyValuePair.Value as NpcShip;
			if (npcShip != null)
			{
				CS$<>8__locals1.list_0.Add(new ValueTuple<Vector2, int>(npcShip.method_0(200), npcShip.Range));
			}
		}
		float num4 = this.method_20(this.method_19(0f, ref CS$<>8__locals1), ref CS$<>8__locals1);
		int num5 = 1;
		float num6 = float.MinValue;
		float num7 = float.MinValue;
		while (num5 <= int_1 && Math.Abs(num - num2) <= 100f)
		{
			float num8 = this.method_20(this.method_19(num3 * (float)num5, ref CS$<>8__locals1), ref CS$<>8__locals1);
			num6 = Math.Max(num6, num8);
			num += num8;
			num8 = this.method_20(this.method_19(-num3 * (float)num5, ref CS$<>8__locals1), ref CS$<>8__locals1);
			num7 = Math.Max(num7, num8);
			num2 += num8;
			if ((double)num <= -1000000.0 && (double)num2 <= -1000000.0)
			{
				return 0;
			}
			num5++;
		}
		num += num6;
		num2 += num7;
		num4 *= (float)num5;
		num4 -= 0.01f;
		if (num4 > num && num4 > num2)
		{
			return 0;
		}
		if (num < num2)
		{
			return -1;
		}
		return 1;
	}

	public virtual Vector2? vmethod_41(Vector2 vector2_1, int int_1 = 1100)
	{
		float num = 0f;
		float num2 = 0f;
		int num3 = 0;
		Vector2 position = this.Hero.Position;
		foreach (ValueTuple<NpcShip, float, int> valueTuple in this.Map.method_7<NpcShip>(vector2_1, new Func<NpcShip, bool>(this.vmethod_10), null, 200))
		{
			if (valueTuple.Item2 <= (float)int_1)
			{
				Vector2 vector = valueTuple.Item1.method_0(200);
				num += vector.X;
				num2 += vector.Y;
				num3++;
			}
		}
		if (num3 == 0)
		{
			return null;
		}
		return new Vector2?(new Vector2(num / (float)num3, num2 / (float)num3));
	}

	public virtual int vmethod_42(NpcShip npcShip_0)
	{
		int val = 590;
		int range = npcShip_0.Range;
		if (npcShip_0.TemporarySpeed != 0f && !this.vmethod_12(npcShip_0))
		{
			return range;
		}
		return Math.Min(range, val);
	}

	public virtual int vmethod_43(Vector2 vector2_1, NpcShip npcShip_0, out Vector2 vector2_2)
	{
		vector2_2 = npcShip_0.method_0(Math.Min(225, 100 + this.C.Game.Connection.PingMs));
		float num = Vector2.Distance(vector2_1, vector2_2);
		int num2 = this.Hero.method_29();
		float num3 = (num + (float)npcShip_0.LastDistance) / 2f;
		int num4 = this.vmethod_42(npcShip_0) + num2;
		int num5 = num4 / 2;
		float num6 = Math.Max(Math.Min((float)num4 - num3 + (float)npcShip_0.RangeFix, (float)(num5 + 75)), (float)(-(float)num5));
		if (npcShip_0.TemporarySpeed <= 0f)
		{
			num6 = 0f;
		}
		int result = num4 + (int)num6;
		npcShip_0.RangeFix = (int)num6;
		npcShip_0.LastDistance = (int)num;
		return result;
	}

	public virtual Vector2? vmethod_44(Vector2 vector2_1, NpcShip npcShip_0, Vector2? nullable_0 = null)
	{
		if (this.method_10() >= KamikazeState.PullingEnemies)
		{
			return this.vmethod_45(vector2_1);
		}
		if (this.vmethod_12(npcShip_0) || npcShip_0.TemporarySpeed == 0f)
		{
			nullable_0 = null;
		}
		return this.vmethod_46(vector2_1, npcShip_0, nullable_0, 0.5f);
	}

	public virtual Vector2? vmethod_45(Vector2 vector2_1)
	{
		if (this.method_10() == KamikazeState.PullingEnemies)
		{
			return null;
		}
		Vector2 position = this.Hero.Pet.Position;
		Vector2 vector2_2 = this.vmethod_41(vector2_1, 1100) ?? position;
		NpcShip npcShip = this.C.EnemyTarget as NpcShip;
		if (this.method_10() == KamikazeState.Activating && !this.Hero.LastTookDamage.smethod_0(2000))
		{
			Vector2? result = this.vmethod_39(vector2_1, vector2_2, 325f, null, 0.5f);
			bool flag;
			if (npcShip != null && this.Map.mdGbaKqNuQ(npcShip, out flag))
			{
				result = this.vmethod_39(vector2_1, vector2_2, 325f, new Vector2?(this.Map.Center), 0.5f);
			}
			return result;
		}
		DateTimeOffset lastControlDisabled = this.Hero.Pet.LastControlDisabled;
		float num = 4000f - 1000f * (float)Math.Min(1, this.C.method_14() / (this.Hero.Hp / 2));
		if ((lastControlDisabled > this.Hero.LastTookDamage || (this.Hero.LastTookDamage - lastControlDisabled).TotalMilliseconds <= (double)num) && (npcShip == null || !this.vmethod_12(npcShip)))
		{
			Vector2 vector = this.Hero.Position - position;
			float num2 = (float)Math.Atan2((double)vector.X + 0.01, (double)vector.Y + 0.01);
			Vector2 vector2_3 = GClass872.smethod_8(position, 100f, num2 + 0.6f);
			return this.vmethod_38(vector2_1, vector2_3, 100f);
		}
		return this.vmethod_39(vector2_1, position, 650f, null, 0.5f);
	}

	public virtual Vector2? vmethod_46(Vector2 vector2_1, NpcShip npcShip_0, Vector2? nullable_0 = null, float float_0 = 0.5f)
	{
		if (npcShip_0 == null)
		{
			return new Vector2?(vector2_1);
		}
		float num = Vector2.Distance(vector2_1, npcShip_0.Position);
		Vector2 vector2_2;
		int num2 = this.vmethod_43(vector2_1, npcShip_0, out vector2_2);
		if (float_0 != 0f)
		{
			if (num - (float)num2 > 50f)
			{
				float_0 = 0.1f;
			}
			float_0 *= (float)this.vmethod_40(vector2_1, vector2_2, (float)num2, 10);
		}
		return this.vmethod_39(vector2_1, vector2_2, (float)num2, nullable_0, float_0);
	}

	public virtual Vector2? vmethod_47(Vector2 vector2_1, Vector2 vector2_2, float float_0)
	{
		GClass903.<>c__DisplayClass69_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass903_0 = this;
		CS$<>8__locals1.vector2_1 = vector2_1;
		CS$<>8__locals1.wKuwXvebEcP = new List<ValueTuple<Vector2, int>>();
		foreach (KeyValuePair<int, Ship> keyValuePair in this.Map.Ships)
		{
			if (keyValuePair.Value.IsNpc)
			{
				CS$<>8__locals1.wKuwXvebEcP.Add(new ValueTuple<Vector2, int>(keyValuePair.Value.method_0(200), (keyValuePair.Value as NpcShip).Range));
			}
		}
		CS$<>8__locals1.vector2_2 = default(Vector2);
		CS$<>8__locals1.float_0 = -2E+18f;
		double num = Math.Atan((double)(25f / float_0));
		int num2 = -1;
		int num3 = -1;
		for (double num4 = 0.0; num4 < 6.2831853071795862; num4 += num)
		{
			CS$<>8__locals1.vector2_0 = new Vector2((float)((double)vector2_2.X + Math.Sin(num4) * (double)float_0), (float)((double)vector2_2.Y + Math.Cos(num4) * (double)float_0));
			int num5;
			int num6;
			if (this.Map.Grid.method_1(CS$<>8__locals1.vector2_0.X, CS$<>8__locals1.vector2_0.Y, out num5, out num6) && (num5 != num2 || num6 != num3))
			{
				num2 = num5;
				num3 = num6;
				if (!this.Map.Grid.method_9(num2, num3))
				{
					this.method_22(ref CS$<>8__locals1);
				}
			}
		}
		if (CS$<>8__locals1.vector2_2 == default(Vector2))
		{
			return null;
		}
		return new Vector2?(CS$<>8__locals1.vector2_2);
	}

	public void method_5()
	{
		GClass903.<>c__DisplayClass70_0 CS$<>8__locals1 = new GClass903.<>c__DisplayClass70_0();
		CS$<>8__locals1.gclass903_0 = this;
		if (this.method_12() != -1)
		{
			return;
		}
		MapProfile mapProfile = this.C.MapProfile;
		if (((mapProfile != null) ? mapProfile.NpcWhitelist : null) == null)
		{
			return;
		}
		CS$<>8__locals1.list_0 = new NpcUtils.NpcType[]
		{
			NpcUtils.NpcType.smethod_3(NpcUtils.N_Styxus),
			NpcUtils.NpcType.smethod_3(NpcUtils.N_Charopos)
		}.Select(new Func<NpcUtils.NpcType, int>(GClass903.<>c.<>c_0.method_5)).ToList<int>();
		NpcShip npcShip = this.Map.method_5<NpcShip>(this.Hero.Position, new Func<NpcShip, bool>(CS$<>8__locals1.method_0), null, 0);
		if (npcShip != null)
		{
			this.method_13(npcShip.Id);
			this.method_9(true);
		}
	}

	public virtual int vmethod_48()
	{
		MapProfile mapProfile = this.C.MapProfile;
		if (mapProfile == null || !mapProfile.ReviveAtPortal)
		{
			return 1;
		}
		return 2;
	}

	public virtual bool vmethod_49(NpcShip npcShip_0)
	{
		return this.method_10() == KamikazeState.PullingEnemies;
	}

	[CompilerGenerated]
	public bool method_6()
	{
		return this.bool_0;
	}

	[CompilerGenerated]
	protected void method_7(bool bool_3)
	{
		this.bool_0 = bool_3;
	}

	[CompilerGenerated]
	public bool method_8()
	{
		return this.bool_1;
	}

	[CompilerGenerated]
	protected void method_9(bool bool_3)
	{
		this.bool_1 = bool_3;
	}

	[CompilerGenerated]
	public KamikazeState method_10()
	{
		return this.kamikazeState_0;
	}

	[CompilerGenerated]
	protected void method_11(KamikazeState kamikazeState_1)
	{
		this.kamikazeState_0 = kamikazeState_1;
	}

	[CompilerGenerated]
	public int method_12()
	{
		return this.int_0;
	}

	[CompilerGenerated]
	protected void method_13(int int_1)
	{
		this.int_0 = int_1;
	}

	[CompilerGenerated]
	public UnknownMapObjectsTracker<bool> method_14()
	{
		return this.unknownMapObjectsTracker_0;
	}

	[CompilerGenerated]
	protected void method_15(UnknownMapObjectsTracker<bool> unknownMapObjectsTracker_1)
	{
		this.unknownMapObjectsTracker_0 = unknownMapObjectsTracker_1;
	}

	[CompilerGenerated]
	public bool method_16()
	{
		return this.bool_2;
	}

	[CompilerGenerated]
	protected void method_17(bool bool_3)
	{
		this.bool_2 = bool_3;
	}

	public virtual void Update()
	{
		this.method_13(-1);
		this.method_7(!this.C.method_73());
		this.method_4();
		this.method_11(this.vmethod_29());
		this.method_14().method_0();
		this.method_17(this.vmethod_32());
		this.method_5();
	}

	public virtual IEnumerable<string> vmethod_50()
	{
		if (this.method_10() != KamikazeState.Uneligible)
		{
			yield return "Kamikaze: " + this.method_10().ToString();
		}
		if (this.method_0() == GroupAttackMode.Assist)
		{
			yield return "Assisting";
		}
		yield break;
	}

	[CompilerGenerated]
	private void method_18(double double_0, ref GClass903.<>c__DisplayClass13_0 <>c__DisplayClass13_0_0)
	{
		this.C.NpcLockout.method_1(<>c__DisplayClass13_0_0.ship_0.Id, double_0 * 10000.0);
	}

	[CompilerGenerated]
	private Vector2 method_19(float float_0, ref GClass903.<>c__DisplayClass62_0 <>c__DisplayClass62_0_0)
	{
		return GClass872.smethod_8(<>c__DisplayClass62_0_0.vector2_0, <>c__DisplayClass62_0_0.float_0, <>c__DisplayClass62_0_0.float_1 + float_0);
	}

	[CompilerGenerated]
	private float method_20(Vector2 vector2_1, ref GClass903.<>c__DisplayClass62_0 <>c__DisplayClass62_0_0)
	{
		return this.vmethod_35(vector2_1) + this.vmethod_36(vector2_1, <>c__DisplayClass62_0_0.list_0);
	}

	[CompilerGenerated]
	private float method_21(ref GClass903.<>c__DisplayClass69_0 <>c__DisplayClass69_0_0)
	{
		return this.vmethod_35(<>c__DisplayClass69_0_0.vector2_0) + this.vmethod_37(<>c__DisplayClass69_0_0.vector2_1, <>c__DisplayClass69_0_0.vector2_0, <>c__DisplayClass69_0_0.wKuwXvebEcP) - Vector2.Distance(<>c__DisplayClass69_0_0.vector2_1, <>c__DisplayClass69_0_0.vector2_0) * 2f;
	}

	[CompilerGenerated]
	private void method_22(ref GClass903.<>c__DisplayClass69_0 <>c__DisplayClass69_0_0)
	{
		float num = this.method_21(ref <>c__DisplayClass69_0_0);
		if (num > <>c__DisplayClass69_0_0.float_0)
		{
			<>c__DisplayClass69_0_0.float_0 = num;
			<>c__DisplayClass69_0_0.vector2_2 = <>c__DisplayClass69_0_0.vector2_0;
		}
	}

	[CompilerGenerated]
	private GClass889 gclass889_0;

	[CompilerGenerated]
	private GroupAttackMode groupAttackMode_0;

	[CompilerGenerated]
	private Vector2 vector2_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private KamikazeState kamikazeState_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private UnknownMapObjectsTracker<bool> unknownMapObjectsTracker_0;

	[CompilerGenerated]
	private bool bool_2;
}

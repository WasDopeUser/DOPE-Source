using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.CommonStructures.Containers;
using DarkorbitAPI.Licensing;
using DarkorbitAPI.NativeWrappers;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DarkorbitAPI.Structures.Pathing;
using DOPE.Common;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using DOPE.Common.Structures;
using DOPE.UI.Models;
using NLog;

public class GClass890 : INotifyPropertyChanged, ILogManager, IPErkavaBotController
{
	public Collectible CollectibleTarget
	{
		[CompilerGenerated]
		get
		{
			return this.collectible_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.collectible_0, value))
			{
				return;
			}
			this.collectible_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_9);
		}
	}

	public void method_0()
	{
		if (this.Cooldowns.method_2(BotAction.RepairBot, 5000.0))
		{
			this.Game.Connection.Server.method_10();
		}
	}

	public void Cloak()
	{
		if (this.Game.Hero.Cloaked)
		{
			return;
		}
		if (!this.Cooldowns.method_2(BotAction.Cloak, 5000.0))
		{
			return;
		}
		this.Log.Debug("Cloaking");
		MenuItem menuItem;
		if (this.Hero.MenuItems.TryGetValue("equipment_extra_cpu_cl04k", out menuItem) && menuItem.Activatable && !menuItem.Selected)
		{
			this.Server.method_15(menuItem.Id, true, false);
			return;
		}
		if (this.Game.Hero.Uridium >= 500.0)
		{
			this.BackgroundQueue.Enqueue(new Func<DarkOrbitWebAPI, object>(GClass890.<>c.<>c_0.method_0));
		}
	}

	public bool method_1(Vector2 vector2_2, int int_11 = 300, bool bool_13 = false)
	{
		if (this.Cooldowns.method_2(BotAction.Move, (double)int_11))
		{
			this.Game.Connection.Server.method_6(vector2_2.X, vector2_2.Y, false);
			return true;
		}
		return false;
	}

	public void method_2(int int_11 = 0)
	{
		if (!this.Game.LastJumped.Cooldown(5000))
		{
			return;
		}
		if (this.Cooldowns.method_2(BotAction.Jump, 600.0))
		{
			this.Game.Connection.Server.method_2(int_11);
		}
	}

	public void method_3(Collectible collectible_1)
	{
		if (this.Game.Security.HashBlockList.method_0(collectible_1.Hash) && this.Cooldowns.method_2(BotAction.Collect, 600.0))
		{
			this.string_0 = collectible_1.Hash;
			UsageCounter<string>.UsageEntry usageEntry = this.BoxTracker.method_2(collectible_1.Hash, TimeSpan.FromSeconds(60000.0), true);
			this.Log.Debug<string, int>("Collecting {boxType} tries={tries}", collectible_1.Type, usageEntry.Count);
			Collectible collectible;
			this.DormantTargets.TryRemove(collectible_1.Hash, out collectible);
			this.Game.Connection.Server.method_14(collectible_1);
			this.IsCollecting = true;
			if (usageEntry.Count > 3)
			{
				this.Game.Security.HashBlockList.method_2(collectible_1.Hash, 120000.0);
			}
		}
	}

	public bool method_4(Vector2 vector2_2, int int_11, int int_12 = 300, bool bool_13 = false, int int_13 = 640, int int_14 = 360, int int_15 = 0, int int_16 = 0, int int_17 = 0, bool bool_14 = false, int int_18 = 0, Action action_0 = null)
	{
		GClass890.<>c__DisplayClass13_0 CS$<>8__locals1 = new GClass890.<>c__DisplayClass13_0();
		CS$<>8__locals1.vector2_0 = vector2_2;
		CS$<>8__locals1.vector2_0 = Vector2.Clamp(CS$<>8__locals1.vector2_0, Vector2.Zero, this.Map.MapSize.Vector);
		if (Vector2.Distance(CS$<>8__locals1.vector2_0, this.HeroPosition) <= (float)int_11)
		{
			if (bool_13)
			{
				this.method_1(this.HeroPosition, 300, true);
			}
			return true;
		}
		if (this.Cooldowns.method_0(BotAction.Move))
		{
			if (!bool_14 && this.Map.Grid.method_2(this.HeroPosition, CS$<>8__locals1.vector2_0))
			{
				PathSequence pathSequence = this.Map.Grid.method_13(this.HeroPosition, CS$<>8__locals1.vector2_0, 30, int_17);
				if (pathSequence == null)
				{
					this.Log.Warn<Vector2, Vector2>("No path from {p1} to {p2}", this.HeroPosition, CS$<>8__locals1.vector2_0);
					if (action_0 != null)
					{
						action_0();
						return false;
					}
				}
				if (pathSequence != null)
				{
					pathSequence.method_2(this.HeroPosition, new Action<Vector2>(CS$<>8__locals1.method_0), this.Map.Grid, 30);
				}
				int num = 0;
				int_16 = 0;
				int_15 = num;
			}
			Vector2 vector2_3 = this.Game.Security.RsiCywyor9(this.HeroPosition, (int)CS$<>8__locals1.vector2_0.X, (int)CS$<>8__locals1.vector2_0.Y, int_13, int_14, int_15, int_16, int_18);
			this.method_1(vector2_3, int_12, false);
		}
		return false;
	}

	public bool method_5(PathSequence pathSequence_1, int int_11 = 300, bool bool_13 = false, int int_12 = 640, int int_13 = 360, int int_14 = 0, int int_15 = 0, int int_16 = 0)
	{
		return true;
	}

	public void method_6(Ship ship_1, bool bool_13 = false)
	{
		if (this.Cooldowns.method_2(BotAction.SelectShip, 275.0))
		{
			this.Game.Connection.Server.method_9(ship_1, bool_13);
			this.float_0 = ship_1.HpPercentage;
			this.Log.Debug("Selecting ship {shipName}", ship_1.Name);
		}
	}

	public void method_7(Ship ship_1)
	{
		LaserType laserType;
		RocketType rocketType;
		HellstormType hellstormType;
		if (!this.MapProfile.GetAmmo(ship_1, this.Map, out laserType, out rocketType, out hellstormType))
		{
			this.EnemyTarget = null;
			return;
		}
		if (laserType > LaserType.LCB_10 && this.Hero.method_21(Ammo.smethod_1(laserType)) < 100.0)
		{
			laserType = LaserType.LCB_10;
		}
		while (rocketType > RocketType.PLT_2026 && this.Hero.method_21(Ammo.smethod_2(rocketType)) < 10.0)
		{
			rocketType--;
		}
		while (hellstormType > HellstormType.ECO_10 && this.Hero.method_21(Ammo.smethod_3(hellstormType)) < 10.0)
		{
			hellstormType--;
		}
		string selectedAmmo = Ammo.smethod_1(laserType);
		string text = Ammo.smethod_2(rocketType);
		string text2 = Ammo.smethod_3(hellstormType);
		this.Server.method_16(this.SelectedAmmo = selectedAmmo, true);
		if (this.Hero.method_16("equipment_extra_cpu_arol-x"))
		{
			this.Server.method_16("equipment_extra_cpu_arol-x", text != null);
		}
		if (this.Hero.method_16("equipment_extra_cpu_rllb-x"))
		{
			this.Server.method_16("equipment_extra_cpu_rllb-x", text2 != null);
		}
		this.Server.method_16(this.SelectedRockets = text, true);
		this.Server.method_16(this.SelectedHS = text2, true);
	}

	public bool IsAttacking
	{
		[CompilerGenerated]
		get
		{
			return this.bool_0;
		}
		[CompilerGenerated]
		set
		{
			if (this.bool_0 == value)
			{
				return;
			}
			this.bool_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_26);
		}
	}

	public bool IsCollecting
	{
		[CompilerGenerated]
		get
		{
			return this.bool_1;
		}
		[CompilerGenerated]
		set
		{
			if (this.bool_1 == value)
			{
				return;
			}
			this.bool_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_27);
		}
	}

	public int AttackingId
	{
		[CompilerGenerated]
		get
		{
			return this.int_0;
		}
		[CompilerGenerated]
		set
		{
			if (this.int_0 == value)
			{
				return;
			}
			this.int_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_0);
		}
	}

	public void method_8(Ship ship_1)
	{
		if (ship_1 == null)
		{
			this.IsAttacking = false;
			this.Server.method_11();
			return;
		}
		if (this.IsAttacking && ship_1.Id == this.AttackingId && !this.Game.Hero.LastAttacked.Cooldown(2000))
		{
			if (this.IsAttacking)
			{
				this.method_7(ship_1);
				if (ship_1.LastTookDamageHero.smethod_0(3000) && this.Behavior.vmethod_4(ship_1).GroupAttackMode == GroupAttackMode.Assist && this.Cooldowns.method_2(BotAction.PingLocation, 3000.0))
				{
					this.Server.method_27(this.HeroPosition);
				}
			}
		}
		else
		{
			if (this.IsAttacking)
			{
				this.Server.method_11();
			}
			this.IsAttacking = false;
			this.method_7(ship_1);
			if (this.Cooldowns.method_2(BotAction.Attack, 225.0))
			{
				this.IsAttacking = true;
				this.Game.Hero.LastAttacked = DateTimeOffset.Now;
				this.Game.Connection.Server.method_12(ship_1);
				this.AttackingId = ship_1.Id;
				return;
			}
		}
	}

	public void method_9()
	{
		if (!this.Cooldowns.method_2(BotAction.BuyAmmo, 2000.0))
		{
			return;
		}
		if (this.SelectedAmmo == "ammunition_laser_lcb-10" && this.Hero.method_21(this.SelectedAmmo) < 1900.0)
		{
			this.Log.Debug("Buying {ammoType}", this.SelectedAmmo);
			this.Server.method_15("buy_" + this.SelectedAmmo, true, false);
		}
		if ((this.SelectedRockets == "ammunition_rocket_r-310" || this.SelectedRockets == "ammunition_rocket_plt-2026") && this.Hero.method_21(this.SelectedRockets) < 90.0)
		{
			this.Log.Debug("Buying {ammoType}", this.SelectedAmmo);
			this.Server.method_15("buy_" + this.SelectedRockets, true, false);
		}
		if (this.SelectedHS == "ammunition_rocketlauncher_eco-10" && this.Hero.method_21(this.SelectedHS) < 90.0)
		{
			this.Log.Debug("Buying {ammoType}", this.SelectedHS);
			bool flag;
			this.method_10<bool>("BuyAmmoHs", new Func<DarkOrbitWebAPI, bool>(this.method_85), out flag);
		}
	}

	public bool method_10<gEvkUYQ5M0P0eSp5eTm>(string string_4, Func<DarkOrbitWebAPI, gEvkUYQ5M0P0eSp5eTm> func_0, out gEvkUYQ5M0P0eSp5eTm gparam_0)
	{
		GClass890.<>c__DisplayClass33_0<gEvkUYQ5M0P0eSp5eTm> CS$<>8__locals1 = new GClass890.<>c__DisplayClass33_0<gEvkUYQ5M0P0eSp5eTm>();
		CS$<>8__locals1.f = func_0;
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.key = string_4;
		gparam_0 = default(gEvkUYQ5M0P0eSp5eTm);
		object obj;
		if (!this.concurrentDictionary_0.TryGetValue(CS$<>8__locals1.key, out obj))
		{
			Func<DarkOrbitWebAPI, object> item = new Func<DarkOrbitWebAPI, object>(CS$<>8__locals1.method_0);
			this.concurrentDictionary_0[CS$<>8__locals1.key] = new object();
			this.BackgroundQueue.Enqueue(item);
			return false;
		}
		if (obj is gEvkUYQ5M0P0eSp5eTm)
		{
			gEvkUYQ5M0P0eSp5eTm gEvkUYQ5M0P0eSp5eTm = (gEvkUYQ5M0P0eSp5eTm)((object)obj);
			object obj2;
			this.concurrentDictionary_0.TryRemove(CS$<>8__locals1.key, out obj2);
			gparam_0 = gEvkUYQ5M0P0eSp5eTm;
			return true;
		}
		return false;
	}

	private bool method_11(int int_11)
	{
		if (this.Hero.Config != int_11 && this.Cooldowns.method_2(BotAction.SetConfig, 5250.0))
		{
			this.Server.method_4(int_11);
			return true;
		}
		return false;
	}

	public void method_12(bool bool_13, bool bool_14 = false)
	{
		int num;
		int num2;
		GEnum4 genum;
		GEnum4 genum2;
		this.MapProfile.GetConfig(this.EnemyTarget, this.Game.Map, out num, out num2, out genum, out genum2);
		int num3 = bool_13 ? num : num2;
		GEnum4 genum3 = bool_13 ? genum : genum2;
		if (this.Behavior.method_10() >= KamikazeState.PullingEnemies)
		{
			if (this.MapProfile.KamikazeConfig != 0)
			{
				num3 = this.MapProfile.KamikazeConfig;
			}
			if (this.MapProfile.KamikazeFormation != GEnum4.Default)
			{
				genum3 = this.MapProfile.KamikazeFormation;
			}
		}
		if (this.State == BotState.Flee || (this.State == BotState.Travel && this.bool_9) || this.State == BotState.Repair)
		{
			num3 = this.MapProfile.FleeConfig;
			genum3 = this.MapProfile.FleeFormation;
		}
		if (!bool_14)
		{
			GClass900 gclass = this.Module as GClass900;
			if (gclass != null)
			{
				int num4 = this.Map.Ships.Count(new Func<KeyValuePair<int, Ship>, bool>(GClass890.<>c.<>c_0.method_1));
				if (gclass.vmethod_1() && num4 == 0)
				{
					genum3 = GEnum4.Veteran;
				}
				else if (this.MapProfile.UseMothToKillCorners && this.Hero.method_16(GEnum4.Moth.smethod_0()) && this.method_86())
				{
					genum3 = GEnum4.Moth;
				}
			}
			MenuItem menuItem;
			if (this.Hero.MenuItems.TryGetValue(genum3.smethod_0(), out menuItem) && menuItem.Activatable && !menuItem.Selected && this.Hero.ItemCooldown.method_0(CooldownType.DroneFormation) && this.Cooldowns.method_2(BotAction.SwitchDroneFormation, 500.0))
			{
				this.Server.method_16(genum3.smethod_0(), true);
			}
		}
		if (this.Hero.Config != num3)
		{
			this.method_11(num3);
		}
	}

	public bool AraMpIxlIaL(bool bool_13, bool bool_14 = false)
	{
		if (this.Behavior is GClass908)
		{
			bool_13 = false;
		}
		Gate gate_;
		Vector2? vector = this.Behavior.vmethod_19(this.Map.Hero.Position, out gate_, bool_14, bool_13);
		if (vector == null)
		{
			return false;
		}
		if (!bool_13 && Vector2.Distance(vector.Value, this.Hero.Position) < 100f)
		{
			vector = this.Behavior.vmethod_19(this.Map.Hero.Position, out gate_, bool_14, true);
		}
		return vector != null && this.method_36(vector.Value, gate_, 15, bool_14);
	}

	public void AutoRefine()
	{
		if (!this.Cooldowns.method_0(BotAction.AutoRefine))
		{
			return;
		}
		foreach (ResourceType resourceType in GClass890.resourceType_0)
		{
			int num = this.Hero.method_27(resourceType);
			if (num > 0)
			{
				this.Server.method_21(resourceType, (double)num);
				this.Cooldowns.method_1(BotAction.AutoRefine, 500.0);
				return;
			}
		}
	}

	protected bool method_13()
	{
		if (this.Map.Grid.method_6(this.HeroPosition) && !this.IsCollecting && this.HeroPosition != default(Vector2) && this.HeroPosition != new Vector2((float)this.Map.MapSize.Width, (float)this.Map.MapSize.Height))
		{
			Vector2 vector = this.Map.Grid.method_16(this.HeroPosition);
			if (vector == default(Vector2))
			{
				vector = new Vector2((float)(this.Map.MapSize.Width / 2), (float)(this.Map.MapSize.Height / 2));
			}
			this.method_1(vector, 300, false);
			return true;
		}
		return false;
	}

	public int method_14()
	{
		return this.int_7 + this.maxStack_0.Sum();
	}

	public void method_15()
	{
		if (this.dateTimeOffset_0.Cooldown(200))
		{
			this.maxStack_0.method_0(this.int_7);
			this.int_7 = 0;
			this.dateTimeOffset_0 = DateTimeOffset.Now;
		}
		if (this.Map.IsGG && this.Behavior.vmethod_26())
		{
			int num = this.method_14();
			if ((double)num > Math.Min((double)this.Hero.HpMax * 0.1, 20000.0) && (double)(this.Hero.Hp + this.Hero.Shield) - Math.Min((double)this.Hero.HpMax * 0.25, 60000.0) < 2.1 * (double)num)
			{
				this.Log.Warn("Took {damage} in the last second. Fleeing.", num);
				this.method_19();
				this.method_18();
				this.method_12(false, false);
				this.method_53();
			}
			return;
		}
	}

	private bool method_16(List<string> list_4)
	{
		foreach (string text in list_4)
		{
			MenuItem menuItem;
			if (this.Hero.method_18(text, out menuItem, true))
			{
				return true;
			}
		}
		return false;
	}

	private string method_17(List<string> list_4)
	{
		foreach (string result in list_4)
		{
			MenuItem menuItem;
			if (this.Hero.method_17(result, out menuItem))
			{
				return result;
			}
		}
		return null;
	}

	public bool method_18()
	{
		return this.method_16(GClass890.list_0);
	}

	public bool method_19()
	{
		return this.method_16(GClass890.list_2);
	}

	public bool method_20()
	{
		return this.method_16(new List<string>
		{
			"ability_aegis_shield-repair"
		});
	}

	public bool method_21()
	{
		if (this.method_17(GClass890.list_0) == "ability_solace")
		{
			using (IEnumerator<GroupManager.GroupMember> enumerator = this.Hero.Group.method_11().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GroupManager.GroupMember groupMember = enumerator.Current;
					GClass198 shipInfo = groupMember.ShipInfo;
					if (shipInfo != null)
					{
						float num = (float)shipInfo.int_0 / ((float)shipInfo.int_1 + 1f) * 100f;
						this.Log.Info("Healing group member {member}", groupMember.Name);
						if (num < (float)this.MapProfile.MinHealHp)
						{
							return this.method_18();
						}
					}
				}
				return false;
			}
			bool result;
			return result;
		}
		return false;
	}

	public bool method_22()
	{
		Ship ship = this.Map.method_5<Ship>(this.HeroPosition, new Func<Ship, bool>(this.method_87), null, 0);
		GClass88 server = this.Server;
		string text = "ability_tartarus_speed-boost";
		bool flag = true;
		bool flag2 = true;
		server.method_16(text, flag);
		if ((float)this.MapProfile.MinHealHp >= this.Hero.HpPercentage)
		{
			flag2 |= this.method_18();
		}
		if ((float)this.MapProfile.MinHealHp >= this.Hero.ShieldPercentage)
		{
			flag2 |= this.method_20();
		}
		if (ship != null && this.State == BotState.Travel && Vector2.Distance(ship.Position, this.HeroPosition) < 1000f)
		{
			flag2 |= this.method_19();
		}
		flag2 |= this.method_21();
		Ship selectedShip = this.Map.SelectedShip;
		if (this.IsAttacking && selectedShip != null && this.AttackingId == selectedShip.Id)
		{
			SelectedNpcModel selectedNpcModel = this.Behavior.vmethod_4(selectedShip);
			if (selectedNpcModel != null && selectedNpcModel.UseOffensiveAbility)
			{
				string text2 = this.method_17(GClass890.list_1);
				if (text2 == "ability_diminisher")
				{
					if (selectedShip.Shield > 15000 && selectedShip.Hp > 25000)
					{
						GClass88 server2 = this.Server;
						string text3 = text2;
						bool flag3 = true;
						flag2 = true;
						server2.method_15(text3, flag3, false);
					}
				}
				else if (text2 == "ability_venom")
				{
					if (selectedShip.Hp > 25000)
					{
						GClass88 server3 = this.Server;
						string text4 = text2;
						bool flag4 = true;
						flag2 = true;
						server3.method_15(text4, flag4, false);
					}
				}
				else if (text2 != null && selectedShip.Hp > 25000)
				{
					GClass88 server4 = this.Server;
					string text5 = text2;
					bool flag5 = true;
					flag2 = true;
					server4.method_15(text5, flag5, false);
				}
			}
		}
		return flag2;
	}

	public ErrorReason LastDisconnectReason
	{
		[CompilerGenerated]
		get
		{
			return this.errorReason_0;
		}
		[CompilerGenerated]
		set
		{
			this.errorReason_0 = value;
			this.method_23();
			this.method_94(Class10.LastDisconnectReason);
		}
	}

	public MapProfile MapProfile
	{
		[CompilerGenerated]
		get
		{
			return this.mapProfile_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.mapProfile_0, value))
			{
				return;
			}
			this.mapProfile_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_39);
		}
	}

	public AccountSettings Account
	{
		[CompilerGenerated]
		get
		{
			return this.accountSettings_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.accountSettings_0, value))
			{
				return;
			}
			this.accountSettings_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_23);
			this.method_94(Class10.propertyChangedEventArgs_36);
			this.method_94(Class10.Account);
		}
	}

	public GClass888 Scheduler
	{
		[CompilerGenerated]
		get
		{
			return this.gclass888_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.gclass888_0, value))
			{
				return;
			}
			this.gclass888_0 = value;
			this.method_94(Class10.Scheduler);
		}
	}

	public int RealDist
	{
		[CompilerGenerated]
		get
		{
			return this.int_1;
		}
		[CompilerGenerated]
		set
		{
			if (this.int_1 == value)
			{
				return;
			}
			this.int_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_44);
		}
	}

	public DateTime LastLogin
	{
		[CompilerGenerated]
		get
		{
			return this.dateTime_0;
		}
		[CompilerGenerated]
		set
		{
			if (DateTime.Equals(this.dateTime_0, value))
			{
				return;
			}
			this.dateTime_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_33);
		}
	}

	public DateTime LastMapLogin
	{
		[CompilerGenerated]
		get
		{
			return this.dateTime_1;
		}
		[CompilerGenerated]
		set
		{
			if (DateTime.Equals(this.dateTime_1, value))
			{
				return;
			}
			this.dateTime_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_34);
		}
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		get
		{
			return this.bool_2;
		}
		[CompilerGenerated]
		set
		{
			if (this.bool_2 == value)
			{
				return;
			}
			this.bool_2 = value;
			this.method_94(Class10.propertyChangedEventArgs_28);
		}
	}

	public bool Run
	{
		[CompilerGenerated]
		get
		{
			return this.bool_3;
		}
		[CompilerGenerated]
		set
		{
			if (this.bool_3 == value)
			{
				return;
			}
			this.bool_3 = value;
			this.method_94(Class10.propertyChangedEventArgs_47);
		}
	}

	public bool IsStopping
	{
		[CompilerGenerated]
		get
		{
			return this.bool_4;
		}
		[CompilerGenerated]
		set
		{
			if (this.bool_4 == value)
			{
				return;
			}
			this.bool_4 = value;
			this.method_94(Class10.propertyChangedEventArgs_29);
		}
	}

	public Thread BotThread
	{
		[CompilerGenerated]
		get
		{
			return this.thread_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.thread_0, value))
			{
				return;
			}
			this.thread_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_6);
		}
	}

	public void method_23()
	{
		if (this.LastDisconnectReason != ErrorReason.Unknown)
		{
			this.Log.Error<ErrorReason>("Error: {reason}", this.LastDisconnectReason);
		}
	}

	public void method_24(string string_4)
	{
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged == null)
		{
			return;
		}
		propertyChanged(this, new PropertyChangedEventArgs(string_4));
	}

	public ConcurrentQueue<Func<DarkOrbitWebAPI, object>> BackgroundQueue
	{
		[CompilerGenerated]
		get
		{
			return this.concurrentQueue_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.concurrentQueue_0, value))
			{
				return;
			}
			this.concurrentQueue_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_1);
		}
	}

	public Task LastBackgroundAction
	{
		[CompilerGenerated]
		get
		{
			return this.task_0;
		}
		[CompilerGenerated]
		internal set
		{
			if (object.Equals(this.task_0, value))
			{
				return;
			}
			this.task_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_31);
		}
	}

	public Task LastBackgroundHandlerAction
	{
		[CompilerGenerated]
		get
		{
			return this.task_1;
		}
		[CompilerGenerated]
		internal set
		{
			if (object.Equals(this.task_1, value))
			{
				return;
			}
			this.task_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_32);
		}
	}

	public void method_25()
	{
		bool bool_ = false;
		if (this.State == BotState.Repair)
		{
			return;
		}
		if (this.State != BotState.Flee && this.State != BotState.Travel && (!this.Hero.LastAttacked.Cooldown(3000) || (this.State == BotState.Hunt && this.EnemyTarget != null && Vector2.Distance(this.HeroPosition, this.EnemyTarget.Position) < 1000f) || (!this.ignoreShields && this.Hero.ShieldPercentage < 90f && this.Hero.Config == this.MapProfile.AttackConfig && this.Hero.Formation == this.MapProfile.AttackFormation)))
		{
			bool_ = true;
		}
		this.method_12(bool_, false);
	}

	private bool method_26(PetState petState_0)
	{
		if (this.Hero.Pet.IsControlDisabled)
		{
			return false;
		}
		if (this.Cooldowns.method_2(BotAction.SwitchPetState, 2000.0))
		{
			this.Server.method_19(petState_0);
			return true;
		}
		return false;
	}

	private bool method_27(PetMode petMode_0, int int_11 = 0)
	{
		if (this.Hero.Pet.IsControlDisabled)
		{
			return false;
		}
		if (this.Cooldowns.method_2(BotAction.SwitchPetMode, 2000.0))
		{
			this.Server.method_20(petMode_0, int_11);
			this.dateTimeOffset_1 = DateTimeOffset.Now;
			return true;
		}
		return false;
	}

	public UsageCounter<int> EnemyLocated
	{
		[CompilerGenerated]
		get
		{
			return this.usageCounter_0;
		}
		[CompilerGenerated]
		protected set
		{
			if (object.Equals(this.usageCounter_0, value))
			{
				return;
			}
			this.usageCounter_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_19);
		}
	}

	public void method_28()
	{
		if (!this.Hero.Pet.IsAvailable || !this.Hero.IsInitialized)
		{
			return;
		}
		int num;
		PetMode petMode = this.Behavior.vmethod_33(out num);
		if (petMode <= PetMode.Off)
		{
			if (this.Hero.Pet.IsEnabled)
			{
				this.method_27(PetMode.Passive, 0);
				this.method_26(PetState.Deactivate);
			}
			return;
		}
		if (this.Hero.Pet.IsEnabled)
		{
			if (this.Hero.Pet.Fuel < 2500 && this.Cooldowns.method_2(BotAction.BuyPetFuel, 60000.0))
			{
				bool flag;
				this.method_10<bool>("BuyPetFuel", new Func<DarkOrbitWebAPI, bool>(GClass890.<>c.<>c_0.method_2), out flag);
			}
			bool flag2;
			if (!this.dateTimeOffset_1.Cooldown(10000) && petMode == this.Hero.Pet.Mode)
			{
				if (num == this.Hero.Pet.ModeExtra)
				{
					flag2 = false;
					goto IL_185;
				}
			}
			flag2 = this.Hero.Pet.method_15(petMode);
			IL_185:
			if (flag2)
			{
				this.method_27(petMode, num);
			}
			return;
		}
		if (this.Hero.Pet.IsRepairNeeded)
		{
			if (this.Cooldowns.method_2(BotAction.RepairPet, 120000.0))
			{
				this.Server.method_19(PetState.Repair);
			}
			return;
		}
		this.method_26(PetState.Activate);
		this.Cooldowns.method_1(BotAction.BuyPetFuel, 60000.0);
		this.Cooldowns.method_1(BotAction.SwitchPetMode, 2000.0);
	}

	public bool method_29()
	{
		if (this.dateTimeOffset_2.Cooldown(5000))
		{
			this.method_82();
		}
		this.method_15();
		this.method_22();
		this.method_9();
		this.method_25();
		this.method_28();
		if (this.Account.AutoRefine)
		{
			this.AutoRefine();
		}
		if (this.Hero.method_16("equipment_extra_repbot_rep") && !this.Hero.method_16("equipment_extra_cpu_nc-rrb-x") && this.Hero.LastTookDamage.Cooldown(6000) && this.Hero.LastAttacked.Cooldown(1000) && this.Hero.HpPercentage < 100f)
		{
			this.method_0();
		}
		if (this.MapProfile.Cloak && !this.MapProfile.Hunter)
		{
			this.Cloak();
		}
		if (Vector2.Distance(this.HeroPosition, this.RoamTarget) < 300f)
		{
			this.RoamTarget = Vector2.Zero;
		}
		if (this.IsAttacking)
		{
			if (this.EnemyTarget == null || this.Game.Hero.LastAttacked.Cooldown(30000) || this.State == BotState.Travel || this.State == BotState.Repair)
			{
				this.Game.Connection.Server.method_11();
				if (this.EnemyTarget != null)
				{
					this.NpcLockout.method_1(this.EnemyTarget.Id, 10000.0);
				}
				this.EnemyTarget = null;
				this.IsAttacking = false;
			}
			if (this.MapProfile.UseRocketPrecision)
			{
				MenuItem menuItem;
				this.Hero.method_18("tech_precision-targeter", out menuItem, false);
			}
		}
		if (!this.Hero.method_16("equipment_extra_cpu_arol-x") && this.IsAttacking && this.Hero.ItemCooldown.method_0(CooldownType.Rocket) && this.SelectedRockets != null)
		{
			this.Hero.ItemCooldown.method_2(CooldownType.Rocket, 213.0);
			this.Server.method_13(this.EnemyTarget);
		}
		if (this.MapProfile.FleeFromEnemySeen && !this.Behavior.vmethod_3(false, false))
		{
			if (GClass890.botState_2.HasFlag(this.State))
			{
				this.method_67(BotState.Flee);
			}
		}
		else if (this.Game.Hero.HpPercentage < (float)this.MapProfile.MinHp && this.Behavior.vmethod_26() && GClass890.botState_2.HasFlag(this.State))
		{
			this.method_67(BotState.Repair);
		}
		return false;
	}

	public Ship EnemyTarget
	{
		[CompilerGenerated]
		get
		{
			return this.ship_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.ship_0, value))
			{
				return;
			}
			this.ship_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_20);
		}
	}

	public bool method_30()
	{
		bool flag = this.method_77();
		bool flag2 = this.method_76();
		BotState botState_;
		if (flag ^ flag2)
		{
			if (flag)
			{
				botState_ = BotState.Collect;
			}
			else
			{
				botState_ = BotState.Hunt;
			}
		}
		else
		{
			if (!flag || !flag2)
			{
				return false;
			}
			if (this.Behavior.vmethod_13(this.EnemyTarget, this.CollectibleTarget))
			{
				botState_ = BotState.Collect;
			}
			else
			{
				botState_ = BotState.Hunt;
			}
		}
		this.method_67(botState_);
		return true;
	}

	public void method_31()
	{
		if (this.StateIters <= 1)
		{
			this.int_2 = 0;
		}
		if (this.Map.IsGG && this.Map.Gates.Any<KeyValuePair<int, Gate>>())
		{
			if (this.StateIters <= 1)
			{
				this.Game.Web.GgInfo = null;
			}
			if (this.Map.method_2(this.HeroPosition, 100))
			{
				this.method_4(this.Map.Center, 10, 300, false, 640, 360, 0, 0, 0, false, 0, null);
			}
		}
		if (this.method_13())
		{
			return;
		}
		if (this.Behavior.vmethod_25() && ((this.Game.Hero.HpPercentage < 98f && this.Hero.method_16("equipment_extra_repbot_rep")) || (!this.ignoreShields && this.Game.Hero.ShieldPercentage < 90f)) && this.dateTimeOffset_3.Cooldown(10000))
		{
			this.method_67(BotState.Repair);
			return;
		}
		if (this.Game.Web.GgInfo == null)
		{
			return;
		}
		if (this.IsStopping && this.Behavior.vmethod_15())
		{
			this.method_67(BotState.Logout);
			return;
		}
		if (this.Hero.InSafeZone)
		{
			if (!this.Behavior.vmethod_3(false, true))
			{
				this.Timeout = new DateTime?(DateTime.Now.AddSeconds((double)this.MapProfile.FleeTimeout));
			}
			if (this.Timeout != null)
			{
				if (!(this.Timeout.Value < DateTime.Now))
				{
					return;
				}
				this.Timeout = null;
			}
		}
		int num;
		if (!this.method_78(out num))
		{
			this.Clear();
			this.method_67(this.Behavior.vmethod_17());
			return;
		}
		Gate gate = this.Behavior.vmethod_24(num);
		if (gate != null)
		{
			this.method_36(gate.Position, gate, 15, false);
			return;
		}
		int num2 = this.int_2;
		this.int_2 = num2 + 1;
		if (num2 > 400)
		{
			this.method_65((GClass892.GEnum10)2);
			return;
		}
	}

	public DateTime? Timeout
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_0;
		}
		[CompilerGenerated]
		set
		{
			if (Nullable.Equals<DateTime>(this.nullable_0, value))
			{
				return;
			}
			this.nullable_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_56);
		}
	}

	private bool method_32(GEnum4 genum4_0)
	{
		MenuItem menuItem;
		return this.Hero.MenuItems.TryGetValue(genum4_0.smethod_0(), out menuItem) && menuItem.Selected;
	}

	private bool ignoreShields
	{
		get
		{
			return this.method_32(GEnum4.Wheel) || this.method_32(GEnum4.Moth);
		}
	}

	public void method_33()
	{
		if (this.StateIters == 0)
		{
			this.int_4 = 0;
			this.nullable_1 = null;
			this.bool_6 = false;
			this.bool_7 = false;
		}
		if (!this.Behavior.vmethod_26())
		{
			this.method_68();
			return;
		}
		if (this.Game.Hero.Hp == 0 && this.StateIters > 200 && this.Game.Connection.Socket.method_2())
		{
			this.Game.Connection.method_14();
			return;
		}
		if (this.int_4 > 6)
		{
			this.method_68();
			return;
		}
		bool bool_ = this.MapProfile.FleeFormation == GEnum4.Wheel || this.MapProfile.FleeFormation == GEnum4.Moth;
		MenuItem menuItem;
		if (this.ignoreShields && this.Hero.MenuItems.TryGetValue(GEnum4.Default.smethod_0(), out menuItem) && menuItem.Activatable && !menuItem.Selected && this.Hero.ItemCooldown.method_0(CooldownType.DroneFormation) && this.Cooldowns.method_2(BotAction.SwitchDroneFormation, 1000.0))
		{
			this.Server.method_16(GEnum4.Default.smethod_0(), true);
		}
		bool flag = this.Game.Hero.LastConfigSwitched.Cooldown(1000);
		bool flag2 = this.Game.Hero.ShieldPercentage >= 90f && flag;
		bool flag3 = (flag && this.Game.Hero.HpPercentage >= 98f) || !this.Hero.method_16("equipment_extra_repbot_rep");
		int config = this.Hero.Config;
		bool flag4 = this.MapProfile.AttackConfig == 1 && this.MapProfile.FleeConfig == 1 && this.MapProfile.FlyingConfig == 1;
		bool flag5 = this.MapProfile.AttackConfig == 2 && this.MapProfile.FleeConfig == 2 && this.MapProfile.FlyingConfig == 2;
		this.bool_6 |= (flag2 && config == 1);
		this.bool_7 |= (flag2 && config == 2);
		if ((this.bool_6 || flag5) && (this.bool_7 || flag4) && flag3 && this.StateIters > 20)
		{
			this.dateTimeOffset_3 = DateTimeOffset.Now;
			this.method_68();
			return;
		}
		this.EnemyTarget = null;
		this.CollectibleTarget = null;
		if (!this.Behavior.vmethod_3(true, false))
		{
			NpcShip npcShip = this.Map.method_5<NpcShip>(this.HeroPosition, null, null, 0);
			if (!this.Map.IsGG || (npcShip != null && Vector2.Distance(npcShip.Position, this.HeroPosition) < 900f))
			{
				this.method_12(false, bool_);
			}
			if (this.Map.IsGG || !this.AraMpIxlIaL(false, false))
			{
				Vector2? vector = this.nullable_1;
				this.nullable_1 = ((vector != null) ? vector : this.Behavior.vmethod_20(false));
				if (this.nullable_1 != null && this.method_4(this.nullable_1.Value, 50, 300, false, 640, 360, 0, 0, 0, false, 0, new Action(this.method_88)))
				{
					this.nullable_1 = null;
				}
			}
		}
		if ((this.bool_6 ^ this.bool_7) && this.method_11(this.bool_6 ? 2 : 1))
		{
			this.int_4++;
		}
	}

	public void method_34()
	{
		if (!this.Behavior.vmethod_3(true, false))
		{
			if (this.AraMpIxlIaL(false, false))
			{
				return;
			}
			this.method_68();
			return;
		}
		else
		{
			if (!this.Behavior.vmethod_15())
			{
				this.method_68();
				return;
			}
			int num = (this.Hero.Premium ? 5000 : 20000) + 10000;
			if (this.StateIters == 1)
			{
				this.Server.method_6(this.HeroPosition.X, this.HeroPosition.Y, false);
				this.Server.method_18();
				return;
			}
			if (this.StateIters > num / 50)
			{
				this.method_67(BotState.Default);
				int num2 = this.int_5 + 1;
				this.int_5 = num2;
				if (num2 > 5)
				{
					this.int_5 = 0;
					this.Game.Connection.method_14();
				}
			}
			return;
		}
	}

	public Vector2 RoamTarget
	{
		get
		{
			return this.vector2_0;
		}
		set
		{
			if (this.vector2_0 == value)
			{
				return;
			}
			this.bool_8 = false;
			this.vector2_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_46);
		}
	}

	public void method_35()
	{
		if (this.method_69())
		{
			return;
		}
		int num;
		if (this.method_78(out num))
		{
			this.method_67(BotState.Default);
			return;
		}
		if (this.method_30())
		{
			return;
		}
		if (!this.Cooldowns.method_0(BotAction.Move))
		{
			return;
		}
		if (this.method_13())
		{
			this.RoamTarget = Vector2.Zero;
			return;
		}
		bool flag = this.RoamTarget == this.HeroPosition || this.RoamTarget == Vector2.Zero;
		Vector2? vector;
		if (!this.Behavior.vmethod_23(out vector))
		{
			Collectible collectible = this.method_79(this.HeroPosition);
			if (collectible != null)
			{
				this.RoamTarget = collectible.Position;
				this.bool_8 = true;
			}
			else if (flag)
			{
				this.RoamTarget = this.Game.Security.method_5(this.Game.Map, this.Behavior.vmethod_16());
			}
		}
		else
		{
			this.RoamTarget = (vector ?? Vector2.Zero);
			if (vector == null)
			{
				return;
			}
		}
		this.method_4(this.RoamTarget, 5, 200, false, 640, 360, 10, 10, 30, false, 0, new Action(this.method_89));
	}

	public Vector2? TravelTarget
	{
		[CompilerGenerated]
		get
		{
			return this.nullable_2;
		}
		[CompilerGenerated]
		set
		{
			if (Nullable.Equals<Vector2>(this.nullable_2, value))
			{
				return;
			}
			this.nullable_2 = value;
			this.method_94(Class10.propertyChangedEventArgs_59);
		}
	}

	public PathSequence CurrentPath
	{
		get
		{
			return this.pathSequence_0;
		}
		set
		{
			if (object.Equals(this.pathSequence_0, value))
			{
				return;
			}
			this.pathSequence_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_14);
		}
	}

	public bool method_36(Vector2 vector2_2, Gate gate_1 = null, int int_11 = 15, bool bool_13 = false)
	{
		GClass890.<>c__DisplayClass173_0 CS$<>8__locals1 = new GClass890.<>c__DisplayClass173_0();
		CS$<>8__locals1.gclass890_0 = this;
		CS$<>8__locals1.vector2_0 = vector2_2;
		if (gate_1 != null)
		{
			Vector2 vector = this.Map.Grid.method_15(gate_1.Position, 580f);
			if (vector == default(Vector2))
			{
				this.Log.Warn("Gate {gate} is fully obstructed.", gate_1.Id);
				return false;
			}
			if (CS$<>8__locals1.vector2_0 != vector)
			{
				this.Log.Info<int, float>("Found a way to semi-occupied gate {gate} dist={dist}.", gate_1.Id, Vector2.Distance(gate_1.Position, vector));
			}
			CS$<>8__locals1.vector2_0 = vector;
		}
		bool flag = Map.Navigators.method_4(new Action<MapNavigator>(CS$<>8__locals1.method_0), 30);
		if (flag && this.pathSequence_0 != null)
		{
			this.TravelTarget = new Vector2?(CS$<>8__locals1.vector2_0);
			this.bool_9 = bool_13;
			this.gate_0 = gate_1;
			this.int_6 = int_11;
			this.Map.Grid.method_14(this.pathSequence_0);
			this.method_67(BotState.Travel);
		}
		return flag;
	}

	public void method_37()
	{
		if (this.StateIters <= 1)
		{
			this.int_3 = 0;
		}
		if (this.LastStates.method_2() != BotState.Logout && this.method_69())
		{
			return;
		}
		if (!this.MapProfile.FleeStopOnEnemyLost || !this.bool_9 || !this.Behavior.vmethod_3(false, false))
		{
			if (this.TravelTarget != null)
			{
				Vector2 value = this.TravelTarget.Value;
				if (Vector2.Distance(value, this.HeroPosition) > (float)this.int_6)
				{
					PathSequence pathSequence = this.pathSequence_0;
					int? num;
					if (pathSequence == null)
					{
						num = null;
					}
					else
					{
						List<Vector2> path = pathSequence.Path;
						num = ((path != null) ? new int?(path.Count) : null);
					}
					int? num2 = num;
					if (num2.GetValueOrDefault() != 0)
					{
						if (this.method_4(value, this.int_6, 300, false, 640, 360, 0, 0, 0, false, 0, new Action(this.method_90)))
						{
							this.TravelTarget = null;
							goto IL_139;
						}
						goto IL_139;
					}
				}
				this.TravelTarget = null;
				this.Server.method_6(this.HeroPosition.X, this.HeroPosition.Y, false);
			}
			IL_139:
			if (this.gate_0 != null)
			{
				Gate gate;
				this.Map.Gates.TryGetValue(this.gate_0.Id, out gate);
				if (gate == null)
				{
					this.gate_0 = null;
					goto IL_20D;
				}
				if (gate.Activatable)
				{
					if (!this.bool_9 || !this.Behavior.vmethod_3(true, false) || this.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(this.method_92)))
					{
						this.method_2(gate.Id);
						this.method_91();
						return;
					}
					goto IL_20D;
				}
				else if (Vector2.Distance(gate.Position, this.HeroPosition) <= 580f)
				{
					if (this.int_3 % 10 == 0)
					{
						this.Server.method_3(gate.Id);
					}
					this.method_91();
					return;
				}
			}
			if (this.TravelTarget != null)
			{
				return;
			}
		}
		IL_20D:
		this.method_68();
	}

	public UsageCounter<string> BoxTracker
	{
		[CompilerGenerated]
		get
		{
			return this.usageCounter_1;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.usageCounter_1, value))
			{
				return;
			}
			this.usageCounter_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_7);
		}
	}

	public void method_38()
	{
		if (this.IsCollecting && this.StateIters < 150)
		{
			return;
		}
		this.method_77();
		if (this.CollectibleTarget != null && this.Game.Security.method_7(this.CollectibleTarget, false))
		{
			if (this.method_4(this.CollectibleTarget.Position, 0, 300, false, 640, 360, 10, 10, 0, false, 7, null))
			{
				if (!this.Cooldowns.method_0(BotAction.Collect))
				{
					return;
				}
				this.StateIters = 0;
				this.method_3(this.CollectibleTarget);
			}
			return;
		}
		this.IsCollecting = false;
		this.CollectibleTarget = null;
		this.method_68();
	}

	public void method_39()
	{
		if (this.Map.IsGG)
		{
			if (this.ReturnState == BotState.Repair)
			{
				this.method_68();
				return;
			}
			if (this.Behavior.vmethod_26())
			{
				this.method_67(BotState.Repair);
				return;
			}
			this.method_67(BotState.Default);
		}
		if (!this.Behavior.vmethod_3(false, false))
		{
			if (this.AraMpIxlIaL(true, true))
			{
				this.Timeout = new DateTime?(DateTime.Now.AddSeconds((double)this.MapProfile.FleeTimeout));
			}
			return;
		}
		this.method_67(BotState.Default);
	}

	public void method_40()
	{
		if (this.MapProfile != null)
		{
			this.method_67(BotState.Default);
			return;
		}
	}

	public void method_41()
	{
		GClass890.<>c__DisplayClass185_0 CS$<>8__locals1 = new GClass890.<>c__DisplayClass185_0();
		CS$<>8__locals1.wMsMoimwbJi = this;
		if (!this.MapProfile.Hunter)
		{
			this.method_68();
		}
		CS$<>8__locals1.ship_0 = this.EnemyTarget;
		if (CS$<>8__locals1.ship_0 == null)
		{
			this.method_68();
			return;
		}
		Ship enemyTarget;
		if (this.Behavior.UntCgkpMdca(CS$<>8__locals1.ship_0, out enemyTarget))
		{
			this.StateIters = 0;
			this.EnemyTarget = enemyTarget;
			return;
		}
		Ship selectedShip = this.Game.Map.SelectedShip;
		Vector2 position = CS$<>8__locals1.ship_0.Position;
		NpcShip npcShip = CS$<>8__locals1.ship_0 as NpcShip;
		if (this.Behavior.vmethod_46(npcShip))
		{
			return;
		}
		Func<bool> func = this.Behavior.vmethod_46(npcShip) ? new Func<bool>(CS$<>8__locals1.method_0) : new Func<bool>(CS$<>8__locals1.method_1);
		if (selectedShip != null)
		{
			if (selectedShip.Id == CS$<>8__locals1.ship_0.Id)
			{
				this.method_8(selectedShip);
				if (!this.Cooldowns.method_0(BotAction.Move))
				{
					return;
				}
				Vector2? vector = null;
				bool flag;
				if ((flag = this.Behavior.vmethod_1(npcShip)) && this.Behavior.vmethod_2(npcShip) && this.method_77())
				{
					if (Vector2.Distance(this.CollectibleTarget.Position, this.HeroPosition) <= 250f)
					{
						this.method_67(BotState.Collect);
						return;
					}
					if (Vector2.Distance(this.CollectibleTarget.Position, this.HeroPosition) < 1400f)
					{
						Collectible collectibleTarget = this.CollectibleTarget;
						vector = ((collectibleTarget != null) ? new Vector2?(collectibleTarget.Position) : null);
					}
				}
				if (flag)
				{
					Vector2? vector2 = this.Behavior.DohCgwiIlt4(this.HeroPosition, npcShip, vector);
					if (vector2 != null)
					{
						this.method_4(vector2.Value, 0, this.Game.Security.Random.Next(180, 200), false, 640, 360, 0, 0, 0, false, 0, new Action(CS$<>8__locals1.method_2));
					}
					return;
				}
				this.method_4(CS$<>8__locals1.ship_0.Position, 300, 300, false, 640, 360, 0, 0, 0, false, 0, new Action(CS$<>8__locals1.method_2));
				return;
			}
		}
		if (func())
		{
			this.method_6(CS$<>8__locals1.ship_0, true);
			npcShip.LastDistance = 460;
			npcShip.RangeFix = 1;
			this.method_83(npcShip);
		}
		if (this.StateIters > 15)
		{
			this.method_68();
		}
	}

	public void method_42()
	{
		Rectangle rectangle = GClass911.list_0.First<Rectangle>();
		if (!rectangle.Contains((int)this.HeroPosition.X, (int)this.HeroPosition.Y))
		{
			Vector2 vector2_ = new Vector2((float)(rectangle.X + rectangle.Width / 2), (float)(rectangle.Y + rectangle.Height / 2));
			if (this.method_36(vector2_, null, 15, false))
			{
				return;
			}
		}
		if (this.StateIters > 1000)
		{
			this.method_67(BotState.Default);
			return;
		}
		Asset value = this.Map.Assets.FirstOrDefault(new Func<KeyValuePair<int, Asset>, bool>(GClass890.<>c.<>c_0.method_3)).Value;
		if (value == null)
		{
			this.method_67(BotState.Default);
			return;
		}
		if (value.Activatable && this.Cooldowns.method_0(BotAction.TradeOre))
		{
			foreach (ResourceType resourceType in GClass890.list_3)
			{
				double num = this.Hero.method_25(resourceType);
				int num2 = (resourceType == ResourceType.PALLADIUM) ? 15 : 1;
				if (num >= (double)num2)
				{
					this.Cooldowns.method_2(BotAction.TradeOre, 500.0);
					this.Server.method_0(value.Id);
					this.Server.method_1();
					this.Server.method_22(resourceType, num);
					return;
				}
			}
			this.method_67(BotState.Default);
		}
	}

	public void method_43()
	{
		if (this.method_69())
		{
			return;
		}
		if (!this.Behavior.vmethod_3(true, false) && this.AraMpIxlIaL(false, false))
		{
			return;
		}
		this.method_67(BotState.Default);
	}

	public Vector2 HeroPosition
	{
		[CompilerGenerated]
		get
		{
			return this.vector2_1;
		}
		[CompilerGenerated]
		set
		{
			if (this.vector2_1 == value)
			{
				return;
			}
			this.vector2_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_24);
		}
	}

	public GClass923 MainController
	{
		get
		{
			GClass922 controller = this.Controller;
			if (controller == null)
			{
				return null;
			}
			return controller.Controller;
		}
	}

	public GClass922 Controller
	{
		[CompilerGenerated]
		get
		{
			return this.gclass922_0;
		}
		[CompilerGenerated]
		internal set
		{
			if (object.Equals(this.gclass922_0, value))
			{
				return;
			}
			this.gclass922_0 = value;
			this.method_94(Class10.propertyChangedEventArgs_38);
			this.method_94(Class10.Controller);
		}
	}

	public Task LoginTask
	{
		[CompilerGenerated]
		get
		{
			return this.task_2;
		}
		[CompilerGenerated]
		internal set
		{
			if (object.Equals(this.task_2, value))
			{
				return;
			}
			this.task_2 = value;
			this.method_94(Class10.propertyChangedEventArgs_37);
		}
	}

	public void method_44()
	{
		for (;;)
		{
			GameManager game = this.Game;
			int? num;
			if (game != null)
			{
				Settings settings = game.Settings;
				if (settings == null)
				{
					num = null;
				}
				else
				{
					FlashSettings flashSettings = settings.FlashSettings;
					num = ((flashSettings != null) ? new int?(flashSettings.userID) : null);
				}
			}
			else
			{
				num = null;
			}
			int? num2 = num;
			if (num2.GetValueOrDefault() != 0)
			{
				break;
			}
			Thread.Sleep(50);
		}
		for (;;)
		{
			IL_315:
			object obj = this.object_0;
			lock (obj)
			{
				this.Clear();
			}
			int num3 = 0;
			while (!this.Game.Hero.IsInitialized)
			{
				if (this.Game.Connection.Socket.method_2())
				{
					if (++num3 > 400)
					{
						this.Game.Connection.Socket.Disconnect(ErrorReason.GracefullyDisconnected, null, false);
						num3 = 0;
					}
				}
				else
				{
					num3 = 0;
				}
				Thread.Sleep(100);
			}
			Thread.Sleep(300);
			while (this.Game.Connection.Socket.method_2() && !this.IsPaused && this.Run && this.Hero.IsInitialized)
			{
				Thread.Sleep(50);
				DateTime now = DateTime.Now;
				this.Cooldowns.Now = new DateTimeOffset?(now);
				obj = this.object_0;
				lock (obj)
				{
					if (this.bool_5 || this.Hero.Hp == 0)
					{
						this.bool_5 = false;
						goto IL_315;
					}
					this.HeroPosition = this.Game.Hero.Position;
					GClass892 gclass = this.Scheduler.method_13();
					GClass904 behavior = gclass.GetBehavior();
					MapProfile mapProfile = gclass.GetMapProfile();
					bool flag2;
					if (gclass == this.Module && behavior == this.Behavior && mapProfile == this.MapProfile)
					{
						MapProfile mapProfile2 = this.MapProfile;
						TargetMap? targetMap = (mapProfile2 != null) ? new TargetMap?(mapProfile2.TargetMap) : null;
						TargetMap? targetMap2 = (mapProfile != null) ? new TargetMap?(mapProfile.TargetMap) : null;
						flag2 = !(targetMap.GetValueOrDefault() == targetMap2.GetValueOrDefault() & targetMap != null == (targetMap2 != null));
					}
					else
					{
						flag2 = true;
					}
					bool flag3 = flag2;
					this.Module = gclass;
					this.Behavior = behavior;
					this.MapProfile = mapProfile;
					behavior.Update();
					this.IsStopping = (!this.Module.ShouldBeInGame() || this.ShouldBeDisabled || this.ForceLogout);
					try
					{
						if (this.method_29())
						{
							continue;
						}
					}
					catch (Exception ex)
					{
						this.Log.Error("Exception in bot loop: {exception}", ex.ToString());
					}
					if (flag3)
					{
						this.Clear();
					}
					BotState botState_;
					if (this.Module.GetNextState(out botState_))
					{
						this.method_67(botState_);
					}
					BotState state = this.State;
					this.method_66();
					if (this.State == state)
					{
						int stateIters = this.StateIters;
						this.StateIters = stateIters + 1;
					}
				}
			}
			this.Cooldowns.Now = null;
		}
	}

	private void method_45(object object_1, GClass195 gclass195_0)
	{
		if (gclass195_0.int_0 == this.Hero.Id)
		{
			GClass890.<>c__DisplayClass204_0 CS$<>8__locals1 = new GClass890.<>c__DisplayClass204_0();
			CS$<>8__locals1.string_0 = gclass195_0.FromId.ToString();
			if (this.MainController.Bots.Any(new Func<GClass922, bool>(CS$<>8__locals1.method_0)))
			{
				this.Server.method_23(gclass195_0.FromId);
			}
		}
	}

	private void method_46()
	{
		this.Cooldowns.Clear(BotAction.RepairPet);
	}

	private void method_47(GameManager gameManager_1, GClass269 gclass269_0)
	{
		string[] array = gclass269_0.string_0.Split(new char[]
		{
			'|'
		});
		if (gameManager_1.Connection.ProxySocket != null)
		{
			this.method_48(array);
		}
		if (array.Length >= 4 && array[1] == "A" && array[2] == "STM" && array[3] == "msg_pet_out_of_fuel")
		{
			this.Log.Warn("Can't activate PET -> out of fuel!");
			this.Cooldowns.method_1(BotAction.BuyPetFuel, 60000.0);
			bool flag;
			this.method_10<bool>("BuyPetFuel", new Func<DarkOrbitWebAPI, bool>(GClass890.<>c.<>c_0.method_4), out flag);
		}
	}

	private void method_48(string[] string_4)
	{
		if (string_4.Length == 0 || string_4[0] != "69")
		{
			return;
		}
		int num;
		if (string_4.Length != 3 || !(string_4[1] == "range") || !int.TryParse(string_4[2], out num))
		{
			if (string_4.Length == 2 && string_4[1] == "distance")
			{
				Ship ship = this.Map.SelectedShip;
				NpcShip npcShip = this.Map.method_5<NpcShip>(this.Hero.Position, new Func<NpcShip, bool>(GClass890.<>c.<>c_0.method_5), null, 0);
				if (npcShip != null)
				{
					ship = npcShip;
				}
				if (ship != null)
				{
					this.method_93(string.Format("Distance to {0}: {1}", ship.Name, Vector2.Distance(this.Map.Hero.Position, ship.Position)));
					return;
				}
			}
			else
			{
				int num2;
				double num3;
				if (string_4.Length == 4 && string_4[1] == "trade" && int.TryParse(string_4[2], out num2) && double.TryParse(string_4[3], out num3))
				{
					ResourceType resourceType = (ResourceType)num2;
					this.method_93(string.Format("Attempting to sell {0} of {1}", num3, num2));
					this.Server.method_22(resourceType, num3);
					return;
				}
				if (string_4.Length == 2 && string_4[1] == "help")
				{
					this.method_93("!dope range/<npc radius>");
					this.method_93("!dope distance");
					this.method_93("!dope trade/<ore>/<amount>");
					return;
				}
				if (string_4.Length == 2 && string_4[1] == "portals")
				{
					this.method_93("PORTALS OPEN");
					GInterface5 proxySocket = this.Game.Connection.ProxySocket;
					for (int i = 1; i < 100; i++)
					{
						int int_ = i % 30 * 500;
						int int_2 = i / 30 * 1500;
						if (proxySocket != null)
						{
							proxySocket.SendMessage(new GClass191(15151515 + i, 0, i, int_, int_2, false, false, null));
						}
						if (proxySocket != null)
						{
							proxySocket.SendMessage(new GClass264(15161615 + i, "ship_goliath", 0, "", string.Format("{0}", i), int_, int_2, 0, 0, 0, false, null, 0, false, true, false, 0, 0, "", null, null));
						}
					}
					return;
				}
				if (string_4.Length == 2 && string_4[1] == "position")
				{
					this.method_93(this.Game.Hero.Position.ToString());
					return;
				}
				int num4;
				if (string_4.Length == 3 && string_4[1] == "close" && int.TryParse(string_4[2], out num4))
				{
					this.Game.Connection.SendMessage(new GClass146(num4 > 0));
					return;
				}
				if (string_4.Length == 5 && string_4[1] == "box")
				{
					bool flag = string_4[2] == "add";
					string text = string_4[3];
					GInterface5 proxySocket2 = this.Game.Connection.ProxySocket;
					if (proxySocket2 == null)
					{
						return;
					}
					if (flag)
					{
						proxySocket2.SendMessage(new GClass181(text, this.Game.Hero.PosX, this.Game.Hero.PosY, string_4[4]));
						return;
					}
					proxySocket2.SendMessage(new GClass140(text, true));
					return;
				}
				else if (string_4.Length == 4 && string_4[1] == "res")
				{
					bool flag2 = string_4[2] == "add";
					string text2 = string_4[3];
					GInterface5 proxySocket3 = this.Game.Connection.ProxySocket;
					if (proxySocket3 == null)
					{
						return;
					}
					if (flag2)
					{
						proxySocket3.SendMessage(new GClass182(text2, this.Game.Hero.PosX, this.Game.Hero.PosY, new GClass260(8)));
						return;
					}
					proxySocket3.SendMessage(new GClass140(text2, true));
					return;
				}
				else
				{
					if (string_4.Length == 2 && string_4[1] == "npc")
					{
						for (int j = 0; j < 4; j++)
						{
							GInterface5 proxySocket4 = this.Game.Connection.ProxySocket;
							if (proxySocket4 != null)
							{
								proxySocket4.SendMessage(new GClass264(15161213 + j, "ship_goliath", 0, "", "Test NPC", this.Game.Hero.PosX + j * 100, this.Game.Hero.PosY, j, 0, 0, false, null, 0, false, true, false, 0, 0, "", null, null));
							}
						}
						return;
					}
					if (string_4.Length == 3 && string_4[1] == "distance" && string_4[2] == "gate")
					{
						Gate gate = this.Map.method_5<Gate>(this.Hero.Position, null, null, 0);
						if (gate == null)
						{
							return;
						}
						float num5 = Vector2.Distance(this.Hero.Position, gate.Position);
						this.method_93(string.Format("Gate #{0} dist={1:0.00} active={2}", gate.Id, num5, gate.Activatable));
						return;
					}
					else if (string_4.Length == 3 && string_4[1] == "init" && string_4[2] == "gate")
					{
						Gate gate2 = this.Map.method_5<Gate>(this.Hero.Position, null, null, 0);
						if (gate2 == null)
						{
							return;
						}
						float num6 = Vector2.Distance(this.Hero.Position, gate2.Position);
						this.method_93(string.Format("Init Gate #{0} dist={1:0.00} active={2}", gate2.Id, num6, gate2.Activatable));
						this.Server.method_3(gate2.Id);
					}
				}
			}
			return;
		}
		NpcShip npcShip2 = this.Map.SelectedShip as NpcShip;
		NpcUtils.NpcClass npcClass;
		if (npcShip2 == null)
		{
			npcClass = null;
		}
		else
		{
			NpcUtils.NpcType type = npcShip2.Type;
			npcClass = ((type != null) ? type.Class : null);
		}
		NpcUtils.NpcClass npcClass2 = npcClass;
		if (npcClass2 == null)
		{
			this.method_93("No npc");
			return;
		}
		SecurityManager.NpcRangesRegular[npcClass2] = num;
		this.method_93(string.Format("Set range for {0} to {1}", npcClass2.ToString(), num));
	}

	private void method_49(Map map_0, Ship ship_1, GClass266 gclass266_0)
	{
		GClass890.<>c__DisplayClass208_0 CS$<>8__locals1 = new GClass890.<>c__DisplayClass208_0();
		CS$<>8__locals1.gclass890_0 = this;
		CS$<>8__locals1.ship_0 = ship_1;
		if (CS$<>8__locals1.ship_0.IsNpc)
		{
			return;
		}
		if (CS$<>8__locals1.ship_0.Id == this.Hero.Id)
		{
			return;
		}
		CS$<>8__locals1.nullable_0 = CS$<>8__locals1.ship_0.TargetPosition;
		if (CS$<>8__locals1.nullable_0 == null)
		{
			return;
		}
		CS$<>8__locals1.collectible_0 = this.Map.method_5<Collectible>(CS$<>8__locals1.nullable_0.Value, new Func<Collectible, bool>(CS$<>8__locals1.method_0), null, 0);
		if (CS$<>8__locals1.collectible_0 == null)
		{
			if (CS$<>8__locals1.ship_0 is Pet)
			{
				Collectible collectible = this.Map.method_5<Collectible>(CS$<>8__locals1.nullable_0.Value, null, null, 0);
				if (collectible != null && Vector2.Distance(collectible.Position, CS$<>8__locals1.nullable_0.Value) < 75f)
				{
					CS$<>8__locals1.collectible_0 = collectible;
				}
			}
			if (CS$<>8__locals1.collectible_0 == null)
			{
				return;
			}
		}
		if (this.Hero.Position == CS$<>8__locals1.collectible_0.Position)
		{
			return;
		}
		int num = (CS$<>8__locals1.ship_0 is Pet) ? 300 : 100;
		if (this.Hero.TimeToTargetLeft + num > CS$<>8__locals1.ship_0.TimeToTargetLeft || (CS$<>8__locals1.ship_0 is HeroPet && (this.Hero.Pet.Mode == PetMode.AutoLoot || this.Hero.Pet.Mode == PetMode.ResourceCollector) && CS$<>8__locals1.ship_0.TimeToTargetLeft < 5000 && !this.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(CS$<>8__locals1.method_1))))
		{
			this.Game.Security.HashBlockList.method_1(CS$<>8__locals1.collectible_0.Hash, (double)(CS$<>8__locals1.ship_0.TimeToTargetLeft + 3000));
		}
	}

	private void method_50(Map map_0, Ship ship_1, bool bool_13)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.EnemyTarget != null && this.EnemyTarget.Id == ship_1.Id)
			{
				this.EnemyTarget = null;
				this.IsAttacking = false;
			}
		}
	}

	private void method_51(Map map_0, Ship ship_1)
	{
		GClass890.<>c__DisplayClass210_0 CS$<>8__locals1 = new GClass890.<>c__DisplayClass210_0();
		CS$<>8__locals1.gclass890_0 = this;
		CS$<>8__locals1.ship_0 = ship_1;
		if (CS$<>8__locals1.ship_0.method_8(this.Hero))
		{
			CachedDictionary<int, bool> obj = this.cachedDictionary_0;
			lock (obj)
			{
				bool flag2;
				if (!this.cachedDictionary_0.TryGetValue(CS$<>8__locals1.ship_0.Id, out flag2))
				{
					this.Service.IsAggressor(CS$<>8__locals1.ship_0.Id).ContinueWith(new Action<Task<bool>>(CS$<>8__locals1.method_0));
				}
			}
		}
		NpcShip npcShip = CS$<>8__locals1.ship_0 as NpcShip;
		if (npcShip != null)
		{
			this.method_83(npcShip);
		}
	}

	public bool method_52(int int_11)
	{
		CachedDictionary<int, bool> obj = this.cachedDictionary_0;
		bool orDefault;
		lock (obj)
		{
			orDefault = this.cachedDictionary_0.GetOrDefault(int_11);
		}
		return orDefault;
	}

	private void method_53()
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (GClass890.botState_2.HasFlag(this.State))
			{
				this.method_67(BotState.Flee);
			}
		}
	}

	private void method_54(Map map_0, Ship ship_1, Ship ship_2, int int_11, int int_12)
	{
		if (ship_1 != null && ship_2 != null)
		{
			if (ship_2.Id == this.Game.Hero.Id)
			{
				if (this.method_81(ship_1) || !ship_1.IsNpc)
				{
					if (this.cooldownTracker_0.method_2(ship_1.Id, 300000.0))
					{
						this.Service.ReportAggressor(ship_1.Id);
						this.cachedDictionary_0.Put(ship_1.Id, true);
					}
					MapProfile mapProfile = this.MapProfile;
					if (mapProfile != null && mapProfile.FleeFromEnemyAttacker)
					{
						this.method_53();
					}
				}
				if (ship_1.IsNpc)
				{
					this.int_7 += int_11;
				}
				object obj = this.object_0;
				lock (obj)
				{
					if (this.State == BotState.Logout)
					{
						this.StateIters = 0;
					}
				}
			}
			return;
		}
	}

	private void method_55(GClass91 gclass91_0)
	{
		this.Log.Info("Connected to game server");
		this.LastDisconnectReason = ErrorReason.Unknown;
	}

	private void method_56(Map map_0, string string_4, Collectible collectible_1, bool bool_13)
	{
		object obj = this.object_0;
		lock (obj)
		{
			Collectible collectibleTarget = this.CollectibleTarget;
			if (((collectibleTarget != null) ? collectibleTarget.Hash : null) == string_4)
			{
				if (this.IsCollecting)
				{
					GClass882 stats = this.Stats;
					int boxes = stats.Boxes;
					stats.Boxes = boxes + 1;
					this.IsCollecting = false;
					this.Cooldowns.method_1(BotAction.Move, (double)this.Game.Security.Random.Next(200, 300));
				}
				this.CollectibleTarget = null;
			}
			if (bool_13)
			{
				Collectible collectible;
				this.DormantTargets.TryRemove(string_4, out collectible);
			}
		}
	}

	private void method_57(GClass91 gclass91_0, ErrorReason errorReason_1, Exception exception_0 = null)
	{
		DateTime now = DateTime.Now;
		if (!this.dateTimeOffset_4.Cooldown(60000))
		{
			this.int_8++;
		}
		else
		{
			this.int_8 = 0;
		}
		this.dateTimeOffset_4 = now;
		if (errorReason_1 == ErrorReason.LoggedOut)
		{
			this.ForceLogout = false;
		}
		if (errorReason_1 == ErrorReason.VersionMismatch)
		{
			this.ShouldBeDisabled = true;
		}
		this.Clear();
		this.LastDisconnectReason = errorReason_1;
		this.Log.Warn<ErrorReason>("Disconnected from game server, {errorReason}", errorReason_1);
		this.dateTime_2 = now;
		if (this.int_8 > 4)
		{
			this.dateTime_2 = now.AddMinutes(5.0);
			this.dateTimeOffset_4 = this.dateTime_2;
		}
		if (errorReason_1 == ErrorReason.NoLicense)
		{
			this.dateTime_2 = now.AddMinutes(10.0);
		}
		if (errorReason_1 == ErrorReason.GracefullyDisconnected || this.Game.NextMapId != 0)
		{
			this.dateTime_2 = DateTime.Now.AddMilliseconds(-600.0);
		}
	}

	private void method_58(GameManager gameManager_1, Hero hero_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.Run)
			{
				this.bool_5 = true;
			}
			this.Game.LastJumped = DateTime.Now.AddSeconds(-4.0);
		}
	}

	private void method_59(GameManager gameManager_1, Hero hero_0, GClass215 gclass215_0, bool bool_13)
	{
		GClass890.<>c__DisplayClass225_0 CS$<>8__locals1 = new GClass890.<>c__DisplayClass225_0();
		CS$<>8__locals1.gameManager_0 = gameManager_1;
		CS$<>8__locals1.gclass890_0 = this;
		CS$<>8__locals1.bool_0 = bool_13;
		CS$<>8__locals1.gclass215_0 = gclass215_0;
		this.Log.Info<bool, string>("Hero died wasAlive={alive} killer={killer}", CS$<>8__locals1.bool_0, CS$<>8__locals1.gclass215_0.string_0);
		this.method_62<GClass917>().imethod_1();
		this.Timeout = null;
		if (this.IsPaused)
		{
			return;
		}
		GClass890.<>c__DisplayClass225_0 CS$<>8__locals2 = CS$<>8__locals1;
		GClass904 behavior = this.Behavior;
		CS$<>8__locals2.int_0 = ((behavior != null) ? behavior.vmethod_45() : 1);
		int val = CS$<>8__locals1.gclass215_0.vector_0.Max(new Func<GClass584, int>(GClass890.<>c.<>c_0.method_6));
		CS$<>8__locals1.int_0 = Math.Min(CS$<>8__locals1.int_0, val);
		object obj = this.object_0;
		lock (obj)
		{
			if (this.Run)
			{
				this.bool_5 = true;
			}
		}
		MapProfile mapProfile = this.MapProfile;
		if (CS$<>8__locals1.bool_0 && mapProfile != null && mapProfile.ReviveAtPortal && (this.Behavior is GClass908 || this.Behavior is GClass912))
		{
			this.Log.Info("Adding 1 minute of delay because of unsafe portal repair");
			this.dateTime_2 = DateTime.Now.AddMinutes(1.0);
		}
		Task.Factory.StartNew(new Action(CS$<>8__locals1.method_0));
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public GameManager Game
	{
		[CompilerGenerated]
		get
		{
			return this.gameManager_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.gameManager_0, value))
			{
				return;
			}
			this.gameManager_0 = value;
			this.method_94(Class10.Hero);
			this.method_94(Class10.propertyChangedEventArgs_25);
			this.method_94(Class10.propertyChangedEventArgs_52);
			this.method_94(Class10.Map);
			this.method_94(Class10.propertyChangedEventArgs_18);
			this.method_94(Class10.propertyChangedEventArgs_53);
			this.method_94(Class10.Game);
		}
	}

	public string GameServer
	{
		get
		{
			AccountSettings account = this.Account;
			if (account == null)
			{
				return null;
			}
			return account.Server;
		}
	}

	public Hero Hero
	{
		get
		{
			return this.Game.Hero;
		}
	}

	public GClass88 Server
	{
		get
		{
			return this.Game.Connection.Server;
		}
	}

	public Map Map
	{
		get
		{
			return this.Game.Map;
		}
	}

	public GClass882 Stats
	{
		[CompilerGenerated]
		get
		{
			return this.gclass882_0;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.gclass882_0, value))
			{
				return;
			}
			this.gclass882_0 = value;
			this.method_94(Class10.Stats);
		}
	}

	public BotState State
	{
		[CompilerGenerated]
		get
		{
			return this.botState_0;
		}
		[CompilerGenerated]
		set
		{
			if (this.botState_0 == value)
			{
				return;
			}
			this.botState_0 = value;
			this.method_94(Class10.State);
		}
	}

	public BotState ReturnState
	{
		[CompilerGenerated]
		get
		{
			return this.botState_1;
		}
		[CompilerGenerated]
		set
		{
			if (this.botState_1 == value)
			{
				return;
			}
			this.botState_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_45);
		}
	}

	public MaxStack<BotState> LastStates
	{
		[CompilerGenerated]
		get
		{
			return this.maxStack_1;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.maxStack_1, value))
			{
				return;
			}
			this.maxStack_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_35);
		}
	}

	public CooldownTracker<BotAction> Cooldowns
	{
		[CompilerGenerated]
		get
		{
			return this.cooldownTracker_1;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.cooldownTracker_1, value))
			{
				return;
			}
			this.cooldownTracker_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_13);
		}
	}

	[CompilerGenerated]
	public List<GInterface9> method_61()
	{
		return this.GnvMoItGjxC;
	}

	public bool ShouldBeDisabled
	{
		[CompilerGenerated]
		get
		{
			return this.bool_10;
		}
		[CompilerGenerated]
		set
		{
			if (this.bool_10 == value)
			{
				return;
			}
			this.bool_10 = value;
			this.method_94(Class10.propertyChangedEventArgs_54);
		}
	}

	public bool ForceLogout
	{
		[CompilerGenerated]
		get
		{
			return this.bool_11;
		}
		[CompilerGenerated]
		set
		{
			if (this.bool_11 == value)
			{
				return;
			}
			this.bool_11 = value;
			this.method_94(Class10.propertyChangedEventArgs_21);
		}
	}

	public bool IsPaused
	{
		[CompilerGenerated]
		get
		{
			return this.bool_12;
		}
		[CompilerGenerated]
		set
		{
			if (this.bool_12 == value)
			{
				return;
			}
			this.bool_12 = value;
			this.method_94(Class10.IsPaused);
		}
	}

	private Logger Log
	{
		get
		{
			string str = "Core-Bot-";
			AccountSettings account = this.Account;
			return LogManager.GetLogger(str + ((account != null) ? account.BotId : null));
		}
	}

	private IDopeService Service
	{
		get
		{
			return this.Game.Dope.Service as IDopeService;
		}
	}

	public GClass892 Module
	{
		[CompilerGenerated]
		get
		{
			return this.gclass892_0;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.gclass892_0, value))
			{
				return;
			}
			this.gclass892_0 = value;
			this.method_94(Class10.Module);
		}
	}

	public GClass904 Behavior
	{
		[CompilerGenerated]
		get
		{
			return this.gclass904_1;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.gclass904_1, value))
			{
				return;
			}
			this.gclass904_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_2);
		}
	}

	public GClass890(IDopeServiceProxy idopeServiceProxy_0, AccountSettings accountSettings_1)
	{
		Class13.lOBHd9Nzn7x2T();
		this.concurrentDictionary_0 = new ConcurrentDictionary<string, object>();
		this.maxStack_0 = new MaxStack<int>(7);
		this.usageCounter_0 = new UsageCounter<int>();
		this.usageCounter_1 = new UsageCounter<string>();
		this.cooldownTracker_0 = new CooldownTracker<int>();
		this.cachedDictionary_0 = new CachedDictionary<int, bool>(3600000);
		this.dateTime_2 = DateTime.Now;
		this.dateTime_3 = DateTime.MinValue;
		this.object_0 = new object();
		this.botState_0 = BotState.Default;
		this.botState_1 = BotState.Default;
		this.maxStack_1 = new MaxStack<BotState>(1000);
		this.cooldownTracker_1 = new CooldownTracker<BotAction>();
		this.GnvMoItGjxC = new List<GInterface9>();
		this.cooldownTracker_2 = new CooldownTracker<int>();
		this.concurrentDictionary_1 = new ConcurrentDictionary<string, Collectible>();
		base..ctor();
		this.Account = accountSettings_1;
		this.Game = new GameManager(idopeServiceProxy_0);
		this.Stats = new GClass882(this);
		this.Scheduler = new GClass888(this);
		this.Game.LogManager = this;
		this.BackgroundQueue = new ConcurrentQueue<Func<DarkOrbitWebAPI, object>>();
		this.GnvMoItGjxC = new List<GInterface9>
		{
			new GClass920(this),
			new GClass918(this),
			new GClass917(this),
			new GClass921(this),
			new GClass919(this)
		};
		this.gclass904_0 = new GClass905(this);
		this.gclass914_0 = new GClass914(this);
		this.gclass912_0 = new GClass912(this);
		this.gclass909_0 = new GClass909(this);
		this.gclass906_0 = new GClass906(this);
		this.gclass907_0 = new GClass907(this);
		this.Behavior = this.gclass904_0;
		this.method_64();
	}

	public fOY4BSQAf1Jn6BJEmIm method_62<fOY4BSQAf1Jn6BJEmIm>() where fOY4BSQAf1Jn6BJEmIm : GClass916
	{
		return this.method_61().First(new Func<GInterface9, bool>(GClass890.<>c__297<fOY4BSQAf1Jn6BJEmIm>.<>9.method_0)) as fOY4BSQAf1Jn6BJEmIm;
	}

	public void method_63()
	{
		this.Game.Settings.UserAgent = this.Account.UserAgent;
		this.LastLogin = DateTime.Now;
		bool isLoggedIn = this.Game.IsLoggedIn;
		bool flag = isLoggedIn && this.Game.Web.CheckLoggedIn();
		if (!isLoggedIn || !flag)
		{
			this.Game.IsLoggedIn = false;
			AccountSettings account = this.Account;
			if (this.Scheduler.method_3())
			{
				AccountSettings account2 = this.Account;
				ProxySettings proxySettings = (account2 != null) ? account2.GetProxySettings() : null;
				this.Log.Info("Logging in with proxy {proxy}", (proxySettings != null) ? proxySettings.ToString() : null);
				try
				{
					this.Game.method_4(account.Username, account.Password, account.Server, proxySettings);
				}
				catch (Exception ex)
				{
					this.Log.Error(ex, "Login failed -- check your libssl compatibility. {exception}", new object[]
					{
						ex
					});
				}
				this.Log.Info("Login " + (this.Game.Web.IsLoggedIn ? "successful" : "failed"));
				if (!this.Game.Web.IsLoggedIn)
				{
					this.LastDisconnectReason = ErrorReason.CantLogin;
				}
			}
		}
		if (this.Game.Web.IsLoggedIn && this.Game.LastDailyLogin.Cooldown(14400000))
		{
			this.Game.method_3();
		}
	}

	private void method_64()
	{
		this.Game.HeroInit += this.method_58;
		this.Game.HeroDied += this.method_59;
		this.Game.Map.ShipAttacked += this.method_54;
		this.Game.Map.ShipCreated += this.method_51;
		this.Game.Map.ShipDestroyed += this.method_50;
		this.Game.Connection.Socket.Disconnected += this.method_57;
		this.Game.Connection.Socket.Connected += this.method_55;
		this.Game.Map.CollectibleCollected += this.method_56;
		this.Game.Map.ShipMoveStarted += this.method_49;
		this.Game.LogMessage += this.method_47;
		this.Game.Hero.Pet.KamikazeDeath += this.method_46;
		this.Game.Hero.Group.InviteAdded += this.method_45;
	}

	public void DetachPErkava()
	{
		this.Log.Info("Detaching PErkava");
		object obj = this.object_0;
		lock (obj)
		{
			this.Game.Settings.IsClient = true;
			this.Game.Connection.ProxySocket = null;
			this.Scheduler.method_4();
			if (!this.Run)
			{
				this.Game.Connection.method_14();
			}
		}
	}

	public bool AttachPErkava(GClass239 obj)
	{
		this.Log.Info("Attaching PErkava");
		GameManager game = this.Game;
		if (game.Settings.FlashSettings.sessionID == null)
		{
			game.Settings.FlashSettings.pid = obj.int_2;
			game.Settings.FlashSettings.sessionID = obj.string_0;
			game.Settings.FlashSettings.userID = obj.int_0;
			game.Settings.FlashSettings.factionID = obj.int_1;
		}
		if (!this.Game.Web.IsLoggedIn)
		{
			this.Game.Web.LoginBySid(game.Settings.FlashSettings.sessionID, this.GameServer, true);
			this.Game.method_2();
		}
		object obj2 = this.object_0;
		lock (obj2)
		{
			game.Settings.IsClient = false;
			this.Scheduler.method_5();
			this.IsPaused = true;
			if (!this.Run)
			{
				this.Start(false);
			}
			this.IsEnabled = true;
			this.ShouldBeDisabled = false;
		}
		if (game.Connection.Socket.method_2())
		{
			game.Connection.Socket.Disconnect(ErrorReason.ConnectionOverridden, null, false);
		}
		else
		{
			game.Start();
		}
		return true;
	}

	public void Start(bool resetStats = true)
	{
		this.Log.Info("Starting AI");
		GClass882 stats = this.Stats;
		int resets = stats.Resets;
		stats.Resets = resets + 1;
		if (resetStats || this.Stats.Started == null || this.Stats.Stopped != null)
		{
			this.Stats.Reset();
			this.Stats.Started = new DateTime?(DateTime.Now);
			this.Stats.Stopped = null;
		}
		this.Run = true;
		this.IsPaused = false;
		this.Cooldowns.Cooldowns.Clear();
		if (this.BotThread != null && this.BotThread.IsAlive)
		{
			this.Clear();
			return;
		}
		this.BotThread = new Thread(new ThreadStart(this.method_44))
		{
			IsBackground = true
		};
		this.BotThread.Start();
	}

	public void Stop()
	{
		this.Log.Info("Stopping");
		if (this.Run)
		{
			this.Run = false;
			this.IsPaused = false;
			this.Stats.Stopped = new DateTime?(DateTime.Now);
		}
	}

	public void method_65(GClass892.GEnum10 genum10_0)
	{
		GClass892 module = this.Module;
		if (module == null)
		{
			return;
		}
		module.HandleError(genum10_0);
	}

	public void Clear()
	{
		this.TravelTarget = null;
		this.gate_0 = null;
		this.bool_8 = false;
		this.CollectibleTarget = null;
		this.SelectedAmmo = (this.SelectedRockets = (this.SelectedHS = null));
		this.EnemyTarget = null;
		this.RoamTarget = Vector2.Zero;
		this.State = BotState.Default;
		this.ReturnState = BotState.Default;
		this.LastStates.Clear();
		this.IsCollecting = false;
		this.IsAttacking = false;
		this.int_2 = 0;
		this.int_3 = 0;
		this.int_5 = 0;
		this.Game.Security.HashBlockList.Cooldowns.Clear();
		this.int_7 = 0;
		this.dateTimeOffset_0 = DateTimeOffset.MinValue;
		this.BoxTracker.Clear();
	}

	public void method_66()
	{
		try
		{
			BotState state = this.State;
			if (state <= BotState.Repair)
			{
				if (state <= BotState.Travel)
				{
					switch (state)
					{
					case BotState.Default:
						this.method_31();
						break;
					case BotState.Roam:
						this.method_35();
						break;
					case BotState.Default | BotState.Roam:
						break;
					case BotState.Flee:
						this.method_39();
						break;
					default:
						if (state == BotState.Travel)
						{
							this.method_37();
						}
						break;
					}
				}
				else if (state != BotState.Collect)
				{
					if (state == BotState.Repair)
					{
						this.method_33();
					}
				}
				else
				{
					this.method_38();
				}
			}
			else if (state <= BotState.Logout)
			{
				if (state != BotState.Hunt)
				{
					if (state == BotState.Logout)
					{
						this.method_34();
					}
				}
				else
				{
					this.method_41();
				}
			}
			else if (state != BotState.PErkava)
			{
				if (state == BotState.TradePalladium)
				{
					this.method_42();
				}
			}
			else
			{
				this.method_40();
			}
		}
		catch (Exception ex)
		{
			this.Log.Error(ex, "Error in state {botState} ({exceptionName})", new object[]
			{
				this.State,
				ex.GetType().ToString()
			});
		}
	}

	public int StateIters
	{
		[CompilerGenerated]
		get
		{
			return this.int_9;
		}
		[CompilerGenerated]
		set
		{
			if (this.int_9 == value)
			{
				return;
			}
			this.int_9 = value;
			this.method_94(Class10.propertyChangedEventArgs_55);
		}
	}

	public void method_67(BotState botState_3)
	{
		this.StateIters = 0;
		if (this.State != botState_3)
		{
			this.Log.Debug<BotState, BotState>("Changing state from {oldState} to {newState}", this.State, botState_3);
			this.LastStates.method_0(this.State);
			this.State = botState_3;
		}
	}

	public void method_68()
	{
		this.StateIters = 0;
		this.ReturnState = this.State;
		if (this.LastStates.Count == 0)
		{
			this.State = BotState.Default;
		}
		else
		{
			this.State = this.LastStates.method_1();
		}
		this.Log.Debug<BotState, BotState>("Reverting state from {oldState} to {newState}", this.ReturnState, this.State);
	}

	public bool method_69()
	{
		if (this.IsStopping && this.Behavior.vmethod_15())
		{
			this.method_67(BotState.Logout);
			return true;
		}
		return false;
	}

	public IEnumerable<string> method_70()
	{
		GClass890.<GetStatusText>d__314 <GetStatusText>d__ = new GClass890.<GetStatusText>d__314(-2);
		<GetStatusText>d__.<>4__this = this;
		return <GetStatusText>d__;
	}

	Logger ILogManager.Get(string string_4)
	{
		string str = "Base-";
		string str2 = "-";
		AccountSettings account = this.Account;
		return LogManager.GetLogger(str + string_4 + str2 + ((account != null) ? account.BotId : null));
	}

	public Logger method_71(string string_4)
	{
		string str = "Core-";
		string str2 = "-";
		AccountSettings account = this.Account;
		return LogManager.GetLogger(str + string_4 + str2 + ((account != null) ? account.BotId : null));
	}

	public CooldownTracker<int> NpcLockout
	{
		[CompilerGenerated]
		get
		{
			return this.cooldownTracker_2;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.cooldownTracker_2, value))
			{
				return;
			}
			this.cooldownTracker_2 = value;
			this.method_94(Class10.propertyChangedEventArgs_41);
		}
	}

	public string SelectedAmmo
	{
		[CompilerGenerated]
		get
		{
			return this.string_1;
		}
		[CompilerGenerated]
		set
		{
			if (string.Equals(this.string_1, value, StringComparison.Ordinal))
			{
				return;
			}
			this.string_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_48);
		}
	}

	public string SelectedRockets
	{
		[CompilerGenerated]
		get
		{
			return this.string_2;
		}
		[CompilerGenerated]
		set
		{
			if (string.Equals(this.string_2, value, StringComparison.Ordinal))
			{
				return;
			}
			this.string_2 = value;
			this.method_94(Class10.propertyChangedEventArgs_50);
		}
	}

	public string SelectedHS
	{
		[CompilerGenerated]
		get
		{
			return this.string_3;
		}
		[CompilerGenerated]
		set
		{
			if (string.Equals(this.string_3, value, StringComparison.Ordinal))
			{
				return;
			}
			this.string_3 = value;
			this.method_94(Class10.propertyChangedEventArgs_49);
		}
	}

	public GEnum6 method_72()
	{
		GEnum6 genum = (GEnum6)4096;
		if (this.MapProfile.CollectBonus)
		{
			genum |= (GEnum6)256;
		}
		if (this.MapProfile.CollectCargo && this.Hero.FreeCargo > 50)
		{
			genum |= (GEnum6)64;
		}
		if (this.MapProfile.CollectPalladium && this.Hero.FreeCargo > 0)
		{
			genum |= (GEnum6)2;
		}
		if (this.MapProfile.CollectMaterials)
		{
			genum |= (GEnum6)512;
		}
		if (this.Account.CollectGreenBooty && this.Hero.BootyKeys > 0.0)
		{
			genum |= (GEnum6)4;
		}
		if (this.Account.CollectGoldBooty && this.Hero.BootyKeys > 0.0)
		{
			genum |= (GEnum6)2048;
		}
		return genum;
	}

	public NpcShip method_73(int int_11 = 0)
	{
		return this.Map.method_6(this.HeroPosition, new Func<NpcShip, bool>(this.Behavior.vmethod_7), new Func<NpcShip, int>(this.Behavior.vmethod_8), int_11);
	}

	public bool method_74()
	{
		return this.Map.method_7<NpcShip>(this.HeroPosition, new Func<NpcShip, bool>(this.Behavior.vmethod_9), new Func<NpcShip, int>(this.Behavior.vmethod_8), 0).Any(new Func<ValueTuple<NpcShip, float, int>, bool>(GClass890.<>c.<>c_0.method_7));
	}

	public IEnumerable<NpcShip> method_75()
	{
		return this.Game.Map.All<NpcShip>(this.HeroPosition, new Func<NpcShip, bool>(this.Behavior.vmethod_9), new Func<NpcShip, int>(this.Behavior.vmethod_8), 0);
	}

	public bool method_76()
	{
		if (!this.MapProfile.Hunter)
		{
			return false;
		}
		this.EnemyTarget = this.method_73(0);
		return this.EnemyTarget != null;
	}

	public bool method_77()
	{
		GClass890.<>c__DisplayClass339_0 CS$<>8__locals1 = new GClass890.<>c__DisplayClass339_0();
		CS$<>8__locals1.gclass890_0 = this;
		if (!this.MapProfile.Collector)
		{
			return false;
		}
		CS$<>8__locals1.genum6_0 = this.method_72();
		List<Collectible> list = this.Game.Map.All<Collectible>(this.HeroPosition, new Func<Collectible, bool>(CS$<>8__locals1.method_0), null, 0).ToList<Collectible>();
		this.CollectibleTarget = list.FirstOrDefault(new Func<Collectible, bool>(CS$<>8__locals1.method_1));
		foreach (Collectible collectible in list)
		{
			if (!this.Map.Grid.method_6(collectible.Position) && collectible.CollectibleType != (GEnum6)64)
			{
				this.DormantTargets[collectible.Hash] = collectible;
			}
		}
		return this.CollectibleTarget != null;
	}

	public bool method_78(out int int_11)
	{
		int_11 = 0;
		return this.Behavior.vmethod_14() && this.Module.TrySwitchMap(out int_11);
	}

	public ConcurrentDictionary<string, Collectible> DormantTargets
	{
		get
		{
			if (this.int_10 != this.Map.MapId)
			{
				this.concurrentDictionary_1.Clear();
			}
			this.int_10 = this.Map.MapId;
			return this.concurrentDictionary_1;
		}
		set
		{
			if (object.Equals(this.concurrentDictionary_1, value))
			{
				return;
			}
			this.concurrentDictionary_1 = value;
			this.method_94(Class10.propertyChangedEventArgs_18);
		}
	}

	public Collectible method_79(Vector2 vector2_2)
	{
		GClass890.<>c__DisplayClass346_0 CS$<>8__locals1 = new GClass890.<>c__DisplayClass346_0();
		CS$<>8__locals1.vector2_0 = vector2_2;
		if (!this.DormantTargets.Any<KeyValuePair<string, Collectible>>())
		{
			return null;
		}
		foreach (KeyValuePair<string, Collectible> keyValuePair in this.DormantTargets)
		{
			if (Vector2.Distance(CS$<>8__locals1.vector2_0, keyValuePair.Value.Position) < 300f || this.Map.Grid.method_6(keyValuePair.Value.Position))
			{
				Collectible collectible;
				this.DormantTargets.TryRemove(keyValuePair.Key, out collectible);
			}
		}
		Collectible collectible2 = this.DormantTargets.Select(new Func<KeyValuePair<string, Collectible>, Collectible>(GClass890.<>c.<>c_0.method_8)).OrderBy(new Func<Collectible, float>(CS$<>8__locals1.method_0)).FirstOrDefault<Collectible>();
		if (collectible2 != null)
		{
			return collectible2;
		}
		return null;
	}

	public Gate method_80(int int_11)
	{
		return this.Behavior.vmethod_24(int_11);
	}

	public bool method_81(Ship ship_1)
	{
		return ship_1.method_8(this.Hero);
	}

	public void method_82()
	{
		foreach (KeyValuePair<int, Ship> keyValuePair in this.Map.Ships)
		{
			NpcShip npcShip = keyValuePair.Value as NpcShip;
			if (npcShip != null)
			{
				this.method_83(npcShip);
			}
		}
		this.dateTimeOffset_2 = DateTimeOffset.Now;
	}

	public void method_83(NpcShip npcShip_0)
	{
		this.Behavior.vmethod_10(npcShip_0);
	}

	public bool method_84()
	{
		return MapUtils.smethod_4(this.Map.MapId) == MapUtils.smethod_4((int)this.MapProfile.TargetMap).Replace("X-", string.Format("{0}-", this.Hero.FactionId));
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass890()
	{
		Class13.lOBHd9Nzn7x2T();
		GClass890.resourceType_0 = new ResourceType[]
		{
			ResourceType.PROMETID,
			ResourceType.DURANIUM,
			ResourceType.PROMERIUM
		};
		GClass890.list_0 = new List<string>
		{
			"ability_solace",
			"ability_aegis_repair-pod",
			"ability_aegis_hp-repair"
		};
		GClass890.list_1 = new List<string>
		{
			"ability_venom",
			"ability_diminisher",
			"ability_zephyr_tbr",
			"ability_tartarus_rapid-fire"
		};
		GClass890.list_2 = new List<string>
		{
			"ability_lightning",
			"ability_sentinel",
			"ability_spectrum",
			"ability_mimesis_scramble",
			"ability_zephyr_mmt"
		};
		GClass890.list_3 = new List<ResourceType>
		{
			ResourceType.PROMETIUM,
			ResourceType.ENDURIUM,
			ResourceType.TERBIUM,
			ResourceType.PROMETID,
			ResourceType.DURANIUM,
			ResourceType.PALLADIUM
		};
		GClass890.botState_2 = (BotState.Roam | BotState.Collect | BotState.Hunt | BotState.Dodge);
	}

	[CompilerGenerated]
	private bool method_85(DarkOrbitWebAPI darkOrbitWebAPI_0)
	{
		return darkOrbitWebAPI_0.BuyItem("rocket", this.SelectedHS, 100, -1, "");
	}

	[CompilerGenerated]
	private bool method_86()
	{
		int num = 0;
		foreach (KeyValuePair<int, Ship> keyValuePair in this.Map.Ships)
		{
			if (keyValuePair.Value.IsNpc && Vector2.Distance(this.HeroPosition, keyValuePair.Value.Position) <= 1000f)
			{
				num++;
				bool flag;
				if (!this.Map.method_8(keyValuePair.Value, out flag))
				{
					return false;
				}
			}
		}
		return num > 0;
	}

	[CompilerGenerated]
	private bool method_87(Ship ship_1)
	{
		return ship_1.IsPlayer && ship_1.method_8(this.Hero);
	}

	[CompilerGenerated]
	private void method_88()
	{
		this.nullable_1 = new Vector2?(this.Game.Security.method_5(this.Map, this.Behavior.vmethod_16()));
	}

	[CompilerGenerated]
	private void method_89()
	{
		this.RoamTarget = Vector2.Zero;
	}

	[CompilerGenerated]
	private void method_90()
	{
		this.method_68();
	}

	[CompilerGenerated]
	private void method_91()
	{
		int num = this.int_3;
		this.int_3 = num + 1;
		if (num > 500)
		{
			this.method_65((GClass892.GEnum10)1);
		}
	}

	[CompilerGenerated]
	private bool method_92(KeyValuePair<int, Ship> keyValuePair_0)
	{
		return this.method_81(keyValuePair_0.Value);
	}

	[CompilerGenerated]
	private void method_93(string string_4)
	{
		GInterface5 proxySocket = this.Game.Connection.ProxySocket;
		if (proxySocket == null)
		{
			return;
		}
		proxySocket.SendMessage(new GClass269(GClass90.Log(string_4)));
	}

	[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
	[DebuggerNonUserCode]
	protected void method_94(PropertyChangedEventArgs propertyChangedEventArgs_0)
	{
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged != null)
		{
			propertyChanged(this, propertyChangedEventArgs_0);
		}
	}

	[CompilerGenerated]
	private Collectible collectible_0;

	public string string_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private int int_0;

	public readonly ConcurrentDictionary<string, object> concurrentDictionary_0;

	private static ResourceType[] resourceType_0;

	public DateTimeOffset dateTimeOffset_0;

	public MaxStack<int> maxStack_0;

	public static List<string> list_0;

	public static List<string> list_1;

	public static List<string> list_2;

	[CompilerGenerated]
	private ErrorReason errorReason_0;

	[CompilerGenerated]
	private MapProfile mapProfile_0;

	[CompilerGenerated]
	private AccountSettings accountSettings_0;

	[CompilerGenerated]
	private GClass888 gclass888_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private DateTime dateTime_0;

	[CompilerGenerated]
	private DateTime dateTime_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private Thread thread_0;

	[CompilerGenerated]
	private ConcurrentQueue<Func<DarkOrbitWebAPI, object>> concurrentQueue_0;

	[CompilerGenerated]
	private Task task_0;

	[CompilerGenerated]
	private Task task_1;

	private volatile bool bool_5;

	private DateTimeOffset dateTimeOffset_1;

	[CompilerGenerated]
	private UsageCounter<int> usageCounter_0;

	private DateTimeOffset dateTimeOffset_2;

	[CompilerGenerated]
	private Ship ship_0;

	private int int_2;

	private int int_3;

	[CompilerGenerated]
	private DateTime? nullable_0;

	private bool bool_6;

	private bool bool_7;

	private int int_4;

	private DateTimeOffset dateTimeOffset_3;

	private Vector2? nullable_1;

	private int int_5;

	private bool bool_8;

	private Vector2 vector2_0;

	[CompilerGenerated]
	private Vector2? nullable_2;

	private Gate gate_0;

	private bool bool_9;

	private PathSequence pathSequence_0;

	[CompilerGenerated]
	private UsageCounter<string> usageCounter_1;

	private int int_6;

	public float float_0;

	public static List<ResourceType> list_3;

	[CompilerGenerated]
	private Vector2 vector2_1;

	[CompilerGenerated]
	private GClass922 gclass922_0;

	[CompilerGenerated]
	private Task task_2;

	private readonly CooldownTracker<int> cooldownTracker_0;

	private readonly CachedDictionary<int, bool> cachedDictionary_0;

	public int int_7;

	public DateTime dateTime_2;

	public DateTime dateTime_3;

	public DateTimeOffset dateTimeOffset_4;

	public int int_8;

	[CompilerGenerated]
	private GameManager gameManager_0;

	public readonly object object_0;

	[CompilerGenerated]
	private GClass882 gclass882_0;

	[CompilerGenerated]
	private BotState botState_0;

	[CompilerGenerated]
	private BotState botState_1;

	[CompilerGenerated]
	private MaxStack<BotState> maxStack_1;

	public static readonly BotState botState_2;

	[CompilerGenerated]
	private CooldownTracker<BotAction> cooldownTracker_1;

	[CompilerGenerated]
	private readonly List<GInterface9> GnvMoItGjxC;

	[CompilerGenerated]
	private bool bool_10;

	[CompilerGenerated]
	private bool bool_11;

	[CompilerGenerated]
	private bool bool_12;

	public readonly GClass904 gclass904_0;

	public readonly GClass914 gclass914_0;

	public readonly GClass912 gclass912_0;

	public readonly GClass909 gclass909_0;

	public readonly GClass906 gclass906_0;

	public readonly GClass907 gclass907_0;

	[CompilerGenerated]
	private GClass892 gclass892_0;

	[CompilerGenerated]
	private GClass904 gclass904_1;

	[CompilerGenerated]
	private int int_9;

	[CompilerGenerated]
	private CooldownTracker<int> cooldownTracker_2;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	private int int_10;

	private ConcurrentDictionary<string, Collectible> concurrentDictionary_1;
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
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

public class GClass810 : INotifyPropertyChanged, ILogManager, IPErkavaBotController
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
			this.method_82(Class5.propertyChangedEventArgs_7);
		}
	}

	public void method_0()
	{
		if (this.Cooldowns.method_2(BotAction.RepairBot, 5000.0))
		{
			this.Game.Connection.Server.method_9();
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
			this.Server.method_14(menuItem.Id, true, false);
			return;
		}
		if (this.Game.Hero.Uridium >= 500.0)
		{
			this.BackgroundQueue.Enqueue(new Func<DarkOrbitWebAPI, object>(GClass810.<>c.<>c_0.method_0));
		}
	}

	public bool method_1(Vector2 vector2_2, int int_11 = 300, bool bool_12 = false)
	{
		if (this.Cooldowns.method_2(BotAction.Move, (double)int_11))
		{
			this.Game.Connection.Server.method_5(vector2_2.X, vector2_2.Y, false);
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
		this.Log.Debug("Jumping gate {id}", int_11);
		if (this.Cooldowns.method_2(BotAction.Jump, 600.0))
		{
			this.Game.Connection.Server.method_2(int_11);
		}
	}

	public void method_3(Collectible collectible_1)
	{
		if (this.Game.Security.HashBlockList.method_0(collectible_1.Hash) && this.Cooldowns.method_2(BotAction.Collect, 600.0))
		{
			if (this.string_0 != collectible_1.Hash)
			{
				this.string_0 = collectible_1.Hash;
				this.int_0 = 0;
			}
			this.Log.Debug<string, int>("Collecting {boxType} tries={tries}", collectible_1.Type, this.int_0);
			Collectible collectible;
			this.DormantTargets.TryRemove(collectible_1.Hash, out collectible);
			this.Game.Connection.Server.method_13(collectible_1);
			this.IsCollecting = true;
			int num = this.int_0 + 1;
			this.int_0 = num;
			if (num > 3)
			{
				this.Game.Security.HashBlockList.method_2(collectible_1.Hash, 120000.0);
			}
		}
	}

	public bool method_4(Vector2 vector2_2, int int_11, int int_12 = 300, bool bool_12 = false, int int_13 = 640, int int_14 = 360, int int_15 = 0, int int_16 = 0, int int_17 = 0, bool bool_13 = false, int int_18 = 0, Action action_0 = null)
	{
		GClass810.<>c__DisplayClass14_0 CS$<>8__locals1 = new GClass810.<>c__DisplayClass14_0();
		CS$<>8__locals1.vector2_0 = vector2_2;
		CS$<>8__locals1.vector2_0 = Vector2.Clamp(CS$<>8__locals1.vector2_0, Vector2.Zero, this.Map.MapSize.Vector);
		if (Vector2.Distance(CS$<>8__locals1.vector2_0, this.HeroPosition) <= (float)int_11)
		{
			if (bool_12)
			{
				this.method_1(this.HeroPosition, 300, true);
			}
			return true;
		}
		if (this.Cooldowns.method_0(BotAction.Move))
		{
			if (!bool_13 && this.Map.Grid.method_3(this.HeroPosition, CS$<>8__locals1.vector2_0))
			{
				PathSequence pathSequence = this.Map.Grid.method_14(this.HeroPosition, CS$<>8__locals1.vector2_0, 30, int_17);
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
			Vector2 vector2_3 = this.Game.Security.method_23(this.HeroPosition, (int)CS$<>8__locals1.vector2_0.X, (int)CS$<>8__locals1.vector2_0.Y, int_13, int_14, int_15, int_16, int_18);
			this.method_1(vector2_3, int_12, false);
		}
		return false;
	}

	public bool method_5(PathSequence pathSequence_1, int int_11 = 300, bool bool_12 = false, int int_12 = 640, int int_13 = 360, int int_14 = 0, int int_15 = 0, int int_16 = 0)
	{
		return true;
	}

	public void method_6(Ship ship_1, bool bool_12 = false)
	{
		if (this.Cooldowns.method_2(BotAction.SelectShip, 275.0))
		{
			this.Game.Connection.Server.method_8(ship_1, bool_12);
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
		while (laserType > LaserType.LCB_10 && this.Hero.method_20(Ammo.smethod_1(laserType)) < 100.0)
		{
			laserType--;
		}
		while (rocketType > RocketType.PLT_2026 && this.Hero.method_20(Ammo.smethod_2(rocketType)) < 10.0)
		{
			rocketType--;
		}
		while (hellstormType > HellstormType.ECO_10 && this.Hero.method_20(Ammo.smethod_3(hellstormType)) < 10.0)
		{
			hellstormType--;
		}
		string selectedAmmo = Ammo.smethod_1(laserType);
		string text = Ammo.smethod_2(rocketType);
		string text2 = Ammo.smethod_3(hellstormType);
		this.Server.method_15(this.SelectedAmmo = selectedAmmo, true);
		if (this.Hero.method_15("equipment_extra_cpu_arol-x"))
		{
			this.Server.method_15("equipment_extra_cpu_arol-x", text != null);
		}
		if (this.Hero.method_15("equipment_extra_cpu_rllb-x"))
		{
			this.Server.method_15("equipment_extra_cpu_rllb-x", text2 != null);
		}
		this.Server.method_15(this.SelectedRockets = text, true);
		this.Server.method_15(this.SelectedHS = text2, true);
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
			this.method_82(Class5.propertyChangedEventArgs_22);
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
			this.method_82(Class5.propertyChangedEventArgs_23);
		}
	}

	public int AttackingId
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
			this.method_82(Class5.propertyChangedEventArgs_0);
		}
	}

	public void method_8(Ship ship_1)
	{
		if (ship_1 == null)
		{
			this.IsAttacking = false;
			this.Server.method_10();
			return;
		}
		if (this.IsAttacking && ship_1.Id == this.AttackingId && !this.Game.Hero.LastAttacked.Cooldown(2000))
		{
			if (this.IsAttacking)
			{
				this.method_7(ship_1);
			}
		}
		else
		{
			if (this.IsAttacking)
			{
				this.Server.method_10();
			}
			this.IsAttacking = false;
			this.method_7(ship_1);
			if (this.Cooldowns.method_2(BotAction.Attack, 225.0))
			{
				this.IsAttacking = true;
				this.Game.Hero.LastAttacked = DateTimeOffset.Now;
				this.Game.Connection.Server.method_11(ship_1);
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
		if (this.SelectedAmmo == "ammunition_laser_lcb-10" && this.Hero.method_20(this.SelectedAmmo) < 1900.0)
		{
			this.Log.Debug("Buying {ammoType}", this.SelectedAmmo);
			this.Server.method_14("buy_" + this.SelectedAmmo, true, false);
		}
		if ((this.SelectedRockets == "ammunition_rocket_r-310" || this.SelectedRockets == "ammunition_rocket_plt-2026") && this.Hero.method_20(this.SelectedRockets) < 90.0)
		{
			this.Log.Debug("Buying {ammoType}", this.SelectedAmmo);
			this.Server.method_14("buy_" + this.SelectedRockets, true, false);
		}
		if (this.SelectedHS == "ammunition_rocketlauncher_eco-10" && this.Hero.method_20(this.SelectedHS) < 90.0)
		{
			this.Log.Debug("Buying {ammoType}", this.SelectedHS);
			bool flag;
			this.method_10<bool>("BuyAmmoHs", new Func<DarkOrbitWebAPI, bool>(this.method_73), out flag);
		}
	}

	public bool method_10<D9uyALCK263P1cyjglM>(string string_4, Func<DarkOrbitWebAPI, D9uyALCK263P1cyjglM> func_0, out D9uyALCK263P1cyjglM gparam_0)
	{
		GClass810.<>c__DisplayClass34_0<D9uyALCK263P1cyjglM> CS$<>8__locals1 = new GClass810.<>c__DisplayClass34_0<D9uyALCK263P1cyjglM>();
		CS$<>8__locals1.f = func_0;
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.key = string_4;
		gparam_0 = default(D9uyALCK263P1cyjglM);
		object obj;
		if (!this.concurrentDictionary_0.TryGetValue(CS$<>8__locals1.key, out obj))
		{
			Func<DarkOrbitWebAPI, object> item = new Func<DarkOrbitWebAPI, object>(CS$<>8__locals1.method_0);
			this.concurrentDictionary_0[CS$<>8__locals1.key] = new object();
			this.BackgroundQueue.Enqueue(item);
			return false;
		}
		if (obj is D9uyALCK263P1cyjglM)
		{
			D9uyALCK263P1cyjglM d9uyALCK263P1cyjglM = (D9uyALCK263P1cyjglM)((object)obj);
			object obj2;
			this.concurrentDictionary_0.TryRemove(CS$<>8__locals1.key, out obj2);
			gparam_0 = d9uyALCK263P1cyjglM;
			return true;
		}
		return false;
	}

	private bool method_11(int int_11)
	{
		if (this.Hero.Config != int_11 && this.Cooldowns.method_2(BotAction.SetConfig, 5250.0))
		{
			this.Server.method_3(int_11);
			return true;
		}
		return false;
	}

	public void method_12(bool bool_12, bool bool_13 = false)
	{
		int num;
		int num2;
		GEnum4 genum;
		GEnum4 genum2;
		this.MapProfile.GetConfig(this.EnemyTarget, this.Game.Map, out num, out num2, out genum, out genum2);
		int num3 = bool_12 ? num : num2;
		GEnum4 genum3 = bool_12 ? genum : genum2;
		if (this.State == BotState.Flee || (this.State == BotState.Travel && this.bool_8) || this.State == BotState.Repair)
		{
			num3 = this.MapProfile.FleeConfig;
			genum3 = this.MapProfile.FleeFormation;
		}
		if (!bool_13)
		{
			GClass818 gclass = this.Module as GClass818;
			if (gclass != null)
			{
				int num4 = this.Map.Ships.Count(new Func<KeyValuePair<int, Ship>, bool>(GClass810.<>c.<>c_0.method_1));
				if (gclass.vmethod_1() && num4 == 0)
				{
					genum3 = GEnum4.Veteran;
				}
				else if (this.MapProfile.UseMothToKillCorners && this.Hero.method_15(GEnum4.Moth.smethod_0()) && this.method_74())
				{
					genum3 = GEnum4.Moth;
				}
			}
			MenuItem menuItem;
			if (this.Hero.MenuItems.TryGetValue(genum3.smethod_0(), out menuItem) && menuItem.Activatable && !menuItem.Selected && this.Hero.ItemCooldown.method_0(CooldownType.DroneFormation) && this.Cooldowns.method_2(BotAction.SwitchDroneFormation, 500.0))
			{
				this.Server.method_15(genum3.smethod_0(), true);
			}
		}
		if (this.Hero.Config != num3)
		{
			this.method_11(num3);
		}
	}

	public bool method_13(bool bool_12, bool bool_13 = false)
	{
		if (this.Behavior is GClass822)
		{
			bool_12 = false;
		}
		Gate gate_;
		Vector2? vector = this.Behavior.vmethod_16(this.Map.Hero.Position, out gate_, bool_13, bool_12);
		return vector != null && this.method_32(vector.Value, gate_, 15, bool_13);
	}

	public void AutoRefine()
	{
		if (!this.Cooldowns.method_0(BotAction.AutoRefine))
		{
			return;
		}
		foreach (ResourceType resourceType in GClass810.resourceType_0)
		{
			int num = this.Hero.method_25(resourceType);
			if (num > 0)
			{
				this.Server.method_20(resourceType, (double)num);
				this.Cooldowns.method_1(BotAction.AutoRefine, 500.0);
				return;
			}
		}
	}

	protected bool method_14()
	{
		if (this.Map.Grid.method_7(this.HeroPosition) && !this.IsCollecting && this.HeroPosition != default(Vector2) && this.HeroPosition != new Vector2((float)this.Map.MapSize.Width, (float)this.Map.MapSize.Height))
		{
			Vector2 vector = this.Map.Grid.LcuZkympWt(this.HeroPosition);
			if (vector == default(Vector2))
			{
				vector = new Vector2((float)(this.Map.MapSize.Width / 2), (float)(this.Map.MapSize.Height / 2));
			}
			this.method_1(vector, 300, false);
			return true;
		}
		return false;
	}

	public void method_15()
	{
		if (this.dateTimeOffset_0.Cooldown(200))
		{
			this.maxStack_0.method_0(this.int_8);
			this.int_8 = 0;
			this.dateTimeOffset_0 = DateTimeOffset.Now;
		}
		if (!this.Map.IsGG)
		{
			return;
		}
		int num = this.maxStack_0.Sum() + this.int_8;
		if ((double)num > Math.Min((double)this.Hero.HpMax * 0.1, 20000.0) && (double)(this.Hero.Hp + this.Hero.Shield) - Math.Min((double)this.Hero.HpMax * 0.25, 60000.0) < 2.2 * (double)num)
		{
			this.Log.Warn("Took {damage} in the last second. Fleeing.", num);
			this.cvgiarhHagp();
			this.wbniaSuPwQR();
			this.method_12(false, false);
			this.method_47();
		}
	}

	private bool method_16(List<string> list_5)
	{
		foreach (string text in list_5)
		{
			MenuItem menuItem;
			if (this.Hero.method_17(text, out menuItem, true))
			{
				return true;
			}
		}
		return false;
	}

	private string method_17(List<string> list_5)
	{
		foreach (string result in list_5)
		{
			MenuItem menuItem;
			if (this.Hero.method_16(result, out menuItem))
			{
				return result;
			}
		}
		return null;
	}

	public bool wbniaSuPwQR()
	{
		return this.method_16(GClass810.list_0);
	}

	public bool cvgiarhHagp()
	{
		return this.method_16(GClass810.list_2);
	}

	public bool method_18()
	{
		return this.method_16(new List<string>
		{
			"ability_aegis_shield-repair"
		});
	}

	public bool method_19()
	{
		Ship ship = this.Map.method_5<Ship>(this.HeroPosition, new Func<Ship, bool>(this.method_75), null, 0);
		GClass88 server = this.Server;
		string text = "ability_tartarus_speed-boost";
		bool flag = true;
		bool flag2 = true;
		server.method_15(text, flag);
		if ((float)this.MapProfile.MinHealHp >= this.Hero.HpPercentage)
		{
			flag2 |= this.wbniaSuPwQR();
		}
		if ((float)this.MapProfile.MinHealHp >= this.Hero.ShieldPercentage)
		{
			flag2 |= this.method_18();
		}
		if (ship != null && this.State == BotState.Travel && Vector2.Distance(ship.Position, this.HeroPosition) < 1000f)
		{
			flag2 |= this.cvgiarhHagp();
		}
		Ship selectedShip = this.Map.SelectedShip;
		if (this.IsAttacking && selectedShip != null && this.AttackingId == selectedShip.Id)
		{
			SelectedNpcModel model = this.MapProfile.GetModel(selectedShip, this.Map, null, 0);
			if (model != null && model.UseOffensiveAbility)
			{
				string text2 = this.method_17(GClass810.list_1);
				if (text2 == "ability_diminisher")
				{
					if (selectedShip.Shield > 15000 && selectedShip.Hp > 25000)
					{
						GClass88 server2 = this.Server;
						string text3 = text2;
						bool flag3 = true;
						flag2 = true;
						server2.method_14(text3, flag3, false);
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
						server3.method_14(text4, flag4, false);
					}
				}
				else if (text2 != null)
				{
					GClass88 server4 = this.Server;
					string text5 = text2;
					bool flag5 = true;
					flag2 = true;
					server4.method_14(text5, flag5, false);
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
			this.method_20();
			this.method_82(Class5.LastDisconnectReason);
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
			this.method_82(Class5.propertyChangedEventArgs_34);
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
			this.method_82(Class5.propertyChangedEventArgs_19);
			this.method_82(Class5.propertyChangedEventArgs_32);
			this.method_82(Class5.Account);
		}
	}

	public GClass808 Scheduler
	{
		[CompilerGenerated]
		get
		{
			return this.gclass808_0;
		}
		[CompilerGenerated]
		set
		{
			if (object.Equals(this.gclass808_0, value))
			{
				return;
			}
			this.gclass808_0 = value;
			this.method_82(Class5.Scheduler);
		}
	}

	public int RealDist
	{
		[CompilerGenerated]
		get
		{
			return this.int_2;
		}
		[CompilerGenerated]
		set
		{
			if (this.int_2 == value)
			{
				return;
			}
			this.int_2 = value;
			this.method_82(Class5.propertyChangedEventArgs_39);
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
			this.method_82(Class5.propertyChangedEventArgs_29);
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
			this.method_82(Class5.propertyChangedEventArgs_30);
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
			this.method_82(Class5.propertyChangedEventArgs_24);
		}
	}

	public bool Run
	{
		[CompilerGenerated]
		get
		{
			return this.KftiXgXeoRK;
		}
		[CompilerGenerated]
		set
		{
			if (this.KftiXgXeoRK == value)
			{
				return;
			}
			this.KftiXgXeoRK = value;
			this.method_82(Class5.propertyChangedEventArgs_42);
		}
	}

	public bool IsStopping
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
			this.method_82(Class5.propertyChangedEventArgs_25);
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
			this.method_82(Class5.propertyChangedEventArgs_5);
		}
	}

	public void method_20()
	{
		if (this.LastDisconnectReason != ErrorReason.Unknown)
		{
			this.Log.Error<ErrorReason>("Error: {reason}", this.LastDisconnectReason);
		}
	}

	public void method_21(string string_4)
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
			this.method_82(Class5.propertyChangedEventArgs_1);
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
			this.method_82(Class5.propertyChangedEventArgs_27);
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
			this.method_82(Class5.propertyChangedEventArgs_28);
		}
	}

	public void method_22()
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

	private bool method_23(PetState petState_0)
	{
		if (this.Hero.Pet.IsControlDisabled)
		{
			return false;
		}
		if (this.Cooldowns.method_2(BotAction.SwitchPetState, 2000.0))
		{
			this.Server.method_18(petState_0);
			return true;
		}
		return false;
	}

	private bool method_24(PetMode petMode_0)
	{
		if (this.Hero.Pet.IsControlDisabled)
		{
			return false;
		}
		if (this.Cooldowns.method_2(BotAction.SwitchPetMode, 2000.0))
		{
			this.Server.method_19(petMode_0);
			this.dateTimeOffset_1 = DateTimeOffset.Now;
			return true;
		}
		return false;
	}

	public void method_25()
	{
		if (!this.Hero.Pet.IsAvailable || !this.Hero.IsInitialized)
		{
			return;
		}
		bool flag = false;
		GClass818 gclass = this.Module as GClass818;
		if (gclass != null)
		{
			Ship enemyTarget = this.EnemyTarget;
			SelectedNpcModel selectedNpcModel = gclass.vmethod_2();
			if (selectedNpcModel != null && selectedNpcModel.UseKamikaze)
			{
				flag = true;
			}
			else if (this.MapProfile.GG_UseKamikazeCorner)
			{
				int attackingId = this.AttackingId;
				int? num = (enemyTarget != null) ? new int?(enemyTarget.Id) : null;
				bool flag2;
				if ((attackingId == num.GetValueOrDefault() & num != null) && this.Map.method_7(enemyTarget, out flag2))
				{
					flag = true;
				}
			}
			bool flag3 = this.Map.All<NpcShip>(this.HeroPosition, new Func<NpcShip, bool>(this.method_76), null, 0).Count > 1;
			flag &= (flag3 && this.Hero.Pet.Cooldowns.method_0(HeroPet.CooldownType.Kamikaze));
		}
		DateTimeOffset? enabledSince = this.Hero.Pet.EnabledSince;
		bool flag4 = (enabledSince != null && !enabledSince.GetValueOrDefault().Cooldown(50000)) || this.MapProfile.PetMode > PetModeSelection.None || flag;
		if (this.State == BotState.Logout || (this.State == BotState.Travel && this.bool_8) || this.State == BotState.Default || this.method_67())
		{
			flag4 = false;
		}
		if (!flag4)
		{
			if (this.Hero.Pet.IsEnabled)
			{
				this.method_24(PetMode.Passive);
				this.method_23(PetState.Deactivate);
			}
			return;
		}
		if (this.Hero.Pet.IsEnabled)
		{
			if (this.Hero.Pet.Fuel < 5000 && this.Cooldowns.method_2(BotAction.BuyPetFuel, 60000.0))
			{
				bool flag2;
				this.method_10<bool>("BuyPetFuel", new Func<DarkOrbitWebAPI, bool>(GClass810.<>c.<>c_0.method_2), out flag2);
			}
			PetMode petMode = (PetMode)((flag && this.Hero.Pet.method_14(PetMode.Kamikaze) && this.Hero.Pet.HpPercentage <= 10f) ? ((PetModeSelection)10) : this.MapProfile.PetMode);
			bool flag5;
			if (!this.dateTimeOffset_1.Cooldown(30000))
			{
				if (petMode == this.Hero.Pet.Mode)
				{
					flag5 = false;
					goto IL_2F2;
				}
			}
			flag5 = this.Hero.Pet.method_14(petMode);
			IL_2F2:
			if (flag5)
			{
				this.method_24(petMode);
			}
			return;
		}
		if (this.Hero.Pet.IsRepairNeeded)
		{
			if (this.Cooldowns.method_2(BotAction.RepairPet, 120000.0))
			{
				this.Server.method_18(PetState.Repair);
			}
			return;
		}
		this.method_23(PetState.Activate);
		this.Cooldowns.method_1(BotAction.BuyPetFuel, 60000.0);
		this.Cooldowns.method_1(BotAction.SwitchPetMode, 2000.0);
	}

	public bool method_26()
	{
		if (this.dateTimeOffset_2.Cooldown(5000))
		{
			this.method_71();
		}
		this.method_15();
		this.method_19();
		this.method_9();
		this.method_22();
		this.method_25();
		if (this.Account.AutoRefine)
		{
			this.AutoRefine();
		}
		if (this.Hero.method_15("equipment_extra_repbot_rep") && !this.Hero.method_15("equipment_extra_cpu_nc-rrb-x") && this.Hero.LastTookDamage.Cooldown(6000) && this.Hero.LastAttacked.Cooldown(1000) && this.Hero.HpPercentage < 100f)
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
			if (this.EnemyTarget == null || this.Game.Hero.LastAttacked.Cooldown(30000))
			{
				this.Game.Connection.Server.method_10();
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
				this.Hero.method_17("tech_precision-targeter", out menuItem, false);
			}
		}
		if (!this.Hero.method_15("equipment_extra_cpu_arol-x") && this.IsAttacking && this.Hero.ItemCooldown.method_0(CooldownType.Rocket) && this.SelectedRockets != null)
		{
			this.Hero.ItemCooldown.method_2(CooldownType.Rocket, 213.0);
			this.Server.method_12(this.EnemyTarget);
		}
		if (this.MapProfile.FleeFromEnemySeen && !this.Behavior.vmethod_4(false, false))
		{
			if (GClass810.botState_2.HasFlag(this.State))
			{
				this.method_60(BotState.Flee);
			}
		}
		else if (this.Game.Hero.HpPercentage < (float)this.MapProfile.MinHp && GClass810.botState_2.HasFlag(this.State))
		{
			this.method_60(BotState.Repair);
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
			this.method_82(Class5.propertyChangedEventArgs_16);
		}
	}

	public bool method_27()
	{
		bool flag = this.method_66();
		bool flag2 = this.method_65();
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
			if (this.Behavior.vmethod_10(this.EnemyTarget, this.CollectibleTarget))
			{
				botState_ = BotState.Collect;
			}
			else
			{
				botState_ = BotState.Hunt;
			}
		}
		this.method_60(botState_);
		return true;
	}

	public void method_28()
	{
		if (this.StateIters <= 1)
		{
			this.int_3 = 0;
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
		if (this.method_14())
		{
			return;
		}
		if (((this.Game.Hero.HpPercentage < 98f && this.Hero.method_15("equipment_extra_repbot_rep")) || (!this.ignoreShields && this.Game.Hero.ShieldPercentage < 90f)) && this.dateTimeOffset_3.Cooldown(10000))
		{
			this.method_60(BotState.Repair);
			return;
		}
		if (this.Game.Web.GgInfo == null)
		{
			return;
		}
		if (this.IsStopping && this.Behavior.vmethod_12())
		{
			this.method_60(BotState.Logout);
			return;
		}
		if (this.Hero.InSafeZone)
		{
			if (!this.Behavior.vmethod_4(false, true))
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
		if (!this.method_67())
		{
			this.Clear();
			this.method_60(this.Behavior.vmethod_14());
			return;
		}
		int int_ = MapUtils.smethod_0(this.MapProfile.TargetMap.GetName(), this.Hero.FactionId);
		GClass818 gclass = this.Module as GClass818;
		if ((gclass != null && gclass.State != ModuleState.Started) || this.IsStopping)
		{
			int_ = MapUtils.smethod_8(1, this.Hero.FactionId);
		}
		Gate gate = this.method_69(this.HeroPosition, int_);
		if (gate != null)
		{
			this.method_32(gate.Position, gate, 15, false);
			return;
		}
		int num = this.int_3;
		this.int_3 = num + 1;
		if (num > 400)
		{
			this.method_58();
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
			this.method_82(Class5.propertyChangedEventArgs_51);
		}
	}

	private bool method_29(GEnum4 genum4_0)
	{
		MenuItem menuItem;
		return this.Hero.MenuItems.TryGetValue(genum4_0.smethod_0(), out menuItem) && menuItem.Selected;
	}

	private bool ignoreShields
	{
		get
		{
			return this.method_29(GEnum4.Wheel) || this.method_29(GEnum4.Moth);
		}
	}

	public void method_30()
	{
		if (this.StateIters == 0)
		{
			this.int_5 = 0;
			this.nullable_1 = null;
			this.bool_5 = false;
			this.bool_6 = false;
		}
		if (this.Game.Hero.Hp == 0 && this.StateIters > 200 && this.Game.Connection.Socket.BdaNsdwBbq())
		{
			this.Game.Connection.method_14();
			return;
		}
		if (this.int_5 > 6)
		{
			this.method_61();
			return;
		}
		bool bool_ = this.MapProfile.FleeFormation == GEnum4.Wheel || this.MapProfile.FleeFormation == GEnum4.Moth;
		MenuItem menuItem;
		if (this.ignoreShields && this.Hero.MenuItems.TryGetValue(GEnum4.Default.smethod_0(), out menuItem) && menuItem.Activatable && !menuItem.Selected && this.Hero.ItemCooldown.method_0(CooldownType.DroneFormation) && this.Cooldowns.method_2(BotAction.SwitchDroneFormation, 1000.0))
		{
			this.Server.method_15(GEnum4.Default.smethod_0(), true);
		}
		bool flag = this.Game.Hero.LastConfigSwitched.Cooldown(1000);
		bool flag2 = this.Game.Hero.ShieldPercentage >= 90f && flag;
		bool flag3 = (flag && this.Game.Hero.HpPercentage >= 98f) || !this.Hero.method_15("equipment_extra_repbot_rep");
		int config = this.Hero.Config;
		bool flag4 = this.MapProfile.AttackConfig == 1 && this.MapProfile.FleeConfig == 1 && this.MapProfile.FlyingConfig == 1;
		bool flag5 = this.MapProfile.AttackConfig == 2 && this.MapProfile.FleeConfig == 2 && this.MapProfile.FlyingConfig == 2;
		this.bool_5 |= (flag2 && config == 1);
		this.bool_6 |= (flag2 && config == 2);
		if ((this.bool_5 || flag5) && (this.bool_6 || flag4) && flag3 && this.StateIters > 20)
		{
			this.dateTimeOffset_3 = DateTimeOffset.Now;
			this.method_61();
			return;
		}
		this.EnemyTarget = null;
		this.CollectibleTarget = null;
		if (!this.Behavior.vmethod_4(true, false))
		{
			this.method_12(false, bool_);
			if (this.Map.IsGG)
			{
				Vector2? vector = this.nullable_1;
				this.nullable_1 = ((vector != null) ? vector : this.Behavior.vmethod_17(false));
				if (this.nullable_1 != null && this.method_4(this.nullable_1.Value, 50, 300, false, 640, 360, 0, 0, 0, false, 0, new Action(this.method_77)))
				{
					this.nullable_1 = null;
				}
			}
			else
			{
				this.method_13(false, false);
			}
		}
		if ((this.bool_5 ^ this.bool_6) && this.method_11(this.bool_5 ? 2 : 1))
		{
			this.int_5++;
		}
	}

	public void method_31()
	{
		if (!this.Behavior.vmethod_4(true, false))
		{
			if (this.method_13(false, false))
			{
				return;
			}
			this.method_61();
			return;
		}
		else
		{
			int num = (this.Hero.Premium ? 5000 : 20000) + 10000;
			if (this.StateIters == 1)
			{
				this.Server.method_5(this.HeroPosition.X, this.HeroPosition.Y, false);
				this.Server.method_17();
				return;
			}
			if (this.StateIters > num / 50)
			{
				this.method_60(BotState.Default);
				int num2 = this.int_6 + 1;
				this.int_6 = num2;
				if (num2 > 5)
				{
					this.int_6 = 0;
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
			this.bool_7 = false;
			this.vector2_0 = value;
			this.method_82(Class5.propertyChangedEventArgs_41);
		}
	}

	public void kgVianNxUu9()
	{
		if (this.wuAiedayWav())
		{
			return;
		}
		if (this.method_67())
		{
			this.method_60(BotState.Default);
			return;
		}
		if (this.method_27())
		{
			return;
		}
		if (this.Behavior.vmethod_19())
		{
			return;
		}
		if (!this.Cooldowns.method_0(BotAction.Move))
		{
			return;
		}
		if (this.method_14())
		{
			this.RoamTarget = Vector2.Zero;
			return;
		}
		bool flag = this.RoamTarget == this.HeroPosition || this.RoamTarget == Vector2.Zero;
		if (!this.bool_7 || flag)
		{
			Collectible collectible = this.method_68(this.HeroPosition);
			if (collectible != null)
			{
				this.RoamTarget = collectible.Position;
				this.bool_7 = true;
			}
			else if (flag)
			{
				this.RoamTarget = this.Game.Security.method_20(this.Game.Map, this.Behavior.vmethod_13());
			}
		}
		this.method_4(this.RoamTarget, 5, 200, false, 640, 360, 10, 10, 30, false, 0, new Action(this.method_78));
	}

	public Vector2? TravelTarget
	{
		[CompilerGenerated]
		get
		{
			return this.zvmiXjajlWa;
		}
		[CompilerGenerated]
		set
		{
			if (Nullable.Equals<Vector2>(this.zvmiXjajlWa, value))
			{
				return;
			}
			this.zvmiXjajlWa = value;
			this.method_82(Class5.propertyChangedEventArgs_54);
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
			this.method_82(Class5.propertyChangedEventArgs_12);
		}
	}

	public bool method_32(Vector2 vector2_2, Gate gate_1 = null, int int_11 = 15, bool bool_12 = false)
	{
		GClass810.<>c__DisplayClass167_0 CS$<>8__locals1 = new GClass810.<>c__DisplayClass167_0();
		CS$<>8__locals1.gclass810_0 = this;
		CS$<>8__locals1.vector2_0 = vector2_2;
		CS$<>8__locals1.bool_0 = bool_12;
		CS$<>8__locals1.gate_0 = gate_1;
		CS$<>8__locals1.int_0 = int_11;
		bool flag = Map.Navigators.method_4(new Action<MapNavigator>(CS$<>8__locals1.method_0), 30);
		if (flag && this.pathSequence_0 != null)
		{
			this.Map.Grid.method_15(this.pathSequence_0);
		}
		return flag;
	}

	public void method_33()
	{
		if (this.StateIters <= 1)
		{
			this.int_4 = 0;
		}
		if (this.LastStates.method_2() != BotState.Logout && this.wuAiedayWav())
		{
			return;
		}
		if (!this.MapProfile.FleeStopOnEnemyLost || !this.bool_8 || !this.Behavior.vmethod_4(false, false))
		{
			if (this.TravelTarget != null)
			{
				Vector2 value = this.TravelTarget.Value;
				if (Vector2.Distance(value, this.HeroPosition) > (float)this.int_7)
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
						if (this.method_4(value, this.int_7, 300, false, 640, 360, 0, 0, 0, false, 0, new Action(this.method_79)))
						{
							this.TravelTarget = null;
							goto IL_139;
						}
						goto IL_139;
					}
				}
				this.TravelTarget = null;
				this.Server.method_5(this.HeroPosition.X, this.HeroPosition.Y, false);
			}
			IL_139:
			if (this.gate_0 != null)
			{
				Gate gate;
				this.Map.Gates.TryGetValue(this.gate_0.Id, out gate);
				if (gate == null)
				{
					this.gate_0 = null;
					goto IL_205;
				}
				if (gate.Activatable)
				{
					this.method_2(gate.Id);
					return;
				}
				if (Vector2.Distance(this.HeroPosition, gate.Position) < 500f)
				{
					if (this.bool_8 && this.Behavior.vmethod_4(false, false) && !this.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(this.method_80)))
					{
						goto IL_205;
					}
					int num3 = this.int_4;
					this.int_4 = num3 + 1;
					if (num3 > 400)
					{
						this.method_58();
					}
				}
			}
			if (this.TravelTarget != null)
			{
				return;
			}
		}
		IL_205:
		this.method_61();
	}

	public void method_34()
	{
		if (this.IsCollecting && this.StateIters < 200)
		{
			return;
		}
		if (!this.IsCollecting && this.CollectibleTarget == null)
		{
			this.method_61();
			return;
		}
		this.method_66();
		if (this.CollectibleTarget == null)
		{
			this.method_61();
			return;
		}
		if (!this.Game.Security.method_21(this.CollectibleTarget, false))
		{
			this.CollectibleTarget = null;
			return;
		}
		if (this.method_4(this.CollectibleTarget.Position, 0, 300, false, 640, 360, 10, 10, 0, false, 7, null))
		{
			if (!this.Cooldowns.method_0(BotAction.Collect))
			{
				return;
			}
			this.StateIters = 0;
			this.method_3(this.CollectibleTarget);
		}
	}

	public void method_35()
	{
		if (this.Map.IsGG)
		{
			if (this.ReturnState == BotState.Repair)
			{
				this.method_61();
				return;
			}
			this.method_60(BotState.Repair);
			return;
		}
		else
		{
			if (!this.Behavior.vmethod_4(false, false))
			{
				if (this.method_13(true, true))
				{
					this.Timeout = new DateTime?(DateTime.Now.AddSeconds((double)this.MapProfile.FleeTimeout));
				}
				return;
			}
			this.method_60(BotState.Default);
			return;
		}
	}

	public void method_36()
	{
		if (this.MapProfile != null)
		{
			this.method_60(BotState.Default);
			return;
		}
	}

	public void method_37()
	{
		GClass810.<>c__DisplayClass175_0 CS$<>8__locals1 = new GClass810.<>c__DisplayClass175_0();
		CS$<>8__locals1.gclass810_0 = this;
		if (!this.MapProfile.Hunter)
		{
			this.method_61();
		}
		CS$<>8__locals1.ship_0 = this.EnemyTarget;
		if (CS$<>8__locals1.ship_0 == null)
		{
			this.method_61();
			return;
		}
		Ship enemyTarget;
		if (this.Behavior.vmethod_1(CS$<>8__locals1.ship_0, out enemyTarget))
		{
			this.StateIters = 0;
			this.EnemyTarget = enemyTarget;
			return;
		}
		Ship selectedShip = this.Game.Map.SelectedShip;
		Vector2 position = CS$<>8__locals1.ship_0.Position;
		NpcShip npcShip = CS$<>8__locals1.ship_0 as NpcShip;
		if (selectedShip != null)
		{
			if (selectedShip.Id == CS$<>8__locals1.ship_0.Id)
			{
				this.method_8(selectedShip);
				if (!this.Cooldowns.method_0(BotAction.Move))
				{
					return;
				}
				bool flag;
				this.Map.method_7(selectedShip, out flag);
				Vector2? vector = null;
				bool flag2;
				if ((flag2 = this.Behavior.vmethod_2(npcShip)) && this.Behavior.vmethod_3(npcShip) && this.method_66())
				{
					if (Vector2.Distance(this.CollectibleTarget.Position, this.HeroPosition) <= 250f)
					{
						this.method_60(BotState.Collect);
						return;
					}
					if (Vector2.Distance(this.CollectibleTarget.Position, this.HeroPosition) < 1500f)
					{
						Collectible collectibleTarget = this.CollectibleTarget;
						vector = ((collectibleTarget != null) ? new Vector2?(collectibleTarget.Position) : null);
					}
				}
				if (flag2)
				{
					Vector2 vector2_ = this.Game.Security.method_9(this.HeroPosition, CS$<>8__locals1.ship_0, vector, 0.5f, 0f, this.MapProfile.GG_DragNpcs);
					this.method_4(vector2_, 0, this.Game.Security.Random.Next(180, 200), false, 640, 360, 0, 0, 0, false, 0, new Action(CS$<>8__locals1.method_0));
					return;
				}
				this.method_4(CS$<>8__locals1.ship_0.Position, 300, 300, false, 640, 360, 0, 0, 0, false, 0, new Action(CS$<>8__locals1.method_0));
				return;
			}
		}
		if (this.method_4(CS$<>8__locals1.ship_0.Position, this.Map.IsGG ? 900 : 700, 300, !this.Map.IsGG, 640, 360, 0, 0, 0, false, 0, new Action(CS$<>8__locals1.method_0)))
		{
			this.method_6(CS$<>8__locals1.ship_0, true);
			npcShip.LastDistance = 460;
			npcShip.RangeFix = 1;
			this.method_72(npcShip);
		}
		if (this.StateIters > 15)
		{
			this.method_61();
		}
	}

	public void method_38()
	{
		Rectangle rectangle = GClass825.list_0.First<Rectangle>();
		if (!rectangle.Contains((int)this.HeroPosition.X, (int)this.HeroPosition.Y))
		{
			Vector2 vector2_ = new Vector2((float)(rectangle.X + rectangle.Width / 2), (float)(rectangle.Y + rectangle.Height / 2));
			if (this.method_32(vector2_, null, 15, false))
			{
				return;
			}
		}
		if (this.StateIters > 1000)
		{
			this.method_60(BotState.Default);
			return;
		}
		Asset value = this.Map.Assets.FirstOrDefault(new Func<KeyValuePair<int, Asset>, bool>(GClass810.<>c.<>c_0.method_3)).Value;
		if (value == null)
		{
			this.method_60(BotState.Default);
			return;
		}
		if (value.Activatable && this.Cooldowns.method_0(BotAction.TradeOre))
		{
			foreach (ResourceType resourceType in GClass810.list_3)
			{
				double num = this.Hero.method_24(resourceType);
				int num2 = (resourceType == ResourceType.PALLADIUM) ? 15 : 1;
				if (num >= (double)num2)
				{
					this.Cooldowns.method_2(BotAction.TradeOre, 500.0);
					this.Server.method_0(value.Id);
					this.Server.method_1();
					this.Server.method_21(resourceType, num);
					return;
				}
			}
			this.method_60(BotState.Default);
		}
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
			this.method_82(Class5.propertyChangedEventArgs_20);
		}
	}

	public GClass836 Controller
	{
		[CompilerGenerated]
		get
		{
			return this.gclass836_0;
		}
		[CompilerGenerated]
		internal set
		{
			if (object.Equals(this.gclass836_0, value))
			{
				return;
			}
			this.gclass836_0 = value;
			this.method_82(Class5.Controller);
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
			this.method_82(Class5.propertyChangedEventArgs_33);
		}
	}

	public void method_39()
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
			IL_30E:
			object obj = this.object_0;
			lock (obj)
			{
				this.Clear();
			}
			int num3 = 0;
			while (!this.Game.Hero.IsInitialized)
			{
				if (this.Game.Connection.Socket.BdaNsdwBbq())
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
			while (this.Game.Connection.Socket.BdaNsdwBbq() && !this.IsPaused && this.Run && this.Hero.IsInitialized)
			{
				Thread.Sleep(50);
				DateTime now = DateTime.Now;
				this.Cooldowns.Now = new DateTimeOffset?(now);
				obj = this.object_0;
				lock (obj)
				{
					if (this.bool_4 || this.Hero.Hp == 0)
					{
						this.bool_4 = false;
						goto IL_30E;
					}
					this.HeroPosition = this.Game.Hero.Position;
					GClass812 gclass = this.Scheduler.method_11();
					GClass820 behavior = gclass.GetBehavior();
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
					this.IsStopping = (!this.Module.ShouldBeInGame() || this.ShouldBeDisabled || this.ForceLogout);
					try
					{
						if (this.method_26())
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
						this.method_60(botState_);
					}
					BotState state = this.State;
					this.method_59();
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

	private void method_40(object object_1, GClass185 gclass185_0)
	{
		int id = this.Hero.Id;
	}

	private void method_41()
	{
		this.Cooldowns.Clear(BotAction.RepairPet);
	}

	private void method_42(GameManager gameManager_1, GClass255 gclass255_0)
	{
		if (!gclass255_0.string_0.StartsWith("69|"))
		{
			return;
		}
		string[] array = gclass255_0.string_0.Split(new char[]
		{
			'|'
		});
		if (array == null)
		{
			return;
		}
		int num;
		if (array.Length != 3 || !(array[1] == "range") || !int.TryParse(array[2], out num))
		{
			if (array.Length == 2 && array[1] == "distance")
			{
				Ship selectedShip = this.Map.SelectedShip;
				if (selectedShip != null)
				{
					this.method_81(string.Format("Distance to {0}: {1}", selectedShip.Name, Vector2.Distance(this.Map.Hero.Position, selectedShip.Position)));
					return;
				}
			}
			else
			{
				int num2;
				if (array.Length == 3 && array[1] == "predict" && int.TryParse(array[2], out num2))
				{
					this.method_81(string.Format("Set prediction time to {0}ms", num2));
					this.Game.Security.PredictionMs = num2;
					return;
				}
				int num3;
				double num4;
				if (array.Length == 4 && array[1] == "trade" && int.TryParse(array[2], out num3) && double.TryParse(array[3], out num4))
				{
					ResourceType resourceType = (ResourceType)num3;
					this.method_81(string.Format("Attempting to sell {0} of {1}", num4, num3));
					this.Server.method_21(resourceType, num4);
					return;
				}
				if (array.Length == 2 && array[1] == "help")
				{
					this.method_81("!dope range/<npc radius>");
					this.method_81("!dope distance");
					this.method_81("!dope trade/<ore>/<amount>");
					return;
				}
				if (array.Length == 2 && array[1] == "portals")
				{
					this.method_81("PORTALS OPEN");
					GInterface5 proxySocket = this.Game.Connection.ProxySocket;
					for (int i = 1; i < 100; i++)
					{
						int int_ = i % 30 * 500;
						int int_2 = i / 30 * 1500;
						if (proxySocket != null)
						{
							proxySocket.SendMessage(new GClass181(15151515 + i, 0, i, int_, int_2, false, false, null));
						}
						if (proxySocket != null)
						{
							proxySocket.SendMessage(new GClass251(15161615 + i, "ship_goliath", 0, "", string.Format("{0}", i), int_, int_2, 0, 0, 0, false, null, 0, false, true, false, 0, 0, "", null, null));
						}
					}
					return;
				}
				if (array.Length == 2 && array[1] == "position")
				{
					this.method_81(this.Game.Hero.Position.ToString());
					return;
				}
				int num5;
				if (array.Length == 3 && array[1] == "close" && int.TryParse(array[2], out num5))
				{
					this.Game.Connection.SendMessage(new GClass142(num5 > 0));
					return;
				}
				if (array.Length == 4 && array[1] == "box")
				{
					bool flag = array[2] == "add";
					string text = array[3];
					GInterface5 proxySocket2 = this.Game.Connection.ProxySocket;
					if (proxySocket2 == null)
					{
						return;
					}
					if (flag)
					{
						proxySocket2.SendMessage(new GClass173(text, this.Game.Hero.PosX, this.Game.Hero.PosY, "BONUS_BOX"));
						return;
					}
					proxySocket2.SendMessage(new GClass136(text, true));
					return;
				}
				else if (array.Length == 4 && array[1] == "res")
				{
					bool flag2 = array[2] == "add";
					string text2 = array[3];
					GInterface5 proxySocket3 = this.Game.Connection.ProxySocket;
					if (proxySocket3 == null)
					{
						return;
					}
					if (flag2)
					{
						proxySocket3.SendMessage(new GClass174(text2, this.Game.Hero.PosX, this.Game.Hero.PosY, new GClass247(8U)));
						return;
					}
					proxySocket3.SendMessage(new GClass136(text2, true));
					return;
				}
				else if (array.Length == 2 && array[1] == "npc")
				{
					for (int j = 0; j < 4; j++)
					{
						GInterface5 proxySocket4 = this.Game.Connection.ProxySocket;
						if (proxySocket4 != null)
						{
							proxySocket4.SendMessage(new GClass251(15161213 + j, "ship_goliath", 0, "", "Test NPC", this.Game.Hero.PosX + j * 100, this.Game.Hero.PosY, j, 0, 0, false, null, 0, false, true, false, 0, 0, "", null, null));
						}
					}
				}
			}
			return;
		}
		NpcShip npcShip = this.Map.SelectedShip as NpcShip;
		NpcUtils.NpcClass npcClass;
		if (npcShip == null)
		{
			npcClass = null;
		}
		else
		{
			NpcUtils.NpcType type = npcShip.Type;
			npcClass = ((type != null) ? type.Class : null);
		}
		NpcUtils.NpcClass npcClass2 = npcClass;
		if (npcClass2 == null)
		{
			this.method_81("No npc");
			return;
		}
		SecurityManager.NpcRangesRegular[npcClass2] = num;
		this.method_81(string.Format("Set range for {0} to {1}", npcClass2.ToString(), num));
	}

	private void method_43(Map map_0, Ship ship_1, GClass253 gclass253_0)
	{
		GClass810.<>c__DisplayClass194_0 CS$<>8__locals1 = new GClass810.<>c__DisplayClass194_0();
		CS$<>8__locals1.gclass810_0 = this;
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

	private void method_44(Map map_0, Ship ship_1)
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

	private void method_45(Map map_0, Ship ship_1)
	{
		GClass810.<>c__DisplayClass196_0 CS$<>8__locals1 = new GClass810.<>c__DisplayClass196_0();
		CS$<>8__locals1.nkciTpwApcd = this;
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
			this.method_72(npcShip);
		}
	}

	public bool method_46(int int_11)
	{
		CachedDictionary<int, bool> obj = this.cachedDictionary_0;
		bool orDefault;
		lock (obj)
		{
			orDefault = this.cachedDictionary_0.GetOrDefault(int_11);
		}
		return orDefault;
	}

	private void method_47()
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (GClass810.botState_2.HasFlag(this.State))
			{
				this.method_60(BotState.Flee);
			}
		}
	}

	private void method_48(Map map_0, Ship ship_1, Ship ship_2, int int_11, uint uint_0)
	{
		if (ship_1 != null && ship_2 != null)
		{
			if (ship_2.Id == this.Game.Hero.Id)
			{
				if (this.method_70(ship_1) || !ship_1.IsNpc)
				{
					if (this.cooldownTracker_0.method_2(ship_1.Id, 300000.0))
					{
						this.Service.ReportAggressor(ship_1.Id);
						this.cachedDictionary_0.Put(ship_1.Id, true);
					}
					MapProfile mapProfile = this.MapProfile;
					if (mapProfile != null && mapProfile.FleeFromEnemyAttacker)
					{
						this.method_47();
					}
				}
				if (this.Map.IsGG && ship_1.IsNpc)
				{
					this.int_8 += int_11;
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

	private void method_49(GClass91 gclass91_0)
	{
		this.Log.Info("Connected to game server");
		this.LastDisconnectReason = ErrorReason.Unknown;
	}

	private void method_50(Map map_0, string string_4, Collectible collectible_1, bool bool_12)
	{
		object obj = this.object_0;
		lock (obj)
		{
			Collectible collectibleTarget = this.CollectibleTarget;
			if (((collectibleTarget != null) ? collectibleTarget.Hash : null) == string_4)
			{
				if (this.IsCollecting)
				{
					GClass803 stats = this.Stats;
					int boxes = stats.Boxes;
					stats.Boxes = boxes + 1;
					this.IsCollecting = false;
					this.Cooldowns.method_1(BotAction.Move, (double)this.Game.Security.Random.Next(200, 300));
				}
				this.CollectibleTarget = null;
			}
			if (bool_12)
			{
				Collectible collectible;
				this.DormantTargets.TryRemove(string_4, out collectible);
			}
		}
	}

	private void method_51(GClass91 gclass91_0, ErrorReason errorReason_1, Exception exception_0 = null)
	{
		DateTime now = DateTime.Now;
		if (!this.dateTimeOffset_4.Cooldown(60000))
		{
			this.NnGiXkucSuH++;
		}
		else
		{
			this.NnGiXkucSuH = 0;
		}
		this.dateTimeOffset_4 = now;
		if (errorReason_1 == ErrorReason.LoggedOut)
		{
			this.ForceLogout = false;
		}
		if (errorReason_1 == ErrorReason.VersionMismatch || this.NnGiXkucSuH > 15)
		{
			this.ShouldBeDisabled = true;
		}
		this.Clear();
		this.LastDisconnectReason = errorReason_1;
		this.Log.Warn<ErrorReason>("Disconnected from game server, {errorReason}", errorReason_1);
		this.dateTime_2 = now;
		if (this.NnGiXkucSuH > 4)
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
			this.dateTime_2 = DateTime.Now.AddMilliseconds(-500.0);
		}
	}

	private void method_52(GameManager gameManager_1, Hero hero_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.Run)
			{
				this.bool_4 = true;
			}
			this.Game.LastJumped = DateTime.Now.AddSeconds(-4.0);
		}
	}

	private void method_53(GameManager gameManager_1, Hero hero_0, GClass207 gclass207_0)
	{
		GClass810.<>c__DisplayClass211_0 CS$<>8__locals1 = new GClass810.<>c__DisplayClass211_0();
		CS$<>8__locals1.gameManager_0 = gameManager_1;
		CS$<>8__locals1.gclass810_0 = this;
		this.Log.Info("Hero died");
		this.QrIiaYslyyT<GClass830>().imethod_1();
		this.Timeout = null;
		if (this.IsPaused)
		{
			return;
		}
		CS$<>8__locals1.uint_0 = 1U;
		MapProfile mapProfile = this.MapProfile;
		if (mapProfile != null && mapProfile.ReviveAtPortal)
		{
			if (gclass207_0.vector_0.Any(new Func<GClass546, bool>(GClass810.<>c.<>c_0.method_4)))
			{
				CS$<>8__locals1.uint_0 = 2U;
			}
		}
		object obj = this.object_0;
		lock (obj)
		{
			this.Hero.Hp = 0;
			this.Hero.IsInitialized = false;
			if (this.Run)
			{
				this.bool_4 = true;
			}
		}
		MapProfile mapProfile2 = this.MapProfile;
		if (mapProfile2 != null && mapProfile2.ReviveAtPortal && (this.Behavior is GClass822 || this.Behavior is GClass826))
		{
			this.Log.Info("Adding 1 minute of delay because of unsafe portal repair");
			this.dateTime_2 = DateTime.Now.AddMinutes(1.0);
		}
		Task.Factory.StartNew(new Action(CS$<>8__locals1.MnRiToGrncM));
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
			this.method_82(Class5.Hero);
			this.method_82(Class5.propertyChangedEventArgs_21);
			this.method_82(Class5.propertyChangedEventArgs_47);
			this.method_82(Class5.Map);
			this.method_82(Class5.propertyChangedEventArgs_15);
			this.method_82(Class5.propertyChangedEventArgs_48);
			this.method_82(Class5.Game);
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

	public GClass803 Stats
	{
		[CompilerGenerated]
		get
		{
			return this.gclass803_0;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.gclass803_0, value))
			{
				return;
			}
			this.gclass803_0 = value;
			this.method_82(Class5.Stats);
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
			this.method_82(Class5.State);
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
			this.method_82(Class5.propertyChangedEventArgs_40);
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
			this.method_82(Class5.propertyChangedEventArgs_31);
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
			this.method_82(Class5.propertyChangedEventArgs_11);
		}
	}

	[CompilerGenerated]
	public List<GInterface8> method_55()
	{
		return this.list_4;
	}

	public bool ShouldBeDisabled
	{
		[CompilerGenerated]
		get
		{
			return this.bool_9;
		}
		[CompilerGenerated]
		set
		{
			if (this.bool_9 == value)
			{
				return;
			}
			this.bool_9 = value;
			this.method_82(Class5.propertyChangedEventArgs_49);
		}
	}

	public bool ForceLogout
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
			this.method_82(Class5.propertyChangedEventArgs_17);
		}
	}

	public bool IsPaused
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
			this.method_82(Class5.IsPaused);
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

	public GClass812 Module
	{
		[CompilerGenerated]
		get
		{
			return this.gclass812_0;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.gclass812_0, value))
			{
				return;
			}
			this.gclass812_0 = value;
			this.method_82(Class5.Module);
		}
	}

	public GClass820 Behavior
	{
		[CompilerGenerated]
		get
		{
			return this.gclass820_1;
		}
		[CompilerGenerated]
		private set
		{
			if (object.Equals(this.gclass820_1, value))
			{
				return;
			}
			this.gclass820_1 = value;
			this.method_82(Class5.propertyChangedEventArgs_2);
		}
	}

	public GClass810(IDopeServiceProxy idopeServiceProxy_0, AccountSettings accountSettings_1)
	{
		Class8.xDph7tozmh5WD();
		this.concurrentDictionary_0 = new ConcurrentDictionary<string, object>();
		this.maxStack_0 = new MaxStack<int>(7);
		this.cooldownTracker_0 = new CooldownTracker<int>();
		this.cachedDictionary_0 = new CachedDictionary<int, bool>(3600000);
		this.dateTime_2 = DateTime.Now;
		this.dateTime_3 = DateTime.MinValue;
		this.object_0 = new object();
		this.botState_0 = BotState.Default;
		this.botState_1 = BotState.Default;
		this.maxStack_1 = new MaxStack<BotState>(1000);
		this.cooldownTracker_1 = new CooldownTracker<BotAction>();
		this.list_4 = new List<GInterface8>();
		this.cooldownTracker_2 = new CooldownTracker<int>();
		this.concurrentDictionary_1 = new ConcurrentDictionary<string, Collectible>();
		base..ctor();
		this.Account = accountSettings_1;
		this.Game = new GameManager(idopeServiceProxy_0);
		this.Stats = new GClass803(this);
		this.Scheduler = new GClass808(this);
		this.Game.LogManager = this;
		this.BackgroundQueue = new ConcurrentQueue<Func<DarkOrbitWebAPI, object>>();
		this.list_4 = new List<GInterface8>
		{
			new GClass833(this),
			new GClass831(this),
			new GClass830(this),
			new GClass834(this),
			new GClass832(this)
		};
		this.gclass820_0 = new GClass821(this);
		this.gclass828_0 = new GClass828(this);
		this.gclass826_0 = new GClass826(this);
		this.gclass823_0 = new GClass823(this);
		this.Behavior = this.gclass820_0;
		this.method_57();
	}

	public fkLHQcC3PB7LGhjcIyh QrIiaYslyyT<fkLHQcC3PB7LGhjcIyh>() where fkLHQcC3PB7LGhjcIyh : GClass829
	{
		return this.method_55().First(new Func<GInterface8, bool>(GClass810.<>c__281<fkLHQcC3PB7LGhjcIyh>.<>9.method_0)) as fkLHQcC3PB7LGhjcIyh;
	}

	public void method_56()
	{
		this.Game.Settings.UserAgent = this.Account.UserAgent;
		this.LastLogin = DateTime.Now;
		bool isLoggedIn = this.Game.IsLoggedIn;
		bool flag = isLoggedIn && this.Game.Web.CheckLoggedIn();
		if (!isLoggedIn || !flag)
		{
			this.Game.IsLoggedIn = false;
			AccountSettings account = this.Account;
			if (this.Scheduler.HmLiAjwBmZt())
			{
				this.Log.Info("Logging in");
				this.Game.method_4(account.Username, account.Password, account.Server);
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

	private void method_57()
	{
		this.Game.HeroInit += this.method_52;
		this.Game.HeroDied += this.method_53;
		this.Game.Map.ShipAttacked += this.method_48;
		this.Game.Map.ShipCreated += this.method_45;
		this.Game.Map.ShipDestroyed += this.method_44;
		this.Game.Connection.Socket.Disconnected += this.method_51;
		this.Game.Connection.Socket.Connected += this.method_49;
		this.Game.Map.CollectibleCollected += this.method_50;
		this.Game.Map.ShipMoveStarted += this.method_43;
		this.Game.LogMessage += this.method_42;
		this.Game.Hero.Pet.KamikazeDeath += this.method_41;
		this.Game.Hero.Group.InviteAdded += this.method_40;
	}

	public void DetachPErkava()
	{
		this.Log.Info("Detaching PErkava");
		object obj = this.object_0;
		lock (obj)
		{
			this.Game.Settings.IsClient = true;
			this.Game.Connection.ProxySocket = null;
			this.Scheduler.method_3();
			if (!this.Run)
			{
				this.Game.Connection.method_14();
			}
		}
	}

	public bool AttachPErkava(GClass228 obj)
	{
		this.Log.Info("Attaching PErkava");
		GameManager game = this.Game;
		if (game.Settings.FlashSettings.sessionID == null)
		{
			game.Settings.FlashSettings.pid = obj.int_0;
			game.Settings.FlashSettings.sessionID = obj.string_0;
			game.Settings.FlashSettings.userID = obj.int_2;
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
			this.Scheduler.method_4();
			this.IsPaused = true;
			this.IsEnabled = true;
			this.ShouldBeDisabled = false;
		}
		if (game.Connection.Socket.BdaNsdwBbq())
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
		GClass803 stats = this.Stats;
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
		this.BotThread = new Thread(new ThreadStart(this.method_39))
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

	public void method_58()
	{
		this.Module.SetCooldown(TimeSpan.FromMinutes(5.0));
		this.method_60(BotState.Default);
	}

	public void Clear()
	{
		this.TravelTarget = null;
		this.gate_0 = null;
		this.bool_7 = false;
		this.CollectibleTarget = null;
		this.SelectedAmmo = (this.SelectedRockets = (this.SelectedHS = null));
		this.EnemyTarget = null;
		this.RoamTarget = Vector2.Zero;
		this.State = BotState.Default;
		this.ReturnState = BotState.Default;
		this.LastStates.Clear();
		this.IsCollecting = false;
		this.IsAttacking = false;
		this.int_3 = 0;
		this.int_4 = 0;
		this.int_6 = 0;
		this.Game.Security.HashBlockList.Cooldowns.Clear();
		this.int_8 = 0;
		this.dateTimeOffset_0 = DateTimeOffset.MinValue;
	}

	public void method_59()
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
						this.method_28();
						break;
					case BotState.Roam:
						this.kgVianNxUu9();
						break;
					case BotState.Default | BotState.Roam:
						break;
					case BotState.Flee:
						this.method_35();
						break;
					default:
						if (state == BotState.Travel)
						{
							this.method_33();
						}
						break;
					}
				}
				else if (state != BotState.Collect)
				{
					if (state == BotState.Repair)
					{
						this.method_30();
					}
				}
				else
				{
					this.method_34();
				}
			}
			else if (state <= BotState.Logout)
			{
				if (state != BotState.Hunt)
				{
					if (state == BotState.Logout)
					{
						this.method_31();
					}
				}
				else
				{
					this.method_37();
				}
			}
			else if (state != BotState.PErkava)
			{
				if (state == BotState.TradePalladium)
				{
					this.method_38();
				}
			}
			else
			{
				this.method_36();
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
			this.method_82(Class5.propertyChangedEventArgs_50);
		}
	}

	public void method_60(BotState botState_3)
	{
		this.StateIters = 0;
		if (this.State != botState_3)
		{
			this.Log.Debug<BotState, BotState>("Changing state from {oldState} to {newState}", this.State, botState_3);
			this.LastStates.method_0(this.State);
			this.State = botState_3;
		}
	}

	public void method_61()
	{
		this.StateIters = 0;
		this.ReturnState = this.State;
		if (this.LastStates.Count == 0)
		{
			this.State = this.State;
		}
		else
		{
			this.State = this.LastStates.method_1();
		}
		this.Log.Debug<BotState, BotState>("Reverting state from {oldState} to {newState}", this.ReturnState, this.State);
	}

	public bool wuAiedayWav()
	{
		if (this.IsStopping && this.Behavior.vmethod_12())
		{
			this.method_60(BotState.Logout);
			return true;
		}
		return false;
	}

	Logger ILogManager.Get(string string_4)
	{
		string str = "Base-";
		string str2 = "-";
		AccountSettings account = this.Account;
		return LogManager.GetLogger(str + string_4 + str2 + ((account != null) ? account.BotId : null));
	}

	public Logger uhYieiJtWf2(string string_4)
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
			this.method_82(Class5.propertyChangedEventArgs_36);
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
			this.method_82(Class5.propertyChangedEventArgs_43);
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
			this.method_82(Class5.propertyChangedEventArgs_45);
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
			this.method_82(Class5.propertyChangedEventArgs_44);
		}
	}

	public GEnum6 method_62()
	{
		GEnum6 genum = GEnum6.None;
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

	public NpcShip method_63(int int_11 = 0)
	{
		return this.Map.method_6(this.HeroPosition, new Func<NpcShip, bool>(this.Behavior.vmethod_6), new Func<NpcShip, int>(this.Behavior.vmethod_7), int_11);
	}

	public IEnumerable<NpcShip> method_64()
	{
		return this.Game.Map.All<NpcShip>(this.HeroPosition, new Func<NpcShip, bool>(this.Behavior.vmethod_8), new Func<NpcShip, int>(this.Behavior.vmethod_7), 0);
	}

	public bool method_65()
	{
		if (!this.MapProfile.Hunter)
		{
			return false;
		}
		this.EnemyTarget = this.method_63(0);
		return this.EnemyTarget != null;
	}

	public bool method_66()
	{
		GClass810.<>c__DisplayClass321_0 CS$<>8__locals1 = new GClass810.<>c__DisplayClass321_0();
		CS$<>8__locals1.gclass810_0 = this;
		if (!this.MapProfile.Collector)
		{
			return false;
		}
		CS$<>8__locals1.genum6_0 = this.method_62();
		List<Collectible> list = this.Game.Map.All<Collectible>(this.HeroPosition, new Func<Collectible, bool>(CS$<>8__locals1.method_0), null, 0);
		this.CollectibleTarget = list.FirstOrDefault(new Func<Collectible, bool>(CS$<>8__locals1.method_1));
		foreach (Collectible collectible in list)
		{
			if (!this.Map.Grid.method_7(collectible.Position) && collectible.CollectibleType != (GEnum6)64)
			{
				this.DormantTargets[collectible.Hash] = collectible;
			}
		}
		return this.CollectibleTarget != null;
	}

	public bool method_67()
	{
		if (!this.Behavior.vmethod_11())
		{
			return false;
		}
		if (this.Map.IsGG)
		{
			return true;
		}
		int num = MapUtils.smethod_0(this.MapProfile.TargetMap.GetName(), this.Hero.FactionId);
		return this.Map.MapId != num;
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
			this.method_82(Class5.propertyChangedEventArgs_15);
		}
	}

	public Collectible method_68(Vector2 vector2_2)
	{
		GClass810.<>c__DisplayClass328_0 CS$<>8__locals1 = new GClass810.<>c__DisplayClass328_0();
		CS$<>8__locals1.vector2_0 = vector2_2;
		if (!this.DormantTargets.Any<KeyValuePair<string, Collectible>>())
		{
			return null;
		}
		foreach (KeyValuePair<string, Collectible> keyValuePair in this.DormantTargets)
		{
			if (Vector2.Distance(CS$<>8__locals1.vector2_0, keyValuePair.Value.Position) < 300f || this.Map.Grid.method_7(keyValuePair.Value.Position))
			{
				Collectible collectible;
				this.DormantTargets.TryRemove(keyValuePair.Key, out collectible);
			}
		}
		Collectible collectible2 = this.DormantTargets.Select(new Func<KeyValuePair<string, Collectible>, Collectible>(GClass810.<>c.<>c_0.method_5)).OrderBy(new Func<Collectible, float>(CS$<>8__locals1.method_0)).FirstOrDefault<Collectible>();
		Collectible collectible3;
		if (collectible2 != null && this.DormantTargets.TryRemove(collectible2.Hash, out collectible3))
		{
			return collectible2;
		}
		return null;
	}

	public Gate method_69(Vector2 vector2_2, int int_11)
	{
		return MapUtils.smethod_11(this.Game.Map, this.Game.Map.Hero.Position, int_11);
	}

	public bool method_70(Ship ship_1)
	{
		return ship_1.method_8(this.Hero);
	}

	public void method_71()
	{
		foreach (KeyValuePair<int, Ship> keyValuePair in this.Map.Ships)
		{
			NpcShip npcShip = keyValuePair.Value as NpcShip;
			if (npcShip != null)
			{
				this.method_72(npcShip);
			}
		}
		this.dateTimeOffset_2 = DateTimeOffset.Now;
	}

	public void method_72(NpcShip npcShip_0)
	{
		this.Behavior.vmethod_20(npcShip_0);
	}

	public bool sGnieFuQuDc()
	{
		return MapUtils.smethod_3(this.Map.MapId) == MapUtils.smethod_3((int)this.MapProfile.TargetMap).Replace("X-", string.Format("{0}-", this.Hero.FactionId));
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass810()
	{
		Class8.xDph7tozmh5WD();
		GClass810.resourceType_0 = new ResourceType[]
		{
			ResourceType.PROMETID,
			ResourceType.DURANIUM,
			ResourceType.PROMERIUM
		};
		GClass810.list_0 = new List<string>
		{
			"ability_solace",
			"ability_aegis_repair-pod",
			"ability_aegis_hp-repair"
		};
		GClass810.list_1 = new List<string>
		{
			"ability_venom",
			"ability_diminisher"
		};
		GClass810.list_2 = new List<string>
		{
			"ability_lightning",
			"ability_sentinel",
			"ability_spectrum",
			"ability_mimesis_scramble"
		};
		GClass810.list_3 = new List<ResourceType>
		{
			ResourceType.PROMETIUM,
			ResourceType.ENDURIUM,
			ResourceType.TERBIUM,
			ResourceType.PROMETID,
			ResourceType.DURANIUM,
			ResourceType.PALLADIUM
		};
		GClass810.botState_2 = (BotState.Roam | BotState.Collect | BotState.Hunt | BotState.Dodge);
	}

	[CompilerGenerated]
	private bool method_73(DarkOrbitWebAPI darkOrbitWebAPI_0)
	{
		return darkOrbitWebAPI_0.BuyItem("rocket", this.SelectedHS, 100, -1, "");
	}

	[CompilerGenerated]
	private bool method_74()
	{
		int num = 0;
		foreach (KeyValuePair<int, Ship> keyValuePair in this.Map.Ships)
		{
			if (keyValuePair.Value.IsNpc && Vector2.Distance(this.HeroPosition, keyValuePair.Value.Position) <= 1000f)
			{
				num++;
				bool flag;
				if (!this.Map.method_7(keyValuePair.Value, out flag))
				{
					return false;
				}
			}
		}
		return num > 0;
	}

	[CompilerGenerated]
	private bool method_75(Ship ship_1)
	{
		return ship_1.IsPlayer && ship_1.method_8(this.Hero);
	}

	[CompilerGenerated]
	private bool method_76(NpcShip npcShip_0)
	{
		return Vector2.Distance(this.HeroPosition, npcShip_0.Position) < 1000f;
	}

	[CompilerGenerated]
	private void method_77()
	{
		this.nullable_1 = new Vector2?(this.Game.Security.method_20(this.Map, this.Behavior.vmethod_13()));
	}

	[CompilerGenerated]
	private void method_78()
	{
		this.RoamTarget = Vector2.Zero;
	}

	[CompilerGenerated]
	private void method_79()
	{
		this.method_61();
	}

	[CompilerGenerated]
	private bool method_80(KeyValuePair<int, Ship> keyValuePair_0)
	{
		return this.method_70(keyValuePair_0.Value);
	}

	[CompilerGenerated]
	private void method_81(string string_4)
	{
		GInterface5 proxySocket = this.Game.Connection.ProxySocket;
		if (proxySocket == null)
		{
			return;
		}
		proxySocket.SendMessage(new GClass255(GClass90.Log(string_4)));
	}

	protected void method_82(PropertyChangedEventArgs propertyChangedEventArgs_0)
	{
		PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
		if (propertyChanged != null)
		{
			propertyChanged(this, propertyChangedEventArgs_0);
		}
	}

	[CompilerGenerated]
	private Collectible collectible_0;

	public int int_0;

	public string string_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private int int_1;

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
	private GClass808 gclass808_0;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private DateTime dateTime_0;

	[CompilerGenerated]
	private DateTime dateTime_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private bool KftiXgXeoRK;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private Thread thread_0;

	[CompilerGenerated]
	private ConcurrentQueue<Func<DarkOrbitWebAPI, object>> concurrentQueue_0;

	[CompilerGenerated]
	private Task task_0;

	[CompilerGenerated]
	private Task task_1;

	private volatile bool bool_4;

	private DateTimeOffset dateTimeOffset_1;

	private DateTimeOffset dateTimeOffset_2;

	[CompilerGenerated]
	private Ship ship_0;

	private int int_3;

	private int int_4;

	[CompilerGenerated]
	private DateTime? nullable_0;

	private bool bool_5;

	private bool bool_6;

	private int int_5;

	private DateTimeOffset dateTimeOffset_3;

	private Vector2? nullable_1;

	private int int_6;

	private bool bool_7;

	private Vector2 vector2_0;

	[CompilerGenerated]
	private Vector2? zvmiXjajlWa;

	private Gate gate_0;

	private bool bool_8;

	private PathSequence pathSequence_0;

	private int int_7;

	public float float_0;

	public static List<ResourceType> list_3;

	[CompilerGenerated]
	private Vector2 vector2_1;

	[CompilerGenerated]
	private GClass836 gclass836_0;

	[CompilerGenerated]
	private Task task_2;

	private readonly CooldownTracker<int> cooldownTracker_0;

	private readonly CachedDictionary<int, bool> cachedDictionary_0;

	public int int_8;

	public DateTime dateTime_2;

	public DateTime dateTime_3;

	public DateTimeOffset dateTimeOffset_4;

	public int NnGiXkucSuH;

	[CompilerGenerated]
	private GameManager gameManager_0;

	public readonly object object_0;

	[CompilerGenerated]
	private GClass803 gclass803_0;

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
	private readonly List<GInterface8> list_4;

	[CompilerGenerated]
	private bool bool_9;

	[CompilerGenerated]
	private bool bool_10;

	[CompilerGenerated]
	private bool bool_11;

	public readonly GClass820 gclass820_0;

	public readonly GClass828 gclass828_0;

	public readonly GClass826 gclass826_0;

	public readonly GClass823 gclass823_0;

	[CompilerGenerated]
	private GClass812 gclass812_0;

	[CompilerGenerated]
	private GClass820 gclass820_1;

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

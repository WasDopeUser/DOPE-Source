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
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures.Pathing;

namespace DarkorbitAPI.Structures
{
	public class Map : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public ConcurrentDictionary<int, Ship> Ships
		{
			[CompilerGenerated]
			get
			{
				return this.<Ships>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Ships>k__BackingField, value))
				{
					return;
				}
				this.<Ships>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_102);
			}
		}

		public ConcurrentDictionary<string, Collectible> Collectibles
		{
			[CompilerGenerated]
			get
			{
				return this.<Collectibles>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Collectibles>k__BackingField, value))
				{
					return;
				}
				this.<Collectibles>k__BackingField = value;
				this.method_26(Class5.xCywTyrSaDy);
			}
		}

		public ConcurrentDictionary<int, Gate> Gates
		{
			[CompilerGenerated]
			get
			{
				return this.<Gates>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Gates>k__BackingField, value))
				{
					return;
				}
				this.<Gates>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_26);
			}
		}

		public ConcurrentDictionary<string, ICollidable> Collidables
		{
			[CompilerGenerated]
			get
			{
				return this.<Collidables>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Collidables>k__BackingField, value))
				{
					return;
				}
				this.<Collidables>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_12);
			}
		}

		public ConcurrentDictionary<int, Asset> Assets
		{
			[CompilerGenerated]
			get
			{
				return this.<Assets>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Assets>k__BackingField, value))
				{
					return;
				}
				this.<Assets>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_2);
			}
		}

		public Battlestation Battlestation
		{
			[CompilerGenerated]
			get
			{
				return this.<Battlestation>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Battlestation>k__BackingField, value))
				{
					return;
				}
				this.<Battlestation>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_3);
			}
		}

		public int MapId
		{
			[CompilerGenerated]
			get
			{
				return this.<MapId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<MapId>k__BackingField == value)
				{
					return;
				}
				this.<MapId>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_43);
				this.method_26(Class5.GG);
				this.method_0();
				this.method_26(Class5.MapId);
			}
		}

		public GameManager Game
		{
			[CompilerGenerated]
			get
			{
				return this.<Game>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Game>k__BackingField, value))
				{
					return;
				}
				this.<Game>k__BackingField = value;
				this.method_26(Class5.Hero);
				this.method_26(Class5.Game);
			}
		}

		public Hero Hero
		{
			get
			{
				return this.Game.Hero;
			}
		}

		public Ship SelectedShip
		{
			[CompilerGenerated]
			get
			{
				return this.<SelectedShip>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<SelectedShip>k__BackingField, value))
				{
					return;
				}
				this.<SelectedShip>k__BackingField = value;
				this.method_26(Class5.SelectedShip);
			}
		}

		public string MapName
		{
			[CompilerGenerated]
			get
			{
				return this.<MapName>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<MapName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<MapName>k__BackingField = value;
				this.method_26(Class5.MapName);
			}
		}

		public DarkorbitAPI.CommonStructures.Size MapSize
		{
			[CompilerGenerated]
			get
			{
				return this.<MapSize>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<MapSize>k__BackingField == value)
				{
					return;
				}
				this.<MapSize>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_71);
			}
		}

		public Vector2 Center
		{
			[CompilerGenerated]
			get
			{
				return this.<Center>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<Center>k__BackingField == value)
				{
					return;
				}
				this.<Center>k__BackingField = value;
				this.method_26(Class5.Center);
			}
		}

		public Vector2 RightCorner
		{
			[CompilerGenerated]
			get
			{
				return this.<RightCorner>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<RightCorner>k__BackingField == value)
				{
					return;
				}
				this.<RightCorner>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_94);
			}
		}

		public Rectangle Rect
		{
			[CompilerGenerated]
			get
			{
				return this.<Rect>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<Rect>k__BackingField == value)
				{
					return;
				}
				this.<Rect>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_84);
			}
		}

		public List<Rectangle> DefaultWorkArea
		{
			[CompilerGenerated]
			get
			{
				return this.<DefaultWorkArea>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<DefaultWorkArea>k__BackingField, value))
				{
					return;
				}
				this.<DefaultWorkArea>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_14);
			}
		}

		public bool IsGG
		{
			get
			{
				return MapUtils.smethod_6(this.MapId);
			}
		}

		public GEnum5 GG
		{
			get
			{
				return MapUtils.smethod_10(this.MapId);
			}
		}

		public List<NpcUtils.NpcType> NpcTypes
		{
			[CompilerGenerated]
			get
			{
				return this.<NpcTypes>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<NpcTypes>k__BackingField, value))
				{
					return;
				}
				this.<NpcTypes>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_76);
			}
		}

		public bool IsX1
		{
			[CompilerGenerated]
			get
			{
				return this.<IsX1>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (this.<IsX1>k__BackingField == value)
				{
					return;
				}
				this.<IsX1>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_48);
			}
		}

		public void method_0()
		{
			this.IsX1 = MapUtils.IsX1(this);
			this.NpcTypes = NpcUtils.smethod_0(this.MapId);
			this.MapName = MapUtils.smethod_4(this.MapId);
			this.MapSize = MapUtils.smethod_1(this.MapId);
			this.Center = new Vector2((float)(this.MapSize.Width / 2), (float)(this.MapSize.Height / 2));
			this.RightCorner = new Vector2((float)this.MapSize.Width, (float)this.MapSize.Height);
			this.Rect = new Rectangle(0, 0, this.MapSize.Width, this.MapSize.Height);
			this.DefaultWorkArea = new List<Rectangle>
			{
				this.Rect
			};
			MapGrid grid = this.Grid;
			if (grid == null)
			{
				return;
			}
			grid.method_12();
		}

		public IEnumerable<string> method_1()
		{
			GEnum5 genum = MapUtils.smethod_10(this.MapId);
			if (genum != GEnum5.None)
			{
				int all = 0;
				int done = 0;
				foreach (KeyValuePair<int, Ship> keyValuePair in this.Ships)
				{
					Ship value = keyValuePair.Value;
					if (value.IsNpc)
					{
						int num = all;
						all = num + 1;
						bool flag;
						if (value.HpPercentage < 25f || this.mdGbaKqNuQ(value, out flag))
						{
							num = done;
							done = num + 1;
						}
					}
				}
				DarkOrbitWebAPI.GalaxyGatesInfo ggInfo = this.Game.Web.GgInfo;
				DarkOrbitWebAPI.jumpgateGate jumpgateGate = (ggInfo != null) ? ggInfo.GetGate(genum) : null;
				string text = string.Format("Wave {0}/{1}", (jumpgateGate != null) ? new int?(jumpgateGate.currentWave) : null, (jumpgateGate != null) ? new int?(jumpgateGate.totalWave) : null);
				if (jumpgateGate != null)
				{
					yield return text;
				}
				yield return string.Format("{0}/{1}", done, all);
			}
			yield break;
		}

		public MapGrid Grid
		{
			[CompilerGenerated]
			get
			{
				return this.<Grid>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Grid>k__BackingField, value))
				{
					return;
				}
				this.<Grid>k__BackingField = value;
				this.method_26(Class5.propertyChangedEventArgs_28);
			}
		}

		public bool method_2(Vector2 vector2_0, int int_0)
		{
			return vector2_0.X < (float)int_0 || vector2_0.Y < (float)int_0 || vector2_0.X > (float)(this.MapSize.Width - int_0) || vector2_0.Y > (float)(this.MapSize.Height - int_0);
		}

		public float method_3(Vector2 vector2_0)
		{
			return Math.Min(Math.Min(Math.Abs(vector2_0.X), Math.Abs(vector2_0.Y)), Math.Min(Math.Abs(vector2_0.X - (float)this.MapSize.Width), Math.Abs(vector2_0.Y - (float)this.MapSize.Height)));
		}

		public Ship method_4(int int_0)
		{
			if (this.Hero.Id == int_0)
			{
				return this.Hero;
			}
			Ship result;
			if (this.Ships.TryGetValue(int_0, out result))
			{
				return result;
			}
			return null;
		}

		public t1Ee312RA6Nl7yiWXeI method_5<t1Ee312RA6Nl7yiWXeI>(Vector2 vector2_0, Func<t1Ee312RA6Nl7yiWXeI, bool> func_0 = null, Func<t1Ee312RA6Nl7yiWXeI, int> func_1 = null, int int_0 = 0) where t1Ee312RA6Nl7yiWXeI : Entity
		{
			return this.All<t1Ee312RA6Nl7yiWXeI>(vector2_0, func_0, func_1, int_0).FirstOrDefault<t1Ee312RA6Nl7yiWXeI>();
		}

		public NpcShip method_6(Vector2 vector2_0, Func<NpcShip, bool> func_0 = null, Func<NpcShip, int> func_1 = null, int int_0 = 0)
		{
			Map.<>c__DisplayClass87_0 CS$<>8__locals1 = new Map.<>c__DisplayClass87_0();
			CS$<>8__locals1.priority = func_1;
			CS$<>8__locals1.origin = vector2_0;
			CS$<>8__locals1.now = DateTimeOffset.Now;
			List<NpcShip> list = this.All<NpcShip>(CS$<>8__locals1.origin, func_0, CS$<>8__locals1.priority, int_0).ToList<NpcShip>();
			bool isGG = this.IsGG;
			CS$<>8__locals1.dpsByType = new Dictionary<NpcUtils.NpcType, double>();
			foreach (NpcShip npcShip in list)
			{
				if (npcShip.Type != null)
				{
					if (!CS$<>8__locals1.dpsByType.ContainsKey(npcShip.Type))
					{
						CS$<>8__locals1.dpsByType[npcShip.Type] = 0.0;
					}
					int num = (int)(CS$<>8__locals1.now - npcShip.LastAttackedHero).TotalMilliseconds;
					Dictionary<NpcUtils.NpcType, double> dpsByType = CS$<>8__locals1.dpsByType;
					NpcUtils.NpcType type = npcShip.Type;
					dpsByType[type] += (double)((float)npcShip.LastAttackedHeroDamage / (float)(num / 1000 + 1));
				}
			}
			var source = list.Select(new Func<NpcShip, <>f__AnonymousType2<NpcShip, float, int, int, double>>(CS$<>8__locals1.method_0));
			if (!isGG)
			{
				var <>f__AnonymousType = source.Where(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, bool>(Map.<>c.<>9.method_0)).OrderBy(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_1)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_2)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_3)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, double>(Map.<>c.<>9.method_4)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, float>(Map.<>c.<>9.method_5)).FirstOrDefault();
				if (<>f__AnonymousType == null)
				{
					return null;
				}
				return <>f__AnonymousType.t;
			}
			else
			{
				var <>f__AnonymousType2 = source.OrderByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_6)).ThenBy(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_7)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, double>(Map.<>c.<>9.method_8)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_9)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, float>(Map.<>c.<>9.method_10)).FirstOrDefault();
				if (<>f__AnonymousType2 == null)
				{
					return null;
				}
				return <>f__AnonymousType2.t;
			}
		}

		[return: TupleElementNames(new string[]
		{
			"obj",
			"dist",
			"priority"
		})]
		public IEnumerable<ValueTuple<h79Yt72SMEwRHBqxqkG, float, int>> method_7<h79Yt72SMEwRHBqxqkG>(Vector2 vector2_0, Func<h79Yt72SMEwRHBqxqkG, bool> func_0 = null, Func<h79Yt72SMEwRHBqxqkG, int> func_1 = null, int int_0 = 0) where h79Yt72SMEwRHBqxqkG : Entity
		{
			Map.<EnumAll>d__88<h79Yt72SMEwRHBqxqkG> <EnumAll>d__ = new Map.<EnumAll>d__88<h79Yt72SMEwRHBqxqkG>(-2);
			<EnumAll>d__.<>4__this = this;
			<EnumAll>d__.<>3__origin = vector2_0;
			<EnumAll>d__.<>3__selector = func_0;
			<EnumAll>d__.<>3__priority = func_1;
			<EnumAll>d__.<>3__predictionMs = int_0;
			return <EnumAll>d__;
		}

		public IEnumerable<T> All<T>(Vector2 origin, Func<T, bool> selector = null, Func<T, int> priority = null, int predictionMs = 0) where T : Entity
		{
			return this.method_7<T>(origin, selector, priority, predictionMs).OrderByDescending(new Func<ValueTuple<T, float, int>, int>(Map.<>c__89<T>.<>9.method_0)).ThenBy(new Func<ValueTuple<T, float, int>, float>(Map.<>c__89<T>.<>9.method_1)).Select(new Func<ValueTuple<T, float, int>, T>(Map.<>c__89<T>.<>9.method_2));
		}

		public static ObjectPool<MapNavigator> Navigators { get; private set; }

		static Map()
		{
			Class13.xnk8ImWzpOt04();
			Map.Navigators = new ObjectPool<MapNavigator>("MapNavigator");
			for (int i = 0; i < 2; i++)
			{
				Map.<Navigators>k__BackingField.method_2(new MapNavigator());
			}
		}

		public Map(GameManager gameManager_0)
		{
			Class13.xnk8ImWzpOt04();
			this.<Ships>k__BackingField = new ConcurrentDictionary<int, Ship>();
			this.<Collectibles>k__BackingField = new ConcurrentDictionary<string, Collectible>();
			this.<Gates>k__BackingField = new ConcurrentDictionary<int, Gate>();
			this.<Collidables>k__BackingField = new ConcurrentDictionary<string, ICollidable>();
			this.<Assets>k__BackingField = new ConcurrentDictionary<int, Asset>();
			base..ctor();
			this.Game = gameManager_0;
			this.Grid = new MapGrid(this);
			this.method_0();
		}

		public void Clear()
		{
			this.Battlestation = null;
			this.Assets.Clear();
			foreach (KeyValuePair<int, Ship> keyValuePair in this.Ships)
			{
				Map.Delegates.ShipRemovedHandler shipDestroyed = this.ShipDestroyed;
				if (shipDestroyed != null)
				{
					shipDestroyed(this, keyValuePair.Value, false);
				}
			}
			this.Ships.Clear();
			foreach (KeyValuePair<string, Collectible> keyValuePair2 in this.Collectibles)
			{
			}
			this.Collectibles.Clear();
			this.Collidables.Clear();
			this.Grid.method_12();
			foreach (KeyValuePair<int, Gate> keyValuePair3 in this.Gates)
			{
			}
			this.Gates.Clear();
			this.SelectedShip = null;
			this.MapId = 0;
		}

		public bool mdGbaKqNuQ(Ship ship_0, out bool bool_0)
		{
			bool_0 = false;
			if (!this.IsGG)
			{
				return false;
			}
			DarkorbitAPI.CommonStructures.Size mapSize = this.MapSize;
			Vector2 position = ship_0.Position;
			bool_0 = this.Game.Security.method_3(Vector2.Zero, position, 0);
			return this.Game.Security.method_3(mapSize.Vector, position, 0) | bool_0;
		}

		internal void method_8(GClass180 gclass180_0)
		{
			Collectible collectible_ = new Collectible(gclass180_0.int_1, gclass180_0.int_0, gclass180_0.string_1, gclass180_0.string_0);
			if (MapUtils.smethod_2(this.MapId) == MapGroup.PayloadEscort)
			{
				this.Game.LogManager.Get("Net-Handlers").Info("Spawned box of type {type}", gclass180_0.string_1);
			}
			this.method_10(collectible_);
		}

		internal void method_9(GClass181 gclass181_0)
		{
			Resource collectible_ = new Resource(gclass181_0.int_1, gclass181_0.int_0, gclass181_0.gclass259_0.int_0, gclass181_0.string_0);
			this.method_10(collectible_);
		}

		internal void method_10(Collectible collectible_0)
		{
			if (this.Game.Security.method_7(collectible_0, true) && this.Collectibles.TryAdd(collectible_0.Hash, collectible_0))
			{
				Map.Delegates.CollectibleCreatedHandler collectibleCreated = this.CollectibleCreated;
				if (collectibleCreated == null)
				{
					return;
				}
				collectibleCreated(this, collectible_0);
			}
		}

		internal void method_11(HjlsnuKxjUgfkCoFhrD hjlsnuKxjUgfkCoFhrD_0)
		{
			Collectible collectible;
			this.Collectibles.TryRemove(hjlsnuKxjUgfkCoFhrD_0.string_0, out collectible);
			Map.Delegates.CollectibleCollected collectibleCollected = this.CollectibleCollected;
			if (collectibleCollected == null)
			{
				return;
			}
			collectibleCollected(this, hjlsnuKxjUgfkCoFhrD_0.string_0, collectible, hjlsnuKxjUgfkCoFhrD_0.bool_0);
		}

		internal void method_12(GClass190 gclass190_0)
		{
			int int_ = gclass190_0.vector_0.FirstOrDefault<int>();
			Gate gate = new Gate(gclass190_0.int_2, gclass190_0.int_3, int_, gclass190_0.Id, gclass190_0.int_1);
			if (this.Gates.TryAdd(gate.Id, gate))
			{
				Map.Delegates.GateCreatedHandler gateCreated = this.GateCreated;
				if (gateCreated == null)
				{
					return;
				}
				gateCreated(this, gate);
			}
		}

		internal void ypabzsOej5(GClass263 gclass263_0)
		{
			Ship ship = gclass263_0.bool_2 ? new NpcShip() : new Ship();
			ship.Init(gclass263_0);
			if (this.Ships.TryAdd(ship.Id, ship))
			{
				Map.Delegates.ShipUpdateHandler shipCreated = this.ShipCreated;
				if (shipCreated == null)
				{
					return;
				}
				shipCreated(this, ship);
			}
		}

		internal void method_13(int int_0, bool bool_0)
		{
			Ship ship;
			if (this.Ships.TryRemove(int_0, out ship))
			{
				if (ship == this.SelectedShip)
				{
					this.SelectedShip = null;
				}
				Map.Delegates.ShipRemovedHandler shipDestroyed = this.ShipDestroyed;
				if (shipDestroyed != null)
				{
					shipDestroyed(this, ship, bool_0);
				}
				HeroPet heroPet = ship as HeroPet;
				if (heroPet != null)
				{
					heroPet.IsEnabled = false;
				}
			}
		}

		internal void method_14(GClass267 gclass267_0)
		{
			DateTime now = DateTime.Now;
			Ship ship = this.method_4(gclass267_0.int_0);
			if (ship != null)
			{
				ship.Shield = gclass267_0.int_2;
				ship.ShieldMax = gclass267_0.int_3;
				ship.Hp = gclass267_0.int_4;
				ship.HpMax = gclass267_0.int_5;
				ship.LastStatUpdate = now;
				this.SelectedShip = ship;
				Map.Delegates.ShipUpdateHandler shipSelected = this.ShipSelected;
				if (shipSelected == null)
				{
					return;
				}
				shipSelected(this, ship);
			}
		}

		internal void method_15(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
		{
			DateTimeOffset now = DateTimeOffset.Now;
			Ship ship = this.method_4(int_0);
			if (ship != null)
			{
				ship.Hp = int_4;
				ship.Shield = int_5;
				ship.LastTookDamage = now;
				ship.LastTookDamageFrom = int_1;
				if (!(ship is NpcShip))
				{
				}
				if (int_1 == this.Hero.Id)
				{
					ship.LastTookDamageHero = now;
				}
			}
			Ship ship2 = this.method_4(int_1);
			if (ship2 != null)
			{
				ship2.LastAttacked = now;
				if (int_0 == this.Hero.Id)
				{
					ship2.LastAttackedHero = now;
					ship2.LastAttackedHeroDamage = int_2;
				}
			}
			if (ship2 != null && ship != null && !ship2.IsNpc)
			{
				ship.LastTookDamageEnemy = now;
			}
			Map.Delegates.ShipAttackHandler shipAttacked = this.ShipAttacked;
			if (shipAttacked != null)
			{
				shipAttacked(this, ship2, ship, int_2, int_3);
			}
			if (ship != null)
			{
				ship.method_9(this, ship2, ship, int_2, int_3);
			}
		}

		internal void method_16(GClass262 gclass262_0)
		{
			this.method_15(gclass262_0.int_1, gclass262_0.int_0, gclass262_0.int_5, gclass262_0.gclass132_0.int_0, gclass262_0.int_2, gclass262_0.int_3);
		}

		internal void method_17(GClass178 gclass178_0)
		{
			Ship ship = this.method_4(gclass178_0.int_0);
			if (ship != null)
			{
				ship.HpMax = gclass178_0.int_2;
				ship.ShieldMax = gclass178_0.int_3;
			}
			this.method_15(gclass178_0.int_0, gclass178_0.int_4, gclass178_0.int_8, gclass178_0.gclass132_0.int_0, gclass178_0.int_6, gclass178_0.int_7);
		}

		internal void method_18(GClass186 gclass186_0)
		{
			Ship ship = this.method_4(gclass186_0.zgNxkCynsb);
			if (ship == null)
			{
				return;
			}
			ship.ApplyModifier(gclass186_0);
		}

		internal void method_19(GClass220 gclass220_0)
		{
			this.Hero.Pet.method_13(gclass220_0);
			this.Ships[gclass220_0.int_1] = this.Hero.Pet;
		}

		internal void method_20(GClass253 gclass253_0)
		{
			Pet pet = this.method_4(gclass253_0.int_1) as Pet;
			if (pet == null)
			{
				pet = new Pet();
				pet.method_11(gclass253_0);
				if (this.Ships.TryAdd(gclass253_0.int_1, pet))
				{
					Map.Delegates.ShipUpdateHandler shipCreated = this.ShipCreated;
					if (shipCreated == null)
					{
						return;
					}
					shipCreated(this, pet);
					return;
				}
			}
			else
			{
				pet.method_11(gclass253_0);
			}
		}

		internal void method_21(GClass243 gclass243_0)
		{
			ICollidable collidable = null;
			ICollidable collidable2 = null;
			ICollidable collidable3;
			if (this.Collidables.TryGetValue(gclass243_0.Name, out collidable3))
			{
				collidable3.Active = gclass243_0.bool_1;
				collidable = collidable3;
			}
			if (gclass243_0.Name == "Cage Zone" && this.MapId == 229)
			{
				return;
			}
			CollidableType int_ = (CollidableType)gclass243_0.gclass140_0.int_0;
			if (gclass243_0.int_0 == 2 && (int_ == CollidableType.Wall || int_ == CollidableType.Mines))
			{
				int num = Map.smethod_1(gclass243_0.vector_0[0U], gclass243_0.vector_0[2U], gclass243_0.vector_0[4U]);
				int num2 = Map.smethod_2(gclass243_0.vector_0[0U], gclass243_0.vector_0[2U], gclass243_0.vector_0[4U]);
				int num3 = Map.smethod_1(gclass243_0.vector_0[1U], gclass243_0.vector_0[3U], gclass243_0.vector_0[5U]);
				int num4 = Map.smethod_2(gclass243_0.vector_0[1U], gclass243_0.vector_0[3U], gclass243_0.vector_0[5U]);
				if (this.MapId == 93 && int_ == CollidableType.Mines)
				{
					num4 = this.MapSize.Height - 500;
				}
				collidable2 = new CollidableRect(gclass243_0.Name, gclass243_0.bool_1, num, num3, num2 - num, num4 - num3, int_);
			}
			else if (gclass243_0.int_0 == 0)
			{
				collidable2 = new CollidableSphere(int_, gclass243_0.Name, new Vector2((float)gclass243_0.vector_0[0U], (float)gclass243_0.vector_0[1U]), gclass243_0.vector_0[2U]);
			}
			if (collidable2 != null)
			{
				if (collidable != null)
				{
					this.Grid.method_10(collidable);
				}
				this.Collidables[gclass243_0.Name] = (Collidable)collidable2;
				this.Grid.method_11(collidable2);
			}
		}

		internal void method_22(GClass245 gclass245_0)
		{
			ICollidable icollidable_;
			if (this.Collidables.TryRemove(gclass245_0.Name, out icollidable_))
			{
				this.Grid.method_10(icollidable_);
			}
		}

		internal void method_23(GClass265 gclass265_0)
		{
			Ship ship;
			if (this.Ships.TryGetValue(gclass265_0.int_0, out ship))
			{
				ship.method_1(gclass265_0.int_1, gclass265_0.int_2, gclass265_0.int_3);
				Map.Delegates.ShipMoveStartedHandler shipMoveStarted = this.ShipMoveStarted;
				if (shipMoveStarted == null)
				{
					return;
				}
				shipMoveStarted(this, ship, gclass265_0);
			}
		}

		internal void method_24(GClass237 gclass237_0)
		{
			DateTimeOffset now = DateTimeOffset.Now;
			Ship ship = this.method_4(gclass237_0.int_1);
			if (ship != null)
			{
				ship.LastTookDamageFrom = gclass237_0.int_0;
				ship.LastTookDamage = DateTimeOffset.Now;
			}
			Ship ship2 = this.method_4(gclass237_0.int_0);
			if (ship2 != null)
			{
				ship2.LastAttacked = now;
				ship2.TargetId = gclass237_0.int_1;
			}
		}

		internal void method_25(GClass246 gclass246_0)
		{
		}

		public event Map.Delegates.CollectibleCreatedHandler CollectibleCreated;

		public event Map.Delegates.GateCreatedHandler GateCreated;

		public event Map.Delegates.ShipUpdateHandler ShipCreated;

		public event Map.Delegates.ShipRemovedHandler ShipDestroyed;

		public event Map.Delegates.ShipUpdateHandler ShipSelected;

		public event Map.Delegates.ShipAttackHandler ShipAttacked;

		public event Map.Delegates.ShipMoveStartedHandler ShipMoveStarted;

		public event Map.Delegates.CollectibleCollected CollectibleCollected;

		[CompilerGenerated]
		internal static ValueTuple<jVL1aX2XHAmEo3RcMkZ, float, int> smethod_0<jVL1aX2XHAmEo3RcMkZ>(Entity entity_0, ref Map.<>c__DisplayClass88_0<jVL1aX2XHAmEo3RcMkZ> <>c__DisplayClass88_0_0) where jVL1aX2XHAmEo3RcMkZ : Entity
		{
			Vector2 value = entity_0.Position;
			if (<>c__DisplayClass88_0_0.predictionMs > 0)
			{
				MovingEntity movingEntity = entity_0 as MovingEntity;
				if (movingEntity != null)
				{
					value = movingEntity.method_0(<>c__DisplayClass88_0_0.predictionMs);
				}
			}
			float num = Vector2.Distance(<>c__DisplayClass88_0_0.origin, value);
			int num2 = 0;
			if (<>c__DisplayClass88_0_0.priority != null)
			{
				num2 = <>c__DisplayClass88_0_0.priority(entity_0 as jVL1aX2XHAmEo3RcMkZ);
			}
			return new ValueTuple<jVL1aX2XHAmEo3RcMkZ, float, int>((jVL1aX2XHAmEo3RcMkZ)((object)entity_0), num, num2);
		}

		[CompilerGenerated]
		internal static int smethod_1(int int_0, int int_1, int int_2)
		{
			return Math.Min(int_0, Math.Min(int_1, int_2));
		}

		[CompilerGenerated]
		internal static int smethod_2(int int_0, int int_1, int int_2)
		{
			return Math.Max(int_0, Math.Max(int_1, int_2));
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
		protected void method_26(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}

		public sealed class Delegates
		{
			public Delegates()
			{
				Class13.xnk8ImWzpOt04();
				base..ctor();
			}

			public delegate void CollectibleCreatedHandler(Map map, Collectible collectible);

			public delegate void GateCreatedHandler(Map map, Gate gate);

			public delegate void ShipUpdateHandler(Map map, Ship ship);

			public delegate void ShipRemovedHandler(Map map, Ship ship, bool wasDestroyed);

			public delegate void ShipMoveStartedHandler(Map map, Ship ship, GClass265 move);

			public delegate void ShipAttackHandler(Map map, Ship attacker, Ship target, int damage, int attackType);

			public delegate void CollectibleCollected(Map map, string hash, Collectible collectible, bool byHero);
		}
	}
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
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
				this.method_22(Class1.propertyChangedEventArgs_83);
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
				this.method_22(Class1.propertyChangedEventArgs_9);
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
				this.method_22(Class1.defiuMuwZcp);
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
				this.method_22(Class1.propertyChangedEventArgs_10);
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
				this.method_22(Class1.propertyChangedEventArgs_2);
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
				this.method_22(Class1.propertyChangedEventArgs_3);
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
				this.method_22(Class1.propertyChangedEventArgs_33);
				this.method_22(Class1.GG);
				this.method_0();
				this.method_22(Class1.propertyChangedEventArgs_57);
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
				this.method_22(Class1.Hero);
				this.method_22(Class1.Game);
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
				this.method_22(Class1.SelectedShip);
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
				this.method_22(Class1.MapName);
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
				this.method_22(Class1.propertyChangedEventArgs_58);
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
				this.method_22(Class1.Center);
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
				this.method_22(Class1.propertyChangedEventArgs_77);
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
				this.method_22(Class1.propertyChangedEventArgs_67);
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
				this.method_22(Class1.propertyChangedEventArgs_12);
			}
		}

		public bool IsGG
		{
			get
			{
				return MapUtils.IsGG(this.MapId);
			}
		}

		public GEnum5 GG
		{
			get
			{
				return MapUtils.smethod_6(this.MapId);
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
				this.method_22(Class1.propertyChangedEventArgs_61);
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
				this.method_22(Class1.propertyChangedEventArgs_39);
			}
		}

		public void method_0()
		{
			this.IsX1 = MapUtils.IsX1(this);
			this.NpcTypes = NpcUtils.smethod_0(this.MapId);
			this.MapName = MapUtils.smethod_3(this.MapId);
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

		public string method_1()
		{
			GEnum5 genum = MapUtils.smethod_6(this.MapId);
			GClass243 gclass;
			bool flag = this.Hero.Pet.Modes.TryGetValue(PetMode.Kamikaze, out gclass);
			string.Format("PET {0},{1},{2:0.00}\r\nKamikaze: {3},{4},{5}", new object[]
			{
				this.Hero.Pet.IsEnabled,
				this.Hero.Pet.IsControlDisabled,
				this.Hero.Pet.HpPercentage,
				flag,
				gclass != null && gclass.Enabled,
				(gclass != null) ? gclass.int_1 : -1
			});
			if (genum == GEnum5.None)
			{
				return null;
			}
			int num = 0;
			int num2 = 0;
			foreach (KeyValuePair<int, Ship> keyValuePair in this.Ships)
			{
				Ship value = keyValuePair.Value;
				if (value.IsNpc)
				{
					num++;
					bool flag2;
					if (value.HpPercentage < 25f || this.method_7(value, out flag2))
					{
						num2++;
					}
				}
			}
			DarkOrbitWebAPI.GalaxyGatesInfo ggInfo = this.Game.Web.GgInfo;
			DarkOrbitWebAPI.jumpgateGate jumpgateGate = (ggInfo != null) ? ggInfo.GetGate(genum) : null;
			string arg = string.Format("Wave {0}/{1}", (jumpgateGate != null) ? new int?(jumpgateGate.currentWave) : null, (jumpgateGate != null) ? new int?(jumpgateGate.totalWave) : null);
			return string.Format("{0}\r\n{1}/{2}", arg, num2, num);
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
				this.method_22(Class1.propertyChangedEventArgs_21);
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

		public o8VuoCJmH0aFNV1gpSu method_5<o8VuoCJmH0aFNV1gpSu>(Vector2 vector2_0, Func<o8VuoCJmH0aFNV1gpSu, bool> func_0 = null, Func<o8VuoCJmH0aFNV1gpSu, int> func_1 = null, int int_0 = 0) where o8VuoCJmH0aFNV1gpSu : Entity
		{
			return this.All<o8VuoCJmH0aFNV1gpSu>(vector2_0, func_0, func_1, int_0).FirstOrDefault<o8VuoCJmH0aFNV1gpSu>();
		}

		public NpcShip method_6(Vector2 vector2_0, Func<NpcShip, bool> func_0 = null, Func<NpcShip, int> func_1 = null, int int_0 = 0)
		{
			Map.<>c__DisplayClass87_0 CS$<>8__locals1 = new Map.<>c__DisplayClass87_0();
			CS$<>8__locals1.priority = func_1;
			CS$<>8__locals1.origin = vector2_0;
			CS$<>8__locals1.now = DateTimeOffset.Now;
			IEnumerable<NpcShip> source = this.All<NpcShip>(CS$<>8__locals1.origin, func_0, CS$<>8__locals1.priority, int_0);
			bool isGG = this.IsGG;
			var source2 = source.Select(new Func<NpcShip, <>f__AnonymousType2<NpcShip, float, int, int, double>>(CS$<>8__locals1.method_0));
			if (!isGG)
			{
				var <>f__AnonymousType = source2.Where(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, bool>(Map.<>c.<>9.method_0)).OrderBy(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_1)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_2)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_3)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, double>(Map.<>c.<>9.method_4)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, float>(Map.<>c.<>9.method_5)).FirstOrDefault();
				if (<>f__AnonymousType == null)
				{
					return null;
				}
				return <>f__AnonymousType.t;
			}
			else
			{
				var <>f__AnonymousType2 = source2.OrderByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_6)).ThenBy(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_7)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, double>(Map.<>c.<>9.method_8)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, int>(Map.<>c.<>9.method_9)).ThenByDescending(new Func<<>f__AnonymousType2<NpcShip, float, int, int, double>, float>(Map.<>c.<>9.method_10)).FirstOrDefault();
				if (<>f__AnonymousType2 == null)
				{
					return null;
				}
				return <>f__AnonymousType2.t;
			}
		}

		public List<T> All<T>(Vector2 origin, Func<T, bool> selector = null, Func<T, int> priority = null, int predictionMs = 0) where T : Entity
		{
			Map.<>c__DisplayClass88_0<T> CS$<>8__locals1;
			CS$<>8__locals1.predictionMs = predictionMs;
			CS$<>8__locals1.origin = origin;
			CS$<>8__locals1.priority = priority;
			CS$<>8__locals1.res = new List<ValueTuple<T, float, int>>();
			if (typeof(Ship).IsAssignableFrom(typeof(T)))
			{
				foreach (KeyValuePair<int, Ship> keyValuePair in this.Ships)
				{
					Ship value = keyValuePair.Value;
					T t = value as T;
					if (t != null && (selector == null || selector(t)))
					{
						Map.smethod_0<T>(value, ref CS$<>8__locals1);
					}
				}
			}
			if (typeof(Collectible).IsAssignableFrom(typeof(T)))
			{
				foreach (KeyValuePair<string, Collectible> keyValuePair2 in this.Collectibles)
				{
					Collectible value2 = keyValuePair2.Value;
					T arg = value2 as T;
					if (selector == null || selector(arg))
					{
						Map.smethod_0<T>(value2, ref CS$<>8__locals1);
					}
				}
			}
			if (typeof(Gate).IsAssignableFrom(typeof(T)))
			{
				foreach (KeyValuePair<int, Gate> keyValuePair3 in this.Gates)
				{
					Gate value3 = keyValuePair3.Value;
					T arg2 = value3 as T;
					if (selector == null || selector(arg2))
					{
						Map.smethod_0<T>(value3, ref CS$<>8__locals1);
					}
				}
			}
			return CS$<>8__locals1.res.OrderByDescending(new Func<ValueTuple<T, float, int>, int>(Map.<>c__88<T>.<>9.method_0)).ThenBy(new Func<ValueTuple<T, float, int>, float>(Map.<>c__88<T>.<>9.FxavmAdcax)).Select(new Func<ValueTuple<T, float, int>, T>(Map.<>c__88<T>.<>9.method_1)).ToList<T>();
		}

		public static ObjectPool<MapNavigator> Navigators { get; private set; }

		static Map()
		{
			Class8.xDph7tozmh5WD();
			Map.Navigators = new ObjectPool<MapNavigator>("MapNavigator");
			for (int i = 0; i < 2; i++)
			{
				Map.<Navigators>k__BackingField.method_3(new MapNavigator());
			}
		}

		public Map(GameManager gameManager_0)
		{
			Class8.xDph7tozmh5WD();
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
				Map.Delegates.ShipUpdateHandler shipDestroyed = this.ShipDestroyed;
				if (shipDestroyed != null)
				{
					shipDestroyed(this, keyValuePair.Value);
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

		public bool method_7(Ship ship_0, out bool bool_0)
		{
			bool_0 = false;
			if (!this.IsGG)
			{
				return false;
			}
			DarkorbitAPI.CommonStructures.Size mapSize = this.MapSize;
			Vector2 position = ship_0.Position;
			bool_0 = this.Game.Security.method_18(Vector2.Zero, position, 0);
			return this.Game.Security.method_18(mapSize.Vector, position, 0) | bool_0;
		}

		internal void method_8(GClass173 gclass173_0)
		{
			Collectible collectible_ = new Collectible(gclass173_0.int_1, gclass173_0.int_0, gclass173_0.string_1, gclass173_0.string_0);
			this.method_10(collectible_);
		}

		internal void method_9(GClass174 gclass174_0)
		{
			Resource collectible_ = new Resource(gclass174_0.int_1, gclass174_0.int_0, gclass174_0.gclass247_0.uint_0, gclass174_0.string_0);
			this.method_10(collectible_);
		}

		internal void method_10(Collectible collectible_0)
		{
			if (this.Game.Security.method_21(collectible_0, true) && this.Collectibles.TryAdd(collectible_0.Hash, collectible_0))
			{
				Map.Delegates.CollectibleCreatedHandler collectibleCreated = this.CollectibleCreated;
				if (collectibleCreated == null)
				{
					return;
				}
				collectibleCreated(this, collectible_0);
			}
		}

		internal void method_11(GClass136 gclass136_0)
		{
			Collectible collectible;
			this.Collectibles.TryRemove(gclass136_0.string_0, out collectible);
			Map.Delegates.CollectibleCollected collectibleCollected = this.CollectibleCollected;
			if (collectibleCollected == null)
			{
				return;
			}
			collectibleCollected(this, gclass136_0.string_0, collectible, gclass136_0.bool_0);
		}

		internal void method_12(GClass181 gclass181_0)
		{
			int int_ = gclass181_0.vector_0.FirstOrDefault<int>();
			Gate gate = new Gate(gclass181_0.int_1, gclass181_0.int_0, int_, gclass181_0.Id, gclass181_0.int_3);
			if (this.Gates.TryAdd(gate.Id, gate))
			{
				Map.Delegates.GateCreatedHander gateCreated = this.GateCreated;
				if (gateCreated == null)
				{
					return;
				}
				gateCreated(this, gate);
			}
		}

		internal void method_13(GClass251 gclass251_0)
		{
			Ship ship = gclass251_0.bool_1 ? new NpcShip() : new Ship();
			ship.Init(gclass251_0);
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

		internal void method_14(GClass252 gclass252_0)
		{
			Ship ship;
			if (this.Ships.TryRemove(gclass252_0.int_0, out ship))
			{
				if (ship == this.SelectedShip)
				{
					this.SelectedShip = null;
				}
				Map.Delegates.ShipUpdateHandler shipDestroyed = this.ShipDestroyed;
				if (shipDestroyed != null)
				{
					shipDestroyed(this, ship);
				}
				HeroPet heroPet = ship as HeroPet;
				if (heroPet != null)
				{
					heroPet.IsEnabled = false;
				}
			}
		}

		internal void method_15(GClass254 gclass254_0)
		{
			DateTime now = DateTime.Now;
			Ship ship = this.method_4(gclass254_0.int_4);
			if (ship != null)
			{
				ship.Shield = gclass254_0.kaVjqpkbjt;
				ship.ShieldMax = gclass254_0.int_1;
				ship.Hp = gclass254_0.int_3;
				ship.HpMax = gclass254_0.int_2;
				ship.IsTaken = gclass254_0.bool_0;
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

		internal void method_16(GClass250 gclass250_0)
		{
			DateTimeOffset now = DateTimeOffset.Now;
			Ship ship = this.method_4(gclass250_0.int_4);
			if (ship != null)
			{
				ship.Hp = gclass250_0.int_5;
				ship.Shield = gclass250_0.int_0;
				ship.LastTookDamage = now;
				if (!(ship is NpcShip))
				{
				}
			}
			Ship ship2 = this.method_4(gclass250_0.int_1);
			if (ship2 != null)
			{
				ship2.LastAttacked = now;
				if (gclass250_0.int_4 == this.Hero.Id)
				{
					ship2.LastAttackedHero = now;
					ship2.LastAttackedHeroDamage = gclass250_0.int_3;
				}
				if (ship2.Id == this.Hero.Id)
				{
					ship.LastTookDamageHero = now;
				}
			}
			if (ship2 != null && ship != null && !ship2.IsNpc)
			{
				ship.LastTookDamageEnemy = now;
			}
			Map.Delegates.ShipAttackHandler shipAttacked = this.ShipAttacked;
			if (shipAttacked != null)
			{
				shipAttacked(this, ship2, ship, gclass250_0.int_3, gclass250_0.gclass128_0.uint_0);
			}
			if (ship != null)
			{
				ship.method_10(this, ship2, ship, gclass250_0.int_3, gclass250_0.gclass128_0.uint_0);
			}
		}

		internal void method_17(GClass179 gclass179_0)
		{
			Ship ship = this.method_4(gclass179_0.int_0);
			if (ship != null)
			{
				ship.ApplyModifier(gclass179_0);
			}
		}

		internal void method_18(GClass213 gclass213_0)
		{
			this.Hero.Pet.AjDviCwchL(gclass213_0);
			this.Ships[gclass213_0.emTnBfukst] = this.Hero.Pet;
		}

		internal void method_19(GClass241 gclass241_0)
		{
			Pet pet = this.method_4(gclass241_0.int_7) as Pet;
			if (pet == null)
			{
				pet = new Pet();
				pet.method_12(gclass241_0);
				if (this.Ships.TryAdd(gclass241_0.int_7, pet))
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
				pet.method_12(gclass241_0);
			}
		}

		internal void method_20(GClass233 gclass233_0)
		{
			ICollidable collidable = null;
			ICollidable collidable2 = null;
			ICollidable collidable3;
			if (this.Collidables.TryGetValue(gclass233_0.Name, out collidable3))
			{
				collidable3.Active = gclass233_0.bool_1;
				collidable = collidable3;
			}
			CollidableType uint_ = (CollidableType)gclass233_0.gclass137_0.uint_0;
			if (gclass233_0.uint_0 == 2U && (uint_ == CollidableType.Wall || uint_ == CollidableType.Mines))
			{
				int num = Map.smethod_1(gclass233_0.vector_0[0U], gclass233_0.vector_0[2U], gclass233_0.vector_0[4U]);
				int num2 = Map.smethod_2(gclass233_0.vector_0[0U], gclass233_0.vector_0[2U], gclass233_0.vector_0[4U]);
				int num3 = Map.smethod_1(gclass233_0.vector_0[1U], gclass233_0.vector_0[3U], gclass233_0.vector_0[5U]);
				int num4 = Map.smethod_2(gclass233_0.vector_0[1U], gclass233_0.vector_0[3U], gclass233_0.vector_0[5U]);
				if (this.MapId == 93 && uint_ == CollidableType.Mines)
				{
					num4 = this.MapSize.Height - 500;
				}
				collidable2 = new CollidableRect(gclass233_0.Name, gclass233_0.bool_1, num, num3, num2 - num, num4 - num3, uint_);
			}
			else if (gclass233_0.uint_0 == 0U)
			{
				collidable2 = new CollidableSphere(uint_, gclass233_0.Name, new Vector2((float)gclass233_0.vector_0[0U], (float)gclass233_0.vector_0[1U]), gclass233_0.vector_0[2U]);
			}
			if (collidable2 != null)
			{
				if (collidable != null)
				{
					this.Grid.method_10(collidable);
				}
				this.Collidables[gclass233_0.Name] = (Collidable)collidable2;
				this.Grid.method_11(collidable2);
			}
		}

		internal void method_21(GClass253 gclass253_0)
		{
			Ship ship;
			if (this.Ships.TryGetValue(gclass253_0.int_3, out ship))
			{
				ship.method_2(gclass253_0.int_1, gclass253_0.int_2, gclass253_0.int_0);
				Map.Delegates.ShipMoveStartedHandler shipMoveStarted = this.ShipMoveStarted;
				if (shipMoveStarted == null)
				{
					return;
				}
				shipMoveStarted(this, ship, gclass253_0);
			}
		}

		public event Map.Delegates.CollectibleCreatedHandler CollectibleCreated;

		public event Map.Delegates.GateCreatedHander GateCreated;

		public event Map.Delegates.ShipUpdateHandler ShipCreated;

		public event Map.Delegates.ShipUpdateHandler ShipDestroyed;

		public event Map.Delegates.ShipUpdateHandler ShipSelected;

		public event Map.Delegates.ShipAttackHandler ShipAttacked;

		public event Map.Delegates.ShipMoveStartedHandler ShipMoveStarted;

		public event Map.Delegates.CollectibleCollected CollectibleCollected;

		[CompilerGenerated]
		internal static void smethod_0<cIGDPLJoShWtMFQgNva>(Entity entity_0, ref Map.<>c__DisplayClass88_0<cIGDPLJoShWtMFQgNva> <>c__DisplayClass88_0_0) where cIGDPLJoShWtMFQgNva : Entity
		{
			Vector2 value = entity_0.Position;
			if (<>c__DisplayClass88_0_0.predictionMs > 0)
			{
				MovingEntity movingEntity = entity_0 as MovingEntity;
				if (movingEntity != null)
				{
					value = movingEntity.method_1(<>c__DisplayClass88_0_0.predictionMs);
				}
			}
			float num = Vector2.Distance(<>c__DisplayClass88_0_0.origin, value);
			int num2 = 0;
			if (<>c__DisplayClass88_0_0.priority != null)
			{
				num2 = <>c__DisplayClass88_0_0.priority(entity_0 as cIGDPLJoShWtMFQgNva);
			}
			<>c__DisplayClass88_0_0.res.Add(new ValueTuple<cIGDPLJoShWtMFQgNva, float, int>((cIGDPLJoShWtMFQgNva)((object)entity_0), num, num2));
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

		protected void method_22(PropertyChangedEventArgs propertyChangedEventArgs_0)
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
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			public delegate void CollectibleCreatedHandler(Map map, Collectible collectible);

			public delegate void GateCreatedHander(Map map, Gate gate);

			public delegate void ShipUpdateHandler(Map map, Ship ship);

			public delegate void ShipMoveStartedHandler(Map map, Ship ship, GClass253 move);

			public delegate void ShipAttackHandler(Map map, Ship attacker, Ship target, int damage, uint attackType);

			public delegate void CollectibleCollected(Map map, string hash, Collectible collectible, bool byHero);
		}
	}
}

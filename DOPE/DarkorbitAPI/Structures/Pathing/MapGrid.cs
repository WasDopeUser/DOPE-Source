using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

namespace DarkorbitAPI.Structures.Pathing
{
	public class MapGrid
	{
		public int ScaleX { get; }

		public int Bx
		{
			get
			{
				return this._bx;
			}
		}

		public int ScaleY { get; }

		public int By
		{
			get
			{
				return this._by;
			}
		}

		public Map Map { get; }

		public byte[,] Blocks { get; private set; }

		public HashSet<ICollidable> Collidables { get; private set; }

		public MaxStack<PathSequence> PathCache { get; private set; }

		public static int smethod_0(int int_0, int int_1)
		{
			int num = int_0 % int_1;
			if (num == 0)
			{
				return int_0;
			}
			if (int_0 < 0)
			{
				return int_0 - num;
			}
			return int_0 + (int_1 - num);
		}

		public static int smethod_1(int int_0, int int_1)
		{
			int num = int_0 % int_1;
			if (num == 0)
			{
				return int_0;
			}
			if (int_0 < 0)
			{
				return int_0 - (int_1 + num);
			}
			return int_0 - num;
		}

		public static Rectangle smethod_2(int int_0, int int_1, int int_2, int int_3)
		{
			int x;
			int num = Math.Abs(int_0 - (x = MapGrid.smethod_1(int_0, 100)));
			int y;
			int num2 = Math.Abs(int_1 - (y = MapGrid.smethod_1(int_1, 50)));
			return new Rectangle(x, y, MapGrid.smethod_0(int_2 + num, 100), MapGrid.smethod_0(int_3 + num2, 50));
		}

		public static int smethod_3(int int_0, int int_1)
		{
			int num = int_0 / int_1;
			if (int_0 % int_1 == 0)
			{
				return num - 1;
			}
			return num;
		}

		public MapGrid(Map map_0)
		{
			Class8.xDph7tozmh5WD();
			this._lock = new object();
			base..ctor();
			this.Map = map_0;
			this.ScaleX = 100;
			this.ScaleY = 50;
			this.PathCache = new MaxStack<PathSequence>(32);
			this.method_12();
		}

		public bool method_0(Vector2 vector2_0, out int int_0, out int int_1)
		{
			return this.method_1((float)((int)vector2_0.X), (float)((int)vector2_0.Y), out int_0, out int_1);
		}

		public bool method_1(float float_0, float float_1, out int int_0, out int int_1)
		{
			int_1 = 0;
			int_0 = 0;
			if (float_0 >= 0f && float_1 >= 0f && float_0 <= (float)this.Map.MapSize.Width && float_1 <= (float)this.Map.MapSize.Height)
			{
				int_0 = (int)float_0 / this.ScaleX;
				int_1 = (int)float_1 / this.ScaleY;
				return true;
			}
			return false;
		}

		public Rectangle method_2(int int_0, int int_1)
		{
			return new Rectangle(int_0 * this.ScaleX, int_1 * this.ScaleY, this.ScaleX, this.ScaleY);
		}

		public bool method_3(Vector2 vector2_0, Vector2 vector2_1)
		{
			using (HashSet<ICollidable>.Enumerator enumerator = this.Collidables.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Vector2 vector;
					if (GClass799.smethod_7(enumerator.Current.imethod_1(), vector2_0, vector2_1, out vector))
					{
						return true;
					}
				}
			}
			return false;
		}

		public bool method_4(Vector2 vector2_0, Vector2 vector2_1, out Vector2 vector2_2)
		{
			vector2_2 = default(Vector2);
			using (HashSet<ICollidable>.Enumerator enumerator = this.Collidables.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (GClass799.smethod_7(enumerator.Current.imethod_1(), vector2_0, vector2_1, out vector2_2))
					{
						return true;
					}
				}
			}
			return false;
		}

		public Vector2 method_5(int int_0, int int_1)
		{
			return new Vector2((float)(int_0 * this.ScaleX + this.ScaleX / 2), (float)(int_1 * this.ScaleY + this.ScaleY / 2));
		}

		public void method_6(Rectangle rectangle_0, Action<int, int> action_0)
		{
			int num = Math.Min(this._bx, Math.Max(0, rectangle_0.Left / this.ScaleX));
			int num2 = Math.Min(this._bx, Math.Max(0, MapGrid.smethod_3(rectangle_0.Right, this.ScaleX)));
			int num3 = Math.Min(this._by, Math.Max(0, rectangle_0.Top / this.ScaleY));
			int num4 = Math.Min(this._by, Math.Max(0, MapGrid.smethod_3(rectangle_0.Bottom, this.ScaleY)));
			for (int i = num; i <= num2; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					action_0(i, j);
				}
			}
		}

		public bool method_7(Vector2 vector2_0)
		{
			return this.method_8(vector2_0.X, vector2_0.Y) && vector2_0 != Vector2.Zero && vector2_0 != this.Map.RightCorner;
		}

		public bool method_8(float float_0, float float_1)
		{
			int int_;
			int int_2;
			return !this.method_1(float_0, float_1, out int_, out int_2) || this.method_9(int_, int_2);
		}

		public bool method_9(int int_0, int int_1)
		{
			return int_0 < 0 || int_1 < 0 || int_0 >= this._bx || int_1 >= this._by || this.Blocks[int_0, int_1] > 0;
		}

		public bool method_10(ICollidable icollidable_0)
		{
			if (icollidable_0 == null)
			{
				return false;
			}
			object @lock = this._lock;
			lock (@lock)
			{
				if (this.Collidables.Remove(icollidable_0))
				{
					Rectangle rectangle_ = icollidable_0.imethod_1();
					this.method_6(rectangle_, new Action<int, int>(this.method_16));
					return true;
				}
			}
			return false;
		}

		public void method_11(ICollidable icollidable_0)
		{
			if (icollidable_0 != null && icollidable_0.imethod_0(this.Map) != CollidableType.None)
			{
				object @lock = this._lock;
				lock (@lock)
				{
					this.method_13();
					if (this.Collidables.Contains(icollidable_0))
					{
						this.method_10(icollidable_0);
					}
					Rectangle rectangle_ = icollidable_0.imethod_1();
					this.method_6(rectangle_, new Action<int, int>(this.method_17));
					this.Collidables.Add(icollidable_0);
				}
				return;
			}
		}

		public void method_12()
		{
			object @lock = this._lock;
			lock (@lock)
			{
				this.method_13();
				this.Collidables = new HashSet<ICollidable>();
				DarkorbitAPI.CommonStructures.Size mapSize = this.Map.MapSize;
				this.Blocks = new byte[(this._bx = mapSize.Width / this.ScaleX) + 10, (this._by = mapSize.Height / this.ScaleY) + 10];
			}
		}

		private void method_13()
		{
			this.PathCache.Clear();
		}

		public PathSequence method_14(Vector2 vector2_0, Vector2 vector2_1, int int_0 = 30, int int_1 = 0)
		{
			MapGrid.<>c__DisplayClass49_0 CS$<>8__locals1 = new MapGrid.<>c__DisplayClass49_0();
			CS$<>8__locals1.origin = vector2_0;
			CS$<>8__locals1.destination = vector2_1;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.ret = null;
			object @lock = this._lock;
			lock (@lock)
			{
				foreach (PathSequence pathSequence in this.PathCache)
				{
					if (pathSequence.method_3(CS$<>8__locals1.destination, int_0) && pathSequence.method_0(CS$<>8__locals1.origin, this, 30) != -1)
					{
						CS$<>8__locals1.ret = pathSequence;
					}
				}
				if (CS$<>8__locals1.ret != null)
				{
					this.PathCache.Remove(CS$<>8__locals1.ret);
					this.PathCache.method_0(CS$<>8__locals1.ret);
					return CS$<>8__locals1.ret;
				}
			}
			Map.Navigators.method_4(new Action<MapNavigator>(CS$<>8__locals1.method_0), int_1);
			if (CS$<>8__locals1.ret != null)
			{
				@lock = this._lock;
				lock (@lock)
				{
					this.PathCache.method_0(CS$<>8__locals1.ret);
				}
			}
			return CS$<>8__locals1.ret;
		}

		public void method_15(PathSequence pathSequence_0)
		{
			object @lock = this._lock;
			lock (@lock)
			{
				this.PathCache.method_0(pathSequence_0);
			}
		}

		public Vector2 LcuZkympWt(Vector2 vector2_0)
		{
			if (!this.method_7(vector2_0))
			{
				return vector2_0;
			}
			int num;
			int num2;
			this.method_0(vector2_0, out num, out num2);
			MapGrid.<>c__DisplayClass51_0 CS$<>8__locals1;
			CS$<>8__locals1.q = new Queue<ValueTuple<int, int>>();
			CS$<>8__locals1.v = new HashSet<ValueTuple<int, int>>();
			CS$<>8__locals1.q.Enqueue(new ValueTuple<int, int>(num, num2));
			while (CS$<>8__locals1.q.Count > 0)
			{
				ValueTuple<int, int> valueTuple = CS$<>8__locals1.q.Dequeue();
				if (!this.method_9(valueTuple.Item1, valueTuple.Item2))
				{
					return this.method_5(valueTuple.Item1, valueTuple.Item2);
				}
				if (CS$<>8__locals1.v.Add(new ValueTuple<int, int>(valueTuple.Item1, valueTuple.Item2)))
				{
					MapGrid.smethod_4(valueTuple.Item1, valueTuple.Item2 + 1, ref CS$<>8__locals1);
					MapGrid.smethod_4(valueTuple.Item1, valueTuple.Item2 - 1, ref CS$<>8__locals1);
					MapGrid.smethod_4(valueTuple.Item1 - 1, valueTuple.Item2, ref CS$<>8__locals1);
					MapGrid.smethod_4(valueTuple.Item1 + 1, valueTuple.Item2, ref CS$<>8__locals1);
					MapGrid.smethod_4(valueTuple.Item1 - 1, valueTuple.Item2 - 1, ref CS$<>8__locals1);
					MapGrid.smethod_4(valueTuple.Item1 - 1, valueTuple.Item2 + 1, ref CS$<>8__locals1);
					MapGrid.smethod_4(valueTuple.Item1 + 1, valueTuple.Item2 - 1, ref CS$<>8__locals1);
					MapGrid.smethod_4(valueTuple.Item1 + 1, valueTuple.Item2 + 1, ref CS$<>8__locals1);
				}
			}
			throw new InvalidOperationException();
		}

		[CompilerGenerated]
		private void method_16(int int_0, int int_1)
		{
			this.Blocks[int_0, int_1] = (byte)Math.Max(0, (int)(this.Blocks[int_0, int_1] - 1));
		}

		[CompilerGenerated]
		private void method_17(int int_0, int int_1)
		{
			this.Blocks[int_0, int_1] = (byte)Math.Min(254, (int)(this.Blocks[int_0, int_1] + 1));
		}

		[CompilerGenerated]
		internal static void smethod_4(int int_0, int int_1, ref MapGrid.<>c__DisplayClass51_0 <>c__DisplayClass51_0_0)
		{
			ValueTuple<int, int> item = new ValueTuple<int, int>(int_0, int_1);
			if (<>c__DisplayClass51_0_0.v.Contains(item))
			{
				return;
			}
			<>c__DisplayClass51_0_0.q.Enqueue(item);
		}

		private int _bx;

		private int _by;

		private readonly object _lock;
	}
}

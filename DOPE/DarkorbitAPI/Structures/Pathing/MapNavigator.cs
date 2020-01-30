using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

namespace DarkorbitAPI.Structures.Pathing
{
	public class MapNavigator
	{
		public MapGrid Grid { get; private set; }

		public MapNavigator()
		{
			Class13.Gj4N3WdzaR1LY();
			base..ctor();
			this.items = new MapNavigator.QueueItem[(MapUtils.LargeMapSize.Width / 100 + 1) * (MapUtils.LargeMapSize.Height / 50 + 1)];
			this._queue = new BfsQueue<MapNavigator.QueueItem>(this.items, new MapNavigator.Comparer());
		}

		private PathSequence method_0(Vector2 vector2_0, Vector2 vector2_1)
		{
			PathSequence pathSequence = new PathSequence(vector2_1);
			int num;
			int num2;
			this.Grid.method_0(vector2_0, out num, out num2);
			int num3;
			int num4;
			this.Grid.method_0(vector2_1, out num3, out num4);
			Stack<Vector2> stack = new Stack<Vector2>();
			stack.Push(vector2_1);
			int num5 = this.method_1(num3, num4);
			int num6 = num3;
			int num7 = num4;
			Vector2 item = this.Grid.method_5(num3, num4);
			int num8 = 0;
			int num9 = 0;
			int parent;
			while ((parent = this.items[num5].Parent) != -1)
			{
				int num10;
				int num11;
				this.method_2(parent, out num10, out num11);
				int num12 = num10 - num6;
				int num13 = num11 - num7;
				if (num8 != num12 || num9 != num13)
				{
					stack.Push(item);
				}
				num8 = num12;
				num9 = num13;
				item = this.Grid.method_5(num10, num11);
				num5 = parent;
				num6 = num10;
				num7 = num11;
			}
			if (stack.Count > 1)
			{
				int num14;
				int num15;
				this.Grid.method_0(stack.Peek(), out num14, out num15);
				if (num14 == num && num15 == num2)
				{
					stack.Pop();
				}
			}
			if (stack.Count > 0 && stack.Peek() != vector2_0)
			{
				stack.Push(vector2_0);
			}
			if (stack.Count == 0)
			{
				return null;
			}
			while (stack.Count > 0)
			{
				pathSequence.Path.Add(stack.Pop());
			}
			return pathSequence;
		}

		private int method_1(int int_0, int int_1)
		{
			return int_1 * this.Grid.Bx + int_0;
		}

		private void method_2(int int_0, out int int_1, out int int_2)
		{
			int_2 = Math.DivRem(int_0, this.Grid.Bx, out int_1);
		}

		[return: TupleElementNames(new string[]
		{
			"x",
			"y"
		})]
		public static IEnumerable<ValueTuple<int, int>> smethod_0(int int_0, int int_1, MapGrid mapGrid_0)
		{
			MapNavigator.<>c__DisplayClass12_0 CS$<>8__locals1;
			CS$<>8__locals1.grid = mapGrid_0;
			bool left = MapNavigator.smethod_1(int_0 - 1, int_1, ref CS$<>8__locals1);
			bool right = MapNavigator.smethod_1(int_0 + 1, int_1, ref CS$<>8__locals1);
			bool up = MapNavigator.smethod_1(int_0, int_1 - 1, ref CS$<>8__locals1);
			bool down = MapNavigator.smethod_1(int_0, int_1 + 1, ref CS$<>8__locals1);
			if (left)
			{
				yield return new ValueTuple<int, int>(int_0 - 1, int_1);
			}
			if (right)
			{
				yield return new ValueTuple<int, int>(int_0 + 1, int_1);
			}
			if (up)
			{
				yield return new ValueTuple<int, int>(int_0, int_1 - 1);
			}
			if (down)
			{
				yield return new ValueTuple<int, int>(int_0, int_1 + 1);
			}
			if (up && left && MapNavigator.smethod_1(int_0 - 1, int_1 - 1, ref CS$<>8__locals1))
			{
				yield return new ValueTuple<int, int>(int_0 - 1, int_1 - 1);
			}
			if (up && right && MapNavigator.smethod_1(int_0 + 1, int_1 - 1, ref CS$<>8__locals1))
			{
				yield return new ValueTuple<int, int>(int_0 + 1, int_1 - 1);
			}
			if (down && left && MapNavigator.smethod_1(int_0 - 1, int_1 + 1, ref CS$<>8__locals1))
			{
				yield return new ValueTuple<int, int>(int_0 - 1, int_1 + 1);
			}
			if (down && right && MapNavigator.smethod_1(int_0 + 1, int_1 + 1, ref CS$<>8__locals1))
			{
				yield return new ValueTuple<int, int>(int_0 + 1, int_1 + 1);
			}
			yield break;
		}

		[return: TupleElementNames(new string[]
		{
			"x",
			"y"
		})]
		private IEnumerable<ValueTuple<int, int>> method_3(int int_0, int int_1)
		{
			int num = this.method_1(int_0, int_1);
			if (this.items[num].Parent != -1)
			{
				goto IL_B5;
			}
			IEnumerator<ValueTuple<int, int>> enumerator = MapNavigator.smethod_0(int_0, int_1, this.Grid).GetEnumerator();
			int dx;
			int dy;
			bool both;
			bool bottomWalkable;
			for (;;)
			{
				try
				{
					IL_294:
					if (!enumerator.MoveNext())
					{
						break;
					}
					goto IL_2B5;
					IL_B5:
					int num2;
					int num3;
					this.method_2(this.items[num].Parent, out num2, out num3);
					dx = (int_0 - num2) / Math.Max(Math.Abs(int_0 - num2), 1);
					dy = (int_1 - num3) / Math.Max(Math.Abs(int_1 - num3), 1);
					if ((dx & dy) == 0)
					{
						goto IL_17C;
					}
					if (!(both = this.method_8(int_0, int_1 + dy)))
					{
						goto IL_2DF;
					}
					yield return new ValueTuple<int, int>(int_0, int_1 + dy);
					goto IL_2D8;
					IL_17C:
					if (dx == 0)
					{
						goto IL_202;
					}
					bool flag = this.method_8(int_0 + dx, int_1);
					both = this.method_8(int_0, int_1 + 1);
					bottomWalkable = this.method_8(int_0, int_1 - 1);
					if (!flag)
					{
						goto IL_3FB;
					}
					yield return new ValueTuple<int, int>(int_0 + dx, int_1);
					goto IL_37A;
					IL_202:
					if (dy == 0)
					{
						goto IL_558;
					}
					bool flag2 = this.method_8(int_0, int_1 + dy);
					bottomWalkable = this.method_8(int_0 + 1, int_1);
					both = this.method_8(int_0 - 1, int_1);
					if (!flag2)
					{
						goto IL_4F0;
					}
					yield return new ValueTuple<int, int>(int_0, int_1 + dy);
					goto IL_470;
					IL_28C:
					goto IL_294;
				}
				finally
				{
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				break;
				IL_2B5:
				ValueTuple<int, int> valueTuple = enumerator.Current;
				yield return valueTuple;
				goto IL_28C;
			}
			enumerator = null;
			yield break;
			IL_2D8:
			IL_2DF:
			if (!this.method_8(int_0 + dx, int_1))
			{
				goto IL_558;
			}
			yield return new ValueTuple<int, int>(int_0 + dx, int_1);
			if (both)
			{
				yield return new ValueTuple<int, int>(int_0 + dx, int_1 + dy);
				goto IL_558;
			}
			goto IL_558;
			IL_37A:
			if (both)
			{
				yield return new ValueTuple<int, int>(int_0 + dx, int_1 + 1);
			}
			if (bottomWalkable)
			{
				yield return new ValueTuple<int, int>(int_0 + dx, int_1 - 1);
			}
			IL_3FB:
			if (both)
			{
				yield return new ValueTuple<int, int>(int_0, int_1 + 1);
			}
			if (bottomWalkable)
			{
				yield return new ValueTuple<int, int>(int_0, int_1 - 1);
				goto IL_558;
			}
			goto IL_558;
			IL_470:
			if (bottomWalkable)
			{
				yield return new ValueTuple<int, int>(int_0 + 1, int_1 + dy);
			}
			if (both)
			{
				yield return new ValueTuple<int, int>(int_0 - 1, int_1 + dy);
			}
			IL_4F0:
			if (bottomWalkable)
			{
				yield return new ValueTuple<int, int>(int_0 + 1, int_1);
			}
			if (both)
			{
				yield return new ValueTuple<int, int>(int_0 - 1, int_1);
			}
			IL_558:
			yield break;
			yield break;
		}

		private bool method_4(int int_0, int int_1, int int_2, int int_3, [TupleElementNames(new string[]
		{
			"x",
			"y"
		})] out ValueTuple<int, int> res)
		{
			for (;;)
			{
				res = new ValueTuple<int, int>(int_2, int_3);
				if (this._endX == int_2 && this._endY == int_3)
				{
					return true;
				}
				if (!this.method_9(int_2, int_3))
				{
					return false;
				}
				int num = int_2 - int_0;
				int num2 = int_3 - int_1;
				if ((num & num2) != 0)
				{
					ValueTuple<int, int> valueTuple;
					if (this.method_4(int_2, int_3, int_2 + num, int_3, out valueTuple))
					{
						break;
					}
					if (this.method_4(int_2, int_3, int_2, int_3 + num2, out valueTuple))
					{
						break;
					}
				}
				else if (num != 0)
				{
					if (this.method_9(int_2, int_3 - 1) && !this.method_9(int_2 - num, int_3 - 1))
					{
						return true;
					}
					if (this.method_9(int_2, int_3 + 1) && !this.method_9(int_2 - num, int_3 + 1))
					{
						goto Block_8;
					}
				}
				else if (num2 != 0 && ((this.method_9(int_2 - 1, int_3) && !this.method_9(int_2 - 1, int_3 - num2)) || (this.method_9(int_2 + 1, int_3) && !this.method_9(int_2 + 1, int_3 - num2))))
				{
					return true;
				}
				if (!this.method_9(int_2 + num, int_3) || !this.method_9(int_2, int_3 + num2))
				{
					return false;
				}
				int_0 = int_2;
				int_1 = int_3;
				int_2 += num;
				int_3 += num2;
			}
			return true;
			Block_8:
			return true;
		}

		public PathSequence method_5(Vector2 vector2_0, Vector2 vector2_1, MapGrid mapGrid_0)
		{
			Vector2 destination = vector2_1;
			if (vector2_1.Y == mapGrid_0.Map.RightCorner.Y || vector2_1.X == mapGrid_0.Map.RightCorner.X)
			{
				vector2_1 = new Vector2(vector2_1.X - 1f, vector2_1.Y - 1f);
			}
			if (vector2_0.Y == mapGrid_0.Map.RightCorner.Y || vector2_0.X == mapGrid_0.Map.RightCorner.X)
			{
				vector2_0 = new Vector2(vector2_0.X - 1f, vector2_0.Y - 1f);
			}
			PathSequence pathSequence = this.method_6(vector2_0, vector2_1, mapGrid_0);
			if (pathSequence != null)
			{
				pathSequence.Destination = destination;
			}
			return pathSequence;
		}

		public unsafe PathSequence method_6(Vector2 vector2_0, Vector2 vector2_1, MapGrid mapGrid_0)
		{
			MapNavigator.<>c__DisplayClass20_0 CS$<>8__locals1;
			CS$<>8__locals1.<>4__this = this;
			this.Grid = mapGrid_0;
			if (!this.Grid.method_1(vector2_1.X, vector2_1.Y, out CS$<>8__locals1.endX, out CS$<>8__locals1.endY))
			{
				return null;
			}
			int int_;
			int int_2;
			this.Grid.method_0(vector2_0, out int_, out int_2);
			if (!this.Grid.method_3(vector2_0, vector2_1))
			{
				int num = this.method_1(CS$<>8__locals1.endX, CS$<>8__locals1.endY);
				int num2 = this.method_1(int_, int_2);
				this.items[num].Parent = num2;
				this.items[num2].Parent = -1;
				return this.method_0(vector2_0, vector2_1);
			}
			for (int i = 0; i < this.items.Length; i++)
			{
				this.items[i].Distance = 1000000000;
				this.items[i].Visited = false;
			}
			CS$<>8__locals1.WZ = (int)Math.Sqrt(12500.0);
			MapNavigator.QueueItem[] array = this.items;
			int num3 = this.method_1(int_, int_2);
			array[num3].Distance = 0;
			array[num3].Left = this.method_10(int_, int_2, ref CS$<>8__locals1);
			array[num3].Parent = -1;
			CS$<>8__locals1.q = this._queue;
			CS$<>8__locals1.q.method_0();
			bool flag = false;
			int num4 = 0;
			int num5 = Math.Max(1, this.Grid.Collidables.Count);
			for (;;)
			{
				MapNavigator.<>c__DisplayClass20_1 CS$<>8__locals2;
				CS$<>8__locals2.current = *CS$<>8__locals1.q.Top;
				if (CS$<>8__locals2.current.Distance == 1000000000)
				{
					goto IL_37F;
				}
				CS$<>8__locals2.topIndex = CS$<>8__locals1.q.method_5();
				CS$<>8__locals1.q[CS$<>8__locals2.topIndex].Distance = 1000000000;
				CS$<>8__locals1.q[CS$<>8__locals2.topIndex].Visited = true;
				CS$<>8__locals1.q.method_3(CS$<>8__locals2.topIndex);
				this.method_2(CS$<>8__locals2.topIndex, out CS$<>8__locals2.currentX, out CS$<>8__locals2.currentY);
				num4++;
				if (CS$<>8__locals2.currentX == CS$<>8__locals1.endX && CS$<>8__locals2.currentY == CS$<>8__locals1.endY)
				{
					break;
				}
				if (num4 % num5 == 0 && !this.Grid.method_3(this.Grid.method_5(CS$<>8__locals2.currentX, CS$<>8__locals2.currentY), vector2_1))
				{
					this.method_12(CS$<>8__locals1.endX, CS$<>8__locals1.endY, ref CS$<>8__locals1, ref CS$<>8__locals2);
				}
				bool flag2 = this.method_12(CS$<>8__locals2.currentX - 1, CS$<>8__locals2.currentY, ref CS$<>8__locals1, ref CS$<>8__locals2);
				bool flag3 = this.method_12(CS$<>8__locals2.currentX + 1, CS$<>8__locals2.currentY, ref CS$<>8__locals1, ref CS$<>8__locals2);
				bool flag4 = this.method_12(CS$<>8__locals2.currentX, CS$<>8__locals2.currentY - 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				bool flag5 = this.method_12(CS$<>8__locals2.currentX, CS$<>8__locals2.currentY + 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				if (flag2 && flag4)
				{
					this.method_12(CS$<>8__locals2.currentX - 1, CS$<>8__locals2.currentY - 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				}
				if (flag3 && flag4)
				{
					this.method_12(CS$<>8__locals2.currentX + 1, CS$<>8__locals2.currentY - 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				}
				if (flag2 && flag5)
				{
					this.method_12(CS$<>8__locals2.currentX - 1, CS$<>8__locals2.currentY + 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				}
				if (flag3 && flag5)
				{
					this.method_12(CS$<>8__locals2.currentX + 1, CS$<>8__locals2.currentY + 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				}
				CS$<>8__locals1.q.method_4();
			}
			flag = true;
			IL_37F:
			if (!flag)
			{
				return null;
			}
			return this.method_0(vector2_0, vector2_1);
		}

		public unsafe PathSequence method_7(Vector2 vector2_0, Vector2 vector2_1, float float_0, MapGrid mapGrid_0)
		{
			MapNavigator.<>c__DisplayClass21_0 CS$<>8__locals1;
			CS$<>8__locals1.grid = mapGrid_0;
			CS$<>8__locals1.<>4__this = this;
			this.Grid = CS$<>8__locals1.grid;
			int int_;
			int int_2;
			this.Grid.method_0(vector2_0, out int_, out int_2);
			for (int i = 0; i < this.items.Length; i++)
			{
				this.items[i].Distance = 1000000000;
				this.items[i].Visited = false;
			}
			CS$<>8__locals1.npcPositions = new List<ValueTuple<Vector2, int>>();
			foreach (KeyValuePair<int, Ship> keyValuePair in CS$<>8__locals1.grid.Map.Ships)
			{
				if (keyValuePair.Value.IsNpc)
				{
					CS$<>8__locals1.npcPositions.Add(new ValueTuple<Vector2, int>(keyValuePair.Value.method_1(200), (keyValuePair.Value as NpcShip).Range));
				}
			}
			MapNavigator.QueueItem[] array = this.items;
			int num = this.method_1(int_, int_2);
			array[num].Distance = 0;
			array[num].Left = this.method_13(CS$<>8__locals1.grid.method_5(int_, int_2), ref CS$<>8__locals1);
			array[num].Parent = -1;
			CS$<>8__locals1.q = this._queue;
			CS$<>8__locals1.q.method_0();
			bool flag = false;
			int num2 = 0;
			Vector2 vector2_2 = default(Vector2);
			MapNavigator.<>c__DisplayClass21_1 CS$<>8__locals2;
			for (;;)
			{
				CS$<>8__locals2.current = *CS$<>8__locals1.q.Top;
				if (CS$<>8__locals2.current.Distance == 1000000000)
				{
					goto IL_346;
				}
				CS$<>8__locals2.topIndex = CS$<>8__locals1.q.method_5();
				CS$<>8__locals1.q[CS$<>8__locals2.topIndex].Distance = 1000000000;
				CS$<>8__locals1.q[CS$<>8__locals2.topIndex].Visited = true;
				CS$<>8__locals1.q.method_3(CS$<>8__locals2.topIndex);
				this.method_2(CS$<>8__locals2.topIndex, out CS$<>8__locals2.currentX, out CS$<>8__locals2.currentY);
				num2++;
				CS$<>8__locals2.currentPos = CS$<>8__locals1.grid.method_5(CS$<>8__locals2.currentX, CS$<>8__locals2.currentY);
				if (Vector2.Distance(CS$<>8__locals2.currentPos, vector2_1) >= float_0)
				{
					break;
				}
				bool flag2 = this.method_14(CS$<>8__locals2.currentX - 1, CS$<>8__locals2.currentY, ref CS$<>8__locals1, ref CS$<>8__locals2);
				bool flag3 = this.method_14(CS$<>8__locals2.currentX + 1, CS$<>8__locals2.currentY, ref CS$<>8__locals1, ref CS$<>8__locals2);
				bool flag4 = this.method_14(CS$<>8__locals2.currentX, CS$<>8__locals2.currentY - 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				bool flag5 = this.method_14(CS$<>8__locals2.currentX, CS$<>8__locals2.currentY + 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				if (flag2 && flag4)
				{
					this.method_14(CS$<>8__locals2.currentX - 1, CS$<>8__locals2.currentY - 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				}
				if (flag3 && flag4)
				{
					this.method_14(CS$<>8__locals2.currentX + 1, CS$<>8__locals2.currentY - 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				}
				if (flag2 && flag5)
				{
					this.method_14(CS$<>8__locals2.currentX - 1, CS$<>8__locals2.currentY + 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				}
				if (flag3 && flag5)
				{
					this.method_14(CS$<>8__locals2.currentX + 1, CS$<>8__locals2.currentY + 1, ref CS$<>8__locals1, ref CS$<>8__locals2);
				}
				CS$<>8__locals1.q.method_4();
			}
			vector2_2 = CS$<>8__locals2.currentPos;
			flag = true;
			IL_346:
			if (!flag)
			{
				return null;
			}
			return this.method_0(vector2_0, vector2_2);
		}

		// Note: this type is marked as 'beforefieldinit'.
		static MapNavigator()
		{
			Class13.Gj4N3WdzaR1LY();
			MapNavigator.NULL = new ValueTuple<int, int>(-1, -1);
		}

		[CompilerGenerated]
		internal static bool smethod_1(int int_0, int int_1, ref MapNavigator.<>c__DisplayClass12_0 <>c__DisplayClass12_0_0)
		{
			return !<>c__DisplayClass12_0_0.grid.method_9(int_0, int_1);
		}

		[CompilerGenerated]
		private bool method_8(int int_0, int int_1)
		{
			return this._ignoreCollisions || !this.Grid.method_9(int_0, int_1);
		}

		[CompilerGenerated]
		private bool method_9(int int_0, int int_1)
		{
			return this._ignoreCollisions || !this.Grid.method_9(int_0, int_1);
		}

		[CompilerGenerated]
		internal static int smethod_2(int int_0, int int_1, ref MapNavigator.<>c__DisplayClass19_0 <>c__DisplayClass19_0_0)
		{
			return Math.Abs(int_0 - <>c__DisplayClass19_0_0.endX) * 100 + Math.Abs(int_1 - <>c__DisplayClass19_0_0.endY) * 50;
		}

		[CompilerGenerated]
		internal static int smethod_3(int int_0, int int_1)
		{
			int num = int_0 * 100;
			int num2 = int_1 * 50;
			return (int)Math.Sqrt((double)(num * num + num2 * num2));
		}

		[CompilerGenerated]
		private int method_10(int int_0, int int_1, ref MapNavigator.<>c__DisplayClass20_0 <>c__DisplayClass20_0_0)
		{
			int num = Math.Abs(int_0 - <>c__DisplayClass20_0_0.endX);
			int num2 = Math.Abs(int_1 - <>c__DisplayClass20_0_0.endY);
			return (int)((double)(num * 100 + num2 * 50 + (<>c__DisplayClass20_0_0.WZ - 100 - 50) * Math.Min(num, num2)) * 1.01);
		}

		[CompilerGenerated]
		private int method_11(int int_0, int int_1, ref MapNavigator.<>c__DisplayClass20_0 <>c__DisplayClass20_0_0)
		{
			int num = Math.Abs(int_0);
			int num2 = Math.Abs(int_1);
			return num * 100 + num2 * 50 + (<>c__DisplayClass20_0_0.WZ - 100 - 50) * Math.Min(num, num2);
		}

		[CompilerGenerated]
		private bool method_12(int int_0, int int_1, ref MapNavigator.<>c__DisplayClass20_0 <>c__DisplayClass20_0_0, ref MapNavigator.<>c__DisplayClass20_1 <>c__DisplayClass20_1_0)
		{
			if (this.Grid.method_9(int_0, int_1))
			{
				return false;
			}
			int num = this.method_1(int_0, int_1);
			if (this.items[num].Visited)
			{
				return true;
			}
			int num2 = <>c__DisplayClass20_1_0.current.Distance + this.method_11(<>c__DisplayClass20_1_0.currentX - int_0, <>c__DisplayClass20_1_0.currentY - int_1, ref <>c__DisplayClass20_0_0);
			if (num2 >= this.items[num].Distance)
			{
				return true;
			}
			this.items[num].Distance = num2;
			this.items[num].Left = this.method_10(int_0, int_1, ref <>c__DisplayClass20_0_0);
			this.items[num].Parent = <>c__DisplayClass20_1_0.topIndex;
			<>c__DisplayClass20_0_0.q.method_3(num);
			return true;
		}

		[CompilerGenerated]
		private int method_13(Vector2 vector2_0, ref MapNavigator.<>c__DisplayClass21_0 <>c__DisplayClass21_0_0)
		{
			int num = 0;
			num = 0 + (int)Math.Max(0f, 900f - <>c__DisplayClass21_0_0.grid.Map.method_3(vector2_0));
			foreach (ValueTuple<Vector2, int> valueTuple in <>c__DisplayClass21_0_0.npcPositions)
			{
				num += (int)Math.Max(0f, (float)valueTuple.Item2 - Vector2.Distance(valueTuple.Item1, vector2_0));
			}
			return num * 15;
		}

		[CompilerGenerated]
		internal static int smethod_4(int int_0, int int_1)
		{
			int num = int_0 * 100;
			int num2 = int_1 * 50;
			return (int)Math.Sqrt((double)(num * num + num2 * num2));
		}

		[CompilerGenerated]
		private bool method_14(int int_0, int int_1, ref MapNavigator.<>c__DisplayClass21_0 <>c__DisplayClass21_0_0, ref MapNavigator.<>c__DisplayClass21_1 <>c__DisplayClass21_1_0)
		{
			if (this.Grid.method_9(int_0, int_1))
			{
				return false;
			}
			int num = this.method_1(int_0, int_1);
			if (this.items[num].Visited)
			{
				return true;
			}
			int num2 = <>c__DisplayClass21_1_0.current.Distance + MapNavigator.smethod_4(<>c__DisplayClass21_1_0.currentX - int_0, <>c__DisplayClass21_1_0.currentY - int_1);
			if (num2 >= this.items[num].Distance)
			{
				return true;
			}
			this.items[num].Distance = num2;
			this.items[num].Left = <>c__DisplayClass21_1_0.current.Left + this.method_13(<>c__DisplayClass21_1_0.currentPos, ref <>c__DisplayClass21_0_0);
			this.items[num].Parent = <>c__DisplayClass21_1_0.topIndex;
			<>c__DisplayClass21_0_0.q.method_3(num);
			return true;
		}

		private readonly MapNavigator.QueueItem[] items;

		private readonly BfsQueue<MapNavigator.QueueItem> _queue;

		private bool _ignoreCollisions;

		[TupleElementNames(new string[]
		{
			"x",
			"y"
		})]
		public static ValueTuple<int, int> NULL;

		private int _endX;

		private int _endY;

		public struct QueueItem
		{
			public QueueItem(int int_0, int int_1)
			{
				Class13.Gj4N3WdzaR1LY();
				this.Distance = int_0;
				this.Left = int_1;
				this.Visited = false;
				this.Parent = -1;
			}

			public bool Visited;

			public int Distance;

			public int Left;

			public int Parent;
		}

		public class Comparer : Comparer<MapNavigator.QueueItem>
		{
			public override int Compare(MapNavigator.QueueItem x, MapNavigator.QueueItem y)
			{
				return x.Distance + x.Left - (y.Distance + y.Left);
			}

			public Comparer()
			{
				Class13.Gj4N3WdzaR1LY();
				base..ctor();
			}
		}
	}
}

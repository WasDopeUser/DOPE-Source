using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DarkorbitAPI.Structures.Pathing;

namespace DarkorbitAPI
{
	public class SecurityManager
	{
		public static int smethod_0(Ship ship_0)
		{
			NpcShip npcShip = ship_0 as NpcShip;
			if (npcShip != null && npcShip.Type != null && npcShip.Type.Class != null)
			{
				return SecurityManager.smethod_1(npcShip.Type);
			}
			return 540;
		}

		public static int smethod_1(NpcUtils.NpcType npcType_0)
		{
			if (npcType_0 == null || npcType_0.Class == null)
			{
				return 540;
			}
			NpcUtils.NpcClass @class = npcType_0.Class;
			int num = (npcType_0.Group == NpcUtils.G_Boss) ? 15 : ((npcType_0.Group == NpcUtils.G_Uber) ? 30 : 0);
			int num2;
			if (SecurityManager.NpcRangesRegular.TryGetValue(@class, out num2))
			{
				return num2 + Math.Min(num, Math.Max(0, 610 - num2));
			}
			return 540 + num;
		}

		public static int smethod_2(NpcUtils.NpcClass npcClass_0)
		{
			int result;
			if (npcClass_0 != null && SecurityManager.NpcRangesRegular.TryGetValue(npcClass_0, out result))
			{
				return result;
			}
			return 540;
		}

		public bool qOxDbmibcL(Map map_0, Entity entity_0)
		{
			return entity_0.PosX >= 0 && entity_0.PosX <= map_0.MapSize.Width && entity_0.PosY >= 0 && entity_0.PosY <= map_0.MapSize.Height;
		}

		public static int smethod_3(Ship ship_0)
		{
			return SecurityManager.smethod_0(ship_0);
		}

		public bool method_0()
		{
			if (this.Game.Map.Collidables.Count <= 0)
			{
				if (this.Game.Map.GG != (GEnum5)300)
				{
					foreach (KeyValuePair<int, Ship> keyValuePair in this.Game.Map.Ships)
					{
						GClass179 gclass;
						if (keyValuePair.Value.IsNpc && keyValuePair.Value.HasModifier(EntityModifierType.INVINCIBILITY, out gclass))
						{
							return true;
						}
					}
					return false;
				}
			}
			return true;
		}

		private Vector2 method_1(Vector2 vector2_0, float float_0, float float_1)
		{
			return new Vector2((float)((int)((double)vector2_0.X + (double)float_0 * Math.Sin((double)float_1))), (float)((int)((double)vector2_0.Y + (double)float_0 * Math.Cos((double)float_1))));
		}

		public int method_2(Vector2 vector2_0, Vector2 vector2_1, float float_0, int int_0 = 10)
		{
			float num = (float)Math.Atan2((double)(vector2_0.X - vector2_1.X), (double)(vector2_0.Y - vector2_1.Y));
			float num2 = 0f;
			float num3 = 0f;
			float num4 = (float)(3.1415926535897931 / (double)int_0);
			List<ValueTuple<Vector2, int>> list = new List<ValueTuple<Vector2, int>>();
			foreach (KeyValuePair<int, Ship> keyValuePair in this.Game.Map.Ships)
			{
				if (keyValuePair.Value.IsNpc && keyValuePair.Value != this.Game.Map.SelectedShip)
				{
					list.Add(new ValueTuple<Vector2, int>(keyValuePair.Value.method_1(200), (keyValuePair.Value as NpcShip).Range));
				}
			}
			float num5 = this.method_5(this.method_1(vector2_1, float_0, num), list);
			int num6 = 1;
			while (num6 <= int_0 && Math.Abs(num2 - num3) <= 400f)
			{
				num2 += this.method_5(this.method_1(vector2_1, float_0, num + num4 * (float)num6), list);
				num3 += this.method_5(this.method_1(vector2_1, float_0, num - num4 * (float)num6), list);
				if ((double)num2 <= -1000000.0 && (double)num3 <= -1000000.0)
				{
					return 0;
				}
				num6++;
			}
			if (num5 > num2 && num5 > num3)
			{
				return 0;
			}
			if (num2 < num3)
			{
				return -1;
			}
			return 1;
		}

		public Vector2? method_3(Vector2 vector2_0, Vector2 vector2_1, float float_0)
		{
			SecurityManager.<>c__DisplayClass18_0 CS$<>8__locals1;
			CS$<>8__locals1.securityManager_0 = this;
			CS$<>8__locals1.vector2_0 = vector2_0;
			CS$<>8__locals1.list_0 = new List<ValueTuple<Vector2, int>>();
			foreach (KeyValuePair<int, Ship> keyValuePair in this.Game.Map.Ships)
			{
				if (keyValuePair.Value.IsNpc)
				{
					CS$<>8__locals1.list_0.Add(new ValueTuple<Vector2, int>(keyValuePair.Value.method_1(200), (keyValuePair.Value as NpcShip).Range));
				}
			}
			CS$<>8__locals1.vector2_2 = default(Vector2);
			CS$<>8__locals1.float_0 = -2E+18f;
			double num = Math.Atan((double)(25f / float_0));
			int num2 = -1;
			int num3 = -1;
			for (double num4 = 0.0; num4 < 6.2831853071795862; num4 += num)
			{
				CS$<>8__locals1.vector2_1 = new Vector2((float)((double)vector2_1.X + Math.Sin(num4) * (double)float_0), (float)((double)vector2_1.Y + Math.Cos(num4) * (double)float_0));
				int num5;
				int num6;
				if (this.Game.Map.Grid.method_1(CS$<>8__locals1.vector2_1.X, CS$<>8__locals1.vector2_1.Y, out num5, out num6) && (num5 != num2 || num6 != num3))
				{
					num2 = num5;
					num3 = num6;
					if (!this.Game.Map.Grid.method_9(num2, num3))
					{
						this.method_27(ref CS$<>8__locals1);
					}
				}
			}
			if (CS$<>8__locals1.vector2_2 == default(Vector2))
			{
				return null;
			}
			return new Vector2?(CS$<>8__locals1.vector2_2);
		}

		public Vector2? method_4(Vector2 vector2_0, Vector2 vector2_1, float float_0)
		{
			SecurityManager.<>c__DisplayClass19_0 CS$<>8__locals1;
			CS$<>8__locals1.securityManager_0 = this;
			CS$<>8__locals1.vector2_0 = vector2_0;
			CS$<>8__locals1.vector2_1 = vector2_1;
			CS$<>8__locals1.float_0 = float_0;
			HashSet<ValueTuple<int, int>> hashSet = new HashSet<ValueTuple<int, int>>();
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			CS$<>8__locals1.dictionary_0 = new Dictionary<ValueTuple<int, int>, ValueTuple<int, int>>();
			Queue<ValueTuple<int, int>> queue = new Queue<ValueTuple<int, int>>();
			int num;
			int num2;
			this.Game.Map.Grid.method_0(CS$<>8__locals1.vector2_1, out num, out num2);
			queue.Enqueue(new ValueTuple<int, int>(num, num2));
			CS$<>8__locals1.list_0 = new List<ValueTuple<Vector2, int>>();
			foreach (KeyValuePair<int, Ship> keyValuePair in this.Game.Map.Ships)
			{
				if (keyValuePair.Value.IsNpc)
				{
					CS$<>8__locals1.list_0.Add(new ValueTuple<Vector2, int>(keyValuePair.Value.method_1(200), (keyValuePair.Value as NpcShip).Range));
				}
			}
			CS$<>8__locals1.vector2_2 = default(Vector2);
			CS$<>8__locals1.float_1 = -2E+18f;
			while (queue.Count > 0)
			{
				ValueTuple<int, int> valueTuple = queue.Dequeue();
				if (hashSet.Add(new ValueTuple<int, int>(valueTuple.Item1, valueTuple.Item2)))
				{
					if ((float)((int)Vector2.Distance(this.Game.Map.Grid.method_5(valueTuple.Item1, valueTuple.Item2), CS$<>8__locals1.vector2_1)) > CS$<>8__locals1.float_0)
					{
						this.method_28(valueTuple, ref CS$<>8__locals1);
					}
					else
					{
						foreach (ValueTuple<int, int> valueTuple2 in MapNavigator.smethod_0(valueTuple.Item1, valueTuple.Item2, this.Game.Map.Grid))
						{
							if (!hashSet.Contains(valueTuple2))
							{
								CS$<>8__locals1.dictionary_0[valueTuple2] = valueTuple;
								queue.Enqueue(valueTuple2);
							}
						}
					}
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return new Vector2?(CS$<>8__locals1.vector2_2);
		}

		public float method_5(Vector2 vector2_0, [TupleElementNames(new string[]
		{
			"pos",
			"range"
		})] List<ValueTuple<Vector2, int>> npcs)
		{
			return SecurityManager.smethod_4(this.Game.Map.Grid, vector2_0, npcs);
		}

		public static float smethod_4(MapGrid mapGrid_0, Vector2 vector2_0, [TupleElementNames(new string[]
		{
			"pos",
			"range"
		})] List<ValueTuple<Vector2, int>> npcs)
		{
			float num = 0f;
			if (mapGrid_0.method_7(vector2_0))
			{
				num -= 1000000f;
			}
			float num2 = mapGrid_0.Map.method_3(vector2_0);
			if (num2 < 100f)
			{
				num -= 100000f;
			}
			else
			{
				num -= Math.Max(0f, 900f - num2);
			}
			foreach (ValueTuple<Vector2, int> valueTuple in npcs)
			{
				num -= Math.Max(0f, (float)valueTuple.Item2 - Vector2.Distance(valueTuple.Item1, vector2_0));
			}
			return num;
		}

		public float method_6(Vector2 vector2_0, Vector2 vector2_1, [TupleElementNames(new string[]
		{
			"pos",
			"range"
		})] List<ValueTuple<Vector2, int>> npcs)
		{
			float num = 0f;
			Map map = this.Game.Map;
			if (map.Grid.method_7(vector2_1))
			{
				num -= 1000000f;
			}
			float num2 = map.method_3(vector2_1);
			if (num2 < 100f)
			{
				num -= 100000f;
			}
			else
			{
				num -= Math.Max(0f, 900f - num2);
			}
			foreach (ValueTuple<Vector2, int> valueTuple in npcs)
			{
				num -= Math.Max(0f, (float)((double)valueTuple.Item2 - GClass799.smethod_12(vector2_0, vector2_1, valueTuple.Item1, true)));
			}
			return num;
		}

		public bool IsDragging { get; set; }

		public bool FlipDrag { get; set; }

		public DateTimeOffset LastFlipped { get; set; }

		public int PredictionMs { get; set; }

		public Vector2 method_7(Vector2 vector2_0, Vector2 vector2_1)
		{
			float x = vector2_1.X + (vector2_0.X - vector2_1.X) * 2f;
			float y = vector2_1.Y + (vector2_0.Y - vector2_1.Y) * 2f;
			return new Vector2(x, y);
		}

		public Vector2? method_8(Vector2 vector2_0, int int_0 = 1100)
		{
			float num = 0f;
			float num2 = 0f;
			int num3 = 0;
			foreach (KeyValuePair<int, Ship> keyValuePair in this.Game.Map.Ships)
			{
				GClass179 gclass;
				if (keyValuePair.Value.IsNpc && !keyValuePair.Value.HasModifier(EntityModifierType.INVINCIBILITY, out gclass))
				{
					Vector2 vector = keyValuePair.Value.method_1(200);
					if (Vector2.Distance(vector2_0, vector) <= (float)int_0)
					{
						num += vector.X;
						num2 += vector.Y;
						num3++;
					}
				}
			}
			if (num3 == 0)
			{
				return null;
			}
			return new Vector2?(new Vector2(num / (float)num3, num2 / (float)num3));
		}

		public Vector2 method_9(Vector2 vector2_0, Ship ship_0, Vector2? nullable_0 = null, float float_0 = 0.5f, float float_1 = 0f, bool bool_0 = true)
		{
			SecurityManager.<>c__DisplayClass41_0 CS$<>8__locals1 = new SecurityManager.<>c__DisplayClass41_0();
			CS$<>8__locals1.securityManager_0 = this;
			CS$<>8__locals1.vector2_0 = vector2_0;
			CS$<>8__locals1.nullable_0 = nullable_0;
			this.IsDragging = false;
			if (ship_0 == null)
			{
				return CS$<>8__locals1.vector2_0;
			}
			CS$<>8__locals1.nullable_1 = null;
			if (this.Game.Map.IsGG)
			{
				CS$<>8__locals1.nullable_1 = this.method_8(CS$<>8__locals1.vector2_0, 1100);
			}
			CS$<>8__locals1.vector2_2 = ship_0.method_1(Math.Min(225, 80 + this.Game.Connection.PingMs));
			float num = Vector2.Distance(CS$<>8__locals1.vector2_0, CS$<>8__locals1.vector2_2);
			NpcShip npcShip = ship_0 as NpcShip;
			int num2 = (npcShip != null) ? npcShip.RangeFix : 0;
			float num3 = (npcShip != null) ? ((num + (float)npcShip.LastDistance) / 2f) : num;
			int num4 = (npcShip != null) ? npcShip.Range : SecurityManager.smethod_0(ship_0);
			if (this.Game.Hero.Pet.Mode == PetMode.Kamikaze && !this.Game.Hero.Pet.IsControlDisabled && this.Game.Hero.LastTookDamage.Cooldown(1000))
			{
				num4 = 325;
			}
			if ((npcShip.HpPercentage < 25f || npcShip.TemporarySpeed == 0f) && num4 > 595)
			{
				num4 = 595;
			}
			int num5 = num4 / 2;
			float num6 = Math.Max(Math.Min((float)num4 - num3 + (float)num2, (float)(num5 + 75)), (float)(-(float)num5));
			if (ship_0.TemporarySpeed <= 0f)
			{
				num6 = 0f;
			}
			num4 += (int)num6;
			if (npcShip != null)
			{
				npcShip.RangeFix = (int)num6;
				npcShip.LastDistance = (int)num;
			}
			if (ship_0.TemporarySpeed == 0f && ship_0.HpPercentage > 24.75f)
			{
				CS$<>8__locals1.nullable_0 = null;
			}
			CS$<>8__locals1.vector2_1 = default(Vector2);
			CS$<>8__locals1.bool_0 = true;
			CS$<>8__locals1.bool_1 = (ship_0.TemporarySpeed > 0f);
			bool flag = this.Game.Map.IsGG && bool_0 && this.Game.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(CS$<>8__locals1.method_0)) && !this.method_0();
			bool flag2;
			if (this.Game.Map.IsGG && this.Game.Hero.Pet.IsControlDisabled && !this.Game.Map.method_7(ship_0, out flag2))
			{
				Vector2 position = this.Game.Hero.Pet.Position;
				Vector2 vector = CS$<>8__locals1.nullable_1 ?? position;
				Vector2.Distance(CS$<>8__locals1.vector2_0, vector);
				Vector2.Distance(position, vector);
				Vector2 vector2 = this.method_7(position, vector) - position;
				double num7 = Math.Atan2((double)vector2.X, (double)vector2.Y);
				CS$<>8__locals1.vector2_1 = this.method_1(position, 700f, (float)num7);
			}
			else if (flag)
			{
				CS$<>8__locals1.vector2_1 = this.method_15(CS$<>8__locals1.vector2_0, CS$<>8__locals1.vector2_2, (float)num4, CS$<>8__locals1.bool_1, float_0, CS$<>8__locals1.nullable_1);
				CS$<>8__locals1.bool_0 = false;
			}
			else
			{
				if (float_0 != 0f)
				{
					if (Math.Abs(num6) == (float)num5 && num - (float)num4 > 50f)
					{
						float_0 = 0.1f;
					}
					float_0 *= (float)this.method_2(CS$<>8__locals1.vector2_0, CS$<>8__locals1.vector2_2, (float)num4, 10);
				}
				CS$<>8__locals1.vector2_1 = this.method_10(CS$<>8__locals1.vector2_0, CS$<>8__locals1.vector2_2, (float)num4, CS$<>8__locals1.nullable_0, float_0);
			}
			return CS$<>8__locals1.vector2_1;
		}

		public Vector2 method_10(Vector2 vector2_0, Vector2 vector2_1, float float_0, Vector2? nullable_0 = null, float float_1 = 0.5f)
		{
			Vector2 vector = default(Vector2);
			if (nullable_0 != null)
			{
				Vector2 value = nullable_0.Value;
				PointF left = GClass799.smethod_1(vector2_1.X, vector2_1.Y, float_0, new PointF(value.X, value.Y), new PointF(vector2_1.X, vector2_1.Y));
				if (left != PointF.Empty)
				{
					vector = new Vector2(left.X, left.Y);
				}
			}
			if (vector == default(Vector2))
			{
				double num = Math.Atan2((double)(vector2_0.X - vector2_1.X), (double)(vector2_0.Y - vector2_1.Y)) + (double)float_1;
				vector = this.method_1(vector2_1, float_0, (float)num);
			}
			if (!this.Game.Map.Grid.method_3(vector2_0, vector) && !this.Game.Map.Grid.method_7(vector))
			{
				return vector;
			}
			Vector2? vector2 = this.method_3(vector2_0, vector2_1, float_0);
			if (vector2 == null)
			{
				return vector;
			}
			return vector2.GetValueOrDefault();
		}

		private int method_11(float float_0, float float_1)
		{
			if (float_0 >= 0f)
			{
				if (float_1 < 0f)
				{
					return 3;
				}
				return 0;
			}
			else
			{
				if (float_1 < 0f)
				{
					return 2;
				}
				return 1;
			}
		}

		public bool method_12(float float_0, float float_1, float float_2, float float_3)
		{
			double num = Math.Atan2((double)float_1, (double)float_0);
			double num2 = Math.Atan2((double)float_3, (double)float_2);
			int num3 = this.method_11(float_0, float_1);
			int num4 = this.method_11(float_2, float_3);
			double num5 = num2;
			if (num3 == num4)
			{
				num5 = Math.Max(num, num2);
			}
			else if (num3 == (num4 + 1) % 4)
			{
				num5 = num;
			}
			return num5 == num2;
		}

		private double method_13(float float_0, float float_1, float float_2, float float_3)
		{
			double num = Math.Atan2((double)float_1, (double)float_0);
			double num2 = Math.Atan2((double)float_3, (double)float_2);
			int num3 = this.method_11(float_0, float_1);
			int num4 = this.method_11(float_2, float_3);
			double num5 = num2;
			if (num3 == num4)
			{
				num5 = Math.Max(num, num2);
			}
			else if (num3 == (num4 + 1) % 4)
			{
				num5 = num;
			}
			if (!this.FlipDrag)
			{
				return num5;
			}
			if (num5 != num)
			{
				return num;
			}
			return num2;
		}

		public static double smethod_5(Vector2 vector2_0, Vector2 vector2_1)
		{
			return SecurityManager.smethod_6(vector2_0.X, vector2_0.Y, vector2_1.X, vector2_1.Y);
		}

		public static double smethod_6(float float_0, float float_1, float float_2, float float_3)
		{
			return Math.Atan2(SecurityManager.Cross(float_0, float_1, float_2, float_3), SecurityManager.smethod_7(float_0, float_1, float_2, float_3));
		}

		public static double smethod_7(float float_0, float float_1, float float_2, float float_3)
		{
			return (double)(float_0 * float_2 + float_1 * float_3);
		}

		public static double Cross(float ox, float oy, float tx, float ty)
		{
			return (double)(ox * ty - oy * tx);
		}

		private float method_14(float float_0, float float_1, float float_2, float float_3, float float_4)
		{
			float num = (float)Math.Atan2((double)float_1, (double)float_0);
			double num2 = SecurityManager.smethod_6(float_0, float_1, float_2, float_3);
			if (float_4 < 0f)
			{
				float_4 = -float_4;
				num2 = 6.2831853071795862 - num2;
			}
			if (Math.Abs(num2) > (double)float_4)
			{
				num2 = (double)(float_4 * (float)Math.Sign(num2));
			}
			return (float)((double)num + num2);
		}

		private Vector2 method_15(Vector2 vector2_0, Vector2 vector2_1, float float_0, bool bool_0, float float_1 = 0.5f, Vector2? nullable_0 = null)
		{
			Vector2 center = this.Game.Map.Center;
			if (nullable_0 != null && this.LastFlipped.Cooldown(10000))
			{
				Vector2 value = nullable_0.Value;
				bool flipDrag = this.FlipDrag;
				this.FlipDrag = this.method_12(vector2_0.Y - center.Y, vector2_0.X - center.X, value.Y - center.Y, value.X - center.X);
				if (flipDrag != this.FlipDrag)
				{
					this.LastFlipped = DateTimeOffset.Now;
				}
			}
			float_1 = 0f;
			float num = (float)this.Game.Map.MapSize.Height * 0.42f;
			PointF pointF;
			PointF pointF2;
			int num2 = GClass799.smethod_0(center.X, center.Y, num, vector2_1.X, vector2_1.Y, float_0, out pointF, out pointF2);
			double num3;
			if (num2 == 2)
			{
				num3 = this.method_13(pointF.Y - center.Y, pointF.X - center.X, pointF2.Y - center.Y, pointF2.X - center.X);
			}
			else
			{
				num3 = Math.Atan2((double)(vector2_1.X - center.X), (double)(vector2_1.Y - center.Y)) + (double)(this.FlipDrag ? -0.5f : 0.5f);
			}
			Vector2 vector = this.method_1(center, num, (float)num3);
			if (num2 == 0 && bool_0)
			{
				return this.method_10(vector2_0, vector2_1, float_0, new Vector2?(vector), float_1);
			}
			this.IsDragging = true;
			return vector;
		}

		public string method_16()
		{
			string text = this.Game.Settings.Use3D ? "3D" : "2D";
			return string.Format("{0} {1}x{2} {3}", new object[]
			{
				text,
				1920,
				1080,
				this.Game.Settings.UIString ?? ".root1.instance467.MainClientApplication0.ApplicationSkin2.Group3.Group4._-k1N5.instance25043 root1 false -1"
			});
		}

		public SecurityManager(GameManager gameManager_0)
		{
			Class8.xDph7tozmh5WD();
			this.HashBlockList = new CooldownTracker<string>();
			this.Random = new Random();
			base..ctor();
			this.Game = gameManager_0;
		}

		public GameManager Game { get; }

		public bool method_17(Vector2 vector2_0, int int_0, int int_1, int int_2 = 0)
		{
			int num = (int)vector2_0.X;
			int num2 = (int)vector2_0.Y;
			return Math.Abs(num - int_0) < 960 - (75 + int_2) && Math.Abs(num2 - int_1) < 540 - (50 + int_2);
		}

		public bool method_18(Vector2 vector2_0, Vector2 vector2_1, int int_0 = 0)
		{
			return this.method_17(vector2_0, (int)vector2_1.X, (int)vector2_1.Y, 0);
		}

		public int LastChunkX { get; set; }

		public int LastChunkY { get; set; }

		public Vector2 method_19(Map map_0, Rectangle rectangle_0)
		{
			return this.AcfDxxThe3(map_0, this.LastChunkX = (this.LastChunkX + this.Random.Next(1, 5)) % 5, this.LastChunkY = (this.LastChunkY + this.Random.Next(0, 4)) % 4, rectangle_0);
		}

		public Vector2 method_20(Map map_0, List<Rectangle> list_0)
		{
			return this.method_19(map_0, list_0[this.Random.Next(0, list_0.Count)]);
		}

		public Vector2 AcfDxxThe3(Map map_0, int int_0, int int_1, Rectangle rectangle_0)
		{
			SecurityManager.<>c__DisplayClass69_0 CS$<>8__locals1 = new SecurityManager.<>c__DisplayClass69_0();
			CS$<>8__locals1.int_1 = int_0;
			CS$<>8__locals1.int_3 = int_1;
			CS$<>8__locals1.int_0 = rectangle_0.Width / 5;
			CS$<>8__locals1.int_2 = rectangle_0.Height / 4;
			if (map_0.Gates.Any(new Func<KeyValuePair<int, Gate>, bool>(CS$<>8__locals1.method_0)))
			{
				return this.method_19(map_0, rectangle_0);
			}
			int num = this.Random.Next(0, CS$<>8__locals1.int_0) + rectangle_0.X;
			int num2 = this.Random.Next(0, CS$<>8__locals1.int_2) + rectangle_0.Y;
			int num3 = CS$<>8__locals1.int_1 * CS$<>8__locals1.int_0 + num;
			int num4 = CS$<>8__locals1.int_3 * CS$<>8__locals1.int_2 + num2;
			Vector2 vector = new Vector2((float)num3, (float)num4);
			if (map_0.Grid.method_7(vector))
			{
				return this.method_19(map_0, rectangle_0);
			}
			return vector;
		}

		public static HashSet<string> BlackBoxes { get; private set; }

		static SecurityManager()
		{
			Class8.xDph7tozmh5WD();
			SecurityManager.NpcRangesRegular = new Dictionary<NpcUtils.NpcClass, int>
			{
				{
					NpcUtils.N_Streuner,
					450
				},
				{
					NpcUtils.N_Lordakia,
					450
				},
				{
					NpcUtils.N_Saimon,
					515
				},
				{
					NpcUtils.N_Mordon,
					470
				},
				{
					NpcUtils.N_Devolarium,
					530
				},
				{
					NpcUtils.N_Sibelon,
					550
				},
				{
					NpcUtils.N_Sibelonit,
					505
				},
				{
					NpcUtils.N_Lordakium,
					575
				},
				{
					NpcUtils.N_Kristallin,
					505
				},
				{
					NpcUtils.N_Kristallon,
					580
				},
				{
					NpcUtils.N_StreuneR,
					550
				},
				{
					NpcUtils.N_Protegit,
					565
				},
				{
					NpcUtils.N_Attend,
					555
				},
				{
					NpcUtils.N_Impulse,
					555
				},
				{
					NpcUtils.N_Melter,
					555
				},
				{
					NpcUtils.N_Annihilator,
					610
				},
				{
					NpcUtils.N_Interceptor,
					610
				},
				{
					NpcUtils.N_Baracuda,
					610
				},
				{
					NpcUtils.N_Saboteur,
					610
				},
				{
					NpcUtils.N_Kucurbium,
					565
				},
				{
					NpcUtils.N_CenturyFalcon,
					580
				},
				{
					NpcUtils.N_UFONIT,
					560
				},
				{
					NpcUtils.N_UFO,
					600
				},
				{
					NpcUtils.N_Cubikon,
					450
				},
				{
					NpcUtils.N_StreunerSoldier,
					570
				},
				{
					NpcUtils.N_StreunerTurret,
					570
				}
			};
			SecurityManager.BlackBoxes = new HashSet<string>
			{
				"ozims",
				"1604u",
				"znmjs",
				"bu9m9",
				"zel71",
				"q4knx",
				"ci7m0",
				"1ukl6",
				"1gtlm",
				"180fk",
				"13b44",
				"ntr63",
				"1lmf1",
				"1r78f",
				"1oloo",
				"xixzz",
				"13jaa",
				"6dge9",
				"m79jj",
				"h0rbx",
				"n5cwr",
				"1hviz",
				"1g4pv",
				"1ss4t",
				"1c2tu",
				"100vp",
				"rku9c",
				"1hd2h",
				"416n4",
				"1t5p4",
				"6ovbk",
				"3k2hr",
				"48chq",
				"lnkdf",
				"1usjy",
				"1scn2",
				"usc1j",
				"qj4o9",
				"yyr28",
				"3mtlo",
				"hkw3g",
				"a2abg",
				"1fnxl",
				"1kjds",
				"9icg0",
				"13umf",
				"qtqry",
				"1ucay",
				"puvoe",
				"1c3oi",
				"1nesl",
				"wl0wr",
				"sn8n9",
				"1v20m",
				"1g568",
				"1malf",
				"w27x1",
				"ov57p",
				"1ecek",
				"1my80",
				"1srvg",
				"2u942",
				"103wa",
				"1srrl",
				"109xs",
				"6x1u8",
				"152g8",
				"5naot",
				"oeoud",
				"tbeuu",
				"13p97",
				"rckbt",
				"1trob",
				"1fsi3",
				"v2qxb",
				"1szeq",
				"87k2a",
				"1bfcm",
				"fc9f7",
				"1g7du",
				"lqzp9",
				"wbku5",
				"1ts89",
				"1ag6n",
				"10tv0",
				"49ol8",
				"1isk4",
				"1jyqj",
				"1e5au",
				"8v03f",
				"uy62u",
				"mk797",
				"1g65j",
				"hm27v",
				"hs940",
				"q0e4a",
				"bv8wq",
				"1nad0",
				"1mc48",
				"1801q"
			};
		}

		public bool method_21(Collectible collectible_0, bool bool_0 = false)
		{
			DateTime now = DateTime.Now;
			string hash = collectible_0.Hash;
			if (!string.IsNullOrWhiteSpace(hash))
			{
				if (collectible_0 is DarkorbitAPI.Structures.Resource || hash.Length != 5)
				{
					return bool_0 || this.HashBlockList.method_0(collectible_0.Hash);
				}
			}
			return false;
		}

		public bool method_22(int int_0)
		{
			return this.Random.Next(0, int_0) == 0;
		}

		public Vector2 method_23(Vector2 vector2_0, int int_0, int int_1, int int_2 = 640, int int_3 = 360, int int_4 = 25, int int_5 = 25, int int_6 = 7)
		{
			Vector2 vector = new Vector2((float)int_0, (float)int_1);
			if (!this.method_17(vector2_0, int_0, int_1, 0))
			{
				int num = (int)((float)int_0 - vector2_0.X);
				int num2 = (int)((float)int_1 - vector2_0.Y);
				int num3 = (num >= 0) ? 1 : -1;
				int num4 = (num2 >= 0) ? 1 : -1;
				int num5 = Math.Min(Math.Abs(num), int_2);
				int num6 = Math.Min(Math.Abs(num2), int_3);
				if (Math.Abs(num2) < int_3)
				{
					num6 = Math.Abs(num2);
				}
				else
				{
					num5 = (int)(Math.Abs((float)num / (float)num2) * (float)num6);
				}
				if (num5 > int_2)
				{
					num6 = (int)((float)num6 * ((float)int_2 / (float)num5));
					num5 = int_2;
				}
				return this.method_25(new Vector2(vector2_0.X + (float)(num5 * num3), vector2_0.Y + (float)(num6 * num4)), int_4, int_5);
			}
			if (int_6 > 0 && this.method_22(int_6))
			{
				return this.method_25(vector, int_4, int_5);
			}
			return vector;
		}

		public Vector2 method_24(Vector2 vector2_0, int int_0, int int_1)
		{
			Vector2 vector = new Vector2((float)int_0, (float)int_1);
			if (!this.method_17(vector2_0, int_0, int_1, 0))
			{
				int num = (int)((float)int_0 - vector2_0.X);
				int num2 = (int)((float)int_1 - vector2_0.Y);
				int num3 = Math.Min(Math.Abs(num), 640) * ((num >= 0) ? 1 : -1);
				int num4 = Math.Min(Math.Abs(num2), 360) * ((num2 >= 0) ? 1 : -1);
				return this.method_25(new Vector2(vector2_0.X + (float)num3, vector2_0.Y + (float)num4), 25, 25);
			}
			if (this.method_22(15))
			{
				return this.method_25(vector, 50, 50);
			}
			return vector;
		}

		public Vector2 method_25(Vector2 vector2_0, int int_0 = 50, int int_1 = 50)
		{
			return this.method_26((int)vector2_0.X, (int)vector2_0.Y, int_0, int_1);
		}

		public Vector2 method_26(int int_0, int int_1, int int_2 = 50, int int_3 = 50)
		{
			int num;
			int num2;
			if (this.Game.Map.Grid.method_1((float)int_0, (float)int_1, out num, out num2))
			{
				int scaleX = this.Game.Map.Grid.ScaleX;
				int scaleY = this.Game.Map.Grid.ScaleY;
				int_2 = Math.Min(int_2, Math.Min(int_0 - num * scaleX, Math.Max(0, (num + 1) * scaleX - 1 - int_0)));
				int_3 = Math.Min(int_3, Math.Min(int_1 - num2 * scaleY, Math.Max(0, (num2 + 1) * scaleY - 1 - int_1)));
			}
			return new Vector2((float)(int_0 + ((int_2 == 0) ? 0 : this.Random.Next(-int_2, int_2))), (float)(int_1 + ((int_3 == 0) ? 0 : this.Random.Next(-int_3, int_3))));
		}

		[CompilerGenerated]
		private void method_27(ref SecurityManager.<>c__DisplayClass18_0 <>c__DisplayClass18_0_0)
		{
			float num = this.method_6(<>c__DisplayClass18_0_0.vector2_0, <>c__DisplayClass18_0_0.vector2_1, <>c__DisplayClass18_0_0.list_0) - Vector2.Distance(<>c__DisplayClass18_0_0.vector2_0, <>c__DisplayClass18_0_0.vector2_1) * 2f;
			if (num > <>c__DisplayClass18_0_0.float_0)
			{
				<>c__DisplayClass18_0_0.float_0 = num;
				<>c__DisplayClass18_0_0.vector2_2 = <>c__DisplayClass18_0_0.vector2_1;
			}
		}

		[CompilerGenerated]
		private void method_28([TupleElementNames(new string[]
		{
			"x",
			"y"
		})] ValueTuple<int, int> result, ref SecurityManager.<>c__DisplayClass19_0 <>c__DisplayClass19_0_0)
		{
			int num = 0;
			ValueTuple<int, int> key = result;
			while (<>c__DisplayClass19_0_0.dictionary_0.TryGetValue(key, out key))
			{
				num++;
			}
			Vector2 vector = this.Game.Map.Grid.method_5(result.Item1, result.Item2);
			float num2 = this.method_5(vector, <>c__DisplayClass19_0_0.list_0) - Vector2.Distance(<>c__DisplayClass19_0_0.vector2_0, vector) * 3f - Math.Abs(Vector2.Distance(vector, <>c__DisplayClass19_0_0.vector2_1) - <>c__DisplayClass19_0_0.float_0) * 5f - (float)(num * 125);
			if (num2 > <>c__DisplayClass19_0_0.float_1)
			{
				<>c__DisplayClass19_0_0.float_1 = num2;
				<>c__DisplayClass19_0_0.vector2_2 = vector;
			}
		}

		public readonly CooldownTracker<string> HashBlockList;

		public readonly Random Random;

		public static readonly Dictionary<NpcUtils.NpcClass, int> NpcRangesRegular;
	}
}

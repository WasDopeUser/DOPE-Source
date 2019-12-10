using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;

public static class GClass799
{
	public static int smethod_0(float float_0, float float_1, float float_2, float float_3, float float_4, float float_5, out PointF pointF_0, out PointF pointF_1)
	{
		float num = float_0 - float_3;
		float num2 = float_1 - float_4;
		double num3 = Math.Sqrt((double)(num * num + num2 * num2));
		if (num3 > (double)(float_2 + float_5))
		{
			pointF_0 = new PointF(float.NaN, float.NaN);
			pointF_1 = new PointF(float.NaN, float.NaN);
			return 0;
		}
		if (num3 < (double)Math.Abs(float_2 - float_5))
		{
			pointF_0 = new PointF(float.NaN, float.NaN);
			pointF_1 = new PointF(float.NaN, float.NaN);
			return 0;
		}
		if (num3 == 0.0 && float_2 == float_5)
		{
			pointF_0 = new PointF(float.NaN, float.NaN);
			pointF_1 = new PointF(float.NaN, float.NaN);
			return 0;
		}
		double num4 = ((double)(float_2 * float_2 - float_5 * float_5) + num3 * num3) / (2.0 * num3);
		double num5 = Math.Sqrt((double)(float_2 * float_2) - num4 * num4);
		double num6 = (double)float_0 + num4 * (double)(float_3 - float_0) / num3;
		double num7 = (double)float_1 + num4 * (double)(float_4 - float_1) / num3;
		pointF_0 = new PointF((float)(num6 + num5 * (double)(float_4 - float_1) / num3), (float)(num7 - num5 * (double)(float_3 - float_0) / num3));
		pointF_1 = new PointF((float)(num6 - num5 * (double)(float_4 - float_1) / num3), (float)(num7 + num5 * (double)(float_3 - float_0) / num3));
		if (num3 == (double)(float_2 + float_5))
		{
			return 1;
		}
		return 2;
	}

	public static PointF smethod_1(float float_0, float float_1, float float_2, PointF pointF_0, PointF pointF_1)
	{
		PointF pointF;
		PointF pointF2;
		int num = GClass799.smethod_3(float_0, float_1, float_2, pointF_0, pointF_1, out pointF, out pointF2);
		if (num == 1)
		{
			return pointF;
		}
		if (num != 2)
		{
			return PointF.Empty;
		}
		double num2 = GClass799.smethod_2(pointF, pointF_0);
		double num3 = GClass799.smethod_2(pointF2, pointF_0);
		if (num2 < num3)
		{
			return pointF;
		}
		return pointF2;
	}

	private static double smethod_2(PointF pointF_0, PointF pointF_1)
	{
		return Math.Sqrt(Math.Pow((double)(pointF_1.X - pointF_0.X), 2.0) + Math.Pow((double)(pointF_1.Y - pointF_0.Y), 2.0));
	}

	public static int smethod_3(float float_0, float float_1, float float_2, PointF pointF_0, PointF pointF_1, out PointF pointF_2, out PointF pointF_3)
	{
		float num = pointF_1.X - pointF_0.X;
		float num2 = pointF_1.Y - pointF_0.Y;
		float num3 = num * num + num2 * num2;
		float num4 = 2f * (num * (pointF_0.X - float_0) + num2 * (pointF_0.Y - float_1));
		float num5 = (pointF_0.X - float_0) * (pointF_0.X - float_0) + (pointF_0.Y - float_1) * (pointF_0.Y - float_1) - float_2 * float_2;
		float num6 = num4 * num4 - 4f * num3 * num5;
		if ((double)num3 <= 1E-07 || num6 < 0f)
		{
			pointF_2 = new PointF(float.NaN, float.NaN);
			pointF_3 = new PointF(float.NaN, float.NaN);
			return 0;
		}
		float num7;
		if (num6 == 0f)
		{
			num7 = -num4 / (2f * num3);
			pointF_2 = new PointF(pointF_0.X + num7 * num, pointF_0.Y + num7 * num2);
			pointF_3 = new PointF(float.NaN, float.NaN);
			return 1;
		}
		num7 = (float)(((double)(-(double)num4) + Math.Sqrt((double)num6)) / (double)(2f * num3));
		pointF_2 = new PointF(pointF_0.X + num7 * num, pointF_0.Y + num7 * num2);
		num7 = (float)(((double)(-(double)num4) - Math.Sqrt((double)num6)) / (double)(2f * num3));
		pointF_3 = new PointF(pointF_0.X + num7 * num, pointF_0.Y + num7 * num2);
		return 2;
	}

	public static bool smethod_4(float float_0, float float_1, float float_2)
	{
		return float_0 >= Math.Min(float_1, float_2) - 5f && float_0 < Math.Max(float_1, float_2) + 5f;
	}

	public static Vector2? smethod_5(Vector2 vector2_0, Vector2 vector2_1, Vector2 vector2_2, Vector2 vector2_3)
	{
		float x = vector2_0.X;
		float y = vector2_0.Y;
		float x2 = vector2_1.X;
		float y2 = vector2_1.Y;
		float x3 = vector2_2.X;
		float y3 = vector2_2.Y;
		float x4 = vector2_3.X;
		float y4 = vector2_3.Y;
		float num = (x - x2) * (y3 - y4) - (y - y2) * (x3 - x4);
		if (num == 0f)
		{
			return null;
		}
		float num2 = (x * y2 - y * x2) * (x3 - x4) - (x - x2) * (x3 * y4 - y3 * x4);
		float num3 = (x * y2 - y * x2) * (y3 - y4) - (y - y2) * (x3 * y4 - y3 * x4);
		float num4 = num2 / num;
		float num5 = num3 / num;
		if (GClass799.smethod_4(num4, vector2_0.X, vector2_1.X) && GClass799.smethod_4(num4, vector2_2.X, vector2_3.X) && GClass799.smethod_4(num5, vector2_0.Y, vector2_1.Y) && GClass799.smethod_4(num5, vector2_2.Y, vector2_3.Y))
		{
			return new Vector2?(new Vector2(num4, num5));
		}
		return null;
	}

	public static bool smethod_6(Vector2 vector2_0, Vector2 vector2_1, Vector2 vector2_2, Vector2 vector2_3, out Vector2 vector2_4)
	{
		Vector2? vector = GClass799.smethod_5(vector2_0, vector2_1, vector2_2, vector2_3);
		vector2_4 = vector.GetValueOrDefault();
		return vector != null;
	}

	public static bool smethod_7(Rectangle rectangle_0, Vector2 vector2_0, Vector2 vector2_1, out Vector2 vector2_2)
	{
		vector2_2 = default(Vector2);
		if (!rectangle_0.Contains(new Point((int)vector2_0.X, (int)vector2_0.Y)) && !rectangle_0.Contains(new Point((int)vector2_1.X, (int)vector2_1.Y)))
		{
			Vector2 vector = new Vector2((float)rectangle_0.Left, (float)rectangle_0.Top);
			Vector2 vector2 = new Vector2((float)rectangle_0.Right, (float)rectangle_0.Top);
			Vector2 vector3 = new Vector2((float)rectangle_0.Left, (float)rectangle_0.Bottom);
			Vector2 vector4 = new Vector2((float)rectangle_0.Right, (float)rectangle_0.Bottom);
			return GClass799.smethod_6(vector, vector2, vector2_0, vector2_1, out vector2_2) || GClass799.smethod_6(vector2, vector4, vector2_0, vector2_1, out vector2_2) || GClass799.smethod_6(vector4, vector3, vector2_0, vector2_1, out vector2_2) || GClass799.smethod_6(vector3, vector, vector2_0, vector2_1, out vector2_2);
		}
		return true;
	}

	public static Vector2? smethod_8(Rectangle rectangle_0, Vector2 vector2_0, Vector2 vector2_1)
	{
		GClass799.<>c__DisplayClass8_0 CS$<>8__locals1;
		CS$<>8__locals1.vector2_0 = vector2_0;
		Vector2 vector = new Vector2((float)rectangle_0.Left, (float)rectangle_0.Top);
		Vector2 vector2 = new Vector2((float)rectangle_0.Right, (float)rectangle_0.Top);
		Vector2 vector3 = new Vector2((float)rectangle_0.Left, (float)rectangle_0.Bottom);
		Vector2 vector4 = new Vector2((float)rectangle_0.Right, (float)rectangle_0.Bottom);
		CS$<>8__locals1.nullable_0 = null;
		GClass799.smethod_13(GClass799.smethod_5(vector, vector2, CS$<>8__locals1.vector2_0, vector2_1), ref CS$<>8__locals1);
		GClass799.smethod_13(GClass799.smethod_5(vector2, vector4, CS$<>8__locals1.vector2_0, vector2_1), ref CS$<>8__locals1);
		GClass799.smethod_13(GClass799.smethod_5(vector4, vector3, CS$<>8__locals1.vector2_0, vector2_1), ref CS$<>8__locals1);
		GClass799.smethod_13(GClass799.smethod_5(vector3, vector, CS$<>8__locals1.vector2_0, vector2_1), ref CS$<>8__locals1);
		return CS$<>8__locals1.nullable_0;
	}

	public static bool smethod_9(Vector2 vector2_0, Vector2 vector2_1, out float float_0, out float float_1, out float float_2)
	{
		float_0 = vector2_1.Y - vector2_0.Y;
		float_1 = -(vector2_1.X - vector2_0.X);
		float_2 = -(float_0 * vector2_0.X + float_1 * vector2_0.Y);
		return float_0 != 0f || float_1 != 0f;
	}

	public static float smethod_10(Vector2 vector2_0, Vector2 vector2_1, Vector2 vector2_2)
	{
		float num;
		float num2;
		float num3;
		if (!GClass799.smethod_9(vector2_0, vector2_1, out num, out num2, out num3))
		{
			return 0f;
		}
		return (float)((double)Math.Abs(vector2_2.X * num + vector2_2.Y * num2 + num3) / Math.Sqrt((double)(num * num + num2 * num2)));
	}

	private static double BaciiiHqkMx(Vector2 vector2_0, Vector2 vector2_1, Vector2 vector2_2)
	{
		double num = (double)(vector2_1.X - vector2_0.X);
		float num2 = vector2_1.Y - vector2_0.Y;
		float num3 = vector2_2.X - vector2_1.X;
		float num4 = vector2_2.Y - vector2_1.Y;
		return num * (double)num3 + (double)(num2 * num4);
	}

	private static double smethod_11(Vector2 vector2_0, Vector2 vector2_1, Vector2 vector2_2)
	{
		double num = (double)(vector2_1.X - vector2_0.X);
		float num2 = vector2_1.Y - vector2_0.Y;
		float num3 = vector2_2.X - vector2_0.X;
		float num4 = vector2_2.Y - vector2_0.Y;
		return num * (double)num4 - (double)(num2 * num3);
	}

	public static double smethod_12(Vector2 vector2_0, Vector2 vector2_1, Vector2 vector2_2, bool bool_0)
	{
		if (bool_0)
		{
			if (GClass799.BaciiiHqkMx(vector2_0, vector2_1, vector2_2) > 0.0)
			{
				return (double)Vector2.Distance(vector2_1, vector2_2);
			}
			if (GClass799.BaciiiHqkMx(vector2_1, vector2_0, vector2_2) > 0.0)
			{
				return (double)Vector2.Distance(vector2_0, vector2_2);
			}
		}
		float num = Vector2.Distance(vector2_0, vector2_1);
		if (num == 0f)
		{
			return (double)Vector2.Distance(vector2_0, vector2_2);
		}
		return Math.Abs(GClass799.smethod_11(vector2_0, vector2_1, vector2_2) / (double)num);
	}

	[CompilerGenerated]
	internal static void smethod_13(Vector2? nullable_0, ref GClass799.<>c__DisplayClass8_0 <>c__DisplayClass8_0_0)
	{
		if (<>c__DisplayClass8_0_0.nullable_0 == null)
		{
			<>c__DisplayClass8_0_0.nullable_0 = nullable_0;
			return;
		}
		if (nullable_0 != null && Vector2.Distance(<>c__DisplayClass8_0_0.nullable_0.Value, <>c__DisplayClass8_0_0.vector2_0) > Vector2.Distance(nullable_0.Value, <>c__DisplayClass8_0_0.vector2_0))
		{
			<>c__DisplayClass8_0_0.nullable_0 = nullable_0;
		}
	}
}

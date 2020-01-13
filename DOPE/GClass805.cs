using System;
using System.Drawing;
using System.Numerics;
using GsujcHxgAhWnFmvxchc;

public static class GClass805
{
	public static Vector2 smethod_0(Vector2 vector2_0, Vector2 vector2_1, float float_0, Vector2? nullable_0 = null, float float_1 = 0.5f)
	{
		Vector2 vector = default(Vector2);
		if (nullable_0 != null)
		{
			Vector2 value = nullable_0.Value;
			PointF left = GClass810.smethod_1(vector2_1.X, vector2_1.Y, float_0, new PointF(value.X, value.Y), new PointF(vector2_1.X, vector2_1.Y));
			if (left != PointF.Empty)
			{
				vector = new Vector2(left.X, left.Y);
			}
		}
		if (vector == default(Vector2))
		{
			double num = Math.Atan2((double)(vector2_0.X - vector2_1.X), (double)(vector2_0.Y - vector2_1.Y)) + (double)float_1;
			vector = GClass805.smethod_8(vector2_1, float_0, (float)num);
		}
		return vector;
	}

	public static int smethod_1(float float_0, float float_1)
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

	public static bool smethod_2(float float_0, float float_1, float float_2, float float_3)
	{
		double num = Math.Atan2((double)float_1, (double)float_0);
		double num2 = Math.Atan2((double)float_3, (double)float_2);
		int num3 = GClass805.smethod_1(float_0, float_1);
		int num4 = GClass805.smethod_1(float_2, float_3);
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

	public static double smethod_3(float float_0, float float_1, float float_2, float float_3, bool bool_0 = false)
	{
		double num = Math.Atan2((double)float_1, (double)float_0);
		double num2 = Math.Atan2((double)float_3, (double)float_2);
		int num3 = GClass805.smethod_1(float_0, float_1);
		int num4 = GClass805.smethod_1(float_2, float_3);
		double num5 = num2;
		if (num3 == num4)
		{
			num5 = Math.Max(num, num2);
		}
		else if (num3 == (num4 + 1) % 4)
		{
			num5 = num;
		}
		if (!bool_0)
		{
			return num5;
		}
		if (num5 != num)
		{
			return num;
		}
		return num2;
	}

	public static double smethod_4(Vector2 vector2_0, Vector2 vector2_1)
	{
		return GClass805.smethod_5(vector2_0.X, vector2_0.Y, vector2_1.X, vector2_1.Y);
	}

	public static double smethod_5(float float_0, float float_1, float float_2, float float_3)
	{
		return Math.Atan2(GClass805.Cross(float_0, float_1, float_2, float_3), GClass805.smethod_6(float_0, float_1, float_2, float_3));
	}

	public static double smethod_6(float float_0, float float_1, float float_2, float float_3)
	{
		return (double)(float_0 * float_2 + float_1 * float_3);
	}

	public static double Cross(float ox, float oy, float tx, float ty)
	{
		return (double)(ox * ty - oy * tx);
	}

	public static float smethod_7(float float_0, float float_1, float float_2, float float_3, float float_4)
	{
		float num = (float)Math.Atan2((double)float_1, (double)float_0);
		double num2 = GClass805.smethod_5(float_0, float_1, float_2, float_3);
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

	public static Vector2 smethod_8(Vector2 vector2_0, float float_0, float float_1)
	{
		return new Vector2((float)((int)((double)vector2_0.X + (double)float_0 * Math.Sin((double)float_1))), (float)((int)((double)vector2_0.Y + (double)float_0 * Math.Cos((double)float_1))));
	}

	public static Vector2 smethod_9(Vector2 vector2_0, Vector2 vector2_1)
	{
		float x = vector2_1.X + (vector2_0.X - vector2_1.X) * 2f;
		float y = vector2_1.Y + (vector2_0.Y - vector2_1.Y) * 2f;
		return new Vector2(x, y);
	}
}

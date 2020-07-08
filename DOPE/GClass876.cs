using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Text;
using Syroot.BinaryData;

public static class GClass876
{
	public static string smethod_0(this string string_0)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
	}

	public static string smethod_1(this string string_0)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0));
	}

	public static BinaryStream smethod_2(this Stream stream_0, bool bool_0 = true)
	{
		return new BinaryStream(stream_0, ByteConverter.Big, Encoding.UTF8, BooleanCoding.Byte, DateTimeCoding.NetTicks, StringCoding.Int16CharCount, bool_0);
	}

	public static Point smethod_3(this Vector2 vector2_0)
	{
		return new Point((int)vector2_0.X, (int)vector2_0.Y);
	}

	public static Vector2 smethod_4(this Rectangle rectangle_0)
	{
		return new Vector2((float)(rectangle_0.X + rectangle_0.Width / 2), (float)(rectangle_0.Y + rectangle_0.Height / 2));
	}
}

using System;
using System.IO;
using System.Text;
using Syroot.BinaryData;

public static class GClass798
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class GClass850
{
	public static string smethod_0(string string_0, string string_1)
	{
		Encoding unicode = Encoding.Unicode;
		return Convert.ToBase64String(GClass850.smethod_2(unicode.GetBytes(string_0), unicode.GetBytes(string_1)));
	}

	public static string smethod_1(string string_0, string string_1)
	{
		Encoding unicode = Encoding.Unicode;
		return unicode.GetString(GClass850.smethod_2(unicode.GetBytes(string_0), Convert.FromBase64String(string_1)));
	}

	public static byte[] smethod_2(byte[] byte_0, byte[] byte_1)
	{
		return GClass850.smethod_5(byte_0, byte_1).ToArray<byte>();
	}

	public static byte[] smethod_3(byte[] byte_0, byte[] byte_1)
	{
		return GClass850.smethod_5(byte_0, byte_1).ToArray<byte>();
	}

	private static byte[] smethod_4(byte[] byte_0)
	{
		byte[] array = Enumerable.Range(0, 256).Select(new Func<int, byte>(GClass850.<>c.<>c_0.method_0)).ToArray<byte>();
		int i = 0;
		int num = 0;
		while (i < 256)
		{
			num = (num + (int)byte_0[i % byte_0.Length] + (int)array[i] & 255);
			GClass850.smethod_6(array, i, num);
			i++;
		}
		return array;
	}

	private static IEnumerable<byte> smethod_5(byte[] byte_0, IEnumerable<byte> ienumerable_0)
	{
		GClass850.<>c__DisplayClass5_0 CS$<>8__locals1 = new GClass850.<>c__DisplayClass5_0();
		CS$<>8__locals1.byte_0 = GClass850.smethod_4(byte_0);
		CS$<>8__locals1.int_0 = 0;
		CS$<>8__locals1.int_1 = 0;
		return ienumerable_0.Select(new Func<byte, byte>(CS$<>8__locals1.method_0));
	}

	private static void smethod_6(byte[] byte_0, int int_0, int int_1)
	{
		byte b = byte_0[int_0];
		byte_0[int_0] = byte_0[int_1];
		byte_0[int_1] = b;
	}
}

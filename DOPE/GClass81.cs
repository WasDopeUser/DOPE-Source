using System;

public static class GClass81
{
	public static int smethod_0(this int int_0, int int_1)
	{
		return int_0 << int_1 | (int)((uint)int_0 >> 32 - int_1);
	}

	public static int smethod_1(this int int_0, int int_1)
	{
		return (int)((uint)int_0 >> int_1 | (uint)((uint)int_0 << 32 - int_1));
	}
}

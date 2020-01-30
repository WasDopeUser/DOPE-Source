using System;

namespace DarkorbitAPI.CommonStructures
{
	public static class U
	{
		public static int smethod_0(int int_0, int int_1)
		{
			return (int)((uint)int_0 >> int_1);
		}

		public static int smethod_1(uint uint_0, uint uint_1)
		{
			return U.smethod_0((int)uint_0, (int)uint_1);
		}

		public static int smethod_2(uint uint_0, int int_0)
		{
			return (int)(uint_0 >> int_0);
		}
	}
}

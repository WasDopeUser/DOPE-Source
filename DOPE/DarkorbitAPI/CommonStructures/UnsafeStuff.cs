using System;
using System.Security;

namespace DarkorbitAPI.CommonStructures
{
	public static class UnsafeStuff
	{
		[SecuritySafeCritical]
		public unsafe static float smethod_0(byte[] byte_0, int int_0 = 0)
		{
			int num = (int)byte_0[int_0] << 24 | (int)byte_0[int_0 + 1] << 16 | (int)byte_0[int_0 + 2] << 8 | (int)byte_0[int_0 + 3];
			return *(float*)(&num);
		}
	}
}

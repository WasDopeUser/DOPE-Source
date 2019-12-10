using System;
using System.Buffers;
using System.IO;
using Ace.Networking.Memory;

public static class GClass800
{
	public static void smethod_0(Stream stream_0, Stream stream_1, int int_0)
	{
		ArrayPool<byte> pool = MemoryManager.Instance.Pool;
		byte[] array = pool.Rent(4096);
		try
		{
			int count = Math.Min(array.Length, int_0);
			int num = stream_0.Read(array, 0, count);
			if (num == 0)
			{
				throw new IndexOutOfRangeException();
			}
			stream_1.Write(array, 0, num);
		}
		finally
		{
			pool.Return(array, false);
		}
	}
}

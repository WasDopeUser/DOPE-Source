using System;
using System.IO;
using System.Text;
using Syroot.BinaryData;

namespace DarkorbitAPI.CommonStructures
{
	public static class MapExtensions
	{
		public static int smethod_0(this BinaryStream binaryStream_0)
		{
			return binaryStream_0.ReadInt32();
		}

		public static short smethod_1(this BinaryStream binaryStream_0)
		{
			return binaryStream_0.ReadInt16();
		}

		public static string smethod_2(this BinaryStream binaryStream_0)
		{
			short num = binaryStream_0.ReadInt16();
			byte[] array = new byte[(int)num];
			binaryStream_0.Read(array, 0, (int)num);
			return Encoding.UTF8.GetString(array);
		}

		public static void MoioCjQkqp0(this BinaryStream binaryStream_0, string string_0)
		{
			binaryStream_0.WriteInt16((short)Encoding.UTF8.GetByteCount(string_0));
			binaryStream_0.Write(Encoding.UTF8.GetBytes(string_0));
		}

		public static void smethod_3(this BinaryStream binaryStream_0, int int_0)
		{
			binaryStream_0.WriteInt32(int_0);
		}

		public static void smethod_4(this BinaryStream binaryStream_0, short short_0)
		{
			binaryStream_0.WriteInt16(short_0);
		}

		public static void smethod_5(this BinaryStream binaryStream_0, uint uint_0)
		{
			binaryStream_0.WriteInt16((short)uint_0);
		}

		public static void smethod_6(this BinaryStream binaryStream_0, int int_0)
		{
			binaryStream_0.WriteInt16((short)int_0);
		}

		public static void smethod_7(this BinaryStream binaryStream_0, float float_0)
		{
			binaryStream_0.Write(float_0);
		}

		public static void smethod_8(this BinaryStream binaryStream_0, double double_0)
		{
			binaryStream_0.Write((float)double_0);
		}

		public static float smethod_9(this BinaryStream binaryStream_0)
		{
			byte[] array = new byte[4];
			binaryStream_0.Read(array, 0, 4);
			return UnsafeStuff.smethod_0(array, 0);
		}

		public static int smethod_10(this BinaryStream binaryStream_0, ByteArray byteArray_0, int int_0, int int_1)
		{
			byteArray_0.Clear();
			byte[] buffer = new byte[int_0 + int_1];
			byteArray_0.Memory = new MemoryStream(buffer);
			byteArray_0.Memory.Seek((long)int_0, SeekOrigin.Begin);
			return binaryStream_0.Read(buffer, int_0, int_1);
		}

		public static void smethod_11(this BinaryStream binaryStream_0, ByteArray byteArray_0, int int_0, int int_1)
		{
			byteArray_0.Memory.Position = (long)int_0;
			if (byteArray_0.Memory.Position == (long)int_0 && byteArray_0.Memory.Length == (long)(int_0 + int_1))
			{
				byteArray_0.Memory.CopyTo(binaryStream_0);
				return;
			}
			byte[] buffer = new byte[int_1];
			byteArray_0.Memory.Read(buffer, 0, int_1);
			binaryStream_0.Write(buffer, 0, int_1);
		}
	}
}

using System;
using DarkorbitAPI.CommonStructures;

public class GClass868
{
	public GClass868(ByteArray byteArray_1, ByteArray byteArray_2)
	{
		Class13.xnk8ImWzpOt04();
		this.uint_1 = 15U;
		base..ctor();
		this.vector_0 = new Vector<int>(8);
		this.vector_1 = new Vector<int>(8);
		this.vector_2 = new Vector<int>(8);
		this.method_0(byteArray_1, byteArray_2);
	}

	private void method_0(ByteArray byteArray_1, ByteArray byteArray_2)
	{
		this.byteArray_0 = new ByteArray();
		for (int i = 0; i < 16; i++)
		{
			this.byteArray_0[i] = 0;
		}
		int num = this.method_3(byteArray_1, 0);
		int num2 = this.method_3(byteArray_1, 4);
		int num3 = this.method_3(byteArray_1, 8);
		int num4 = this.method_3(byteArray_1, 12);
		this.vector_0[0U] = num;
		this.vector_0[2U] = num2;
		this.vector_0[4U] = num3;
		this.vector_0[6U] = num4;
		this.vector_0[1U] = (num4 << 16 | num3 >> 16);
		this.vector_0[3U] = (num << 16 | num4 >> 16);
		this.vector_0[5U] = (num2 << 16 | num >> 16);
		this.vector_0[7U] = (num3 << 16 | num2 >> 16);
		this.vector_1[0U] = (int)this.method_5(num3, 16);
		this.vector_1[2U] = (int)this.method_5(num4, 16);
		this.vector_1[4U] = (int)this.method_5(num, 16);
		this.vector_1[6U] = (int)this.method_5(num2, 16);
		this.vector_1[1U] = ((int)((long)num & 4294901760L) | (num2 & 65535));
		this.vector_1[3U] = ((int)((long)num2 & 4294901760L) | (num3 & 65535));
		this.vector_1[5U] = ((int)((long)num3 & 4294901760L) | (num4 & 65535));
		this.vector_1[7U] = ((int)((long)num4 & 4294901760L) | (num & 65535));
		this.uint_0 = 0U;
		for (int j = 0; j < 4; j++)
		{
			this.method_1();
		}
		for (int k = 0; k < 8; k++)
		{
			this.vector_1[k] = (this.vector_1[k] ^ this.vector_0[k + 4 & 7]);
		}
		int num5 = this.method_3(byteArray_2, 0);
		int num6 = this.method_3(byteArray_2, 4);
		int num7 = (int)((long)(num5 >> 16) | ((long)num6 & 4294901760L));
		int num8 = num6 << 16 | (num5 & 65535);
		this.vector_1[0U] = (this.vector_1[0U] ^ num5);
		this.vector_1[1U] = (this.vector_1[1U] ^ num7);
		this.vector_1[2U] = (this.vector_1[2U] ^ num6);
		this.vector_1[3U] = (this.vector_1[3U] ^ num8);
		this.vector_1[4U] = (this.vector_1[4U] ^ num5);
		this.vector_1[5U] = (this.vector_1[5U] ^ num7);
		this.vector_1[6U] = (this.vector_1[6U] ^ num6);
		this.vector_1[7U] = (this.vector_1[7U] ^ num8);
		for (int l = 0; l < 4; l++)
		{
			this.method_1();
		}
	}

	private void method_1()
	{
		for (int i = 0; i < 8; i++)
		{
			this.vector_2[i] = this.vector_1[i];
		}
		this.vector_1[0U] = (int)((long)(this.vector_1[0U] + 1295307597) + (long)((ulong)this.uint_0));
		this.vector_1[1U] = (int)((long)this.vector_1[1U] + 3545052371L + ((this.vector_1[0U] < this.vector_2[0U]) ? 1L : 0L));
		this.vector_1[2U] = this.vector_1[2U] + 886263092 + ((this.vector_1[1U] < this.vector_2[1U]) ? 1 : 0);
		this.vector_1[3U] = this.vector_1[3U] + 1295307597 + ((this.vector_1[2U] < this.vector_2[2U]) ? 1 : 0);
		this.vector_1[4U] = (int)((long)this.vector_1[4U] + 3545052371L + ((this.vector_1[3U] < this.vector_2[3U]) ? 1L : 0L));
		this.vector_1[5U] = this.vector_1[5U] + 886263092 + ((this.vector_1[4U] < this.vector_2[4U]) ? 1 : 0);
		this.vector_1[6U] = this.vector_1[6U] + 1295307597 + ((this.vector_1[5U] < this.vector_2[5U]) ? 1 : 0);
		this.vector_1[7U] = (int)((long)this.vector_1[7U] + 3545052371L + ((this.vector_1[6U] < this.vector_2[6U]) ? 1L : 0L));
		this.uint_0 = ((this.vector_1[7U] < this.vector_2[7U]) ? 1U : 0U);
		for (int j = 0; j < 8; j++)
		{
			this.vector_2[j] = (int)this.method_2(this.vector_0[j] + this.vector_1[j]);
		}
		this.vector_0[0U] = (int)((long)this.vector_2[0U] + (long)((ulong)this.method_5(this.vector_2[7U], 16)) + (long)((ulong)this.method_5(this.vector_2[6U], 16)));
		this.vector_0[1U] = (int)((long)this.vector_2[1U] + (long)((ulong)this.method_5(this.vector_2[0U], 8)) + (long)this.vector_2[7U]);
		this.vector_0[2U] = (int)((long)this.vector_2[2U] + (long)((ulong)this.method_5(this.vector_2[1U], 16)) + (long)((ulong)this.method_5(this.vector_2[0U], 16)));
		this.vector_0[3U] = (int)((long)this.vector_2[3U] + (long)((ulong)this.method_5(this.vector_2[2U], 8)) + (long)this.vector_2[1U]);
		this.vector_0[4U] = (int)((long)this.vector_2[4U] + (long)((ulong)this.method_5(this.vector_2[3U], 16)) + (long)((ulong)this.method_5(this.vector_2[2U], 16)));
		this.vector_0[5U] = (int)((long)this.vector_2[5U] + (long)((ulong)this.method_5(this.vector_2[4U], 8)) + (long)this.vector_2[3U]);
		this.vector_0[6U] = (int)((long)this.vector_2[6U] + (long)((ulong)this.method_5(this.vector_2[5U], 16)) + (long)((ulong)this.method_5(this.vector_2[4U], 16)));
		this.vector_0[7U] = (int)((long)this.vector_2[7U] + (long)((ulong)this.method_5(this.vector_2[6U], 8)) + (long)this.vector_2[5U]);
	}

	public uint method_2(int int_0)
	{
		int num = int_0 & 65535;
		int num2 = int_0 >> 16;
		uint num3 = (uint)(((num * num >> 17) + num * num2 >> 15) + num2 * num2);
		int num4 = int_0 * int_0;
		return num3 ^ (uint)num4;
	}

	private int method_3(ByteArray byteArray_1, int int_0)
	{
		return (int)(byteArray_1[int_0] & byte.MaxValue) | (int)(byteArray_1[int_0 + 1] & byte.MaxValue) << 8 | (int)(byteArray_1[int_0 + 2] & byte.MaxValue) << 16 | (int)byteArray_1[int_0 + 3] << 24;
	}

	private void method_4(ByteArray byteArray_1, int int_0, int int_1)
	{
		byteArray_1[int_0] = (byte)(int_1 & 255);
		byteArray_1[int_0 + 1] = (byte)(U.smethod_0(int_1, 8) & 255);
		byteArray_1[int_0 + 2] = (byte)(U.smethod_0(int_1, 16) & 255);
		byteArray_1[int_0 + 3] = (byte)(U.smethod_0(int_1, 24) & 255);
	}

	private uint method_5(int int_0, int int_1)
	{
		return (uint)(int_0 << int_1 | int_0 >> 32 - int_1);
	}

	private int method_6()
	{
		uint num = this.uint_1 + 1U;
		this.uint_1 = num;
		if ((ulong)num >= (ulong)((long)this.byteArray_0.Length))
		{
			this.method_7();
			this.uint_1 = 0U;
		}
		return (int)this.byteArray_0[(int)this.uint_1];
	}

	private void method_7()
	{
		this.method_1();
		this.method_4(this.byteArray_0, 0, this.vector_0[0U] ^ this.vector_0[5U] >> 16 ^ this.vector_0[3U] << 16);
		this.method_4(this.byteArray_0, 4, this.vector_0[2U] ^ this.vector_0[7U] >> 16 ^ this.vector_0[5U] << 16);
		this.method_4(this.byteArray_0, 8, this.vector_0[4U] ^ this.vector_0[1U] >> 16 ^ this.vector_0[7U] << 16);
		this.method_4(this.byteArray_0, 12, this.vector_0[6U] ^ this.vector_0[3U] >> 16 ^ this.vector_0[1U] << 16);
	}

	public virtual void vmethod_0(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < int_1; i++)
		{
			byte_0[i + int_0] = (byte)(((int)byte_0[i + int_0] ^ this.method_6()) & 255);
		}
	}

	private Vector<int> vector_0;

	private Vector<int> vector_1;

	private uint uint_0;

	private ByteArray byteArray_0;

	private uint uint_1;

	private Vector<int> vector_2;
}

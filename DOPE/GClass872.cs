using System;
using DarkorbitAPI.CommonStructures;

public class GClass872
{
	public GClass872(Vector<uint> vector_5, Vector<uint> vector_6)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.vector_0 = new Vector<uint>(512);
		this.vector_1 = new Vector<uint>(512);
		this.vector_4 = new Vector<uint>(4);
		if (vector_6 != null)
		{
			if (vector_6.Length == 16)
			{
				if (vector_5 != null)
				{
					if (vector_5.Length == 16)
					{
						this.vector_3 = vector_5;
						this.vector_2 = vector_6;
						this.method_0();
						return;
					}
				}
				return;
			}
		}
	}

	private void method_0()
	{
		Vector<uint> vector = new Vector<uint>(1280);
		for (uint num = 0U; num < 16U; num += 1U)
		{
			uint num2 = this.vector_2[num] & 255U;
			uint num3 = 8U * (num & 3U);
			uint num4 = num >> 2;
			vector[num4] |= num2 << (int)num3;
		}
		this.method_13(vector, 0U, vector, 4U, 4U);
		int num5 = 0;
		while (num5 < this.vector_3.Length && num5 < 16)
		{
			vector[(num5 >> 2) + 8] = (vector[(num5 >> 2) + 8] | (this.vector_3[num5] & 255U) << 8 * (num5 & 3));
			num5++;
		}
		this.method_13(vector, 8U, vector, 12U, 4U);
		for (int i = 16; i < 1280; i++)
		{
			vector[i] = (uint)((ulong)(this.method_3(vector[i - 2]) + vector[i - 7] + this.method_2(vector[i - 15]) + vector[i - 16]) + (ulong)((long)i));
		}
		this.method_13(vector, 256U, this.vector_0, 0U, 512U);
		this.method_13(vector, 768U, this.vector_1, 0U, 512U);
		for (int j = 0; j < 512; j++)
		{
			this.vector_0[j] = this.method_12();
		}
		for (int k = 0; k < 512; k++)
		{
			this.vector_1[k] = this.method_12();
		}
		this.uint_0 = 0U;
	}

	public virtual void vmethod_0(byte[] byte_0, int int_0, int int_1)
	{
		uint num = 0U;
		while ((ulong)num < (ulong)((long)int_1))
		{
			byte_0[(int)(checked((IntPtr)(unchecked((long)int_0 + (long)((ulong)num)))))] = (byte)(((uint)byte_0[(int)(checked((IntPtr)(unchecked((long)int_0 + (long)((ulong)num)))))] ^ this.method_1()) & 255U);
			num += 1U;
		}
	}

	private uint method_1()
	{
		if (this.uint_1 == 0U)
		{
			uint num = this.method_12();
			this.vector_4[0U] = (num & 255U);
			num >>= 8;
			this.vector_4[1U] = (num & 255U);
			num >>= 8;
			this.vector_4[2U] = (num & 255U);
			num >>= 8;
			this.vector_4[3U] = (num & 255U);
		}
		uint result = this.vector_4[this.uint_1];
		this.uint_1 = (this.uint_1 + 1U & 3U);
		return result;
	}

	private uint method_2(uint uint_2)
	{
		return this.method_6(uint_2, 7U) ^ this.method_6(uint_2, 18U) ^ uint_2 >> 3;
	}

	private uint method_3(uint uint_2)
	{
		return this.method_6(uint_2, 17U) ^ this.method_6(uint_2, 19U) ^ uint_2 >> 10;
	}

	private uint qiuMthoaYyi(uint uint_2, uint uint_3, uint uint_4)
	{
		return (this.method_6(uint_2, 10U) ^ this.method_6(uint_4, 23U)) + this.method_6(uint_3, 8U);
	}

	private uint method_4(uint uint_2, uint uint_3, uint uint_4)
	{
		return (this.method_5(uint_2, 10U) ^ this.method_5(uint_4, 23U)) + this.method_5(uint_3, 8U);
	}

	private uint method_5(uint uint_2, uint uint_3)
	{
		return uint_2 << (int)uint_3 | (uint)U.smethod_2(uint_2, (int)(-(int)uint_3));
	}

	private uint method_6(uint uint_2, uint uint_3)
	{
		return (uint)(U.smethod_1(uint_2, uint_3) | (int)((int)uint_2 << (int)(-(int)uint_3)));
	}

	private uint method_7(uint uint_2)
	{
		return this.vector_1[uint_2 & 255U] + this.vector_1[(uint_2 >> 16 & 255U) + 256U];
	}

	private uint method_8(uint uint_2)
	{
		return this.vector_0[uint_2 & 255U] + this.vector_0[(uint_2 >> 16 & 255U) + 256U];
	}

	private uint method_9(uint uint_2)
	{
		return uint_2 & 1023U;
	}

	private uint method_10(uint uint_2)
	{
		return uint_2 & 511U;
	}

	private uint method_11(uint uint_2, uint uint_3)
	{
		return this.method_10(uint_2 - uint_3);
	}

	private uint method_12()
	{
		uint uint_ = this.method_10(this.uint_0);
		uint result;
		if (this.uint_0 < 512U)
		{
			this.vector_0[uint_] = this.vector_0[uint_] + this.qiuMthoaYyi(this.vector_0[this.method_11(uint_, 3U)], this.vector_0[this.method_11(uint_, 10U)], this.vector_0[this.method_11(uint_, 511U)]);
			result = (this.method_7(this.vector_0[this.method_11(uint_, 12U)]) ^ this.vector_0[uint_]);
		}
		else
		{
			this.vector_1[uint_] = this.vector_1[uint_] + this.method_4(this.vector_1[this.method_11(uint_, 3U)], this.vector_1[this.method_11(uint_, 10U)], this.vector_1[this.method_11(uint_, 511U)]);
			result = (this.method_8(this.vector_1[this.method_11(uint_, 12U)]) ^ this.vector_1[uint_]);
		}
		this.uint_0 = this.method_9(this.uint_0 + 1U);
		return result;
	}

	private void method_13(Vector<uint> vector_5, uint uint_2, Vector<uint> vector_6, uint uint_3, uint uint_4)
	{
		uint num = uint_3;
		uint num2 = uint_4 + uint_2;
		for (uint num3 = uint_2; num3 < num2; num3 += 1U)
		{
			vector_6[num] = vector_5[num3];
			num += 1U;
		}
	}

	public virtual void vmethod_1()
	{
		this.uint_1 = 0U;
		this.method_0();
	}

	private uint uint_0;

	private Vector<uint> vector_0;

	private Vector<uint> vector_1;

	private Vector<uint> vector_2;

	private Vector<uint> vector_3;

	private Vector<uint> vector_4;

	private uint uint_1;
}

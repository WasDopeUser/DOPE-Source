using System;
using DarkorbitAPI.CommonStructures;

public class GClass803
{
	private void method_0(Vector<uint> vector_2)
	{
		this.vector_1[0U] = this.method_1(this.vector_0, 0U);
		this.vector_1[1U] = this.method_1(this.vector_0, 4U);
		this.vector_1[2U] = ((this.vector_0[8U] & 255U) | (this.vector_0[9U] << 8 & 65280U));
		this.vector_1[3U] = this.method_1(vector_2, 0U);
		this.vector_1[4U] = this.method_1(vector_2, 4U);
		this.vector_1[5U] = ((vector_2[8U] & 255U) | (vector_2[9U] << 8 & 65280U));
		this.vector_1[6U] = 0U;
		this.vector_1[7U] = 0U;
		this.vector_1[8U] = 0U;
		this.vector_1[9U] = 28672U;
		for (int i = 0; i < 36; i++)
		{
			uint num = (this.vector_1[2U] << 30 | (uint)U.smethod_1(this.vector_1[1U], 2)) ^ (this.vector_1[2U] << 3 | (uint)U.smethod_1(this.vector_1[1U], 29));
			uint num2 = (this.vector_1[5U] << 27 | (uint)U.smethod_1(this.vector_1[4U], 5)) ^ (this.vector_1[5U] << 12 | (uint)U.smethod_1(this.vector_1[4U], 20));
			uint num3 = (this.vector_1[8U] << 30 | (uint)U.smethod_1(this.vector_1[7U], 2)) ^ (this.vector_1[9U] << 17 | (uint)U.smethod_1(this.vector_1[8U], 15));
			num ^= (((this.vector_1[2U] << 5 | (uint)U.smethod_1(this.vector_1[1U], 27)) & (this.vector_1[2U] << 4 | (uint)U.smethod_1(this.vector_1[1U], 28))) ^ (this.vector_1[5U] << 18 | (uint)U.smethod_1(this.vector_1[4U], 14)));
			num2 ^= (((this.vector_1[5U] << 14 | (uint)U.smethod_1(this.vector_1[4U], 18)) & (this.vector_1[5U] << 13 | (uint)U.smethod_1(this.vector_1[4U], 19))) ^ (this.vector_1[8U] << 9 | (uint)U.smethod_1(this.vector_1[7U], 23)));
			num3 ^= (((this.vector_1[9U] << 19 | (uint)U.smethod_1(this.vector_1[8U], 13)) & (this.vector_1[9U] << 18 | (uint)U.smethod_1(this.vector_1[8U], 14))) ^ (this.vector_1[2U] << 27 | (uint)U.smethod_1(this.vector_1[1U], 5)));
			this.vector_1[2U] = this.vector_1[1U];
			this.vector_1[1U] = this.vector_1[0U];
			this.vector_1[0U] = num3;
			this.vector_1[5U] = this.vector_1[4U];
			this.vector_1[4U] = this.vector_1[3U];
			this.vector_1[3U] = num;
			this.vector_1[9U] = this.vector_1[8U];
			this.vector_1[8U] = this.vector_1[7U];
			this.vector_1[7U] = this.vector_1[6U];
			this.vector_1[6U] = num2;
		}
	}

	private uint method_1(Vector<uint> vector_2, uint uint_2)
	{
		return vector_2[uint_2 + 3U] << 24 | (vector_2[uint_2 + 2U] & 255U) << 16 | (vector_2[uint_2 + 1U] & 255U) << 8 | (vector_2[uint_2] & 255U);
	}

	private uint method_2()
	{
		uint num = (this.vector_1[2U] << 30 | (uint)U.smethod_1(this.vector_1[1U], 2)) ^ (this.vector_1[2U] << 3 | (uint)U.smethod_1(this.vector_1[1U], 29));
		uint num2 = (this.vector_1[5U] << 27 | (uint)U.smethod_1(this.vector_1[4U], 5)) ^ (this.vector_1[5U] << 12 | (uint)U.smethod_1(this.vector_1[4U], 20));
		uint num3 = (this.vector_1[8U] << 30 | (uint)U.smethod_1(this.vector_1[7U], 2)) ^ (this.vector_1[9U] << 17 | (uint)U.smethod_1(this.vector_1[8U], 15));
		uint result = num ^ num2 ^ num3;
		num ^= (((this.vector_1[2U] << 5 | (uint)U.smethod_1(this.vector_1[1U], 27)) & (this.vector_1[2U] << 4 | (uint)U.smethod_1(this.vector_1[1U], 28))) ^ (this.vector_1[5U] << 18 | (uint)U.smethod_1(this.vector_1[4U], 14)));
		num2 ^= (((this.vector_1[5U] << 14 | (uint)U.smethod_1(this.vector_1[4U], 18)) & (this.vector_1[5U] << 13 | (uint)U.smethod_1(this.vector_1[4U], 19))) ^ (this.vector_1[8U] << 9 | (uint)U.smethod_1(this.vector_1[7U], 23)));
		num3 ^= (((this.vector_1[9U] << 19 | (uint)U.smethod_1(this.vector_1[8U], 13)) & (this.vector_1[9U] << 18 | (uint)U.smethod_1(this.vector_1[8U], 14))) ^ (this.vector_1[2U] << 27 | (uint)U.smethod_1(this.vector_1[1U], 5)));
		this.vector_1[2U] = this.vector_1[1U];
		this.vector_1[1U] = this.vector_1[0U];
		this.vector_1[0U] = num3;
		this.vector_1[5U] = this.vector_1[4U];
		this.vector_1[4U] = this.vector_1[3U];
		this.vector_1[3U] = num;
		this.vector_1[9U] = this.vector_1[8U];
		this.vector_1[8U] = this.vector_1[7U];
		this.vector_1[7U] = this.vector_1[6U];
		this.vector_1[6U] = num2;
		return result;
	}

	public GClass803(Vector<uint> vector_2, Vector<uint> vector_3)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.vector_1 = new Vector<uint>(10);
		if (vector_2 != null)
		{
			if (vector_2.Length == 10)
			{
				if (vector_3 != null)
				{
					if (vector_3.Length == 10)
					{
						this.vector_0 = vector_2;
						this.method_0(vector_3);
						return;
					}
				}
				return;
			}
		}
	}

	public virtual void vmethod_0(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < int_1; i++)
		{
			if (this.uint_1 == 0U)
			{
				this.uint_0 = this.method_2();
				this.uint_1 = 4U;
			}
			byte_0[i + int_0] = (byte)(((uint)byte_0[i + int_0] ^ this.uint_0) & 255U);
			this.uint_0 >>= 8;
			this.uint_1 -= 1U;
		}
	}

	private uint uint_0;

	private uint uint_1;

	private Vector<uint> vector_0;

	private Vector<uint> vector_1;
}

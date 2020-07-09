using System;
using DarkorbitAPI.CommonStructures;

public class GClass870
{
	public GClass870(Vector<uint> vector_5, Vector<uint> vector_6)
	{
		Class13.lOBHd9Nzn7x2T();
		this.uint_1 = 4U;
		base..ctor();
		if (vector_5 != null)
		{
			if (vector_5.Length == 12)
			{
				if (vector_6 == null)
				{
					return;
				}
				this.vector_3 = new Vector<uint>(4);
				this.vector_4 = new Vector<uint>(4);
				this.vector_2 = new Vector<uint>(4);
				uint length = (uint)vector_6.Length;
				this.vector_0 = new Vector<uint>((int)length);
				this.vector_1 = new Vector<uint>((int)length);
				for (int i = 0; i < vector_5.Length; i++)
				{
					this.vector_1[i] = vector_5[i];
				}
				int num = 0;
				while ((long)num < (long)((ulong)length))
				{
					this.vector_0[num] = vector_6[num];
					num++;
				}
				this.method_5(this.vector_0, this.vector_1);
				this.method_0();
				return;
			}
		}
	}

	private void method_0()
	{
		for (int i = 0; i < 8; i++)
		{
			this.uint_0 = this.method_1();
			this.vector_4 = this.method_2(this.vector_4, this.method_3() ^ this.vector_3[0U] ^ this.uint_0);
			this.vector_3 = this.method_2(this.vector_3, this.method_4() ^ this.uint_0);
		}
		this.bool_0 = true;
	}

	private uint method_1()
	{
		uint num = (uint)(U.smethod_2(this.vector_4[0U], 2) | (int)((int)this.vector_4[1U] << 30));
		uint num2 = (uint)(U.smethod_2(this.vector_4[0U], 12) | (int)((int)this.vector_4[1U] << 20));
		uint num3 = (uint)(U.smethod_2(this.vector_4[0U], 15) | (int)((int)this.vector_4[1U] << 17));
		uint num4 = (uint)(U.smethod_2(this.vector_4[1U], 4) | (int)((int)this.vector_4[2U] << 28));
		uint num5 = (uint)(U.smethod_2(this.vector_4[1U], 13) | (int)((int)this.vector_4[2U] << 19));
		uint num6 = this.vector_4[2U];
		uint num7 = (uint)(U.smethod_2(this.vector_4[2U], 9) | (int)((int)this.vector_4[3U] << 23));
		uint num8 = (uint)(U.smethod_2(this.vector_4[2U], 25) | (int)((int)this.vector_4[3U] << 7));
		uint num9 = (uint)(U.smethod_2(this.vector_4[2U], 31) | (int)((int)this.vector_4[3U] << 1));
		uint num10 = (uint)(U.smethod_2(this.vector_3[0U], 8) | (int)((int)this.vector_3[1U] << 24));
		uint num11 = (uint)(U.smethod_2(this.vector_3[0U], 13) | (int)((int)this.vector_3[1U] << 19));
		uint num12 = (uint)(U.smethod_2(this.vector_3[0U], 20) | (int)((int)this.vector_3[1U] << 12));
		uint num13 = (uint)(U.smethod_2(this.vector_3[1U], 10) | (int)((int)this.vector_3[2U] << 22));
		uint num14 = (uint)(U.smethod_2(this.vector_3[1U], 28) | (int)((int)this.vector_3[2U] << 4));
		uint num15 = (uint)(U.smethod_2(this.vector_3[2U], 15) | (int)((int)this.vector_3[3U] << 17));
		uint num16 = (uint)(U.smethod_2(this.vector_3[2U], 29) | (int)((int)this.vector_3[3U] << 3));
		uint num17 = (uint)(U.smethod_2(this.vector_3[2U], 31) | (int)((int)this.vector_3[3U] << 1));
		return (num2 & num10) ^ (num11 & num12) ^ (num9 & num13) ^ (num14 & num15) ^ (num2 & num9 & num17) ^ num16 ^ num ^ num3 ^ num4 ^ num5 ^ num6 ^ num7 ^ num8;
	}

	private Vector<uint> method_2(Vector<uint> vector_5, uint uint_2)
	{
		vector_5[0U] = vector_5[1U];
		vector_5[1U] = vector_5[2U];
		vector_5[2U] = vector_5[3U];
		vector_5[3U] = uint_2;
		return vector_5;
	}

	private uint method_3()
	{
		uint num = this.vector_4[0U];
		uint num2 = (uint)(U.smethod_2(this.vector_4[0U], 3) | (int)((int)this.vector_4[1U] << 29));
		uint num3 = (uint)(U.smethod_2(this.vector_4[0U], 11) | (int)((int)this.vector_4[1U] << 21));
		uint num4 = (uint)(U.smethod_2(this.vector_4[0U], 13) | (int)((int)this.vector_4[1U] << 19));
		uint num5 = (uint)(U.smethod_2(this.vector_4[0U], 17) | (int)((int)this.vector_4[1U] << 15));
		uint num6 = (uint)(U.smethod_2(this.vector_4[0U], 18) | (int)((int)this.vector_4[1U] << 14));
		uint num7 = (uint)(U.smethod_2(this.vector_4[0U], 26) | (int)((int)this.vector_4[1U] << 6));
		uint num8 = (uint)(U.smethod_2(this.vector_4[0U], 27) | (int)((int)this.vector_4[1U] << 5));
		uint num9 = (uint)(U.smethod_2(this.vector_4[1U], 8) | (int)((int)this.vector_4[2U] << 24));
		uint num10 = (uint)(U.smethod_2(this.vector_4[1U], 16) | (int)((int)this.vector_4[2U] << 16));
		uint num11 = (uint)(U.smethod_2(this.vector_4[1U], 24) | (int)((int)this.vector_4[2U] << 8));
		uint num12 = (uint)(U.smethod_2(this.vector_4[1U], 27) | (int)((int)this.vector_4[2U] << 5));
		uint num13 = (uint)(U.smethod_2(this.vector_4[1U], 29) | (int)((int)this.vector_4[2U] << 3));
		uint num14 = (uint)(U.smethod_2(this.vector_4[2U], 1) | (int)((int)this.vector_4[3U] << 31));
		uint num15 = (uint)(U.smethod_2(this.vector_4[2U], 3) | (int)((int)this.vector_4[3U] << 29));
		uint num16 = (uint)(U.smethod_2(this.vector_4[2U], 4) | (int)((int)this.vector_4[3U] << 28));
		uint num17 = (uint)(U.smethod_2(this.vector_4[2U], 20) | (int)((int)this.vector_4[3U] << 12));
		uint num18 = (uint)(U.smethod_2(this.vector_4[2U], 27) | (int)((int)this.vector_4[3U] << 5));
		uint num19 = this.vector_4[3U];
		return num ^ num7 ^ num11 ^ num18 ^ num19 ^ (num2 & num15) ^ (num3 & num4) ^ (num5 & num6) ^ (num8 & num12) ^ (num9 & num10) ^ (num13 & num14) ^ (num16 & num17);
	}

	private uint method_4()
	{
		uint num = this.vector_3[0U];
		uint num2 = (uint)(U.smethod_2(this.vector_3[0U], 7) | (int)((int)this.vector_3[1U] << 25));
		uint num3 = (uint)(U.smethod_2(this.vector_3[1U], 6) | (int)((int)this.vector_3[2U] << 26));
		uint num4 = (uint)(U.smethod_2(this.vector_3[2U], 6) | (int)((int)this.vector_3[3U] << 26));
		uint num5 = (uint)(U.smethod_2(this.vector_3[2U], 17) | (int)((int)this.vector_3[3U] << 15));
		uint num6 = this.vector_3[3U];
		return num ^ num2 ^ num3 ^ num4 ^ num5 ^ num6;
	}

	private void method_5(Vector<uint> vector_5, Vector<uint> vector_6)
	{
		vector_6[12U] = 255U;
		vector_6[13U] = 255U;
		vector_6[14U] = 255U;
		vector_6[15U] = 255U;
		this.vector_0 = vector_5;
		this.vector_1 = vector_6;
		uint num = 0U;
		uint length = (uint)this.vector_4.Length;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)length))
		{
			this.vector_4[num2] = (this.vector_0[num + 3U] << 24 | (this.vector_0[num + 2U] << 16 & 16711680U) | (this.vector_0[num + 1U] << 8 & 65280U) | (this.vector_0[num] & 255U));
			this.vector_3[num2] = (this.vector_1[num + 3U] << 24 | (this.vector_1[num + 2U] << 16 & 16711680U) | (this.vector_1[num + 1U] << 8 & 65280U) | (this.vector_1[num] & 255U));
			num += 4U;
			num2++;
		}
	}

	public virtual void vmethod_0(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < int_1; i++)
		{
			byte_0[i + int_0] = (byte)(((uint)byte_0[i + int_0] ^ this.method_6()) & 255U);
		}
	}

	private uint method_6()
	{
		if (this.uint_1 > 3U)
		{
			this.method_7();
			this.uint_1 = 0U;
		}
		Vector<uint> vector = this.vector_2;
		uint num = this.uint_1;
		this.uint_1 = num + 1U;
		return vector[num];
	}

	private void method_7()
	{
		this.uint_0 = this.method_1();
		this.vector_2[0U] = this.uint_0;
		this.vector_2[1U] = this.uint_0 >> 8;
		this.vector_2[2U] = this.uint_0 >> 16;
		this.vector_2[3U] = this.uint_0 >> 24;
		this.vector_4 = this.method_2(this.vector_4, this.method_3() ^ this.vector_3[0U]);
		this.vector_3 = this.method_2(this.vector_3, this.method_4());
	}

	private Vector<uint> vector_0;

	private Vector<uint> vector_1;

	private Vector<uint> vector_2;

	private Vector<uint> vector_3;

	private Vector<uint> vector_4;

	private uint uint_0;

	private uint uint_1;

	private bool bool_0;
}

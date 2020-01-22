using System;
using DarkorbitAPI.CommonStructures;

public class GClass800
{
	public GClass800(Vector<uint> vector_6, Vector<uint> vector_7)
	{
		Class13.plZSWFPzBWWEZ();
		this.YyHqywmrQmj = 16U;
		base..ctor();
		this.vector_1 = new Vector<uint>((int)this.YyHqywmrQmj);
		this.vector_2 = new Vector<uint>((int)this.YyHqywmrQmj);
		this.vector_3 = new Vector<uint>((int)((int)this.YyHqywmrQmj << 2));
		this.method_0(vector_7, vector_6);
	}

	protected void method_0(Vector<uint> vector_6, Vector<uint> vector_7)
	{
		this.vector_5 = vector_7;
		this.vector_4 = vector_6;
		this.method_5();
		this.vector_1[1U] = this.method_3(vector_6, 0U);
		this.vector_1[2U] = this.method_3(vector_6, 4U);
		this.vector_1[3U] = this.method_3(vector_6, 8U);
		this.vector_1[4U] = this.method_3(vector_6, 12U);
		Vector<uint> vector_8 = GClass800.vector_0;
		this.vector_1[11U] = this.method_3(vector_6, 16U);
		this.vector_1[12U] = this.method_3(vector_6, 20U);
		this.vector_1[13U] = this.method_3(vector_6, 24U);
		this.vector_1[14U] = this.method_3(vector_6, 28U);
		this.vector_1[0U] = this.method_3(vector_8, 0U);
		this.vector_1[5U] = this.method_3(vector_8, 4U);
		this.vector_1[10U] = this.method_3(vector_8, 8U);
		this.vector_1[15U] = this.method_3(vector_8, 12U);
		this.vector_1[6U] = this.method_3(vector_7, 0U);
		this.vector_1[7U] = this.method_3(vector_7, 4U);
		this.vector_1[9U] = 0U;
		this.vector_1[8U] = 0U;
	}

	private void method_1(Vector<uint> vector_6, Vector<uint> vector_7)
	{
		this.method_6(vector_6, 0U, this.vector_2, 0U, (uint)vector_6.Length);
		uint num = 10U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)num))
		{
			this.vector_2[4U] = (this.vector_2[4U] ^ this.method_2(this.vector_2[0U] + this.vector_2[12U], 7U));
			this.vector_2[8U] = (this.vector_2[8U] ^ this.method_2(this.vector_2[4U] + this.vector_2[0U], 9U));
			this.vector_2[12U] = (this.vector_2[12U] ^ this.method_2(this.vector_2[8U] + this.vector_2[4U], 13U));
			this.vector_2[0U] = (this.vector_2[0U] ^ this.method_2(this.vector_2[12U] + this.vector_2[8U], 18U));
			this.vector_2[9U] = (this.vector_2[9U] ^ this.method_2(this.vector_2[5U] + this.vector_2[1U], 7U));
			this.vector_2[13U] = (this.vector_2[13U] ^ this.method_2(this.vector_2[9U] + this.vector_2[5U], 9U));
			this.vector_2[1U] = (this.vector_2[1U] ^ this.method_2(this.vector_2[13U] + this.vector_2[9U], 13U));
			this.vector_2[5U] = (this.vector_2[5U] ^ this.method_2(this.vector_2[1U] + this.vector_2[13U], 18U));
			this.vector_2[14U] = (this.vector_2[14U] ^ this.method_2(this.vector_2[10U] + this.vector_2[6U], 7U));
			this.vector_2[2U] = (this.vector_2[2U] ^ this.method_2(this.vector_2[14U] + this.vector_2[10U], 9U));
			this.vector_2[6U] = (this.vector_2[6U] ^ this.method_2(this.vector_2[2U] + this.vector_2[14U], 13U));
			this.vector_2[10U] = (this.vector_2[10U] ^ this.method_2(this.vector_2[6U] + this.vector_2[2U], 18U));
			this.vector_2[3U] = (this.vector_2[3U] ^ this.method_2(this.vector_2[15U] + this.vector_2[11U], 7U));
			this.vector_2[7U] = (this.vector_2[7U] ^ this.method_2(this.vector_2[3U] + this.vector_2[15U], 9U));
			this.vector_2[11U] = (this.vector_2[11U] ^ this.method_2(this.vector_2[7U] + this.vector_2[3U], 13U));
			this.vector_2[15U] = (this.vector_2[15U] ^ this.method_2(this.vector_2[11U] + this.vector_2[7U], 18U));
			this.vector_2[1U] = (this.vector_2[1U] ^ this.method_2(this.vector_2[0U] + this.vector_2[3U], 7U));
			this.vector_2[2U] = (this.vector_2[2U] ^ this.method_2(this.vector_2[1U] + this.vector_2[0U], 9U));
			this.vector_2[3U] = (this.vector_2[3U] ^ this.method_2(this.vector_2[2U] + this.vector_2[1U], 13U));
			this.vector_2[0U] = (this.vector_2[0U] ^ this.method_2(this.vector_2[3U] + this.vector_2[2U], 18U));
			this.vector_2[6U] = (this.vector_2[6U] ^ this.method_2(this.vector_2[5U] + this.vector_2[4U], 7U));
			this.vector_2[7U] = (this.vector_2[7U] ^ this.method_2(this.vector_2[6U] + this.vector_2[5U], 9U));
			this.vector_2[4U] = (this.vector_2[4U] ^ this.method_2(this.vector_2[7U] + this.vector_2[6U], 13U));
			this.vector_2[5U] = (this.vector_2[5U] ^ this.method_2(this.vector_2[4U] + this.vector_2[7U], 18U));
			this.vector_2[11U] = (this.vector_2[11U] ^ this.method_2(this.vector_2[10U] + this.vector_2[9U], 7U));
			this.vector_2[8U] = (this.vector_2[8U] ^ this.method_2(this.vector_2[11U] + this.vector_2[10U], 9U));
			this.vector_2[9U] = (this.vector_2[9U] ^ this.method_2(this.vector_2[8U] + this.vector_2[11U], 13U));
			this.vector_2[10U] = (this.vector_2[10U] ^ this.method_2(this.vector_2[9U] + this.vector_2[8U], 18U));
			this.vector_2[12U] = (this.vector_2[12U] ^ this.method_2(this.vector_2[15U] + this.vector_2[14U], 7U));
			this.vector_2[13U] = (this.vector_2[13U] ^ this.method_2(this.vector_2[12U] + this.vector_2[15U], 9U));
			this.vector_2[14U] = (this.vector_2[14U] ^ this.method_2(this.vector_2[13U] + this.vector_2[12U], 13U));
			this.vector_2[15U] = (this.vector_2[15U] ^ this.method_2(this.vector_2[14U] + this.vector_2[13U], 18U));
			num2++;
		}
		uint num3 = 0U;
		for (uint num4 = 0U; num4 < this.YyHqywmrQmj; num4 += 1U)
		{
			this.method_4(this.vector_2[num4] + vector_6[num4], vector_7, num3);
			num3 += 4U;
		}
		uint num5 = this.YyHqywmrQmj;
		while ((ulong)num5 < (ulong)((long)this.vector_2.Length))
		{
			this.method_4(this.vector_2[num5], vector_7, num3);
			num3 += 4U;
			num5 += 1U;
		}
	}

	private uint method_2(uint uint_4, uint uint_5)
	{
		return uint_4 << (int)uint_5 | (uint)U.smethod_1(uint_4, (int)(-(int)uint_5));
	}

	private uint method_3(Vector<uint> vector_6, uint uint_4)
	{
		return (vector_6[uint_4] & 255U) | (vector_6[uint_4 + 1U] & 255U) << 8 | (vector_6[uint_4 + 2U] & 255U) << 16 | vector_6[uint_4 + 3U] << 24;
	}

	private Vector<uint> method_4(uint uint_4, Vector<uint> vector_6, uint uint_5 = 0U)
	{
		vector_6[uint_5] = (uint_4 & 255U);
		vector_6[uint_5 + 1U] = (uint)(U.smethod_1(uint_4, 8) & 255);
		vector_6[uint_5 + 2U] = (uint)(U.smethod_1(uint_4, 16) & 255);
		vector_6[uint_5 + 3U] = (uint)(U.smethod_1(uint_4, 24) & 255);
		return vector_6;
	}

	private void method_5()
	{
		this.uint_1 = 0U;
		this.uint_2 = 0U;
		this.uint_3 = 0U;
	}

	public virtual void vmethod_0(byte[] byte_0, int int_0, int int_1)
	{
		for (int i = 0; i < int_1; i++)
		{
			if (this.uint_0 == 0U)
			{
				this.method_1(this.vector_1, this.vector_3);
				Vector<uint> vector = this.vector_1;
				uint num = vector[8U];
				vector[8U] = num + 1U;
				if (this.vector_1[8U] == 0U)
				{
					Vector<uint> vector2 = this.vector_1;
					num = vector2[9U];
					vector2[9U] = num + 1U;
				}
			}
			byte_0[i + int_0] = (byte)(((uint)byte_0[i + int_0] ^ this.vector_3[this.uint_0]) & 255U);
			this.uint_0 = (this.uint_0 + 1U & 63U);
		}
	}

	private void method_6(Vector<uint> vector_6, uint uint_4, Vector<uint> vector_7, uint uint_5, uint uint_6)
	{
		uint num = uint_5;
		uint num2 = uint_6 + uint_4;
		for (uint num3 = uint_4; num3 < num2; num3 += 1U)
		{
			vector_7[num] = vector_6[num3];
			num += 1U;
		}
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass800()
	{
		Class13.plZSWFPzBWWEZ();
		GClass800.vector_0 = new Vector<uint>
		{
			35U,
			185U,
			189U,
			33U,
			149U,
			10U,
			12U,
			45U,
			132U,
			146U,
			47U,
			208U,
			233U,
			161U,
			234U,
			164U
		};
	}

	public static readonly Vector<uint> vector_0;

	private uint YyHqywmrQmj;

	private uint uint_0;

	private Vector<uint> vector_1;

	private Vector<uint> vector_2;

	private Vector<uint> vector_3;

	private Vector<uint> vector_4;

	private Vector<uint> vector_5;

	private uint uint_1;

	private uint uint_2;

	private uint uint_3;
}

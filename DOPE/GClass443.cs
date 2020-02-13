using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass443 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15112;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass443(uint uint_1 = 0U, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_2 = int_4;
		this.int_3 = int_5;
		this.int_1 = int_6;
		this.int_0 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 15112;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 6) | this.int_3 << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(15112);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_3(this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_3(this.int_3 << 6 | U.smethod_0(this.int_3, 26));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public uint uint_0;

	public int int_3;
}

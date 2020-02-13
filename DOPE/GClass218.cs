using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass218 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25650;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass218(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_4;
		this.int_3 = int_5;
		this.int_0 = int_6;
		this.int_2 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 25650;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 4) | this.int_2 << 28);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 3) | this.int_3 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25650);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_3(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_6(29588);
		binaryStream_0.smethod_6(15992);
		binaryStream_0.smethod_3(this.int_2 << 4 | U.smethod_0(this.int_2, 28));
		binaryStream_0.smethod_3(this.int_3 << 3 | U.smethod_0(this.int_3, 29));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}

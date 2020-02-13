using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass701 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21434;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass701(int int_2 = 0, int int_3 = 0, double double_1 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 21434;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_9();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(21434);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_8(this.double_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_6(-30159);
		binaryStream_0.smethod_3(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
	}

	public double double_0;

	public int int_0;

	public int int_1;
}

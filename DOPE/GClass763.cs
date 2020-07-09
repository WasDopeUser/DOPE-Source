using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass763 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11381;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass763(int int_2 = 0, int int_3 = 0, int int_4 = 0, double double_1 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.lHxigOdjPc = int_4;
		this.int_0 = int_3;
		this.double_0 = double_1;
		this.int_1 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 11381;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.lHxigOdjPc = binaryStream_0.smethod_0();
		this.lHxigOdjPc = (U.smethod_0(this.lHxigOdjPc, 12) | this.lHxigOdjPc << 20);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11381);
		binaryStream_0.smethod_4(this.lHxigOdjPc << 12 | U.smethod_0(this.lHxigOdjPc, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
	}

	public int lHxigOdjPc;

	public int int_0;

	public double double_0;

	public int int_1;
}

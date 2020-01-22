using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass703 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14197;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass703(int int_3 = 0, int int_4 = 0, int int_5 = 0, double double_1 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 14197;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14197);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_4(this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		binaryStream_0.smethod_7(29732);
	}

	public int int_0;

	public double double_0;

	public int int_1;

	public int int_2;
}

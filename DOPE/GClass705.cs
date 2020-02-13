using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass705 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7613;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass705(int int_3 = 0, int int_4 = 0, int int_5 = 0, double double_1 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.int_0 = int_5;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 7613;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.double_0 = (double)binaryStream_0.smethod_9();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(7613);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_8(this.double_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_3(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
	}

	public int int_0;

	public double double_0;

	public int int_1;

	public int int_2;
}

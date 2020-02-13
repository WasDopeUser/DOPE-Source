using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass706 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5677;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass706(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 5677;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 14) | this.int_2 << 18);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(5677);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_3(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_3(this.int_2 << 14 | U.smethod_0(this.int_2, 18));
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

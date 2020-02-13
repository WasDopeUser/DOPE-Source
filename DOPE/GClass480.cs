using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass480 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11199;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass480(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 11199;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 10 | U.smethod_0(this.int_2, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(11199);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_3(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.smethod_6(1694);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 10) | this.int_2 << 22);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

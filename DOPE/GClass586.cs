using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass586 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -30023;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass586(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_6;
		this.Color = int_5;
		this.int_1 = int_3;
		this.int_2 = int_4;
	}

	public virtual int vmethod_0()
	{
		return -30023;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.Color = binaryStream_0.smethod_0();
		this.Color = (this.Color << 15 | U.smethod_0(this.Color, 17));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 16 | U.smethod_0(this.int_2, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-30023);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_4(U.smethod_0(this.Color, 15) | this.Color << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 16) | this.int_2 << 16);
	}

	public int int_0;

	public int Color;

	public int int_1;

	public int int_2;
}

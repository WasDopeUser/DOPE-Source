using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass691 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13012;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass691(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.Color = int_5;
		this.int_0 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 13012;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		this.Color = binaryStream_0.smethod_0();
		this.Color = (this.Color << 3 | U.smethod_0(this.Color, 29));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13012);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.Color, 3) | this.Color << 29);
		binaryStream_0.smethod_7(9870);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int Color;
}

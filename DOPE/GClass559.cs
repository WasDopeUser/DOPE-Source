using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass559 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11491;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass559(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.Color = int_5;
		this.int_0 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 11491;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		this.Color = binaryStream_0.smethod_0();
		this.Color = (this.Color << 6 | U.smethod_0(this.Color, 26));
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 2 | U.smethod_0(this.int_2, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11491);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.Color, 6) | this.Color << 26);
		binaryStream_0.smethod_7(4563);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 2) | this.int_2 << 30);
	}

	public int int_0;

	public int int_1;

	public int Color;

	public int int_2;
}

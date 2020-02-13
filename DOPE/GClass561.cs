using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass561 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5180;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass561(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.Color = int_5;
		this.int_0 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 5180;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		this.Color = binaryStream_0.smethod_0();
		this.Color = (U.smethod_0(this.Color, 4) | this.Color << 28);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(5180);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_3(this.Color << 4 | U.smethod_0(this.Color, 28));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		binaryStream_0.smethod_6(9579);
	}

	public int int_0;

	public int Color;

	public int int_1;

	public int int_2;
}

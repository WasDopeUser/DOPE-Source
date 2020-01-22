using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass690 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1921;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass690(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.Color = int_5;
		this.int_2 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 1921;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.Color = binaryStream_0.smethod_0();
		this.Color = (this.Color << 8 | U.smethod_0(this.Color, 24));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 4 | U.smethod_0(this.int_2, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1921);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.Color, 8) | this.Color << 24);
		binaryStream_0.smethod_7(-19503);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 4) | this.int_2 << 28);
	}

	public int int_0;

	public int Color;

	public int int_1;

	public int int_2;
}

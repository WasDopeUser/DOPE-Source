using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass747 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21005;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass747(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Color = int_5;
		this.int_0 = int_4;
		this.int_1 = int_6;
		this.int_2 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 21005;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Color = binaryStream_0.smethod_0();
		this.Color = (U.smethod_0(this.Color, 8) | this.Color << 24);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21005);
		binaryStream_0.smethod_4(this.Color << 8 | U.smethod_0(this.Color, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
	}

	public int Color;

	public int int_0;

	public int int_1;

	public int int_2;
}

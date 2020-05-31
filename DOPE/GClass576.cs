using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass576 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3526;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass576(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.Color = int_5;
		this.int_1 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 3526;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Color = binaryStream_0.smethod_0();
		this.Color = (U.smethod_0(this.Color, 4) | this.Color << 28);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3526);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.Color << 4 | U.smethod_0(this.Color, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_4(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
	}

	public int Color;

	public int int_0;

	public int int_1;

	public int int_2;
}

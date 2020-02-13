using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass692 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32044;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass692(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.Color = int_5;
		this.int_2 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 32044;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.Color = binaryStream_0.smethod_0();
		this.Color = (this.Color << 14 | U.smethod_0(this.Color, 18));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 6 | U.smethod_0(this.int_2, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(32044);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_3(U.smethod_0(this.Color, 14) | this.Color << 18);
		binaryStream_0.smethod_6(10178);
		binaryStream_0.smethod_6(-21705);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 6) | this.int_2 << 26);
	}

	public int int_0;

	public int int_1;

	public int Color;

	public int int_2;
}

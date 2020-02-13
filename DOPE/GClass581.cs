using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass581 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12386;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass581(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.int_0 = int_7;
		this.int_4 = int_8;
		this.int_3 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 12386;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 4 | U.smethod_0(this.int_3, 28));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 12 | U.smethod_0(this.int_4, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(12386);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_3(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 4) | this.int_3 << 28);
		binaryStream_0.smethod_3(U.smethod_0(this.int_4, 12) | this.int_4 << 20);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}

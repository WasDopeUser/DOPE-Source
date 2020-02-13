using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass444 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9920;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass444(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 9920;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 15 | U.smethod_0(this.int_2, 17));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9920);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_3(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 15) | this.int_2 << 17);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

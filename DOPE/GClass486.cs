using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass486 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20514;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass486(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 20514;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 15) | this.int_2 << 17);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20514);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-4831);
		binaryStream_0.smethod_7(23472);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_4(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.smethod_4(this.int_2 << 15 | U.smethod_0(this.int_2, 17));
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

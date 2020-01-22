using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass734 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1076;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass734(int int_2 = 0, int int_3 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 1076;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1076);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_7(-10077);
		binaryStream_0.smethod_4(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
	}

	public int int_0;

	public int int_1;
}

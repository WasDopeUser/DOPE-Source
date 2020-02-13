using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass362 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25324;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass362(uint uint_1 = 0U, int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 25324;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25324);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_6(-32489);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_5(this.uint_0);
	}

	public int int_0;

	public int int_1;

	public uint uint_0;
}

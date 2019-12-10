using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass771 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4475;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass771(GClass372 gclass372_1 = null, int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass372_1 == null)
		{
			this.gclass372_0 = new GClass372();
		}
		else
		{
			this.gclass372_0 = gclass372_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 4475;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.gclass372_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass372);
		this.gclass372_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(4475);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(5714);
		binaryStream_0.fUeiimuocMk(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.gclass372_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(28433);
	}

	public int int_0;

	public GClass372 gclass372_0;
}

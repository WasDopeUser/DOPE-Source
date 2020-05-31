using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass431 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1474;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass431(uint uint_1 = 0U, GClass325 gclass325_1 = null, int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass325_1 == null)
		{
			this.gclass325_0 = new GClass325(0U);
		}
		else
		{
			this.gclass325_0 = gclass325_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 1474;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass325_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass325);
		this.gclass325_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1474);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(13557);
		this.gclass325_0.imethod_1(binaryStream_0);
	}

	public int int_0;

	public uint uint_0;

	public GClass325 gclass325_0;
}

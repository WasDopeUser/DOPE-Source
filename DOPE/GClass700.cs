using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass700 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25354;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass700(GClass692 gclass692_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass692_1 == null)
		{
			this.gclass692_0 = new GClass692();
		}
		else
		{
			this.gclass692_0 = gclass692_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 25354;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.gclass692_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass692);
		this.gclass692_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25354);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-17795);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.gclass692_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
	}

	public int int_0;

	public GClass692 gclass692_0;

	public int int_1;
}

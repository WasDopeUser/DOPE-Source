using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass414 : GClass407, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -31248;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass414(int int_1 = 0, GClass366 gclass366_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_1;
		if (gclass366_1 == null)
		{
			this.gclass366_0 = new GClass366(false);
			return;
		}
		this.gclass366_0 = gclass366_1;
	}

	public override int vmethod_0()
	{
		return -31248;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.gclass366_0 = (GClass366)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass366_0 != null)
		{
			this.gclass366_0.imethod_1(binaryStream_0);
		}
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-31248);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		if (this.gclass366_0 != null)
		{
			this.gclass366_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public GClass366 gclass366_0;
}

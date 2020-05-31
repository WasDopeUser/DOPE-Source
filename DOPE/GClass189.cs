using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass189 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26376;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass189(int int_1 = 0, GClass190 gclass190_1 = null, GClass332 gclass332_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_0 = int_1;
		if (gclass190_1 == null)
		{
			this.gclass190_0 = new GClass190(0.0, 0.0);
		}
		else
		{
			this.gclass190_0 = gclass190_1;
		}
		if (gclass332_1 == null)
		{
			this.gclass332_0 = new GClass332(null, null);
			return;
		}
		this.gclass332_0 = gclass332_1;
	}

	public virtual int vmethod_0()
	{
		return 26376;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.gclass190_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass190);
		this.gclass190_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass332_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass332);
		this.gclass332_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26376);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.gclass190_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-3638);
		this.gclass332_0.imethod_1(binaryStream_0);
	}

	public int int_0;

	public GClass190 gclass190_0;

	public GClass332 gclass332_0;
}

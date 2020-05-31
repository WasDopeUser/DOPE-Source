using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass637 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32662;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass637(GClass776 gclass776_1 = null, GClass325 gclass325_1 = null, int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass776_1 == null)
		{
			this.gclass776_0 = new GClass776(0U);
		}
		else
		{
			this.gclass776_0 = gclass776_1;
		}
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
		return 32662;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.gclass325_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass325);
		this.gclass325_0.HrqIugnatr8(binaryStream_0);
		this.gclass776_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass776);
		this.gclass776_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32662);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12149);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.gclass325_0.imethod_1(binaryStream_0);
		this.gclass776_0.imethod_1(binaryStream_0);
	}

	public int int_0;

	public GClass325 gclass325_0;

	public GClass776 gclass776_0;
}

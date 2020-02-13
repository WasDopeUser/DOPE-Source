using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass639 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1980;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass639(GClass632 gclass632_1 = null, string string_1 = "", GClass582 gclass582_1 = null, GClass482 gclass482_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		if (gclass632_1 == null)
		{
			this.gclass632_0 = new GClass632(0U);
		}
		else
		{
			this.gclass632_0 = gclass632_1;
		}
		this.string_0 = string_1;
		if (gclass582_1 == null)
		{
			this.gclass582_0 = new GClass582(0U);
		}
		else
		{
			this.gclass582_0 = gclass582_1;
		}
		if (gclass482_1 == null)
		{
			this.gclass482_0 = new GClass482(false, 0);
			return;
		}
		this.gclass482_0 = gclass482_1;
	}

	public virtual int vmethod_0()
	{
		return 1980;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass582_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass582);
		this.gclass582_0.imethod_1(binaryStream_0);
		this.gclass482_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass482);
		this.gclass482_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass632_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass632);
		this.gclass632_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(1980);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-18369);
		binaryStream_0.smethod_6(28618);
		this.gclass582_0.imethod_2(binaryStream_0);
		this.gclass482_0.imethod_2(binaryStream_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		this.gclass632_0.imethod_2(binaryStream_0);
	}

	public GClass582 gclass582_0;

	public GClass482 gclass482_0;

	public string string_0;

	public GClass632 gclass632_0;
}

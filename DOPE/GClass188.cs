using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass188 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13196;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass188(int int_0 = 0, GClass189 gclass189_1 = null, GClass325 gclass325_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.gLrdiUyUf2 = int_0;
		if (gclass189_1 == null)
		{
			this.gclass189_0 = new GClass189(0.0, 0.0);
		}
		else
		{
			this.gclass189_0 = gclass189_1;
		}
		if (gclass325_1 == null)
		{
			this.gclass325_0 = new GClass325(null, null);
			return;
		}
		this.gclass325_0 = gclass325_1;
	}

	public virtual int vmethod_0()
	{
		return 13196;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gLrdiUyUf2 = binaryStream_0.smethod_0();
		this.gLrdiUyUf2 = (U.smethod_0(this.gLrdiUyUf2, 15) | this.gLrdiUyUf2 << 17);
		binaryStream_0.smethod_1();
		this.gclass325_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass325);
		this.gclass325_0.imethod_1(binaryStream_0);
		this.gclass189_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass189);
		this.gclass189_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13196);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.gLrdiUyUf2 << 15 | U.smethod_0(this.gLrdiUyUf2, 17));
		binaryStream_0.smethod_7(-742);
		this.gclass325_0.imethod_2(binaryStream_0);
		this.gclass189_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-11446);
	}

	public int gLrdiUyUf2;

	public GClass325 gclass325_0;

	public GClass189 gclass189_0;
}

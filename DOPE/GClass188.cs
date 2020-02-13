using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass188 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16814;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass188(int int_0 = 0, GClass189 gclass189_1 = null, GClass327 gclass327_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.hfOqaBlyd3 = int_0;
		if (gclass189_1 == null)
		{
			this.gclass189_0 = new GClass189(0.0, 0.0);
		}
		else
		{
			this.gclass189_0 = gclass189_1;
		}
		if (gclass327_1 == null)
		{
			this.gclass327_0 = new GClass327(null, null);
			return;
		}
		this.gclass327_0 = gclass327_1;
	}

	public virtual int vmethod_0()
	{
		return 16814;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.hfOqaBlyd3 = binaryStream_0.smethod_0();
		this.hfOqaBlyd3 = (this.hfOqaBlyd3 << 3 | U.smethod_0(this.hfOqaBlyd3, 29));
		this.gclass189_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass189);
		this.gclass189_0.imethod_1(binaryStream_0);
		this.gclass327_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass327);
		this.gclass327_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(16814);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.hfOqaBlyd3, 3) | this.hfOqaBlyd3 << 29);
		this.gclass189_0.imethod_2(binaryStream_0);
		this.gclass327_0.imethod_2(binaryStream_0);
	}

	public int hfOqaBlyd3;

	public GClass189 gclass189_0;

	public GClass327 gclass327_0;
}

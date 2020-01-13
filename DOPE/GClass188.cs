using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass188 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25420;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass188(int int_1 = 0, GClass189 gclass189_1 = null, GClass325 gclass325_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_0 = int_1;
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
		return 25420;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass189_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass189);
		this.gclass189_0.imethod_1(binaryStream_0);
		this.gclass325_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass325);
		this.gclass325_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25420);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass189_0.imethod_2(binaryStream_0);
		this.gclass325_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
	}

	public GClass189 gclass189_0;

	public GClass325 gclass325_0;

	public int int_0;
}

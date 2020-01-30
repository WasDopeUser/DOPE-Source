using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass177 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18644;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass177(GClass175 gclass175_1 = null, GClass543 gclass543_1 = null, GClass430 gclass430_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass175_1 == null)
		{
			this.gclass175_0 = new GClass175(null);
		}
		else
		{
			this.gclass175_0 = gclass175_1;
		}
		if (gclass543_1 == null)
		{
			this.gclass543_0 = new GClass543(false, false, false, false);
		}
		else
		{
			this.gclass543_0 = gclass543_1;
		}
		if (gclass430_1 == null)
		{
			this.gclass430_0 = new GClass430(false);
			return;
		}
		this.gclass430_0 = gclass430_1;
	}

	public virtual int vmethod_0()
	{
		return 18644;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass430_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass430);
		this.gclass430_0.imethod_1(binaryStream_0);
		this.gclass543_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass543);
		this.gclass543_0.imethod_1(binaryStream_0);
		this.gclass175_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass175);
		this.gclass175_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18644);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass430_0.imethod_2(binaryStream_0);
		this.gclass543_0.imethod_2(binaryStream_0);
		this.gclass175_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(27518);
	}

	public GClass430 gclass430_0;

	public GClass543 gclass543_0;

	public GClass175 gclass175_0;
}

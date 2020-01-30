using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass176 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8602;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass176(GClass729 gclass729_1 = null, GClass582 gclass582_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass729_1 == null)
		{
			this.gclass729_0 = new GClass729(0, null);
		}
		else
		{
			this.gclass729_0 = gclass729_1;
		}
		if (gclass582_1 == null)
		{
			this.gclass582_0 = new GClass582(0, null);
			return;
		}
		this.gclass582_0 = gclass582_1;
	}

	public virtual int vmethod_0()
	{
		return 8602;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass729_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass729);
		this.gclass729_0.imethod_1(binaryStream_0);
		this.gclass582_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass582);
		this.gclass582_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8602);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass729_0.imethod_2(binaryStream_0);
		this.gclass582_0.imethod_2(binaryStream_0);
	}

	public GClass729 gclass729_0;

	public GClass582 gclass582_0;
}

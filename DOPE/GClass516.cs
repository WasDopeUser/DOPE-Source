using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass516 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28630;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass516(GClass500 gclass500_1 = null, GClass454 gclass454_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass500_1 == null)
		{
			this.gclass500_0 = new GClass500(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass500_0 = gclass500_1;
		}
		if (gclass454_1 == null)
		{
			this.gclass454_0 = new GClass454(0, null, 0U, 0U, 0.0, false, null, null);
			return;
		}
		this.gclass454_0 = gclass454_1;
	}

	public virtual int vmethod_0()
	{
		return 28630;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass454_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass454);
		this.gclass454_0.imethod_1(binaryStream_0);
		this.gclass500_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass500);
		this.gclass500_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(28630);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass454_0.imethod_2(binaryStream_0);
		this.gclass500_0.imethod_2(binaryStream_0);
	}

	public GClass454 gclass454_0;

	public GClass500 gclass500_0;
}

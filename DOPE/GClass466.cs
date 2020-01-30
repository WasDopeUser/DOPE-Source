using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass466 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14754;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass466(GClass482 gclass482_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass482_1 == null)
		{
			this.gclass482_0 = new GClass482(0, null, null, null, null, "", "");
			return;
		}
		this.gclass482_0 = gclass482_1;
	}

	public virtual int vmethod_0()
	{
		return 14754;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass482_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass482);
		this.gclass482_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14754);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass482_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(21953);
	}

	public GClass482 gclass482_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass404 : GClass402, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24733;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass404(GClass623 gclass623_2 = null, GClass623 gclass623_3 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass623_3 == null)
		{
			this.gclass623_0 = new GClass623("", 0.0);
		}
		else
		{
			this.gclass623_0 = gclass623_3;
		}
		if (gclass623_2 == null)
		{
			this.gclass623_1 = new GClass623("", 0.0);
			return;
		}
		this.gclass623_1 = gclass623_2;
	}

	public override int vmethod_0()
	{
		return 24733;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.gclass623_0 = (GClass623)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass623_0 != null)
		{
			this.gclass623_0.imethod_1(binaryStream_0);
		}
		this.gclass623_1 = (GClass623)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass623_1 != null)
		{
			this.gclass623_1.imethod_1(binaryStream_0);
		}
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24733);
		base.imethod_2(binaryStream_0);
		if (this.gclass623_0 != null)
		{
			this.gclass623_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass623_1 != null)
		{
			this.gclass623_1.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass623 gclass623_0;

	public GClass623 gclass623_1;
}

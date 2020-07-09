using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass361 : GClass360, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19743;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass361(GClass440 gclass440_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass440_1 == null)
		{
			this.gclass440_0 = new GClass440(0, "", null, null);
			return;
		}
		this.gclass440_0 = gclass440_1;
	}

	public override int vmethod_0()
	{
		return 19743;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.gclass440_0 = (GClass440)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass440_0 != null)
		{
			this.gclass440_0.imethod_1(binaryStream_0);
		}
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19743);
		base.imethod_2(binaryStream_0);
		if (this.gclass440_0 != null)
		{
			this.gclass440_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass440 gclass440_0;
}

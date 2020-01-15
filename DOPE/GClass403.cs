using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass403 : GClass402, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4879;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass403(GClass703 gclass703_1 = null, GClass635 gclass635_1 = null, GClass540 gclass540_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass703_1 == null)
		{
			this.gclass703_0 = new GClass703(0, 0, 0, 0.0);
		}
		else
		{
			this.gclass703_0 = gclass703_1;
		}
		if (gclass635_1 == null)
		{
			this.gclass635_0 = new GClass635(null);
		}
		else
		{
			this.gclass635_0 = gclass635_1;
		}
		if (gclass540_1 == null)
		{
			this.gclass540_0 = new GClass540("", 0.0, null);
			return;
		}
		this.gclass540_0 = gclass540_1;
	}

	public override int vmethod_0()
	{
		return 4879;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass703_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass703);
		this.gclass703_0.imethod_1(binaryStream_0);
		this.gclass540_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass540);
		this.gclass540_0.imethod_1(binaryStream_0);
		this.gclass635_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass635);
		this.gclass635_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4879);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass703_0.imethod_2(binaryStream_0);
		this.gclass540_0.imethod_2(binaryStream_0);
		this.gclass635_0.imethod_2(binaryStream_0);
	}

	public GClass703 gclass703_0;

	public GClass540 gclass540_0;

	public GClass635 gclass635_0;
}

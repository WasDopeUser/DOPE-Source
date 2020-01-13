using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass398 : GClass396, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24734;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass398(GClass589 gclass589_2 = null, GClass589 gclass589_3 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass589_2 == null)
		{
			this.gclass589_0 = new GClass589("", 0.0);
		}
		else
		{
			this.gclass589_0 = gclass589_2;
		}
		if (gclass589_3 == null)
		{
			this.gclass589_1 = new GClass589("", 0.0);
			return;
		}
		this.gclass589_1 = gclass589_3;
	}

	public override int vmethod_0()
	{
		return 24734;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass589_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass589);
		this.gclass589_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass589_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass589);
		this.gclass589_1.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24734);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-18987);
		this.gclass589_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-7561);
		this.gclass589_1.imethod_2(binaryStream_0);
	}

	public GClass589 gclass589_0;

	public GClass589 gclass589_1;
}

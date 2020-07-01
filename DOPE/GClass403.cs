using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass403 : GClass401, GInterface0
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

	public GClass403(GClass622 gclass622_2 = null, GClass622 gclass622_3 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass622_3 == null)
		{
			this.gclass622_0 = new GClass622("", 0.0);
		}
		else
		{
			this.gclass622_0 = gclass622_3;
		}
		if (gclass622_2 == null)
		{
			this.gclass622_1 = new GClass622("", 0.0);
			return;
		}
		this.gclass622_1 = gclass622_2;
	}

	public override int vmethod_0()
	{
		return 24733;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.gclass622_0 = (GClass622)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass622_0 != null)
		{
			this.gclass622_0.imethod_0(binaryStream_0);
		}
		this.gclass622_1 = (GClass622)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass622_1 != null)
		{
			this.gclass622_1.imethod_0(binaryStream_0);
		}
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24733);
		base.imethod_1(binaryStream_0);
		if (this.gclass622_0 != null)
		{
			this.gclass622_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass622_1 != null)
		{
			this.gclass622_1.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass622 gclass622_0;

	public GClass622 gclass622_1;
}

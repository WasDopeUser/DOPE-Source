using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass407 : GClass406, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32647;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass407(GClass763 gclass763_1 = null, GClass683 gclass683_1 = null, GClass560 gclass560_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass683_1 == null)
		{
			this.gclass683_0 = new GClass683(null);
		}
		else
		{
			this.gclass683_0 = gclass683_1;
		}
		if (gclass560_1 == null)
		{
			this.gclass560_0 = new GClass560("", 0.0, null);
		}
		else
		{
			this.gclass560_0 = gclass560_1;
		}
		if (gclass763_1 == null)
		{
			this.gclass763_0 = new GClass763(0, 0, 0, 0.0);
			return;
		}
		this.gclass763_0 = gclass763_1;
	}

	public override int vmethod_0()
	{
		return 32647;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.gclass683_0 = (GClass683)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass683_0 != null)
		{
			this.gclass683_0.imethod_0(binaryStream_0);
		}
		this.gclass560_0 = (GClass560)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass560_0 != null)
		{
			this.gclass560_0.imethod_0(binaryStream_0);
		}
		this.gclass763_0 = (GClass763)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass763_0 != null)
		{
			this.gclass763_0.imethod_0(binaryStream_0);
		}
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32647);
		base.imethod_1(binaryStream_0);
		if (this.gclass683_0 != null)
		{
			this.gclass683_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass560_0 != null)
		{
			this.gclass560_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass763_0 != null)
		{
			this.gclass763_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass683 gclass683_0;

	public GClass560 gclass560_0;

	public GClass763 gclass763_0;
}

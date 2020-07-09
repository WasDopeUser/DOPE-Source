using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass408 : GClass407, GInterface0
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

	public GClass408(GClass763 gclass763_1 = null, GClass683 gclass683_1 = null, GClass561 gclass561_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass683_1 == null)
		{
			this.gclass683_0 = new GClass683(null);
		}
		else
		{
			this.gclass683_0 = gclass683_1;
		}
		if (gclass561_1 == null)
		{
			this.gclass561_0 = new GClass561("", 0.0, null);
		}
		else
		{
			this.gclass561_0 = gclass561_1;
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

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.gclass683_0 = (GClass683)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass683_0 != null)
		{
			this.gclass683_0.imethod_1(binaryStream_0);
		}
		this.gclass561_0 = (GClass561)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass561_0 != null)
		{
			this.gclass561_0.imethod_1(binaryStream_0);
		}
		this.gclass763_0 = (GClass763)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass763_0 != null)
		{
			this.gclass763_0.imethod_1(binaryStream_0);
		}
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32647);
		base.imethod_2(binaryStream_0);
		if (this.gclass683_0 != null)
		{
			this.gclass683_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass561_0 != null)
		{
			this.gclass561_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass763_0 != null)
		{
			this.gclass763_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass683 gclass683_0;

	public GClass561 gclass561_0;

	public GClass763 gclass763_0;
}

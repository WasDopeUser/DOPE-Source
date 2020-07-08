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

	public GClass407(GClass762 gclass762_1 = null, GClass682 gclass682_1 = null, GClass560 gclass560_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass682_1 == null)
		{
			this.gclass682_0 = new GClass682(null);
		}
		else
		{
			this.gclass682_0 = gclass682_1;
		}
		if (gclass560_1 == null)
		{
			this.gclass560_0 = new GClass560("", 0.0, null);
		}
		else
		{
			this.gclass560_0 = gclass560_1;
		}
		if (gclass762_1 == null)
		{
			this.gclass762_0 = new GClass762(0, 0, 0, 0.0);
			return;
		}
		this.gclass762_0 = gclass762_1;
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
		this.gclass682_0 = (GClass682)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass682_0 != null)
		{
			this.gclass682_0.imethod_1(binaryStream_0);
		}
		this.gclass560_0 = (GClass560)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass560_0 != null)
		{
			this.gclass560_0.imethod_1(binaryStream_0);
		}
		this.gclass762_0 = (GClass762)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass762_0 != null)
		{
			this.gclass762_0.imethod_1(binaryStream_0);
		}
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32647);
		base.imethod_2(binaryStream_0);
		if (this.gclass682_0 != null)
		{
			this.gclass682_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass560_0 != null)
		{
			this.gclass560_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass762_0 != null)
		{
			this.gclass762_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass682 gclass682_0;

	public GClass560 gclass560_0;

	public GClass762 gclass762_0;
}

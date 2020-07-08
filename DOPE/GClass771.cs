using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass771 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6668;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass771(GClass200 gclass200_1 = null, GClass480 gclass480_1 = null, double double_1 = 0.0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass200_1 == null)
		{
			this.gclass200_0 = new GClass200(0);
		}
		else
		{
			this.gclass200_0 = gclass200_1;
		}
		if (gclass480_1 == null)
		{
			this.gclass480_0 = new GClass480(0);
		}
		else
		{
			this.gclass480_0 = gclass480_1;
		}
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 6668;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass200_0 = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_1(binaryStream_0);
		}
		this.gclass480_0 = (GClass480)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass480_0 != null)
		{
			this.gclass480_0.imethod_1(binaryStream_0);
		}
		this.double_0 = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6668);
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass480_0 != null)
		{
			this.gclass480_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_9(this.double_0);
	}

	public GClass200 gclass200_0;

	public GClass480 gclass480_0;

	public double double_0;
}

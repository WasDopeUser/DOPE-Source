using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass772 : GInterface0
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

	public GClass772(GClass201 gclass201_1 = null, GClass481 gclass481_1 = null, double double_1 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (gclass481_1 == null)
		{
			this.gclass481_0 = new GClass481(0);
		}
		else
		{
			this.gclass481_0 = gclass481_1;
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
		this.gclass201_0 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_1(binaryStream_0);
		}
		this.gclass481_0 = (GClass481)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass481_0 != null)
		{
			this.gclass481_0.imethod_1(binaryStream_0);
		}
		this.double_0 = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6668);
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass481_0 != null)
		{
			this.gclass481_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_9(this.double_0);
	}

	public GClass201 gclass201_0;

	public GClass481 gclass481_0;

	public double double_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass471 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 204;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass471(GClass823 gclass823_1 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass823_1 == null)
		{
			this.gclass823_0 = new GClass823(0);
		}
		else
		{
			this.gclass823_0 = gclass823_1;
		}
		this.double_0 = double_2;
		this.double_1 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 204;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass823_0 = (GClass823)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass823_0 != null)
		{
			this.gclass823_0.imethod_0(binaryStream_0);
		}
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.double_1 = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(204);
		if (this.gclass823_0 != null)
		{
			this.gclass823_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_9(this.double_1);
	}

	public GClass823 gclass823_0;

	public double double_0;

	public double double_1;
}

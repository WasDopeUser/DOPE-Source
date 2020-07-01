using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass135 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 105;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass135(GClass259 gclass259_1 = null, double double_0 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass259_1 == null)
		{
			this.gclass259_0 = new GClass259(0);
		}
		else
		{
			this.gclass259_0 = gclass259_1;
		}
		this.Count = double_0;
	}

	public virtual int vmethod_0()
	{
		return 105;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass259_0 = (GClass259)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_0(binaryStream_0);
		}
		this.Count = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(105);
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteDouble(this.Count);
	}

	public GClass259 gclass259_0;

	public double Count;
}

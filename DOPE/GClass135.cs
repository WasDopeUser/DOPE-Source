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

	public GClass135(GClass260 gclass260_1 = null, double double_0 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass260_1 == null)
		{
			this.gclass260_0 = new GClass260(0);
		}
		else
		{
			this.gclass260_0 = gclass260_1;
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

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass260_0 = (GClass260)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass260_0 != null)
		{
			this.gclass260_0.imethod_1(binaryStream_0);
		}
		this.Count = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(105);
		if (this.gclass260_0 != null)
		{
			this.gclass260_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteDouble(this.Count);
	}

	public GClass260 gclass260_0;

	public double Count;
}

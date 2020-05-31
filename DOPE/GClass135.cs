using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass135 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16659;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass135(GClass265 gclass265_1 = null, double double_0 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass265_1 == null)
		{
			this.gclass265_0 = new GClass265(0U);
		}
		else
		{
			this.gclass265_0 = gclass265_1;
		}
		this.Count = double_0;
	}

	public virtual int vmethod_0()
	{
		return 16659;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass265_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass265);
		this.gclass265_0.HrqIugnatr8(binaryStream_0);
		this.Count = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16659);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass265_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteDouble(this.Count);
	}

	public GClass265 gclass265_0;

	public double Count;
}

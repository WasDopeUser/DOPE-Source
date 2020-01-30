using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass135 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24452;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass135(GClass261 gclass261_1 = null, double double_0 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass261_1 == null)
		{
			this.gclass261_0 = new GClass261(0U);
		}
		else
		{
			this.gclass261_0 = gclass261_1;
		}
		this.Count = double_0;
	}

	public virtual int vmethod_0()
	{
		return 24452;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass261_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass261);
		this.gclass261_0.imethod_1(binaryStream_0);
		this.Count = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24452);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(698);
		this.gclass261_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.Count);
		binaryStream_0.smethod_7(2338);
	}

	public GClass261 gclass261_0;

	public double Count;
}

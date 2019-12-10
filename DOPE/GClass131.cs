using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass131 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29942;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass131(GClass247 gclass247_1 = null, double double_0 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass247_1 == null)
		{
			this.gclass247_0 = new GClass247(0U);
		}
		else
		{
			this.gclass247_0 = gclass247_1;
		}
		this.Count = double_0;
	}

	public virtual int vmethod_0()
	{
		return 29942;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Count = binaryStream_0.ReadDouble();
		this.gclass247_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass247);
		this.gclass247_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(29942);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.Count);
		this.gclass247_0.imethod_2(binaryStream_0);
	}

	public double Count;

	public GClass247 gclass247_0;
}

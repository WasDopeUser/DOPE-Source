using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass223 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18319;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass223(GClass171 gclass171_1 = null, GClass743 gclass743_1 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass171_1 == null)
		{
			this.gclass171_0 = new GClass171(0U);
		}
		else
		{
			this.gclass171_0 = gclass171_1;
		}
		if (gclass743_1 == null)
		{
			this.gclass743_0 = new GClass743(0U);
		}
		else
		{
			this.gclass743_0 = gclass743_1;
		}
		this.double_0 = double_2;
		this.double_1 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 18319;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass743_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass743);
		this.gclass743_0.imethod_1(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		this.gclass171_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass171);
		this.gclass171_0.imethod_1(binaryStream_0);
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(18319);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-6104);
		this.gclass743_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_5(-3700);
		this.gclass171_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_1);
	}

	public GClass743 gclass743_0;

	public double double_0;

	public GClass171 gclass171_0;

	public double double_1;
}

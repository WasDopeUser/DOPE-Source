using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass235 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24753;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass235(GClass178 gclass178_1 = null, GClass754 gclass754_1 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0U);
		}
		else
		{
			this.gclass178_0 = gclass178_1;
		}
		if (gclass754_1 == null)
		{
			this.gclass754_0 = new GClass754(0U);
		}
		else
		{
			this.gclass754_0 = gclass754_1;
		}
		this.double_0 = double_2;
		this.double_1 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 24753;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.gclass178_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass178);
		this.gclass178_0.imethod_1(binaryStream_0);
		this.gclass754_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass754);
		this.gclass754_0.imethod_1(binaryStream_0);
		this.double_1 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(24753);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		this.gclass178_0.imethod_2(binaryStream_0);
		this.gclass754_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_6(15686);
	}

	public double double_0;

	public GClass178 gclass178_0;

	public GClass754 gclass754_0;

	public double double_1;
}

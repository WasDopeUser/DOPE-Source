using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass235 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22362;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass235(GClass178 gclass178_1 = null, GClass752 gclass752_1 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0U);
		}
		else
		{
			this.gclass178_0 = gclass178_1;
		}
		if (gclass752_1 == null)
		{
			this.gclass752_0 = new GClass752(0U);
		}
		else
		{
			this.gclass752_0 = gclass752_1;
		}
		this.double_0 = double_2;
		this.double_1 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 22362;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass752_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass752);
		this.gclass752_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.gclass178_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass178);
		this.gclass178_0.imethod_1(binaryStream_0);
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22362);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass752_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(9887);
		binaryStream_0.WriteDouble(this.double_0);
		this.gclass178_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_1);
	}

	public GClass752 gclass752_0;

	public double double_0;

	public GClass178 gclass178_0;

	public double double_1;
}

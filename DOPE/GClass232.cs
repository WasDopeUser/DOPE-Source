using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass232 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -27028;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass232(GClass178 gclass178_1 = null, GClass814 gclass814_1 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0);
		}
		else
		{
			this.gclass178_0 = gclass178_1;
		}
		this.double_0 = double_3;
		this.double_1 = double_2;
		if (gclass814_1 == null)
		{
			this.gclass814_0 = new GClass814(0);
			return;
		}
		this.gclass814_0 = gclass814_1;
	}

	public virtual int vmethod_0()
	{
		return -27028;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass178_0 = (GClass178)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass178_0 != null)
		{
			this.gclass178_0.imethod_0(binaryStream_0);
		}
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.gclass814_0 = (GClass814)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass814_0 != null)
		{
			this.gclass814_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-27028);
		if (this.gclass178_0 != null)
		{
			this.gclass178_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		if (this.gclass814_0 != null)
		{
			this.gclass814_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass178 gclass178_0;

	public double double_0;

	public double double_1;

	public GClass814 gclass814_0;
}

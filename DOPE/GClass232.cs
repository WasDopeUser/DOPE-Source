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

	public GClass232(GClass177 gclass177_1 = null, GClass813 gclass813_1 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass177_1 == null)
		{
			this.gclass177_0 = new GClass177(0);
		}
		else
		{
			this.gclass177_0 = gclass177_1;
		}
		this.double_0 = double_3;
		this.double_1 = double_2;
		if (gclass813_1 == null)
		{
			this.gclass813_0 = new GClass813(0);
			return;
		}
		this.gclass813_0 = gclass813_1;
	}

	public virtual int vmethod_0()
	{
		return -27028;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass177_0 = (GClass177)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass177_0 != null)
		{
			this.gclass177_0.imethod_1(binaryStream_0);
		}
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.gclass813_0 = (GClass813)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass813_0 != null)
		{
			this.gclass813_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-27028);
		if (this.gclass177_0 != null)
		{
			this.gclass177_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		if (this.gclass813_0 != null)
		{
			this.gclass813_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass177 gclass177_0;

	public double double_0;

	public double double_1;

	public GClass813 gclass813_0;
}

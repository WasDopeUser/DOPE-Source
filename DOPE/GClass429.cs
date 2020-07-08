using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass429 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 201;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass429(GClass822 gclass822_1 = null, int int_1 = 0, double double_1 = 0.0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass822_1 == null)
		{
			this.gclass822_0 = new GClass822(0);
		}
		else
		{
			this.gclass822_0 = gclass822_1;
		}
		this.int_0 = int_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 201;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass822_0 = (GClass822)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass822_0 != null)
		{
			this.gclass822_0.imethod_1(binaryStream_0);
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(201);
		if (this.gclass822_0 != null)
		{
			this.gclass822_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public GClass822 gclass822_0;

	public int int_0;

	public double double_0;
}

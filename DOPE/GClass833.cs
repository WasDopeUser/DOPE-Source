using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass833 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -16140;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass833(double double_1 = 0.0, double double_2 = 0.0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.double_0 = double_2;
		this.YicgvJilgL = double_1;
	}

	public virtual int vmethod_0()
	{
		return -16140;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.YicgvJilgL = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-16140);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.YicgvJilgL);
	}

	public double double_0;

	public double YicgvJilgL;
}

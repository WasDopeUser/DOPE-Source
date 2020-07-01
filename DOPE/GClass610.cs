using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass610 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -3487;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass610(double double_1 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return -3487;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-3487);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double double_0;
}

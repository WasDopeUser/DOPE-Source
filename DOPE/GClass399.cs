using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass399 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -21477;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass399(double double_1 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return -21477;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-21477);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double double_0;
}

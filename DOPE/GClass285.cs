using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass285 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 159;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass285(double double_1 = 0.0, double double_2 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.TrqTmuyPqn = double_1;
		this.double_0 = double_2;
	}

	public virtual int vmethod_0()
	{
		return 159;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.TrqTmuyPqn = binaryStream_0.ReadDouble();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(159);
		binaryStream_0.WriteDouble(this.TrqTmuyPqn);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double TrqTmuyPqn;

	public double double_0;
}

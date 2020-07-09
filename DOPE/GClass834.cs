using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass834 : GInterface0
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

	public GClass834(double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.double_0 = double_3;
		this.double_1 = double_2;
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
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-16140);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
	}

	public double double_0;

	public double double_1;
}

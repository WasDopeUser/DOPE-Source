using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass770 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19034;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass770(double double_1 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 19034;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(19034);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(8754);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double double_0;
}

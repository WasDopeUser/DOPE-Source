using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass756 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15665;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass756(double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.double_0 = double_3;
		this.double_2 = double_4;
		this.double_1 = double_5;
	}

	public virtual int vmethod_0()
	{
		return 15665;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.double_2 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(15665);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.WriteDouble(this.double_2);
		binaryStream_0.smethod_5(-32596);
	}

	public double double_0;

	public double double_1;

	public double double_2;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass829 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24370;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass829(double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.double_0 = double_4;
		this.double_1 = double_5;
		this.double_2 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 24370;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.double_2 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24370);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.WriteDouble(this.double_2);
	}

	public double double_0;

	public double double_1;

	public double double_2;
}

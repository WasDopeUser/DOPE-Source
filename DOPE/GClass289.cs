using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass289 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9437;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass289(double double_1 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 9437;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9437);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_6(10206);
	}

	public double double_0;
}

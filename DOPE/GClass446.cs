using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass446 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22325;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass446(double double_1 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 22325;
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
		binaryStream_0.smethod_7(22325);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9880);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double double_0;
}

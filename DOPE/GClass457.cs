using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass457 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23717;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass457(double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 23717;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23717);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_7(26318);
		binaryStream_0.smethod_7(-7299);
		binaryStream_0.WriteDouble(this.double_1);
	}

	public double double_0;

	public double double_1;
}

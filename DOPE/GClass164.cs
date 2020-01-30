using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass164 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20107;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass164(uint uint_0 = 0U)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.cnYdMyimpW = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 20107;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.cnYdMyimpW = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20107);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-31121);
		binaryStream_0.smethod_7(-5900);
		binaryStream_0.smethod_6(this.cnYdMyimpW);
	}

	public uint cnYdMyimpW;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass710 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11803;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass710(uint uint_1 = 0U)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 11803;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11803);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-21977);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public uint uint_0;
}

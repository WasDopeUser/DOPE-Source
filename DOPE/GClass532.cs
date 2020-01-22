using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass532 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9858;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass532(uint uint_1 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 9858;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9858);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-3946);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(-5634);
	}

	public uint uint_0;
}

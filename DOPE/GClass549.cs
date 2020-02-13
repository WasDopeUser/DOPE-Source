using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass549 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26120;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass549()
	{
		Class13.igxcIukzfpare();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 26120;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(26120);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(17430);
		binaryStream_0.smethod_6(-10196);
	}
}

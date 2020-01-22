using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass192 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3009;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass192()
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 3009;
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
		binaryStream_0.smethod_7(3009);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-25003);
		binaryStream_0.smethod_7(-9715);
	}
}

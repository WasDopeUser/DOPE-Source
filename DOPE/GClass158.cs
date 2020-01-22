using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass158 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12538;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass158()
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 12538;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12538);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-6703);
	}
}

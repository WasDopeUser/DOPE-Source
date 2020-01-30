using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass373 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1666;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass373()
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 1666;
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
		binaryStream_0.smethod_7(1666);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-10485);
		binaryStream_0.smethod_7(-7344);
	}
}

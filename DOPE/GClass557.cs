using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass557 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23127;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass557()
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 23127;
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
		binaryStream_0.smethod_7(23127);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7435);
	}
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass269 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass269()
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 17;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17);
	}
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass148 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26530;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass148(int int_0 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.FromId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 26530;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (this.FromId << 16 | U.smethod_0(this.FromId, 16));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26530);
		binaryStream_0.smethod_4(U.smethod_0(this.FromId, 16) | this.FromId << 16);
	}

	public int FromId;
}

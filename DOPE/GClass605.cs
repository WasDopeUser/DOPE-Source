using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass605 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -31885;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass605(int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -31885;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-31885);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
	}

	public int int_0;
}

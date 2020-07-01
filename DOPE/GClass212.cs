using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass212 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -21819;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass212(int int_2 = 0, int int_3 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_2;
	}

	public virtual int vmethod_0()
	{
		return -21819;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-21819);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_4(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
	}

	public int int_0;

	public int int_1;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass302 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -6401;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass302(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_3;
	}

	public virtual int vmethod_0()
	{
		return -6401;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-6401);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_7(this.int_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

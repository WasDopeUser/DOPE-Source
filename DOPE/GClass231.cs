using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass231 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 96;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass231(int int_1 = 0, int int_2 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.GjmBmjIwIs = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 96;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.GjmBmjIwIs = binaryStream_0.smethod_0();
		this.GjmBmjIwIs = (this.GjmBmjIwIs << 12 | U.smethod_0(this.GjmBmjIwIs, 20));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(96);
		binaryStream_0.smethod_4(U.smethod_0(this.GjmBmjIwIs, 12) | this.GjmBmjIwIs << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
	}

	public int GjmBmjIwIs;

	public int int_0;
}

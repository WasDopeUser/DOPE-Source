using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass641 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25489;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass641(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_5;
		this.int_2 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 25489;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25489);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

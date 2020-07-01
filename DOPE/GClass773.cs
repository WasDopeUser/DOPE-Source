using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass773 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass773(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.XsovZftlp2 = int_6;
		this.int_2 = int_7;
		this.int_3 = int_8;
	}

	public virtual int vmethod_0()
	{
		return 31;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.XsovZftlp2 = binaryStream_0.smethod_0();
		this.XsovZftlp2 = (this.XsovZftlp2 << 3 | U.smethod_0(this.XsovZftlp2, 29));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 4 | U.smethod_0(this.int_2, 28));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 7 | U.smethod_0(this.int_3, 25));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.XsovZftlp2, 3) | this.XsovZftlp2 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 4) | this.int_2 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 7) | this.int_3 << 25);
	}

	public int int_0;

	public int int_1;

	public int XsovZftlp2;

	public int int_2;

	public int int_3;
}

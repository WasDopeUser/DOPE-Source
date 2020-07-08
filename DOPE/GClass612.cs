using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass612 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 190;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass612(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_5;
		this.int_1 = int_6;
		this.int_2 = int_7;
		this.int_3 = int_8;
		this.int_4 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 190;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 3 | U.smethod_0(this.int_4, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(190);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_4(this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		binaryStream_0.smethod_4(this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 3) | this.int_4 << 29);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}

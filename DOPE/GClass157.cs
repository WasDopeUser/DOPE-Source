using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass157 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6073;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass157(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_3 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
		this.int_1 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 6073;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 10) | this.int_3 << 22);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6073);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.fUeiimuocMk(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.fUeiimuocMk(this.int_3 << 10 | U.smethod_0(this.int_3, 22));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}

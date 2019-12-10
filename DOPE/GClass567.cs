using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass567 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29847;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass567(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_3 = int_5;
		this.int_0 = int_6;
		this.int_2 = int_7;
		this.int_4 = int_8;
		this.int_1 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 29847;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 2 | U.smethod_0(this.int_3, 30));
		binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 6) | this.int_4 << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(29847);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.fUeiimuocMk(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 2) | this.int_3 << 30);
		binaryStream_0.smethod_5(-21032);
		binaryStream_0.fUeiimuocMk(this.int_4 << 6 | U.smethod_0(this.int_4, 26));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}

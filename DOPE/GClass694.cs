using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass694 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8431;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass694(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 8431;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 10 | U.smethod_0(this.int_2, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(8431);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_5(-17351);
		binaryStream_0.fUeiimuocMk(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 10) | this.int_2 << 22);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

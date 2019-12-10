using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass164 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12634;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass164(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_5;
		this.int_3 = int_6;
		this.int_0 = int_7;
		this.int_2 = int_8;
		this.int_4 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 12634;
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
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 14) | this.int_3 << 18);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 10 | U.smethod_0(this.int_4, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(12634);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.fUeiimuocMk(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.smethod_5(-32057);
		binaryStream_0.fUeiimuocMk(this.int_3 << 14 | U.smethod_0(this.int_3, 18));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_4, 10) | this.int_4 << 22);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}

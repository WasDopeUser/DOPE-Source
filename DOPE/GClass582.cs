using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass582 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21233;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass582(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 21233;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 8 | U.smethod_0(this.Id, 24));
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 10 | U.smethod_0(this.int_2, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(21233);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.Id, 8) | this.Id << 24);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(-558);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_5(17484);
		binaryStream_0.fUeiimuocMk(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 10) | this.int_2 << 22);
	}

	public int Id;

	public bool bool_0;

	public int int_0;

	public int int_1;

	public int int_2;
}

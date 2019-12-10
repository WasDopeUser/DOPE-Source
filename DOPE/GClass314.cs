using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass314 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8676;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass314(int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_6;
		this.int_2 = int_7;
		this.int_4 = int_8;
		this.int_3 = int_9;
		this.int_0 = int_10;
		this.int_5 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 8676;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 10 | U.smethod_0(this.int_3, 22));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 12) | this.int_4 << 20);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 11 | U.smethod_0(this.int_5, 21));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(8676);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.fUeiimuocMk(this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 10) | this.int_3 << 22);
		binaryStream_0.fUeiimuocMk(this.int_4 << 12 | U.smethod_0(this.int_4, 20));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 11) | this.int_5 << 21);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;
}

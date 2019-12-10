using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass254 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25550;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 33;
		}
	}

	public GClass254(int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_4 = int_7;
		this.int_5 = int_8;
		this.kaVjqpkbjt = int_9;
		this.int_1 = int_10;
		this.int_3 = int_11;
		this.int_2 = int_12;
		this.int_0 = int_13;
		this.int_6 = int_14;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 25550;
	}

	public virtual int vmethod_1()
	{
		return 33;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 2) | this.int_4 << 30);
		this.kaVjqpkbjt = binaryStream_0.smethod_0();
		this.kaVjqpkbjt = (U.smethod_0(this.kaVjqpkbjt, 1) | this.kaVjqpkbjt << 31);
		binaryStream_0.smethod_1();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 6 | U.smethod_0(this.int_5, 26));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 4) | this.int_6 << 28);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(25550);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.fUeiimuocMk(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		binaryStream_0.fUeiimuocMk(this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		binaryStream_0.fUeiimuocMk(this.int_4 << 2 | U.smethod_0(this.int_4, 30));
		binaryStream_0.fUeiimuocMk(this.kaVjqpkbjt << 1 | U.smethod_0(this.kaVjqpkbjt, 31));
		binaryStream_0.smethod_5(-5717);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 6) | this.int_5 << 26);
		binaryStream_0.fUeiimuocMk(this.int_6 << 4 | U.smethod_0(this.int_6, 28));
	}

	public int int_0;

	public bool bool_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int kaVjqpkbjt;

	public int int_5;

	public int int_6;
}

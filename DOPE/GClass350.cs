using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass350 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7802;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 54;
		}
	}

	public GClass350(int int_12 = 0, int int_13 = 0, int int_14 = 0, uint uint_1 = 0U, int int_15 = 0, int int_16 = 0, int int_17 = 0, int int_18 = 0, int int_19 = 0, string string_1 = "", int int_20 = 0, int int_21 = 0, int int_22 = 0, int int_23 = 0, int int_24 = 0)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.int_8 = int_12;
		this.int_4 = int_13;
		this.int_7 = int_14;
		this.uint_0 = uint_1;
		this.int_11 = int_15;
		this.int_2 = int_16;
		this.int_6 = int_17;
		this.int_0 = int_18;
		this.int_1 = int_19;
		this.string_0 = string_1;
		this.int_9 = int_20;
		this.int_3 = int_21;
		this.GtuxNnoYo2 = int_22;
		this.int_10 = int_23;
		this.int_5 = int_24;
	}

	public virtual int vmethod_0()
	{
		return 7802;
	}

	public virtual int vmethod_1()
	{
		return 54;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 7) | this.int_4 << 25);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 14 | U.smethod_0(this.int_5, 18));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 2 | U.smethod_0(this.int_6, 30));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 12) | this.int_7 << 20);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 11) | this.int_8 << 21);
		this.int_9 = binaryStream_0.smethod_0();
		this.int_9 = (this.int_9 << 7 | U.smethod_0(this.int_9, 25));
		this.int_10 = binaryStream_0.smethod_0();
		this.int_10 = (U.smethod_0(this.int_10, 14) | this.int_10 << 18);
		this.int_11 = binaryStream_0.smethod_0();
		this.int_11 = (U.smethod_0(this.int_11, 12) | this.int_11 << 20);
		this.GtuxNnoYo2 = binaryStream_0.smethod_0();
		this.GtuxNnoYo2 = (U.smethod_0(this.GtuxNnoYo2, 10) | this.GtuxNnoYo2 << 22);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(7802);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.fUeiimuocMk(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		binaryStream_0.fUeiimuocMk(this.int_4 << 7 | U.smethod_0(this.int_4, 25));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 14) | this.int_5 << 18);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_6, 2) | this.int_6 << 30);
		binaryStream_0.fUeiimuocMk(this.int_7 << 12 | U.smethod_0(this.int_7, 20));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(this.int_8 << 11 | U.smethod_0(this.int_8, 21));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_9, 7) | this.int_9 << 25);
		binaryStream_0.fUeiimuocMk(this.int_10 << 14 | U.smethod_0(this.int_10, 18));
		binaryStream_0.fUeiimuocMk(this.int_11 << 12 | U.smethod_0(this.int_11, 20));
		binaryStream_0.fUeiimuocMk(this.GtuxNnoYo2 << 10 | U.smethod_0(this.GtuxNnoYo2, 22));
	}

	public uint uint_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public string string_0;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	public int GtuxNnoYo2;
}

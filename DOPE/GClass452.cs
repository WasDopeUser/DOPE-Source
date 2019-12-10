using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass452 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7606;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 32;
		}
	}

	public GClass452(int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, string string_1 = "", int int_12 = 0, string string_2 = "", int int_13 = 0)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.kxhtneVwBi = "";
		base..ctor();
		this.int_1 = int_7;
		this.int_2 = int_8;
		this.int_4 = int_9;
		this.int_6 = int_10;
		this.int_5 = int_11;
		this.kxhtneVwBi = string_1;
		this.int_0 = int_12;
		this.string_0 = string_2;
		this.int_3 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 7606;
	}

	public virtual int vmethod_1()
	{
		return 32;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		this.kxhtneVwBi = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 4 | U.smethod_0(this.int_3, 28));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 7) | this.int_4 << 25);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 3 | U.smethod_0(this.int_5, 29));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 16 | U.smethod_0(this.int_6, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(7606);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.fUeiimuocMk(this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		binaryStream_0.smethod_3(this.kxhtneVwBi);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 4) | this.int_3 << 28);
		binaryStream_0.fUeiimuocMk(this.int_4 << 7 | U.smethod_0(this.int_4, 25));
		binaryStream_0.smethod_5(-6151);
		binaryStream_0.smethod_5(21476);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 3) | this.int_5 << 29);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_6, 16) | this.int_6 << 16);
	}

	public string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public string kxhtneVwBi;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;
}

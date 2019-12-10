using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass725 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25391;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 30;
		}
	}

	public GClass725(uint uint_0 = 0U, uint uint_1 = 0U, int int_7 = 0, int int_8 = 0, int int_9 = 0, string string_1 = "", int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.drwfojmMxW = uint_0;
		this.Status = uint_1;
		this.int_5 = int_7;
		this.int_4 = int_8;
		this.int_3 = int_9;
		this.string_0 = string_1;
		this.int_6 = int_10;
		this.int_0 = int_11;
		this.int_1 = int_12;
		this.int_2 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 25391;
	}

	public virtual int vmethod_1()
	{
		return 30;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 4) | this.int_3 << 28);
		this.Status = (uint)binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 15) | this.int_4 << 17);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 15 | U.smethod_0(this.int_5, 17));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 2 | U.smethod_0(this.int_6, 30));
		this.drwfojmMxW = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(25391);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.fUeiimuocMk(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.fUeiimuocMk(this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		binaryStream_0.fUeiimuocMk(this.int_3 << 4 | U.smethod_0(this.int_3, 28));
		binaryStream_0.lwAiiEjwcUm(this.Status);
		binaryStream_0.fUeiimuocMk(this.int_4 << 15 | U.smethod_0(this.int_4, 17));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 15) | this.int_5 << 17);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_6, 2) | this.int_6 << 30);
		binaryStream_0.lwAiiEjwcUm(this.drwfojmMxW);
		binaryStream_0.smethod_5(29399);
	}

	public string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public uint Status;

	public int int_4;

	public int int_5;

	public int int_6;

	public uint drwfojmMxW;
}

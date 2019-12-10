using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass242 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12345;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 54;
		}
	}

	public GClass242(int int_9 = 0, int int_10 = 0, double double_1 = 0.0, double double_2 = 0.0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, string string_0 = "")
	{
		Class8.xDph7tozmh5WD();
		this.Name = "";
		base..ctor();
		this.int_3 = int_9;
		this.int_4 = int_10;
		this.Experience = double_1;
		this.double_0 = double_2;
		this.int_2 = int_11;
		this.int_5 = int_12;
		this.int_6 = int_13;
		this.int_7 = int_14;
		this.int_8 = int_15;
		this.int_1 = int_16;
		this.int_0 = int_17;
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 12345;
	}

	public virtual int vmethod_1()
	{
		return 54;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		binaryStream_0.smethod_1();
		this.Experience = binaryStream_0.ReadDouble();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 5) | this.int_4 << 27);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 3) | this.int_5 << 29);
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 13 | U.smethod_0(this.int_6, 19));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 8 | U.smethod_0(this.int_7, 24));
		this.Name = binaryStream_0.smethod_2();
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 16) | this.int_8 << 16);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(12345);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.smethod_5(-32608);
		binaryStream_0.WriteDouble(this.Experience);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.fUeiimuocMk(this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		binaryStream_0.fUeiimuocMk(this.int_4 << 5 | U.smethod_0(this.int_4, 27));
		binaryStream_0.fUeiimuocMk(this.int_5 << 3 | U.smethod_0(this.int_5, 29));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_6, 13) | this.int_6 << 19);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_7, 8) | this.int_7 << 24);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.fUeiimuocMk(this.int_8 << 16 | U.smethod_0(this.int_8, 16));
	}

	public int int_0;

	public int int_1;

	public double Experience;

	public int int_2;

	public double double_0;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public string Name;

	public int int_8;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass254 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 157;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 54;
		}
	}

	public GClass254(int int_9 = 0, int int_10 = 0, double double_1 = 0.0, double double_2 = 0.0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, string string_0 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.Name = "";
		base..ctor();
		this.int_0 = int_9;
		this.int_1 = int_10;
		this.Experience = double_1;
		this.double_0 = double_2;
		this.int_2 = int_11;
		this.int_3 = int_12;
		this.int_4 = int_13;
		this.int_5 = int_14;
		this.int_6 = int_15;
		this.int_7 = int_16;
		this.int_8 = int_17;
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 157;
	}

	public virtual int vmethod_1()
	{
		return 54;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.Experience = binaryStream_0.ReadDouble();
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 13 | U.smethod_0(this.int_4, 19));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 2 | U.smethod_0(this.int_5, 30));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 4 | U.smethod_0(this.int_6, 28));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 6 | U.smethod_0(this.int_7, 26));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 12) | this.int_8 << 20);
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(157);
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.WriteDouble(this.Experience);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.smethod_4(this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 13) | this.int_4 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 2) | this.int_5 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 4) | this.int_6 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 6) | this.int_7 << 26);
		binaryStream_0.smethod_4(this.int_8 << 12 | U.smethod_0(this.int_8, 20));
		binaryStream_0.smethod_3(this.Name);
	}

	public int int_0;

	public int int_1;

	public double Experience;

	public double double_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public string Name;
}

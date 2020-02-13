using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass256 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17485;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 54;
		}
	}

	public GClass256(int int_9 = 0, int int_10 = 0, double double_1 = 0.0, double double_2 = 0.0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, string string_0 = "")
	{
		Class13.igxcIukzfpare();
		this.Name = "";
		base..ctor();
		this.int_8 = int_9;
		this.int_2 = int_10;
		this.Experience = double_1;
		this.double_0 = double_2;
		this.int_5 = int_11;
		this.int_4 = int_12;
		this.int_7 = int_13;
		this.int_0 = int_14;
		this.int_1 = int_15;
		this.int_6 = int_16;
		this.int_3 = int_17;
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 17485;
	}

	public virtual int vmethod_1()
	{
		return 54;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 14) | this.int_3 << 18);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 14 | U.smethod_0(this.int_4, 18));
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 4 | U.smethod_0(this.int_5, 28));
		this.Experience = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 16 | U.smethod_0(this.int_6, 16));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 9 | U.smethod_0(this.int_7, 23));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 10 | U.smethod_0(this.int_8, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(17485);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.Name);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_3(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_3(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_3(this.int_3 << 14 | U.smethod_0(this.int_3, 18));
		binaryStream_0.smethod_3(U.smethod_0(this.int_4, 14) | this.int_4 << 18);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_5, 4) | this.int_5 << 28);
		binaryStream_0.WriteDouble(this.Experience);
		binaryStream_0.smethod_6(-28391);
		binaryStream_0.smethod_3(U.smethod_0(this.int_6, 16) | this.int_6 << 16);
		binaryStream_0.smethod_3(U.smethod_0(this.int_7, 9) | this.int_7 << 23);
		binaryStream_0.smethod_3(U.smethod_0(this.int_8, 10) | this.int_8 << 22);
	}

	public string Name;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public double double_0;

	public int int_5;

	public double Experience;

	public int int_6;

	public int int_7;

	public int int_8;
}

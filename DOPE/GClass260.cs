using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass260 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15389;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 54;
		}
	}

	public GClass260(int int_9 = 0, int int_10 = 0, double double_1 = 0.0, double double_2 = 0.0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0, string string_0 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.Name = "";
		base..ctor();
		this.int_1 = int_9;
		this.int_5 = int_10;
		this.Experience = double_1;
		this.double_0 = double_2;
		this.int_7 = int_11;
		this.int_6 = int_12;
		this.int_2 = int_13;
		this.int_8 = int_14;
		this.int_0 = int_15;
		this.int_3 = int_16;
		this.int_4 = int_17;
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 15389;
	}

	public virtual int vmethod_1()
	{
		return 54;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.Name = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 9) | this.int_3 << 23);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 3) | this.int_4 << 29);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 10) | this.int_5 << 22);
		this.Experience = binaryStream_0.ReadDouble();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 6 | U.smethod_0(this.int_6, 26));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 13 | U.smethod_0(this.int_7, 19));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 6) | this.int_8 << 26);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15389);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_7(23830);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_4(this.int_3 << 9 | U.smethod_0(this.int_3, 23));
		binaryStream_0.smethod_4(this.int_4 << 3 | U.smethod_0(this.int_4, 29));
		binaryStream_0.smethod_4(this.int_5 << 10 | U.smethod_0(this.int_5, 22));
		binaryStream_0.WriteDouble(this.Experience);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 6) | this.int_6 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 13) | this.int_7 << 19);
		binaryStream_0.smethod_4(this.int_8 << 6 | U.smethod_0(this.int_8, 26));
	}

	public int int_0;

	public double double_0;

	public int int_1;

	public int int_2;

	public string Name;

	public int int_3;

	public int int_4;

	public int int_5;

	public double Experience;

	public int int_6;

	public int int_7;

	public int int_8;
}

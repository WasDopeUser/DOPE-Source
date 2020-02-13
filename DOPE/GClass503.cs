using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass503 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14288;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 38;
		}
	}

	public GClass503(int int_4 = 0, int int_5 = 0, int int_6 = 0, double double_2 = 0.0, double double_3 = 0.0, int int_7 = 0, int int_8 = 0, string string_0 = "")
	{
		Class13.igxcIukzfpare();
		this.Name = "";
		base..ctor();
		this.LkNwwiiTm1 = int_4;
		this.int_3 = int_5;
		this.int_1 = int_6;
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.int_2 = int_7;
		this.int_0 = int_8;
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 14288;
	}

	public virtual int vmethod_1()
	{
		return 38;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.LkNwwiiTm1 = binaryStream_0.smethod_0();
		this.LkNwwiiTm1 = (this.LkNwwiiTm1 << 8 | U.smethod_0(this.LkNwwiiTm1, 24));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		this.double_0 = binaryStream_0.ReadDouble();
		this.Name = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		this.double_1 = binaryStream_0.ReadDouble();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 14) | this.int_3 << 18);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(14288);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.LkNwwiiTm1, 8) | this.LkNwwiiTm1 << 24);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_3(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.MoioCjQkqp0(this.Name);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_3(this.int_3 << 14 | U.smethod_0(this.int_3, 18));
	}

	public int LkNwwiiTm1;

	public int int_0;

	public int int_1;

	public double double_0;

	public string Name;

	public int int_2;

	public double double_1;

	public int int_3;
}

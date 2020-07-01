using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass514 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1724;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 38;
		}
	}

	public GClass514(int int_5 = 0, int int_6 = 0, int int_7 = 0, double double_2 = 0.0, double double_3 = 0.0, int int_8 = 0, int int_9 = 0, string string_0 = "")
	{
		Class13.F93tSdiz1aNIA();
		this.Name = "";
		base..ctor();
		this.int_0 = int_5;
		this.int_1 = int_6;
		this.int_2 = int_7;
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.int_3 = int_8;
		this.int_4 = int_9;
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 1724;
	}

	public virtual int vmethod_1()
	{
		return 38;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 9) | this.int_3 << 23);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 1 | U.smethod_0(this.int_4, 31));
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1724);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_4(this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_4(this.int_3 << 9 | U.smethod_0(this.int_3, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 1) | this.int_4 << 31);
		binaryStream_0.smethod_3(this.Name);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public double double_0;

	public double double_1;

	public int int_3;

	public int int_4;

	public string Name;
}

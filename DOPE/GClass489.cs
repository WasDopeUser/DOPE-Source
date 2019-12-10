using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass489 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29406;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 38;
		}
	}

	public GClass489(int int_5 = 0, int int_6 = 0, int int_7 = 0, double double_2 = 0.0, double double_3 = 0.0, int int_8 = 0, int int_9 = 0, string string_0 = "")
	{
		Class8.xDph7tozmh5WD();
		this.Name = "";
		base..ctor();
		this.int_2 = int_5;
		this.int_1 = int_6;
		this.int_4 = int_7;
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.int_0 = int_8;
		this.int_3 = int_9;
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 29406;
	}

	public virtual int vmethod_1()
	{
		return 38;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.Name = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 10) | this.int_3 << 22);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 3 | U.smethod_0(this.int_4, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(29406);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.fUeiimuocMk(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.fUeiimuocMk(this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		binaryStream_0.fUeiimuocMk(this.int_3 << 10 | U.smethod_0(this.int_3, 22));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_4, 3) | this.int_4 << 29);
	}

	public int int_0;

	public string Name;

	public double double_0;

	public double double_1;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}

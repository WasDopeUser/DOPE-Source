using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass501 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12189;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 38;
		}
	}

	public GClass501(int int_5 = 0, int int_6 = 0, int int_7 = 0, double double_1 = 0.0, double double_2 = 0.0, int int_8 = 0, int int_9 = 0, string string_0 = "")
	{
		Class13.tMHx78BzgCM8j();
		this.Name = "";
		base..ctor();
		this.int_0 = int_5;
		this.int_4 = int_6;
		this.int_3 = int_7;
		this.double_0 = double_1;
		this.oibqGjlJuQ = double_2;
		this.int_2 = int_8;
		this.int_1 = int_9;
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 12189;
	}

	public virtual int vmethod_1()
	{
		return 38;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.oibqGjlJuQ = binaryStream_0.ReadDouble();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		this.Name = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 16 | U.smethod_0(this.int_3, 16));
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 13 | U.smethod_0(this.int_4, 19));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12189);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.WriteDouble(this.oibqGjlJuQ);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 16) | this.int_3 << 16);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 13) | this.int_4 << 19);
		binaryStream_0.smethod_7(15909);
	}

	public int int_0;

	public double oibqGjlJuQ;

	public int int_1;

	public int int_2;

	public string Name;

	public int int_3;

	public double double_0;

	public int int_4;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass346 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6012;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass346(string string_2 = "", string string_3 = "", double double_0 = 0.0, int int_1 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_1 = string_2;
		this.string_0 = string_3;
		this.Id = double_0;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 6012;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.Id = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6012);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.WriteDouble(this.Id);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-12930);
		binaryStream_0.smethod_3(this.string_1);
	}

	public int int_0;

	public double Id;

	public string string_0;

	public string string_1;
}

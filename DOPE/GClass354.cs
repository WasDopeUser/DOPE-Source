using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass354 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1484;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass354(string string_2 = "", string string_3 = "", double double_0 = 0.0, int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
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
		return 1484;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1484);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_7(31706);
		binaryStream_0.WriteDouble(this.Id);
	}

	public string string_0;

	public int int_0;

	public string string_1;

	public double Id;
}

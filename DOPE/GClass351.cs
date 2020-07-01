using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass351 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -5163;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass351(string string_2 = "", string string_3 = "", double double_0 = 0.0, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		this.string_1 = string_3;
		this.Id = double_0;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -5163;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.Id = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-5163);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.WriteDouble(this.Id);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
	}

	public string string_0;

	public string string_1;

	public double Id;

	public int int_0;
}

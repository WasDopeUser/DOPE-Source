using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass841 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26143;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass841(string string_1 = "", double double_1 = 0.0, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 26143;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26143);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
	}

	public string string_0;

	public double double_0;

	public int int_0;
}

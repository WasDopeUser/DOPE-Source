using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass573 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25500;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass573(int int_1 = 0, string string_1 = "")
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 25500;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25500);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
	}

	public string string_0;

	public int int_0;
}

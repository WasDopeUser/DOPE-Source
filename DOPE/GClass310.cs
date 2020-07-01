using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass310 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20360;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass310(string string_1 = "", string string_2 = "")
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		this.Value = "";
		base..ctor();
		this.string_0 = string_1;
		this.Value = string_2;
	}

	public virtual int vmethod_0()
	{
		return 20360;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.Value = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20360);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.Value);
	}

	public string string_0;

	public string Value;
}

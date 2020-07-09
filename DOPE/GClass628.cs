using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass628 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 176;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass628(string string_2 = "", string string_3 = "", string string_4 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.RyUaMhmMyD = "";
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.RyUaMhmMyD = string_2;
		this.string_0 = string_3;
		this.string_1 = string_4;
	}

	public virtual int vmethod_0()
	{
		return 176;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.RyUaMhmMyD = binaryStream_0.smethod_2();
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(176);
		binaryStream_0.smethod_3(this.RyUaMhmMyD);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
	}

	public string RyUaMhmMyD;

	public string string_0;

	public string string_1;
}

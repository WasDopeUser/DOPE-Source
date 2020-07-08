using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass173 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -30179;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass173(string string_1 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return -30179;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-30179);
		binaryStream_0.smethod_3(this.string_0);
	}

	public string string_0;
}

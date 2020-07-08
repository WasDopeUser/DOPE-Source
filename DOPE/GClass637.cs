using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass637 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 85;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass637(string string_1 = "", string string_2 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		this.Value = "";
		base..ctor();
		this.string_0 = string_1;
		this.Value = string_2;
	}

	public virtual int vmethod_0()
	{
		return 85;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.Value = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(85);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.Value);
	}

	public string string_0;

	public string Value;
}

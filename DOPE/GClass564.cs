using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass564 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -26325;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass564(string string_1 = "", string string_2 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.Value = "";
		this.string_0 = "";
		base..ctor();
		this.Value = string_2;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return -26325;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Value = binaryStream_0.smethod_2();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-26325);
		binaryStream_0.smethod_3(this.Value);
		binaryStream_0.smethod_3(this.string_0);
	}

	public string Value;

	public string string_0;
}

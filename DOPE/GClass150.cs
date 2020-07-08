using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass150 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30949;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass150(string string_0 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 30949;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30949);
		binaryStream_0.smethod_3(this.Name);
	}

	public string Name;
}

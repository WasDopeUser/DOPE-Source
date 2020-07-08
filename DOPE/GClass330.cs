using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass330 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -23886;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass330(string string_0 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.nsXhfOnfwl = "";
		base..ctor();
		this.nsXhfOnfwl = string_0;
	}

	public virtual int vmethod_0()
	{
		return -23886;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.nsXhfOnfwl = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-23886);
		binaryStream_0.smethod_3(this.nsXhfOnfwl);
	}

	public string nsXhfOnfwl;
}

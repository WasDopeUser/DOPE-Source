using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass246 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6676;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass246(string string_0 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 6676;
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
		binaryStream_0.smethod_7(6676);
		binaryStream_0.smethod_3(this.Name);
	}

	public string Name;
}

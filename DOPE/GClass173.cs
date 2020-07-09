using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass173 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16576;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass173(string string_1 = "", int int_2 = 0, int int_3 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_3;
		this.string_0 = string_1;
		this.int_1 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 16576;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16576);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(this.int_1);
	}

	public int int_0;

	public string string_0;

	public int int_1;
}

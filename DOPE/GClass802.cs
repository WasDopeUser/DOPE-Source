using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass802 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 100;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass802(string string_1 = "", double double_0 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.Value = double_0;
	}

	public virtual int vmethod_0()
	{
		return 100;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.Value = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(100);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_9(this.Value);
	}

	public string string_0;

	public double Value;
}

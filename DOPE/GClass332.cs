using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass332 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -17947;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass332(int int_1 = 0, string string_0 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.Value = "";
		base..ctor();
		this.int_0 = int_1;
		this.Value = string_0;
	}

	public virtual int vmethod_0()
	{
		return -17947;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.Value = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-17947);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_3(this.Value);
	}

	public int int_0;

	public string Value;
}

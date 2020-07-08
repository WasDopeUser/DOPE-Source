using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass292 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -22265;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass292(string string_1 = "", double double_1 = 0.0)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.double_0 = double_1;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return -22265;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-22265);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public double double_0;

	public string string_0;
}

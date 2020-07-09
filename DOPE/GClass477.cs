using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass477 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -426;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass477(string string_1 = "", double double_1 = 0.0, double double_2 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.KdhGcAgoxd = double_2;
		this.string_0 = string_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return -426;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.KdhGcAgoxd = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-426);
		binaryStream_0.WriteDouble(this.KdhGcAgoxd);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double KdhGcAgoxd;

	public string string_0;

	public double double_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass572 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15419;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass572(string string_1 = "", double double_1 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 15419;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15419);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-24064);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-17500);
	}

	public double double_0;

	public string string_0;
}

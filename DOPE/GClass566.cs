using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass566 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27507;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass566(double double_1 = 0.0, string string_1 = "")
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.double_0 = double_1;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 27507;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27507);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public string string_0;

	public double double_0;
}

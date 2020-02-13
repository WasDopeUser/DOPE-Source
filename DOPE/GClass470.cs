using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass470 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7418;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass470(string string_1 = "", double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 7418;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		this.double_1 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(7418);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_6(-11782);
	}

	public double double_0;

	public string string_0;

	public double double_1;
}

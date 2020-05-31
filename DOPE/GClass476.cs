using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass476 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17600;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass476(string string_1 = "", double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_2;
		this.double_1 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 17600;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17600);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_1);
	}

	public double double_0;

	public string string_0;

	public double double_1;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass301 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23349;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass301(string string_0 = "", double double_1 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		this.nxOesuTdaK = "";
		base..ctor();
		this.nxOesuTdaK = string_0;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 23349;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.nxOesuTdaK = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23349);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.nxOesuTdaK);
		binaryStream_0.smethod_7(-446);
	}

	public double double_0;

	public string nxOesuTdaK;
}

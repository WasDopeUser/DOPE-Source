using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass571 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21168;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass571(string string_1 = "", double double_1 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 21168;
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
		binaryStream_0.smethod_7(21168);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public double double_0;

	public string string_0;
}

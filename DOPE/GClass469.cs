using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass469 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16716;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass469(string string_1 = "", double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_2;
		this.double_1 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 16716;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16716);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_7(7365);
		binaryStream_0.smethod_7(26812);
	}

	public string string_0;

	public double double_0;

	public double double_1;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass564 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30334;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass564(double double_1 = 0.0, string string_1 = "")
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.double_0 = double_1;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 30334;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30334);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_7(-20893);
	}

	public string string_0;

	public double double_0;
}

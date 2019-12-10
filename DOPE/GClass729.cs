using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass729 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21242;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass729(string string_1 = "", double double_0 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.Value = double_0;
	}

	public virtual int vmethod_0()
	{
		return 21242;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Value = (double)binaryStream_0.smethod_8();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(21242);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(this.Value);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_5(28794);
	}

	public double Value;

	public string string_0;
}

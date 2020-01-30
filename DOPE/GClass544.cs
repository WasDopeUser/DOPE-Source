using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass544 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15838;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass544(string string_1 = "", string string_2 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.Value = "";
		base..ctor();
		this.string_0 = string_1;
		this.Value = string_2;
	}

	public virtual int vmethod_0()
	{
		return 15838;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.Value = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15838);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.Value);
		binaryStream_0.smethod_7(18715);
		binaryStream_0.smethod_7(-13945);
	}

	public string string_0;

	public string Value;
}

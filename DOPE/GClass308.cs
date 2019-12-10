using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass308 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15339;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass308(uint uint_1 = 0U, string string_0 = "")
	{
		Class8.xDph7tozmh5WD();
		this.Value = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.Value = string_0;
	}

	public virtual int vmethod_0()
	{
		return 15339;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.Value = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(15339);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(284);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.smethod_3(this.Value);
	}

	public uint uint_0;

	public string Value;
}

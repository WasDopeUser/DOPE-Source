using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass169 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27201;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass169(string string_1 = "", uint uint_2 = 0U, uint uint_3 = 0U)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.uint_0 = uint_2;
		this.uint_1 = uint_3;
	}

	public virtual int vmethod_0()
	{
		return 27201;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.uint_1 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27201);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(62);
		binaryStream_0.smethod_5(7215);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_1);
	}

	public uint uint_0;

	public string string_0;

	public uint uint_1;
}

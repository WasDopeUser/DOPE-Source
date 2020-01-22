using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass172 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28300;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass172(string string_1 = "", uint uint_1 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 28300;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28300);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(-12977);
		binaryStream_0.smethod_7(5649);
		binaryStream_0.smethod_3(this.string_0);
	}

	public uint uint_0;

	public string string_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass329 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30699;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass329(uint uint_1 = 0U, string string_0 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.Value = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.Value = string_0;
	}

	public virtual int vmethod_0()
	{
		return 30699;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.Value = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30699);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_3(this.Value);
		binaryStream_0.smethod_7(-19398);
	}

	public uint uint_0;

	public string Value;
}

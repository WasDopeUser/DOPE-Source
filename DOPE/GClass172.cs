using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass172 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10157;
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
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 10157;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(10157);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
	}

	public uint uint_0;

	public string string_0;
}

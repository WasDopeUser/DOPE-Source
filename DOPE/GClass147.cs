using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass147 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23877;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass147(string string_0 = "", int int_1 = 0, uint uint_1 = 0U)
	{
		Class13.igxcIukzfpare();
		this.qkBqepmgqI = "";
		base..ctor();
		this.qkBqepmgqI = string_0;
		this.int_0 = int_1;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 23877;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.qkBqepmgqI = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(23877);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.MoioCjQkqp0(this.qkBqepmgqI);
		binaryStream_0.smethod_3(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
	}

	public uint uint_0;

	public string qkBqepmgqI;

	public int int_0;
}

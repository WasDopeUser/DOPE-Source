using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass703 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9401;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 7;
		}
	}

	public GClass703(int int_1 = 0, string string_1 = "", bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_1;
		this.string_0 = string_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 9401;
	}

	public virtual int vmethod_1()
	{
		return 7;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9401);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(15296);
		binaryStream_0.smethod_6(12284);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.MoioCjQkqp0(this.string_0);
	}

	public bool bool_0;

	public int int_0;

	public string string_0;
}

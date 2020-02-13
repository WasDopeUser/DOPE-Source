using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass676 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3507;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass676(string string_1 = "", int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 3507;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(3507);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.smethod_6(-19308);
		binaryStream_0.MoioCjQkqp0(this.string_0);
	}

	public int int_0;

	public string string_0;
}

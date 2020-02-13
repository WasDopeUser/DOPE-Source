using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass379 : GClass377, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13205;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass379(string string_1 = "", int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 13205;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(13205);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_6(-15913);
		binaryStream_0.MoioCjQkqp0(this.string_0);
	}

	public int int_0;

	public string string_0;
}

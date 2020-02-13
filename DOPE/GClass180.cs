using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass180 : GClass179, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1828;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass180(string string_2 = "", int int_2 = 0, int int_3 = 0, string string_3 = "")
	{
		Class13.igxcIukzfpare();
		this.string_1 = "";
		base..ctor(string_2, int_2, int_3);
		this.string_1 = string_3;
	}

	public override int vmethod_0()
	{
		return 1828;
	}

	public override int vmethod_1()
	{
		return 22;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(1828);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.smethod_6(7371);
	}

	public string string_1;
}

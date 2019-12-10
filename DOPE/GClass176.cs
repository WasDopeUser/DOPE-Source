using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass176 : GClass172, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2584;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 30;
		}
	}

	public GClass176(string string_2 = "", int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, string string_3 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_1 = "";
		base..ctor(string_2, int_4, int_5);
		this.int_3 = int_6;
		this.int_2 = int_7;
		this.string_1 = string_3;
	}

	public override int vmethod_0()
	{
		return 2584;
	}

	public override int vmethod_1()
	{
		return 30;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(2584);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_5(-1708);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		binaryStream_0.smethod_5(717);
	}

	public int int_2;

	public string string_1;

	public int int_3;
}

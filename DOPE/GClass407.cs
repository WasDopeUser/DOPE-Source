using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass407 : GClass403, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25764;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass407(string string_2 = "", string string_3 = "", int int_2 = 0, int int_3 = 0, GClass550 gclass550_1 = null, GClass434 gclass434_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		this.string_1 = string_3;
		this.int_0 = int_2;
		this.int_1 = int_3;
		if (gclass550_1 == null)
		{
			this.gclass550_0 = new GClass550(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass550_0 = gclass550_1;
		}
		if (gclass434_1 == null)
		{
			this.gclass434_0 = new GClass434(0, 0U);
			return;
		}
		this.gclass434_0 = gclass434_1;
	}

	public override int vmethod_0()
	{
		return 25764;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass434_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass434);
		this.gclass434_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		this.gclass550_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass550);
		this.gclass550_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25764);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.smethod_6(-19672);
		this.gclass434_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.gclass550_0.imethod_2(binaryStream_0);
	}

	public string string_0;

	public string string_1;

	public GClass434 gclass434_0;

	public int int_0;

	public int int_1;

	public GClass550 gclass550_0;
}

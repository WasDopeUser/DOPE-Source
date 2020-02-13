using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass627 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20003;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass627(string string_1 = "", GClass130 gclass130_1 = null, GClass456 gclass456_1 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass130_1 == null)
		{
			this.gclass130_0 = new GClass130(0U);
		}
		else
		{
			this.gclass130_0 = gclass130_1;
		}
		if (gclass456_1 == null)
		{
			this.gclass456_0 = new GClass456(0U);
		}
		else
		{
			this.gclass456_0 = gclass456_1;
		}
		this.int_0 = int_3;
		this.int_2 = int_4;
		this.int_1 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 20003;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		this.gclass130_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass130);
		this.gclass130_0.imethod_1(binaryStream_0);
		this.gclass456_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass456);
		this.gclass456_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(20003);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_3(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		this.gclass130_0.imethod_2(binaryStream_0);
		this.gclass456_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public int int_2;

	public GClass130 gclass130_0;

	public GClass456 gclass456_0;
}

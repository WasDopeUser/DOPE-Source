using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass681 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5410;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass681(int int_4 = 0, int int_5 = 0, string string_2 = "", int int_6 = 0, int int_7 = 0, string string_3 = "", GClass201 gclass201_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_4;
		this.int_2 = int_5;
		this.string_0 = string_2;
		this.int_1 = int_6;
		this.int_3 = int_7;
		this.string_1 = string_3;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
			return;
		}
		this.gclass201_0 = gclass201_1;
	}

	public virtual int vmethod_0()
	{
		return 5410;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		this.string_1 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 13) | this.int_3 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(5410);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_6(-2555);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.smethod_3(this.int_3 << 13 | U.smethod_0(this.int_3, 19));
	}

	public int int_0;

	public GClass201 gclass201_0;

	public string string_0;

	public int int_1;

	public int int_2;

	public string string_1;

	public int int_3;
}

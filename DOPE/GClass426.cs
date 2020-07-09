using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass426 : GClass425, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -9629;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass426(string string_2 = "", bool bool_1 = false, GClass364 gclass364_1 = null, string string_3 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_2 = false, GClass364 gclass364_2 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_1 = "";
		base..ctor(string_2, bool_1, gclass364_1);
		this.int_0 = int_4;
		this.int_1 = int_3;
		if (gclass364_2 == null)
		{
			this.gclass364_0 = new GClass364(null);
		}
		else
		{
			this.gclass364_0 = gclass364_2;
		}
		this.int_2 = int_6;
		this.string_1 = string_3;
		this.Width = int_5;
		this.bool_0 = bool_2;
	}

	public override int vmethod_0()
	{
		return -9629;
	}

	public override int vmethod_1()
	{
		return 19;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.gclass364_0 = (GClass364)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass364_0 != null)
		{
			this.gclass364_0.imethod_1(binaryStream_0);
		}
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.string_1 = binaryStream_0.smethod_2();
		this.Width = binaryStream_0.smethod_0();
		this.Width = (U.smethod_0(this.Width, 9) | this.Width << 23);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-9629);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_4(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		if (this.gclass364_0 != null)
		{
			this.gclass364_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.Width << 9 | U.smethod_0(this.Width, 23));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public int int_1;

	public GClass364 gclass364_0;

	public int int_2;

	public string string_1;

	public int Width;

	public bool bool_0;
}

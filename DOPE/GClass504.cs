using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass504 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31454;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass504(int int_5 = 0, int int_6 = 0, string string_1 = "", GClass616 gclass616_0 = null, GClass722 gclass722_1 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.int_2 = int_5;
		this.int_3 = int_6;
		this.string_0 = string_1;
		if (gclass616_0 == null)
		{
			this.Progress = new GClass616(0, 0.0, 0.0, "", "", null, false);
		}
		else
		{
			this.Progress = gclass616_0;
		}
		if (gclass722_1 == null)
		{
			this.gclass722_0 = new GClass722(null);
		}
		else
		{
			this.gclass722_0 = gclass722_1;
		}
		this.int_0 = int_7;
		this.int_1 = int_8;
		this.int_4 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 31454;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.gclass722_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass722);
		this.gclass722_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		this.Progress = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass616);
		this.Progress.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 1) | this.int_4 << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(31454);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.gclass722_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.Progress.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(517);
		binaryStream_0.smethod_3(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_6(19288);
		binaryStream_0.smethod_3(this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		binaryStream_0.smethod_3(this.int_4 << 1 | U.smethod_0(this.int_4, 31));
	}

	public int int_0;

	public GClass722 gclass722_0;

	public int int_1;

	public GClass616 Progress;

	public int int_2;

	public string string_0;

	public int int_3;

	public int int_4;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass502 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9782;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass502(int int_5 = 0, int int_6 = 0, string string_1 = "", GClass614 gclass614_0 = null, GClass720 gclass720_1 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		base..ctor();
		this.int_1 = int_5;
		this.int_3 = int_6;
		this.string_0 = string_1;
		if (gclass614_0 == null)
		{
			this.Progress = new GClass614(0, 0.0, 0.0, "", "", null, false);
		}
		else
		{
			this.Progress = gclass614_0;
		}
		if (gclass720_1 == null)
		{
			this.gclass720_0 = new GClass720(null);
		}
		else
		{
			this.gclass720_0 = gclass720_1;
		}
		this.int_0 = int_7;
		this.int_2 = int_8;
		this.int_4 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 9782;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.gclass720_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass720);
		this.gclass720_0.imethod_1(binaryStream_0);
		this.Progress = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass614);
		this.Progress.imethod_1(binaryStream_0);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 9) | this.int_4 << 23);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9782);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_4(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.gclass720_0.imethod_2(binaryStream_0);
		this.Progress.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		binaryStream_0.smethod_7(-15802);
		binaryStream_0.smethod_4(this.int_4 << 9 | U.smethod_0(this.int_4, 23));
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public GClass720 gclass720_0;

	public GClass614 Progress;

	public int int_3;

	public int int_4;

	public string string_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass502 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8581;
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
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.int_2 = int_5;
		this.int_1 = int_6;
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
		this.int_4 = int_8;
		this.int_3 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 8581;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.Progress = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass614);
		this.Progress.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 4) | this.int_2 << 28);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		this.gclass720_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass720);
		this.gclass720_0.imethod_1(binaryStream_0);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 8 | U.smethod_0(this.int_4, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8581);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.Progress.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(25265);
		binaryStream_0.smethod_4(this.int_2 << 4 | U.smethod_0(this.int_2, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		this.gclass720_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 8) | this.int_4 << 24);
	}

	public int int_0;

	public int int_1;

	public GClass614 Progress;

	public string string_0;

	public int int_2;

	public int int_3;

	public GClass720 gclass720_0;

	public int int_4;
}

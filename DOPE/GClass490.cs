using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass490 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19592;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass490(int int_5 = 0, int int_6 = 0, string string_1 = "", GClass602 gclass602_0 = null, GClass710 gclass710_1 = null, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.int_3 = int_5;
		this.int_4 = int_6;
		this.string_0 = string_1;
		if (gclass602_0 == null)
		{
			this.Progress = new GClass602(0, 0.0, 0.0, "", "", null, false);
		}
		else
		{
			this.Progress = gclass602_0;
		}
		if (gclass710_1 == null)
		{
			this.gclass710_0 = new GClass710(null);
		}
		else
		{
			this.gclass710_0 = gclass710_1;
		}
		this.int_0 = int_7;
		this.int_2 = int_8;
		this.int_1 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 19592;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass710_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass710);
		this.gclass710_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 10) | this.int_2 << 22);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 4 | U.smethod_0(this.int_4, 28));
		this.Progress = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass602);
		this.Progress.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(19592);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_5(-12559);
		binaryStream_0.smethod_5(-11044);
		this.gclass710_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(this.int_2 << 10 | U.smethod_0(this.int_2, 22));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_4, 4) | this.int_4 << 28);
		this.Progress.imethod_2(binaryStream_0);
	}

	public int int_0;

	public int int_1;

	public GClass710 gclass710_0;

	public string string_0;

	public int int_2;

	public int int_3;

	public int int_4;

	public GClass602 Progress;
}

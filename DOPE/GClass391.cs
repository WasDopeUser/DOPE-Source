using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass391 : GClass387, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4794;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass391(string string_2 = "", string string_3 = "", int int_1 = 0, int int_2 = 0, GClass536 gclass536_1 = null, GClass419 gclass419_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_1 = string_2;
		this.string_0 = string_3;
		this.XaOtFxWgmD = int_1;
		this.int_0 = int_2;
		if (gclass536_1 == null)
		{
			this.gclass536_0 = new GClass536(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass536_0 = gclass536_1;
		}
		if (gclass419_1 == null)
		{
			this.gclass419_0 = new GClass419(0, 0U);
			return;
		}
		this.gclass419_0 = gclass419_1;
	}

	public override int vmethod_0()
	{
		return 4794;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass536_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass536);
		this.gclass536_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.XaOtFxWgmD = binaryStream_0.smethod_0();
		this.XaOtFxWgmD = (this.XaOtFxWgmD << 15 | U.smethod_0(this.XaOtFxWgmD, 17));
		this.string_1 = binaryStream_0.smethod_2();
		this.gclass419_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass419);
		this.gclass419_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(4794);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		this.gclass536_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-17791);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.XaOtFxWgmD, 15) | this.XaOtFxWgmD << 17);
		binaryStream_0.smethod_3(this.string_1);
		this.gclass419_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-31971);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
	}

	public string string_0;

	public GClass536 gclass536_0;

	public int XaOtFxWgmD;

	public string string_1;

	public GClass419 gclass419_0;

	public int int_0;
}

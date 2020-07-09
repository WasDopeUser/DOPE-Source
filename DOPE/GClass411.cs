using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass411 : GClass407, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -875;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass411(string string_2 = "", string string_3 = "", int int_2 = 0, int int_3 = 0, GClass571 gclass571_1 = null, GClass439 gclass439_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		if (gclass571_1 == null)
		{
			this.gclass571_0 = new GClass571(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass571_0 = gclass571_1;
		}
		this.int_0 = int_2;
		if (gclass439_1 == null)
		{
			this.gclass439_0 = new GClass439(0, 0);
		}
		else
		{
			this.gclass439_0 = gclass439_1;
		}
		this.string_1 = string_3;
		this.int_1 = int_3;
	}

	public override int vmethod_0()
	{
		return -875;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass571_0 = (GClass571)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass571_0 != null)
		{
			this.gclass571_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.gclass439_0 = (GClass439)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass439_0 != null)
		{
			this.gclass439_0.imethod_1(binaryStream_0);
		}
		this.string_1 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-875);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass571_0 != null)
		{
			this.gclass571_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		if (this.gclass439_0 != null)
		{
			this.gclass439_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
	}

	public string string_0;

	public GClass571 gclass571_0;

	public int int_0;

	public GClass439 gclass439_0;

	public string string_1;

	public int int_1;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass626 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7072;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass626(string string_1 = "", GClass130 gclass130_1 = null, GClass454 gclass454_1 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
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
		if (gclass454_1 == null)
		{
			this.gclass454_0 = new GClass454(0U);
		}
		else
		{
			this.gclass454_0 = gclass454_1;
		}
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 7072;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.gclass130_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass130);
		this.gclass130_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass454_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass454);
		this.gclass454_0.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7072);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.gclass130_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_3(this.string_0);
		this.gclass454_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
	}

	public int int_0;

	public GClass130 gclass130_0;

	public int int_1;

	public string string_0;

	public GClass454 gclass454_0;

	public int int_2;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass499 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19468;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass499(uint uint_1 = 0U, string string_1 = "", int int_1 = 0, GClass492 gclass492_1 = null, GClass493 gclass493_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.string_0 = string_1;
		this.int_0 = int_1;
		if (gclass492_1 == null)
		{
			this.gclass492_0 = new GClass492(0.0, 0.0);
		}
		else
		{
			this.gclass492_0 = gclass492_1;
		}
		if (gclass493_1 == null)
		{
			this.gclass493_0 = new GClass493(0, 0);
			return;
		}
		this.gclass493_0 = gclass493_1;
	}

	public virtual int vmethod_0()
	{
		return 19468;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.gclass492_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass492);
		this.gclass492_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass493_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass493);
		this.gclass493_0.HrqIugnatr8(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19468);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23339);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.gclass492_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-21428);
		this.gclass493_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public GClass492 gclass492_0;

	public GClass493 gclass493_0;

	public uint uint_0;

	public string string_0;
}

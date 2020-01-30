using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass488 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11016;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass488(uint uint_1 = 0U, string string_1 = "", int int_1 = 0, GClass483 gclass483_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.string_0 = string_1;
		this.int_0 = int_1;
		if (gclass483_1 == null)
		{
			this.gclass483_0 = new GClass483(0.0, 0.0);
			return;
		}
		this.gclass483_0 = gclass483_1;
	}

	public virtual int vmethod_0()
	{
		return 11016;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass483_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass483);
		this.gclass483_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11016);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-25262);
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass483_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
	}

	public string string_0;

	public uint uint_0;

	public GClass483 gclass483_0;

	public int int_0;
}

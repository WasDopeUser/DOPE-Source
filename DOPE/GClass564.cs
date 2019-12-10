using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass564 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13498;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass564(GClass772 gclass772_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass772_1 == null)
		{
			this.gclass772_0 = new GClass772(0U);
		}
		else
		{
			this.gclass772_0 = gclass772_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 13498;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.gclass772_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass772);
		this.gclass772_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(13498);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.fUeiimuocMk(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		this.gclass772_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-9791);
	}

	public int int_0;

	public int int_1;

	public GClass772 gclass772_0;
}

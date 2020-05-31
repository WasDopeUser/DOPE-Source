using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass593 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5101;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass593(GClass799 gclass799_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass799_1 == null)
		{
			this.gclass799_0 = new GClass799(0U);
		}
		else
		{
			this.gclass799_0 = gclass799_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 5101;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.gclass799_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass799);
		this.gclass799_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5101);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.gclass799_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-5277);
		binaryStream_0.smethod_4(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
	}

	public int int_0;

	public GClass799 gclass799_0;

	public int int_1;
}

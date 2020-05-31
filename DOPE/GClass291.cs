using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass291 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24178;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass291(int int_1 = 0, GClass489 gclass489_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_0 = int_1;
		if (gclass489_1 == null)
		{
			this.gclass489_0 = new GClass489(false, 0);
			return;
		}
		this.gclass489_0 = gclass489_1;
	}

	public virtual int vmethod_0()
	{
		return 24178;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass489_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass489);
		this.gclass489_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24178);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24574);
		this.gclass489_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(11780);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
	}

	public GClass489 gclass489_0;

	public int int_0;
}

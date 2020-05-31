using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass495 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31740;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass495(int int_2 = 0, int int_3 = 0, GClass367 gclass367_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		if (gclass367_0 == null)
		{
			this.ToolTip = new GClass367(null);
			return;
		}
		this.ToolTip = gclass367_0;
	}

	public virtual int vmethod_0()
	{
		return 31740;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass367);
		this.ToolTip.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31740);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-10555);
		this.ToolTip.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
	}

	public GClass367 ToolTip;

	public int int_0;

	public int int_1;
}

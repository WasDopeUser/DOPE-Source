using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass485 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21243;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass485(int int_2 = 0, int int_3 = 0, GClass359 gclass359_0 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		if (gclass359_0 == null)
		{
			this.ToolTip = new GClass359(null);
			return;
		}
		this.ToolTip = gclass359_0;
	}

	public virtual int vmethod_0()
	{
		return 21243;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_1();
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass359);
		this.ToolTip.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21243);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_7(30143);
		this.ToolTip.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
	}

	public int int_0;

	public GClass359 ToolTip;

	public int int_1;
}

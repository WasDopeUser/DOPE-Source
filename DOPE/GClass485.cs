using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass485 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1809;
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
		Class13.plZSWFPzBWWEZ();
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
		return 1809;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass359);
		this.ToolTip.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1809);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-9757);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.ToolTip.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
	}

	public int int_0;

	public GClass359 ToolTip;

	public int int_1;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass496 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2085;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass496(int int_2 = 0, int int_3 = 0, GClass364 gclass364_0 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		if (gclass364_0 == null)
		{
			this.ToolTip = new GClass364(null);
			return;
		}
		this.ToolTip = gclass364_0;
	}

	public virtual int vmethod_0()
	{
		return 2085;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.ToolTip = (GClass364)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.ToolTip != null)
		{
			this.ToolTip.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2085);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		if (this.ToolTip != null)
		{
			this.ToolTip.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public int int_1;

	public GClass364 ToolTip;
}

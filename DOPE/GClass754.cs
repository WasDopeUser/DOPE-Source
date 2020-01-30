using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass754 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21106;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass754(uint uint_1 = 0U, GClass771 gclass771_2 = null, GClass771 gclass771_3 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass771_2 == null)
		{
			this.gclass771_1 = new GClass771(0, 0, false);
		}
		else
		{
			this.gclass771_1 = gclass771_2;
		}
		if (gclass771_3 == null)
		{
			this.gclass771_0 = new GClass771(0, 0, false);
			return;
		}
		this.gclass771_0 = gclass771_3;
	}

	public virtual int vmethod_0()
	{
		return 21106;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass771_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass771);
		this.gclass771_0.imethod_1(binaryStream_0);
		this.gclass771_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass771);
		this.gclass771_1.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21106);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25925);
		binaryStream_0.smethod_7(-4614);
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass771_0.imethod_2(binaryStream_0);
		this.gclass771_1.imethod_2(binaryStream_0);
	}

	public uint uint_0;

	public GClass771 gclass771_0;

	public GClass771 gclass771_1;
}

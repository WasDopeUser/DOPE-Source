using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass768 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20566;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass768(uint uint_1 = 0U, GClass786 gclass786_2 = null, GClass786 gclass786_3 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass786_2 == null)
		{
			this.gclass786_0 = new GClass786(0, 0, false);
		}
		else
		{
			this.gclass786_0 = gclass786_2;
		}
		if (gclass786_3 == null)
		{
			this.gclass786_1 = new GClass786(0, 0, false);
			return;
		}
		this.gclass786_1 = gclass786_3;
	}

	public virtual int vmethod_0()
	{
		return 20566;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass786_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass786);
		this.gclass786_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass786_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass786);
		this.gclass786_1.HrqIugnatr8(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20566);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass786_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(24268);
		this.gclass786_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public GClass786 gclass786_0;

	public GClass786 gclass786_1;

	public uint uint_0;
}

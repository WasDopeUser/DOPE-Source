using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass621 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14676;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass621(GClass762 gclass762_1 = null, GClass318 gclass318_1 = null, int int_1 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass762_1 == null)
		{
			this.gclass762_0 = new GClass762(0U);
		}
		else
		{
			this.gclass762_0 = gclass762_1;
		}
		if (gclass318_1 == null)
		{
			this.gclass318_0 = new GClass318(0U);
		}
		else
		{
			this.gclass318_0 = gclass318_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 14676;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass318_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass318);
		this.gclass318_0.imethod_1(binaryStream_0);
		this.gclass762_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass762);
		this.gclass762_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14676);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27631);
		this.gclass318_0.imethod_2(binaryStream_0);
		this.gclass762_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
	}

	public GClass318 gclass318_0;

	public GClass762 gclass762_0;

	public int int_0;
}

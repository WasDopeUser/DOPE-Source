using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass708 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21720;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass708(GClass762 gclass762_1 = null, int int_1 = 0)
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
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 21720;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.gclass762_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass762);
		this.gclass762_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21720);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11465);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.gclass762_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass762 gclass762_0;
}

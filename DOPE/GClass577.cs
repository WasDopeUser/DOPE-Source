using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass577 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6161;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass577(GClass783 gclass783_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass783_1 == null)
		{
			this.gclass783_0 = new GClass783(0U);
		}
		else
		{
			this.gclass783_0 = gclass783_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 6161;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_1();
		this.gclass783_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass783);
		this.gclass783_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6161);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_7(8917);
		this.gclass783_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
	}

	public int int_0;

	public GClass783 gclass783_0;

	public int int_1;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass701 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23839;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass701(GClass693 gclass693_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass693_1 == null)
		{
			this.gclass693_0 = new GClass693();
		}
		else
		{
			this.gclass693_0 = gclass693_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 23839;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.gclass693_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass693);
		this.gclass693_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23839);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4418);
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.gclass693_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
	}

	public int int_0;

	public GClass693 gclass693_0;

	public int int_1;
}

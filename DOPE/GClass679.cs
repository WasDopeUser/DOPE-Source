using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass679 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10850;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass679(GClass318 gclass318_1 = null, uint uint_0 = 0U, int int_1 = 0, int int_2 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass318_1 == null)
		{
			this.gclass318_0 = new GClass318(0U);
		}
		else
		{
			this.gclass318_0 = gclass318_1;
		}
		this.jUmgofkjPv = uint_0;
		this.XvOgPoEfxB = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 10850;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.XvOgPoEfxB = binaryStream_0.smethod_0();
		this.XvOgPoEfxB = (U.smethod_0(this.XvOgPoEfxB, 16) | this.XvOgPoEfxB << 16);
		binaryStream_0.smethod_1();
		this.gclass318_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass318);
		this.gclass318_0.imethod_1(binaryStream_0);
		this.jUmgofkjPv = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10850);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.XvOgPoEfxB << 16 | U.smethod_0(this.XvOgPoEfxB, 16));
		binaryStream_0.smethod_7(-18991);
		this.gclass318_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(this.jUmgofkjPv);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_7(27502);
	}

	public int XvOgPoEfxB;

	public GClass318 gclass318_0;

	public uint jUmgofkjPv;

	public int int_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass424 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7466;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass424(uint uint_1 = 0U, GClass318 gclass318_1 = null, int int_1 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.uint_0 = uint_1;
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
		return 7466;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass318_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass318);
		this.gclass318_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7466);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-2166);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass318_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public uint uint_0;

	public GClass318 gclass318_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass678 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24792;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass678(GClass318 gclass318_1 = null, uint uint_1 = 0U, int int_2 = 0, int int_3 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass318_1 == null)
		{
			this.gclass318_0 = new GClass318(0U);
		}
		else
		{
			this.gclass318_0 = gclass318_1;
		}
		this.uint_0 = uint_1;
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 24792;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass318_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass318);
		this.gclass318_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24792);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass318_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
	}

	public GClass318 gclass318_0;

	public int int_0;

	public uint uint_0;

	public int int_1;
}

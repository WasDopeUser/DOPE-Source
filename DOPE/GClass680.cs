using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass680 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6807;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass680(GClass320 gclass320_1 = null, uint uint_1 = 0U, int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass320_1 == null)
		{
			this.gclass320_0 = new GClass320(0U);
		}
		else
		{
			this.gclass320_0 = gclass320_1;
		}
		this.uint_0 = uint_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 6807;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass320_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass320);
		this.gclass320_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(6807);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-26716);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_5(this.uint_0);
		this.gclass320_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-3093);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
	}

	public int int_0;

	public uint uint_0;

	public GClass320 gclass320_0;

	public int int_1;
}

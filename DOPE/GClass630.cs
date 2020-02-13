using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass630 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27916;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass630(uint uint_1 = 0U, int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 27916;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27916);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_3(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
	}

	public uint uint_0;

	public int int_0;
}

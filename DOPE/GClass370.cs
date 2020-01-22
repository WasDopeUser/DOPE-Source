using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass370 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 152;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass370(uint uint_1 = 0U, int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 152;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(152);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(25229);
		binaryStream_0.smethod_7(12167);
	}

	public int int_0;

	public uint uint_0;
}

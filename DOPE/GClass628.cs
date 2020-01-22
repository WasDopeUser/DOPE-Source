using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass628 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6075;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass628(uint uint_1 = 0U, int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 6075;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6075);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
	}

	public uint uint_0;

	public int int_0;
}

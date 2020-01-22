using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass283 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8097;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass283(uint uint_1 = 0U, int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 8097;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8097);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public int int_0;

	public uint uint_0;
}

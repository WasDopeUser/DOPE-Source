using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass362 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3652;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass362(uint uint_1 = 0U, int int_2 = 0, int int_3 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 3652;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3652);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(5378);
	}

	public int int_0;

	public int int_1;

	public uint uint_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass213 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14387;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass213(int int_1 = 0, int int_2 = 0, uint uint_1 = 0U)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.FromId = int_1;
		this.int_0 = int_2;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 14387;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (U.smethod_0(this.FromId, 1) | this.FromId << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14387);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(-4112);
		binaryStream_0.smethod_4(this.FromId << 1 | U.smethod_0(this.FromId, 31));
	}

	public int int_0;

	public uint uint_0;

	public int FromId;
}

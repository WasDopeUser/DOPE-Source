using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass213 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4531;
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
		Class13.igxcIukzfpare();
		base..ctor();
		this.FromId = int_1;
		this.int_0 = int_2;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 4531;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (this.FromId << 2 | U.smethod_0(this.FromId, 30));
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(4531);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_3(U.smethod_0(this.FromId, 2) | this.FromId << 30);
		binaryStream_0.smethod_6(17045);
		binaryStream_0.smethod_3(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
	}

	public uint uint_0;

	public int FromId;

	public int int_0;
}

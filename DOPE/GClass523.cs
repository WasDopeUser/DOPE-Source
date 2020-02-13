using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass523 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18115;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass523(uint uint_0 = 0U, int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Status = uint_0;
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 18115;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Status = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(18115);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.Status);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_3(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
	}

	public uint Status;

	public int int_0;

	public int int_1;
}

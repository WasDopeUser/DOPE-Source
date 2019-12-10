using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass436 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24202;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass436(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 24202;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 12) | this.int_2 << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(24202);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_5(-24793);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.fUeiimuocMk(this.int_2 << 12 | U.smethod_0(this.int_2, 20));
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

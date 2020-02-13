using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass740 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30664;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass740(int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 30664;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(30664);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-1586);
		binaryStream_0.smethod_3(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		binaryStream_0.smethod_6(15191);
	}

	public int int_0;

	public int int_1;
}

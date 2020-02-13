using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass225 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32609;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass225(int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 32609;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(32609);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_6(-6501);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.smethod_6(30421);
	}

	public int int_0;

	public int int_1;
}

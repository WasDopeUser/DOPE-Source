using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass128 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6059;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass128(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 6059;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(6059);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_3(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		binaryStream_0.smethod_6(-21562);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		binaryStream_0.smethod_6(1644);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

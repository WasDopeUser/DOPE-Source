using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass316 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29148;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass316(int int_6 = 0, uint uint_1 = 0U, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_5 = int_6;
		this.uint_0 = uint_1;
		this.int_1 = int_7;
		this.int_3 = int_8;
		this.int_0 = int_9;
		this.int_2 = int_10;
		this.int_4 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 29148;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 10) | this.int_3 << 22);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 11) | this.int_4 << 21);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 14 | U.smethod_0(this.int_5, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29148);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_4(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.smethod_4(this.int_3 << 10 | U.smethod_0(this.int_3, 22));
		binaryStream_0.smethod_4(this.int_4 << 11 | U.smethod_0(this.int_4, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 14) | this.int_5 << 18);
	}

	public int int_0;

	public uint uint_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;
}

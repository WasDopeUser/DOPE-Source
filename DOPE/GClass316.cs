using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass316 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3983;
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
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_1 = int_6;
		this.uint_0 = uint_1;
		this.int_3 = int_7;
		this.int_5 = int_8;
		this.int_2 = int_9;
		this.int_4 = int_10;
		this.int_0 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 3983;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 9) | this.int_3 << 23);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 12 | U.smethod_0(this.int_4, 20));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 6) | this.int_5 << 26);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3983);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_4(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.smethod_7(16953);
		binaryStream_0.smethod_4(this.int_3 << 9 | U.smethod_0(this.int_3, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 12) | this.int_4 << 20);
		binaryStream_0.smethod_4(this.int_5 << 6 | U.smethod_0(this.int_5, 26));
		binaryStream_0.smethod_6(this.uint_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public uint uint_0;
}

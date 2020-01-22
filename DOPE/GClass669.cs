using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass669 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28566;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass669(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_4;
		this.int_2 = int_5;
		this.int_1 = int_6;
		this.int_3 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 28566;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 10) | this.int_3 << 22);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28566);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.smethod_7(25678);
		binaryStream_0.smethod_4(this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		binaryStream_0.smethod_7(1629);
		binaryStream_0.smethod_4(this.int_3 << 10 | U.smethod_0(this.int_3, 22));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass268 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14712;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 33;
		}
	}

	public GClass268(int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.IiecLscxlx = int_7;
		this.int_2 = int_8;
		this.int_0 = int_9;
		this.int_3 = int_10;
		this.int_1 = int_11;
		this.int_5 = int_12;
		this.int_4 = int_13;
		this.int_6 = int_14;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 14712;
	}

	public virtual int vmethod_1()
	{
		return 33;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.IiecLscxlx = binaryStream_0.smethod_0();
		this.IiecLscxlx = (U.smethod_0(this.IiecLscxlx, 7) | this.IiecLscxlx << 25);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 11 | U.smethod_0(this.int_4, 21));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 8 | U.smethod_0(this.int_5, 24));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 12 | U.smethod_0(this.int_6, 20));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14712);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_4(this.IiecLscxlx << 7 | U.smethod_0(this.IiecLscxlx, 25));
		binaryStream_0.smethod_4(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 11) | this.int_4 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 8) | this.int_5 << 24);
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 12) | this.int_6 << 20);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public int int_1;

	public int IiecLscxlx;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public bool bool_0;
}

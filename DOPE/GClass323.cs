using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass323 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29758;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass323(int int_6 = 0, uint uint_1 = 0U, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_4 = int_6;
		this.uint_0 = uint_1;
		this.int_1 = int_7;
		this.int_0 = int_8;
		this.int_5 = int_9;
		this.int_3 = int_10;
		this.int_2 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 29758;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 11) | this.int_4 << 21);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 5) | this.int_5 << 27);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29758);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_4(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(4601);
		binaryStream_0.smethod_4(this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		binaryStream_0.smethod_4(this.int_4 << 11 | U.smethod_0(this.int_4, 21));
		binaryStream_0.smethod_4(this.int_5 << 5 | U.smethod_0(this.int_5, 27));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public uint uint_0;

	public int int_3;

	public int int_4;

	public int int_5;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass714 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1645;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass714(uint uint_1 = 0U, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_3 = int_4;
		this.int_1 = int_5;
		this.int_0 = int_6;
		this.int_2 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 1645;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 9) | this.int_3 << 23);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(1645);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(1013);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_6(16808);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_3(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.smethod_3(this.int_3 << 9 | U.smethod_0(this.int_3, 23));
	}

	public uint uint_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}

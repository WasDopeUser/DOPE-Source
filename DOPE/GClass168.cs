using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass168 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12262;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass168(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_3 = int_5;
		this.int_2 = int_6;
		this.int_0 = int_7;
		this.int_4 = int_8;
		this.int_1 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 12262;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 9) | this.int_3 << 23);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 3) | this.int_4 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12262);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-9116);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.smethod_4(this.int_3 << 9 | U.smethod_0(this.int_3, 23));
		binaryStream_0.smethod_4(this.int_4 << 3 | U.smethod_0(this.int_4, 29));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}

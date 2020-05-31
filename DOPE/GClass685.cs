using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass685 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22135;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass685(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_2 = int_4;
		this.int_3 = int_5;
		this.int_1 = int_6;
		this.int_0 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 22135;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 10) | this.int_2 << 22);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 12) | this.int_3 << 20);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22135);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_4(this.int_2 << 10 | U.smethod_0(this.int_2, 22));
		binaryStream_0.smethod_4(this.int_3 << 12 | U.smethod_0(this.int_3, 20));
		binaryStream_0.smethod_7(-3044);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass267 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18976;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass267(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.int_3 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 18976;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 13) | this.int_3 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18976);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2820);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		binaryStream_0.smethod_7(-6556);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		binaryStream_0.smethod_4(this.int_3 << 13 | U.smethod_0(this.int_3, 19));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}

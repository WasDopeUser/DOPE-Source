using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass689 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21247;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass689(int int_2 = 0, int int_3 = 0, double double_1 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 21247;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_8();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(21247);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(this.double_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_5(10597);
		binaryStream_0.smethod_5(24833);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
	}

	public double double_0;

	public int int_0;

	public int int_1;
}

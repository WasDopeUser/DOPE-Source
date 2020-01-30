using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass579 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6360;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass579(int int_1 = 0, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_1;
		this.double_1 = double_2;
		this.double_0 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 6360;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.double_1 = (double)binaryStream_0.smethod_10();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6360);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_9(this.double_1);
		binaryStream_0.smethod_7(-20784);
	}

	public int int_0;

	public double double_0;

	public double double_1;
}

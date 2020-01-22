using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass615 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26011;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass615(int int_2 = 0, int int_3 = 0, double double_1 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 26011;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26011);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
	}

	public double double_0;

	public int int_0;

	public int int_1;
}

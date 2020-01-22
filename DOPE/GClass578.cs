using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass578 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19471;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass578(int int_1 = 0, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
		this.double_0 = double_2;
		this.double_1 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 19471;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.double_0 = (double)binaryStream_0.smethod_10();
		binaryStream_0.smethod_1();
		this.double_1 = (double)binaryStream_0.smethod_10();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19471);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-18252);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_7(25253);
		binaryStream_0.smethod_9(this.double_1);
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
	}

	public double double_0;

	public double double_1;

	public int int_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass443 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9354;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass443(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 9354;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9354);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

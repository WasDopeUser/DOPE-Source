using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass218 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20448;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass218(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_2 = int_4;
		this.int_1 = int_5;
		this.int_0 = int_6;
		this.int_3 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 20448;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 16 | U.smethod_0(this.int_3, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20448);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7835);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.smethod_4(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 16) | this.int_3 << 16);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}

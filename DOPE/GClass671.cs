using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass671 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12146;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass671(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_3 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
		this.int_1 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 12146;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(12146);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_3(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}

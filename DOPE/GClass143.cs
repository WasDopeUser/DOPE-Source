using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass143 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19606;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass143(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Id = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 19606;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 16) | this.Id << 16);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19606);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_7(-24246);
		binaryStream_0.smethod_7(-22086);
		binaryStream_0.smethod_4(this.Id << 16 | U.smethod_0(this.Id, 16));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
	}

	public int int_0;

	public int Id;

	public int int_1;
}

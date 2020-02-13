using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass619 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21701;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass619(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Id = int_4;
		this.int_2 = int_5;
		this.int_0 = int_6;
		this.int_3 = int_7;
		this.int_1 = int_8;
	}

	public virtual int vmethod_0()
	{
		return 21701;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 7 | U.smethod_0(this.Id, 25));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 2 | U.smethod_0(this.int_3, 30));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(21701);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.smethod_3(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.smethod_3(U.smethod_0(this.Id, 7) | this.Id << 25);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 2) | this.int_3 << 30);
		binaryStream_0.smethod_6(-8564);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int Id;

	public int int_3;
}

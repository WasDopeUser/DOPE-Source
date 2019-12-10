using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass679 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18768;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass679(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_3;
		this.int_2 = int_4;
		this.Color = int_5;
		this.int_1 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 18768;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.Color = binaryStream_0.smethod_0();
		this.Color = (U.smethod_0(this.Color, 15) | this.Color << 17);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 14) | this.int_2 << 18);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(18768);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.fUeiimuocMk(this.Color << 15 | U.smethod_0(this.Color, 17));
		binaryStream_0.fUeiimuocMk(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.fUeiimuocMk(this.int_2 << 14 | U.smethod_0(this.int_2, 18));
	}

	public int int_0;

	public int Color;

	public int int_1;

	public int int_2;
}

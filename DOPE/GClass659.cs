using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass659 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15448;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass659(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_7;
		this.int_1 = int_8;
		this.int_2 = int_5;
		this.Id = int_4;
		this.int_3 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 15448;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 15 | U.smethod_0(this.Id, 17));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 12) | this.int_3 << 20);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15448);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 15) | this.Id << 17);
		binaryStream_0.smethod_4(this.int_3 << 12 | U.smethod_0(this.int_3, 20));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int Id;

	public int int_3;
}

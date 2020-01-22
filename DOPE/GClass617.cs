using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass617 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15831;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass617(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.Id = int_4;
		this.int_2 = int_5;
		this.int_0 = int_6;
		this.int_3 = int_7;
		this.int_1 = int_8;
	}

	public virtual int vmethod_0()
	{
		return 15831;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 11 | U.smethod_0(this.Id, 21));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 1 | U.smethod_0(this.int_3, 31));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15831);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 11) | this.Id << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_7(-20724);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_4(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 1) | this.int_3 << 31);
	}

	public int Id;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}

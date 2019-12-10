using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass724 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 227;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass724(int int_1 = 0, int int_2 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
		this.oxHfxsadCJ = int_2;
	}

	public virtual int vmethod_0()
	{
		return 227;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.oxHfxsadCJ = binaryStream_0.smethod_0();
		this.oxHfxsadCJ = (U.smethod_0(this.oxHfxsadCJ, 7) | this.oxHfxsadCJ << 25);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(227);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.oxHfxsadCJ << 7 | U.smethod_0(this.oxHfxsadCJ, 25));
		binaryStream_0.smethod_5(-21741);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_5(29191);
	}

	public int oxHfxsadCJ;

	public int int_0;
}

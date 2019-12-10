using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass580 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30347;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass580(GClass128 gclass128_1 = null, int int_1 = 0, int int_2 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass128_1 == null)
		{
			this.gclass128_0 = new GClass128(0U);
		}
		else
		{
			this.gclass128_0 = gclass128_1;
		}
		this.JbyEeuwxkR = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 30347;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.JbyEeuwxkR = binaryStream_0.smethod_0();
		this.JbyEeuwxkR = (U.smethod_0(this.JbyEeuwxkR, 16) | this.JbyEeuwxkR << 16);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.gclass128_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass128);
		this.gclass128_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(30347);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.JbyEeuwxkR << 16 | U.smethod_0(this.JbyEeuwxkR, 16));
		binaryStream_0.fUeiimuocMk(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.gclass128_0.imethod_2(binaryStream_0);
	}

	public int JbyEeuwxkR;

	public int int_0;

	public GClass128 gclass128_0;
}

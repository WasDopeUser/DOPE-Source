using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass427 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11480;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass427(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.cxAmDyfrje = int_4;
	}

	public virtual int vmethod_0()
	{
		return 11480;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.cxAmDyfrje = binaryStream_0.smethod_0();
		this.cxAmDyfrje = (this.cxAmDyfrje << 13 | U.smethod_0(this.cxAmDyfrje, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11480);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-21552);
		binaryStream_0.smethod_7(6838);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.cxAmDyfrje, 13) | this.cxAmDyfrje << 19);
		binaryStream_0.smethod_4(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
	}

	public int int_0;

	public int cxAmDyfrje;

	public int int_1;
}

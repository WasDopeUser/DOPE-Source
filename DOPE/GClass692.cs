using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass692 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19738;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass692(int int_1 = 0, int int_2 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_1;
		this.vbyyDomuxV = int_2;
	}

	public virtual int vmethod_0()
	{
		return 19738;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.vbyyDomuxV = binaryStream_0.smethod_0();
		this.vbyyDomuxV = (U.smethod_0(this.vbyyDomuxV, 16) | this.vbyyDomuxV << 16);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19738);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_4(this.vbyyDomuxV << 16 | U.smethod_0(this.vbyyDomuxV, 16));
	}

	public int int_0;

	public int vbyyDomuxV;
}

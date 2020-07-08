using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass153 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19862;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass153(int int_1 = 0, int int_2 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_1;
		this.EkBoLoNfyc = int_2;
	}

	public virtual int vmethod_0()
	{
		return 19862;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.EkBoLoNfyc = binaryStream_0.smethod_0();
		this.EkBoLoNfyc = (this.EkBoLoNfyc << 4 | U.smethod_0(this.EkBoLoNfyc, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19862);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.EkBoLoNfyc, 4) | this.EkBoLoNfyc << 28);
	}

	public int int_0;

	public int EkBoLoNfyc;
}

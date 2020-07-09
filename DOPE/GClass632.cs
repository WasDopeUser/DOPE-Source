using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass632 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6671;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass632(int int_1 = 0, int int_2 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_1;
		this.FcpapCsMf7 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 6671;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.FcpapCsMf7 = binaryStream_0.smethod_0();
		this.FcpapCsMf7 = (U.smethod_0(this.FcpapCsMf7, 11) | this.FcpapCsMf7 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6671);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(this.FcpapCsMf7 << 11 | U.smethod_0(this.FcpapCsMf7, 21));
	}

	public int int_0;

	public int FcpapCsMf7;
}

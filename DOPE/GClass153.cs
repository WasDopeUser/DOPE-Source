using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass153 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24808;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass153(int int_0 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.RsyllvsLlx = int_0;
	}

	public virtual int vmethod_0()
	{
		return 24808;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.RsyllvsLlx = binaryStream_0.smethod_0();
		this.RsyllvsLlx = (this.RsyllvsLlx << 6 | U.smethod_0(this.RsyllvsLlx, 26));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(24808);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.RsyllvsLlx, 6) | this.RsyllvsLlx << 26);
		binaryStream_0.smethod_5(-12850);
	}

	public int RsyllvsLlx;
}

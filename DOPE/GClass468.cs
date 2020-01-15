using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass468 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25401;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass468(uint uint_0 = 0U)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.wgSirVurVo = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 25401;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.wgSirVurVo = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25401);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.wgSirVurVo);
	}

	public uint wgSirVurVo;
}

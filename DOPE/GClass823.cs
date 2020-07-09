using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass823 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 202;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass823(int int_0 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.VrxxNhiNlx = int_0;
	}

	public virtual int vmethod_0()
	{
		return 202;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.VrxxNhiNlx = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(202);
		binaryStream_0.smethod_7(this.VrxxNhiNlx);
	}

	public int VrxxNhiNlx;
}

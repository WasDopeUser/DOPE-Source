using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass608 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2006;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass608(int int_0 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 2006;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 1 | U.smethod_0(this.Id, 31));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2006);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 1) | this.Id << 31);
	}

	public int Id;
}

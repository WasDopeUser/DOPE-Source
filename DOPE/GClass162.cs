using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass162 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24726;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass162()
	{
		Class13.igxcIukzfpare();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 24726;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(24726);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
	}
}

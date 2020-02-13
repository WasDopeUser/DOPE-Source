using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass303 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7626;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass303()
	{
		Class13.igxcIukzfpare();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 7626;
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
		binaryStream_0.smethod_6(7626);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
	}
}

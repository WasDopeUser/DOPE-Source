using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass761 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3377;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass761()
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 3377;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3377);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-14671);
	}
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass760 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6897;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass760()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 6897;
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
		binaryStream_0.smethod_7(6897);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-2040);
	}
}

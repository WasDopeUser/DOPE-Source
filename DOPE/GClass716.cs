using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass716 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29834;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass716()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 29834;
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
		binaryStream_0.smethod_7(29834);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
	}
}

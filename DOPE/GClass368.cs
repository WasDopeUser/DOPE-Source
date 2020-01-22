using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass368 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28428;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass368(int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.jgjuagYlqW = int_0;
	}

	public virtual int vmethod_0()
	{
		return 28428;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.jgjuagYlqW = binaryStream_0.smethod_0();
		this.jgjuagYlqW = (this.jgjuagYlqW << 5 | U.smethod_0(this.jgjuagYlqW, 27));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28428);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.jgjuagYlqW, 5) | this.jgjuagYlqW << 27);
	}

	public int jgjuagYlqW;
}

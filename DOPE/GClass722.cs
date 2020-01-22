using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass722 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10696;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass722()
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 10696;
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
		binaryStream_0.smethod_7(10696);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(801);
	}
}

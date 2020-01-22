using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass741 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13342;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass741(bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 13342;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13342);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-18730);
		binaryStream_0.smethod_7(5202);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public bool bool_0;
}

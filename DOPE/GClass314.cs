using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass314 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7199;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass314(bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 7199;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7199);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public bool bool_0;
}

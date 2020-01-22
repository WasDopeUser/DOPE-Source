using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass305 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15767;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass305(bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 15767;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15767);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-15542);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(-26436);
	}

	public bool bool_0;
}

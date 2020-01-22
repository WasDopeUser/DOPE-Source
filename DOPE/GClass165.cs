using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass165 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13601;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass165(GClass258 gclass258_1 = null, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass258_1 == null)
		{
			this.gclass258_0 = new GClass258(0U);
		}
		else
		{
			this.gclass258_0 = gclass258_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 13601;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass258_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass258);
		this.gclass258_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13601);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass258_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-16426);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass258 gclass258_0;

	public bool bool_0;
}

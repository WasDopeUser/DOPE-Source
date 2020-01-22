using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass343 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20416;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass343(GClass347 gclass347_1 = null, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass347_1 == null)
		{
			this.gclass347_0 = new GClass347(0U);
		}
		else
		{
			this.gclass347_0 = gclass347_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 20416;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass347_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass347);
		this.gclass347_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20416);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass347_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(-7984);
	}

	public GClass347 gclass347_0;

	public bool bool_0;
}

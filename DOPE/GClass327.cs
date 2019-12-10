using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass327 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3652;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass327(GClass331 gclass331_1 = null, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass331_1 == null)
		{
			this.gclass331_0 = new GClass331(0U);
		}
		else
		{
			this.gclass331_0 = gclass331_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 3652;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass331_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass331);
		this.gclass331_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(3652);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass331_0.imethod_2(binaryStream_0);
	}

	public bool bool_0;

	public GClass331 gclass331_0;
}

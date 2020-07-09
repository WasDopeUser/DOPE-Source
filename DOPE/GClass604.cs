using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass604 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -5347;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass604(GClass287 gclass287_1 = null, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass287_1 == null)
		{
			this.gclass287_0 = new GClass287(0);
		}
		else
		{
			this.gclass287_0 = gclass287_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return -5347;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass287_0 = (GClass287)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass287_0 != null)
		{
			this.gclass287_0.imethod_1(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-5347);
		if (this.gclass287_0 != null)
		{
			this.gclass287_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass287 gclass287_0;

	public bool bool_0;
}

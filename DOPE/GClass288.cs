using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass288 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 69;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass288(GClass431 gclass431_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass431_1 == null)
		{
			this.gclass431_0 = new GClass431(0);
			return;
		}
		this.gclass431_0 = gclass431_1;
	}

	public virtual int vmethod_0()
	{
		return 69;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass431_0 = (GClass431)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass431_0 != null)
		{
			this.gclass431_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(69);
		if (this.gclass431_0 != null)
		{
			this.gclass431_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass431 gclass431_0;
}

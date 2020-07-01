using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass241 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -11531;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass241(GClass240 gclass240_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass240_1 == null)
		{
			this.gclass240_0 = new GClass240(0.0, "", 0.0, 0, false, 0.0, null);
			return;
		}
		this.gclass240_0 = gclass240_1;
	}

	public virtual int vmethod_0()
	{
		return -11531;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass240_0 = (GClass240)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass240_0 != null)
		{
			this.gclass240_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-11531);
		if (this.gclass240_0 != null)
		{
			this.gclass240_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass240 gclass240_0;
}

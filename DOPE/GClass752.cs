using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass752 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19526;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass752(GClass197 gclass197_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass197_0 == null)
		{
			this.Mode = new GClass197(0U);
			return;
		}
		this.Mode = gclass197_0;
	}

	public virtual int vmethod_0()
	{
		return 19526;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.Mode = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass197);
		this.Mode.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19526);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-10067);
		this.Mode.imethod_1(binaryStream_0);
	}

	public GClass197 Mode;
}

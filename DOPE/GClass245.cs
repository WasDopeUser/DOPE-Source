using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass245 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32068;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass245(GClass244 gclass244_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass244_1 == null)
		{
			this.gclass244_0 = new GClass244(0.0, "", 0.0, 0, false, 0.0, null);
			return;
		}
		this.gclass244_0 = gclass244_1;
	}

	public virtual int vmethod_0()
	{
		return 32068;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass244_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass244);
		this.gclass244_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32068);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass244_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(13489);
	}

	public GClass244 gclass244_0;
}

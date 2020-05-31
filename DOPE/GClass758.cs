using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass758 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31149;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass758(GClass178 gclass178_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0U);
			return;
		}
		this.gclass178_0 = gclass178_1;
	}

	public virtual int vmethod_0()
	{
		return 31149;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass178_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass178);
		this.gclass178_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31149);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-22211);
		this.gclass178_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-2365);
	}

	public GClass178 gclass178_0;
}

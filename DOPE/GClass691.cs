using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass691 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20409;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass691(GClass784 gclass784_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass784_1 == null)
		{
			this.gclass784_0 = new GClass784(0U);
			return;
		}
		this.gclass784_0 = gclass784_1;
	}

	public virtual int vmethod_0()
	{
		return 20409;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass784_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass784);
		this.gclass784_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(20409);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass784_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-30158);
		binaryStream_0.smethod_6(-14522);
	}

	public GClass784 gclass784_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass232 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16591;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass232(GClass490 gclass490_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass490_1 == null)
		{
			this.gclass490_0 = new GClass490();
			return;
		}
		this.gclass490_0 = gclass490_1;
	}

	public virtual int vmethod_0()
	{
		return 16591;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass490_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass490);
		this.gclass490_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(16591);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-18845);
		this.gclass490_0.imethod_2(binaryStream_0);
	}

	public GClass490 gclass490_0;
}

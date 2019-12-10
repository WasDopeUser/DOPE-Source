using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass727 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14626;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass727(GClass186 gclass186_0 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass186_0 == null)
		{
			this.Mode = new GClass186(0U);
			return;
		}
		this.Mode = gclass186_0;
	}

	public virtual int vmethod_0()
	{
		return 14626;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Mode = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass186);
		this.Mode.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(14626);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.Mode.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-24008);
		binaryStream_0.smethod_5(32113);
	}

	public GClass186 Mode;
}

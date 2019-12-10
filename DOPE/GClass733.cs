using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass733 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20639;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass733(GClass171 gclass171_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass171_1 == null)
		{
			this.gclass171_0 = new GClass171(0U);
			return;
		}
		this.gclass171_0 = gclass171_1;
	}

	public virtual int vmethod_0()
	{
		return 20639;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass171_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass171);
		this.gclass171_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(20639);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass171_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(30353);
		binaryStream_0.smethod_5(-18207);
	}

	public GClass171 gclass171_0;
}

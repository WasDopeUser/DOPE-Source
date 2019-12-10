using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass163 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2251;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass163(GClass246 gclass246_1 = null, GClass228 gclass228_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass246_1 == null)
		{
			this.gclass246_0 = new GClass246(0U);
		}
		else
		{
			this.gclass246_0 = gclass246_1;
		}
		if (gclass228_1 == null)
		{
			this.gclass228_0 = new GClass228(0, 0, "", "", 0);
			return;
		}
		this.gclass228_0 = gclass228_1;
	}

	public virtual int vmethod_0()
	{
		return 2251;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass246_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass246);
		this.gclass246_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass228_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass228);
		this.gclass228_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(2251);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(31216);
		this.gclass246_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-13886);
		this.gclass228_0.imethod_2(binaryStream_0);
	}

	public GClass246 gclass246_0;

	public GClass228 gclass228_0;
}

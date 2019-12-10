using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass317 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17243;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass317(GClass446 gclass446_1 = null, GClass469 gclass469_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass446_1 == null)
		{
			this.gclass446_0 = new GClass446(0U);
		}
		else
		{
			this.gclass446_0 = gclass446_1;
		}
		if (gclass469_1 == null)
		{
			this.gclass469_0 = new GClass469(0, null, null, null, null, "", "");
			return;
		}
		this.gclass469_0 = gclass469_1;
	}

	public virtual int vmethod_0()
	{
		return 17243;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass446_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass446);
		this.gclass446_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass469_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass469);
		this.gclass469_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17243);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass446_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-9675);
		this.gclass469_0.imethod_2(binaryStream_0);
	}

	public GClass446 gclass446_0;

	public GClass469 gclass469_0;
}

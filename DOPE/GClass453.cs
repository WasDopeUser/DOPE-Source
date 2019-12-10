using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass453 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2631;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass453(GClass469 gclass469_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass469_1 == null)
		{
			this.gclass469_0 = new GClass469(0, null, null, null, null, "", "");
			return;
		}
		this.gclass469_0 = gclass469_1;
	}

	public virtual int vmethod_0()
	{
		return 2631;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass469_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass469);
		this.gclass469_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(2631);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass469_0.imethod_2(binaryStream_0);
	}

	public GClass469 gclass469_0;
}

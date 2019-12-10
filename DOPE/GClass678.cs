using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass678 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4068;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass678(GClass772 gclass772_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass772_1 == null)
		{
			this.gclass772_0 = new GClass772(0U);
			return;
		}
		this.gclass772_0 = gclass772_1;
	}

	public virtual int vmethod_0()
	{
		return 4068;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass772_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass772);
		this.gclass772_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(4068);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6586);
		this.gclass772_0.imethod_2(binaryStream_0);
	}

	public GClass772 gclass772_0;
}

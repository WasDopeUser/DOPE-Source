using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass231 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3542;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass231(GClass230 gclass230_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass230_1 == null)
		{
			this.gclass230_0 = new GClass230(0.0, "", 0.0, 0, false, 0.0, null);
			return;
		}
		this.gclass230_0 = gclass230_1;
	}

	public virtual int vmethod_0()
	{
		return 3542;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass230_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass230);
		this.gclass230_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(3542);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass230_0.imethod_2(binaryStream_0);
	}

	public GClass230 gclass230_0;
}

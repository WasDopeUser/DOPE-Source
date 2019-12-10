using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass261 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9339;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass261(GClass180 gclass180_1 = null, GClass131 gclass131_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass180_1 == null)
		{
			this.gclass180_0 = new GClass180(0U);
		}
		else
		{
			this.gclass180_0 = gclass180_1;
		}
		if (gclass131_1 == null)
		{
			this.gclass131_0 = new GClass131(null, 0.0);
			return;
		}
		this.gclass131_0 = gclass131_1;
	}

	public virtual int vmethod_0()
	{
		return 9339;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass131_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass131);
		this.gclass131_0.imethod_1(binaryStream_0);
		this.gclass180_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass180);
		this.gclass180_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(9339);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass131_0.imethod_2(binaryStream_0);
		this.gclass180_0.imethod_2(binaryStream_0);
	}

	public GClass131 gclass131_0;

	public GClass180 gclass180_0;
}

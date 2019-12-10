using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass502 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32176;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass502(GClass486 gclass486_1 = null, GClass440 gclass440_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass486_1 == null)
		{
			this.gclass486_0 = new GClass486(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass486_0 = gclass486_1;
		}
		if (gclass440_1 == null)
		{
			this.gclass440_0 = new GClass440(0, null, 0U, 0U, 0.0, false, null, null);
			return;
		}
		this.gclass440_0 = gclass440_1;
	}

	public virtual int vmethod_0()
	{
		return 32176;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass440_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass440);
		this.gclass440_0.imethod_1(binaryStream_0);
		this.gclass486_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass486);
		this.gclass486_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(32176);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass440_0.imethod_2(binaryStream_0);
		this.gclass486_0.imethod_2(binaryStream_0);
	}

	public GClass440 gclass440_0;

	public GClass486 gclass486_0;
}

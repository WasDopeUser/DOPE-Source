using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass230 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -9740;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass230(GClass501 gclass501_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass501_1 == null)
		{
			this.gclass501_0 = new GClass501();
			return;
		}
		this.gclass501_0 = gclass501_1;
	}

	public virtual int vmethod_0()
	{
		return -9740;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass501_0 = (GClass501)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass501_0 != null)
		{
			this.gclass501_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-9740);
		if (this.gclass501_0 != null)
		{
			this.gclass501_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass501 gclass501_0;
}

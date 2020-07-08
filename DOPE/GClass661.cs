using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass661 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 212;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass661(GClass822 gclass822_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass822_1 == null)
		{
			this.gclass822_0 = new GClass822(0);
			return;
		}
		this.gclass822_0 = gclass822_1;
	}

	public virtual int vmethod_0()
	{
		return 212;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass822_0 = (GClass822)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass822_0 != null)
		{
			this.gclass822_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(212);
		if (this.gclass822_0 != null)
		{
			this.gclass822_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass822 gclass822_0;
}

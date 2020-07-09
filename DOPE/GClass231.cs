using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass231 : GInterface0
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

	public GClass231(GClass502 gclass502_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass502_1 == null)
		{
			this.gclass502_0 = new GClass502();
			return;
		}
		this.gclass502_0 = gclass502_1;
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
		this.gclass502_0 = (GClass502)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass502_0 != null)
		{
			this.gclass502_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-9740);
		if (this.gclass502_0 != null)
		{
			this.gclass502_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass502 gclass502_0;
}

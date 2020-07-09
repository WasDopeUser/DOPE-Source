using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass557 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 91;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass557(GClass178 gclass178_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0);
			return;
		}
		this.gclass178_0 = gclass178_1;
	}

	public virtual int vmethod_0()
	{
		return 91;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass178_0 = (GClass178)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass178_0 != null)
		{
			this.gclass178_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(91);
		if (this.gclass178_0 != null)
		{
			this.gclass178_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass178 gclass178_0;
}

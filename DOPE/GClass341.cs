using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass341 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22034;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass341(GClass469 gclass469_1 = null, GClass491 gclass491_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass469_1 == null)
		{
			this.gclass469_0 = new GClass469(0);
		}
		else
		{
			this.gclass469_0 = gclass469_1;
		}
		if (gclass491_1 == null)
		{
			this.gclass491_0 = new GClass491(0, null, null, null, null, "", "");
			return;
		}
		this.gclass491_0 = gclass491_1;
	}

	public virtual int vmethod_0()
	{
		return 22034;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass469_0 = (GClass469)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass469_0 != null)
		{
			this.gclass469_0.imethod_1(binaryStream_0);
		}
		this.gclass491_0 = (GClass491)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass491_0 != null)
		{
			this.gclass491_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22034);
		if (this.gclass469_0 != null)
		{
			this.gclass469_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass491_0 != null)
		{
			this.gclass491_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass469 gclass469_0;

	public GClass491 gclass491_0;
}

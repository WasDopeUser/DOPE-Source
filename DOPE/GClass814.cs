using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass814 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -8985;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass814(int int_1 = 0, GClass834 gclass834_2 = null, GClass834 gclass834_3 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass834_3 == null)
		{
			this.gclass834_0 = new GClass834(0, 0, false);
		}
		else
		{
			this.gclass834_0 = gclass834_3;
		}
		this.int_0 = int_1;
		if (gclass834_2 == null)
		{
			this.gclass834_1 = new GClass834(0, 0, false);
			return;
		}
		this.gclass834_1 = gclass834_2;
	}

	public virtual int vmethod_0()
	{
		return -8985;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass834_0 = (GClass834)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass834_0 != null)
		{
			this.gclass834_0.imethod_1(binaryStream_0);
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass834_1 = (GClass834)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass834_1 != null)
		{
			this.gclass834_1.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-8985);
		if (this.gclass834_0 != null)
		{
			this.gclass834_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass834_1 != null)
		{
			this.gclass834_1.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass834 gclass834_0;

	public int int_0;

	public GClass834 gclass834_1;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass302 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4145;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass302(GClass407 gclass407_1 = null, int int_1 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass407_1 == null)
		{
			this.gclass407_0 = new GClass407();
		}
		else
		{
			this.gclass407_0 = gclass407_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 4145;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass407_0 = (GClass407)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass407_0 != null)
		{
			this.gclass407_0.imethod_1(binaryStream_0);
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4145);
		if (this.gclass407_0 != null)
		{
			this.gclass407_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_0);
	}

	public GClass407 gclass407_0;

	public int int_0;
}

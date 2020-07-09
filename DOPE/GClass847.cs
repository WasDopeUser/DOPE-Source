using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass847 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -31293;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass847(GClass392 gclass392_1 = null, int int_1 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_1;
		if (gclass392_1 == null)
		{
			this.gclass392_0 = new GClass392();
			return;
		}
		this.gclass392_0 = gclass392_1;
	}

	public virtual int vmethod_0()
	{
		return -31293;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.gclass392_0 = (GClass392)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass392_0 != null)
		{
			this.gclass392_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-31293);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		if (this.gclass392_0 != null)
		{
			this.gclass392_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public GClass392 gclass392_0;
}

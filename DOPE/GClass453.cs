using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass453 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 41;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass453(GClass328 gclass328_1 = null, int int_1 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass328_1 == null)
		{
			this.gclass328_0 = new GClass328(0);
		}
		else
		{
			this.gclass328_0 = gclass328_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 41;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass328_0 = (GClass328)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass328_0 != null)
		{
			this.gclass328_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(41);
		if (this.gclass328_0 != null)
		{
			this.gclass328_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public GClass328 gclass328_0;

	public int int_0;
}

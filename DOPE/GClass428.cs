using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass428 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 42;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass428(int int_2 = 0, GClass328 gclass328_1 = null, int int_3 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_2;
		if (gclass328_1 == null)
		{
			this.gclass328_0 = new GClass328(0);
		}
		else
		{
			this.gclass328_0 = gclass328_1;
		}
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 42;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass328_0 = (GClass328)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass328_0 != null)
		{
			this.gclass328_0.imethod_1(binaryStream_0);
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(42);
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass328_0 != null)
		{
			this.gclass328_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
	}

	public int int_0;

	public GClass328 gclass328_0;

	public int int_1;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass640 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 129;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass640(GClass260 gclass260_1 = null, int int_1 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass260_1 == null)
		{
			this.gclass260_0 = new GClass260(0);
		}
		else
		{
			this.gclass260_0 = gclass260_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 129;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass260_0 = (GClass260)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass260_0 != null)
		{
			this.gclass260_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(129);
		if (this.gclass260_0 != null)
		{
			this.gclass260_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
	}

	public GClass260 gclass260_0;

	public int int_0;
}

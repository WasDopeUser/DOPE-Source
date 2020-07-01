using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass639 : GInterface0
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

	public GClass639(GClass259 gclass259_1 = null, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass259_1 == null)
		{
			this.gclass259_0 = new GClass259(0);
		}
		else
		{
			this.gclass259_0 = gclass259_1;
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

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass259_0 = (GClass259)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(129);
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
	}

	public GClass259 gclass259_0;

	public int int_0;
}

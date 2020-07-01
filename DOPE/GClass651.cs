using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass651 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 73;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass651(GClass431 gclass431_1 = null, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass431_1 == null)
		{
			this.gclass431_0 = new GClass431(0);
		}
		else
		{
			this.gclass431_0 = gclass431_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 73;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass431_0 = (GClass431)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass431_0 != null)
		{
			this.gclass431_0.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(73);
		if (this.gclass431_0 != null)
		{
			this.gclass431_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
	}

	public GClass431 gclass431_0;

	public int int_0;
}

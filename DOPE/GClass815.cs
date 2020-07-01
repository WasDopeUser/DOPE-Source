using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass815 : GInterface0
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

	public GClass815(int int_1 = 0, GClass835 gclass835_2 = null, GClass835 gclass835_3 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass835_3 == null)
		{
			this.gclass835_0 = new GClass835(0, 0, false);
		}
		else
		{
			this.gclass835_0 = gclass835_3;
		}
		this.int_0 = int_1;
		if (gclass835_2 == null)
		{
			this.gclass835_1 = new GClass835(0, 0, false);
			return;
		}
		this.gclass835_1 = gclass835_2;
	}

	public virtual int vmethod_0()
	{
		return -8985;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass835_0 = (GClass835)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass835_0 != null)
		{
			this.gclass835_0.imethod_0(binaryStream_0);
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass835_1 = (GClass835)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass835_1 != null)
		{
			this.gclass835_1.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-8985);
		if (this.gclass835_0 != null)
		{
			this.gclass835_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass835_1 != null)
		{
			this.gclass835_1.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass835 gclass835_0;

	public int int_0;

	public GClass835 gclass835_1;
}

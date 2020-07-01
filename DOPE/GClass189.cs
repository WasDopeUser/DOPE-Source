using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass189 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21525;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass189(int int_1 = 0, GClass190 gclass190_1 = null, GClass333 gclass333_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
		if (gclass333_1 == null)
		{
			this.gclass333_0 = new GClass333(null, null);
		}
		else
		{
			this.gclass333_0 = gclass333_1;
		}
		if (gclass190_1 == null)
		{
			this.gclass190_0 = new GClass190(0.0, 0.0);
			return;
		}
		this.gclass190_0 = gclass190_1;
	}

	public virtual int vmethod_0()
	{
		return 21525;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.gclass333_0 = (GClass333)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass333_0 != null)
		{
			this.gclass333_0.imethod_0(binaryStream_0);
		}
		this.gclass190_0 = (GClass190)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass190_0 != null)
		{
			this.gclass190_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21525);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		if (this.gclass333_0 != null)
		{
			this.gclass333_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass190_0 != null)
		{
			this.gclass190_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public GClass333 gclass333_0;

	public GClass190 gclass190_0;
}

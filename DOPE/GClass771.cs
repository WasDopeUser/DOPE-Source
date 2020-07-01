using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass771 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 93;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass771(GClass178 gclass178_1 = null, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0);
		}
		else
		{
			this.gclass178_0 = gclass178_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 93;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass178_0 = (GClass178)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass178_0 != null)
		{
			this.gclass178_0.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(93);
		if (this.gclass178_0 != null)
		{
			this.gclass178_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
	}

	public GClass178 gclass178_0;

	public int int_0;
}

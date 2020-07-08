using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass770 : GInterface0
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

	public GClass770(GClass177 gclass177_1 = null, int int_1 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass177_1 == null)
		{
			this.gclass177_0 = new GClass177(0);
		}
		else
		{
			this.gclass177_0 = gclass177_1;
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

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass177_0 = (GClass177)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass177_0 != null)
		{
			this.gclass177_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(93);
		if (this.gclass177_0 != null)
		{
			this.gclass177_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
	}

	public GClass177 gclass177_0;

	public int int_0;
}

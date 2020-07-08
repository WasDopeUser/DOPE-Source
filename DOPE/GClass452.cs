using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass452 : GInterface0
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

	public GClass452(GClass327 gclass327_1 = null, int int_1 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass327_1 == null)
		{
			this.gclass327_0 = new GClass327(0);
		}
		else
		{
			this.gclass327_0 = gclass327_1;
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
		this.gclass327_0 = (GClass327)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass327_0 != null)
		{
			this.gclass327_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(41);
		if (this.gclass327_0 != null)
		{
			this.gclass327_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public GClass327 gclass327_0;

	public int int_0;
}

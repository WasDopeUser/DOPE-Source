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

	public GClass452(GClass327 gclass327_0 = null, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass327_0 == null)
		{
			this.RyfskxUpTi = new GClass327(0);
		}
		else
		{
			this.RyfskxUpTi = gclass327_0;
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

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.RyfskxUpTi = (GClass327)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.RyfskxUpTi != null)
		{
			this.RyfskxUpTi.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(41);
		if (this.RyfskxUpTi != null)
		{
			this.RyfskxUpTi.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public GClass327 RyfskxUpTi;

	public int int_0;
}

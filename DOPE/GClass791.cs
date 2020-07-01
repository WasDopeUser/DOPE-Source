using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass791 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9667;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass791(GClass201 gclass201_0 = null, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass201_0 == null)
		{
			this.gSugJdeqZg = new GClass201(0);
		}
		else
		{
			this.gSugJdeqZg = gclass201_0;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 9667;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gSugJdeqZg = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gSugJdeqZg != null)
		{
			this.gSugJdeqZg.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9667);
		if (this.gSugJdeqZg != null)
		{
			this.gSugJdeqZg.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
	}

	public GClass201 gSugJdeqZg;

	public int int_0;
}

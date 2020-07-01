using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass760 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 71;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass760(GClass749 gclass749_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass749_1 == null)
		{
			this.gclass749_0 = new GClass749();
		}
		else
		{
			this.gclass749_0 = gclass749_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 71;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass749_0 = (GClass749)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass749_0 != null)
		{
			this.gclass749_0.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(71);
		if (this.gclass749_0 != null)
		{
			this.gclass749_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
	}

	public GClass749 gclass749_0;

	public int int_0;

	public int int_1;
}

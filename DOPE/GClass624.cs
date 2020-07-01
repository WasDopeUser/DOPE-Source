using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass624 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 163;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass624(GClass132 gclass132_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass132_1 == null)
		{
			this.gclass132_0 = new GClass132(0);
		}
		else
		{
			this.gclass132_0 = gclass132_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 163;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass132_0 = (GClass132)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass132_0 != null)
		{
			this.gclass132_0.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(163);
		if (this.gclass132_0 != null)
		{
			this.gclass132_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
	}

	public GClass132 gclass132_0;

	public int int_0;

	public int int_1;
}

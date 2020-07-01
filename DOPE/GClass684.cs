using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass684 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 208;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass684(GClass823 gclass823_1 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass823_1 == null)
		{
			this.gclass823_0 = new GClass823(0);
		}
		else
		{
			this.gclass823_0 = gclass823_1;
		}
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 208;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass823_0 = (GClass823)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass823_0 != null)
		{
			this.gclass823_0.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(208);
		if (this.gclass823_0 != null)
		{
			this.gclass823_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
	}

	public GClass823 gclass823_0;

	public int int_0;

	public int int_1;

	public int int_2;
}

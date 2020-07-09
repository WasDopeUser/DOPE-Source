using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass513 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 233;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass513(GClass257 gclass257_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass257_1 == null)
		{
			this.gclass257_0 = new GClass257(0);
		}
		else
		{
			this.gclass257_0 = gclass257_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 233;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass257_0 = (GClass257)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass257_0 != null)
		{
			this.gclass257_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(233);
		if (this.gclass257_0 != null)
		{
			this.gclass257_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
	}

	public GClass257 gclass257_0;

	public int int_0;

	public int int_1;
}

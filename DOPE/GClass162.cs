using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass162 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 154;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass162(GClass256 gclass256_1 = null, int int_1 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass256_1 == null)
		{
			this.gclass256_0 = new GClass256(0);
		}
		else
		{
			this.gclass256_0 = gclass256_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 154;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass256_0 = (GClass256)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass256_0 != null)
		{
			this.gclass256_0.imethod_1(binaryStream_0);
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_0 = (65535 & (U.smethod_0(65535 & this.int_0, 11) | (65535 & this.int_0) << 5));
		this.int_0 = ((this.int_0 > 32767) ? (this.int_0 - 65536) : this.int_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(154);
		if (this.gclass256_0 != null)
		{
			this.gclass256_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(65535 & ((65535 & this.int_0) << 11 | U.smethod_0(65535 & this.int_0, 5)));
	}

	public GClass256 gclass256_0;

	public int int_0;
}

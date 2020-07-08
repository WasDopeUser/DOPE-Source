using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass759 : GInterface0
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

	public GClass759(GClass748 gclass748_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass748_1 == null)
		{
			this.gclass748_0 = new GClass748();
		}
		else
		{
			this.gclass748_0 = gclass748_1;
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

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass748_0 = (GClass748)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass748_0 != null)
		{
			this.gclass748_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(71);
		if (this.gclass748_0 != null)
		{
			this.gclass748_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
	}

	public GClass748 gclass748_0;

	public int int_0;

	public int int_1;
}

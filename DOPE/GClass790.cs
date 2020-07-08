using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass790 : GInterface0
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

	public GClass790(GClass200 gclass200_1 = null, int int_1 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass200_1 == null)
		{
			this.gclass200_0 = new GClass200(0);
		}
		else
		{
			this.gclass200_0 = gclass200_1;
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

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass200_0 = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9667);
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
	}

	public GClass200 gclass200_0;

	public int int_0;
}

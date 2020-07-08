using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass293 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -2641;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass293(int int_1 = 0, GClass488 gclass488_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass488_1 == null)
		{
			this.gclass488_0 = new GClass488(false, 0);
		}
		else
		{
			this.gclass488_0 = gclass488_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -2641;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass488_0 = (GClass488)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass488_0 != null)
		{
			this.gclass488_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-2641);
		if (this.gclass488_0 != null)
		{
			this.gclass488_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
	}

	public GClass488 gclass488_0;

	public int int_0;
}

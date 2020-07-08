using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass188 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21525;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass188(int int_1 = 0, GClass189 gclass189_1 = null, GClass333 gclass333_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_1;
		if (gclass333_1 == null)
		{
			this.gclass333_0 = new GClass333(null, null);
		}
		else
		{
			this.gclass333_0 = gclass333_1;
		}
		if (gclass189_1 == null)
		{
			this.gclass189_0 = new GClass189(0.0, 0.0);
			return;
		}
		this.gclass189_0 = gclass189_1;
	}

	public virtual int vmethod_0()
	{
		return 21525;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.gclass333_0 = (GClass333)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass333_0 != null)
		{
			this.gclass333_0.imethod_1(binaryStream_0);
		}
		this.gclass189_0 = (GClass189)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass189_0 != null)
		{
			this.gclass189_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21525);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		if (this.gclass333_0 != null)
		{
			this.gclass333_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass189_0 != null)
		{
			this.gclass189_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public GClass333 gclass333_0;

	public GClass189 gclass189_0;
}

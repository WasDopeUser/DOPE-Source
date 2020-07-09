using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass189 : GInterface0
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

	public GClass189(int int_1 = 0, GClass190 gclass190_0 = null, GClass334 gclass334_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_1;
		if (gclass334_1 == null)
		{
			this.gclass334_0 = new GClass334(null, null);
		}
		else
		{
			this.gclass334_0 = gclass334_1;
		}
		if (gclass190_0 == null)
		{
			this.VtDukicRh5 = new GClass190(0.0, 0.0);
			return;
		}
		this.VtDukicRh5 = gclass190_0;
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
		this.gclass334_0 = (GClass334)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass334_0 != null)
		{
			this.gclass334_0.imethod_1(binaryStream_0);
		}
		this.VtDukicRh5 = (GClass190)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.VtDukicRh5 != null)
		{
			this.VtDukicRh5.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21525);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		if (this.gclass334_0 != null)
		{
			this.gclass334_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.VtDukicRh5 != null)
		{
			this.VtDukicRh5.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public GClass334 gclass334_0;

	public GClass190 VtDukicRh5;
}

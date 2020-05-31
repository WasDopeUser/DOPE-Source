using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass618 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3018;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass618(GClass265 gclass265_1 = null, int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass265_1 == null)
		{
			this.gclass265_0 = new GClass265(0U);
		}
		else
		{
			this.gclass265_0 = gclass265_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 3018;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_1();
		this.gclass265_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass265);
		this.gclass265_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3018);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29080);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_7(-15052);
		this.gclass265_0.imethod_1(binaryStream_0);
	}

	public int int_0;

	public GClass265 gclass265_0;
}

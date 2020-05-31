using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass167 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25835;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass167(GClass264 gclass264_1 = null, GClass242 gclass242_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass264_1 == null)
		{
			this.gclass264_0 = new GClass264(0U);
		}
		else
		{
			this.gclass264_0 = gclass264_1;
		}
		if (gclass242_1 == null)
		{
			this.gclass242_0 = new GClass242(0, 0, "", "", 0);
			return;
		}
		this.gclass242_0 = gclass242_1;
	}

	public virtual int vmethod_0()
	{
		return 25835;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass242_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass242);
		this.gclass242_0.HrqIugnatr8(binaryStream_0);
		this.gclass264_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass264);
		this.gclass264_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25835);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass242_0.imethod_1(binaryStream_0);
		this.gclass264_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(21270);
	}

	public GClass242 gclass242_0;

	public GClass264 gclass264_0;
}

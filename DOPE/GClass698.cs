using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass698 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17426;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass698(GClass518 gclass518_1 = null, GClass601 gclass601_1 = null, GClass393 gclass393_1 = null, GClass703 gclass703_1 = null, GClass282 gclass282_1 = null, GClass418 gclass418_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass518_1 == null)
		{
			this.gclass518_0 = new GClass518(false, 0, 0, 0, false, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass518_0 = gclass518_1;
		}
		if (gclass601_1 == null)
		{
			this.gclass601_0 = new GClass601(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false);
		}
		else
		{
			this.gclass601_0 = gclass601_1;
		}
		if (gclass393_1 == null)
		{
			this.gclass393_0 = new GClass393(false, 0, 0, 0, false);
		}
		else
		{
			this.gclass393_0 = gclass393_1;
		}
		if (gclass703_1 == null)
		{
			this.gclass703_0 = new GClass703(0, "", false);
		}
		else
		{
			this.gclass703_0 = gclass703_1;
		}
		if (gclass282_1 == null)
		{
			this.gclass282_0 = new GClass282(false, false, false, false, false, false, false, false, false, false);
		}
		else
		{
			this.gclass282_0 = gclass282_1;
		}
		if (gclass418_1 == null)
		{
			this.gclass418_0 = new GClass418(false, false, false, false, false, false);
			return;
		}
		this.gclass418_0 = gclass418_1;
	}

	public virtual int vmethod_0()
	{
		return 17426;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass703_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass703);
		this.gclass703_0.imethod_1(binaryStream_0);
		this.gclass282_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass282);
		this.gclass282_0.imethod_1(binaryStream_0);
		this.gclass601_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass601);
		this.gclass601_0.imethod_1(binaryStream_0);
		this.gclass418_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass418);
		this.gclass418_0.imethod_1(binaryStream_0);
		this.gclass393_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass393);
		this.gclass393_0.imethod_1(binaryStream_0);
		this.gclass518_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass518);
		this.gclass518_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(17426);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-21778);
		this.gclass703_0.imethod_2(binaryStream_0);
		this.gclass282_0.imethod_2(binaryStream_0);
		this.gclass601_0.imethod_2(binaryStream_0);
		this.gclass418_0.imethod_2(binaryStream_0);
		this.gclass393_0.imethod_2(binaryStream_0);
		this.gclass518_0.imethod_2(binaryStream_0);
	}

	public GClass703 gclass703_0;

	public GClass282 gclass282_0;

	public GClass601 gclass601_0;

	public GClass418 gclass418_0;

	public GClass393 gclass393_0;

	public GClass518 gclass518_0;
}

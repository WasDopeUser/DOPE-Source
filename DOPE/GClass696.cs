using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass696 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9336;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass696(GClass516 gclass516_1 = null, GClass599 gclass599_1 = null, GClass392 gclass392_1 = null, GClass701 gclass701_1 = null, GClass282 gclass282_1 = null, GClass417 gclass417_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass516_1 == null)
		{
			this.gclass516_0 = new GClass516(false, 0, 0, 0, false, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass516_0 = gclass516_1;
		}
		if (gclass599_1 == null)
		{
			this.gclass599_0 = new GClass599(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false);
		}
		else
		{
			this.gclass599_0 = gclass599_1;
		}
		if (gclass392_1 == null)
		{
			this.gclass392_0 = new GClass392(false, 0, 0, 0, false);
		}
		else
		{
			this.gclass392_0 = gclass392_1;
		}
		if (gclass701_1 == null)
		{
			this.gclass701_0 = new GClass701(0, "", false);
		}
		else
		{
			this.gclass701_0 = gclass701_1;
		}
		if (gclass282_1 == null)
		{
			this.gclass282_0 = new GClass282(false, false, false, false, false, false, false, false, false, false);
		}
		else
		{
			this.gclass282_0 = gclass282_1;
		}
		if (gclass417_1 == null)
		{
			this.gclass417_0 = new GClass417(false, false, false, false, false, false);
			return;
		}
		this.gclass417_0 = gclass417_1;
	}

	public virtual int vmethod_0()
	{
		return 9336;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass417_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass417);
		this.gclass417_0.imethod_1(binaryStream_0);
		this.gclass282_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass282);
		this.gclass282_0.imethod_1(binaryStream_0);
		this.gclass392_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass392);
		this.gclass392_0.imethod_1(binaryStream_0);
		this.gclass599_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass599);
		this.gclass599_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass701_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass701);
		this.gclass701_0.imethod_1(binaryStream_0);
		this.gclass516_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass516);
		this.gclass516_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9336);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass417_0.imethod_2(binaryStream_0);
		this.gclass282_0.imethod_2(binaryStream_0);
		this.gclass392_0.imethod_2(binaryStream_0);
		this.gclass599_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-28608);
		this.gclass701_0.imethod_2(binaryStream_0);
		this.gclass516_0.imethod_2(binaryStream_0);
	}

	public GClass417 gclass417_0;

	public GClass282 gclass282_0;

	public GClass392 gclass392_0;

	public GClass599 gclass599_0;

	public GClass701 gclass701_0;

	public GClass516 gclass516_0;
}

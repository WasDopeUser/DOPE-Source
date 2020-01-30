using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass697 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4790;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass697(GClass517 gclass517_1 = null, GClass600 gclass600_1 = null, GClass391 gclass391_1 = null, GClass702 gclass702_1 = null, GClass282 gclass282_1 = null, GClass416 gclass416_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass517_1 == null)
		{
			this.gclass517_0 = new GClass517(false, 0, 0, 0, false, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass517_0 = gclass517_1;
		}
		if (gclass600_1 == null)
		{
			this.gclass600_0 = new GClass600(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false);
		}
		else
		{
			this.gclass600_0 = gclass600_1;
		}
		if (gclass391_1 == null)
		{
			this.gclass391_0 = new GClass391(false, 0, 0, 0, false);
		}
		else
		{
			this.gclass391_0 = gclass391_1;
		}
		if (gclass702_1 == null)
		{
			this.gclass702_0 = new GClass702(0, "", false);
		}
		else
		{
			this.gclass702_0 = gclass702_1;
		}
		if (gclass282_1 == null)
		{
			this.gclass282_0 = new GClass282(false, false, false, false, false, false, false, false, false, false);
		}
		else
		{
			this.gclass282_0 = gclass282_1;
		}
		if (gclass416_1 == null)
		{
			this.gclass416_0 = new GClass416(false, false, false, false, false, false);
			return;
		}
		this.gclass416_0 = gclass416_1;
	}

	public virtual int vmethod_0()
	{
		return 4790;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass600_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass600);
		this.gclass600_0.imethod_1(binaryStream_0);
		this.gclass282_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass282);
		this.gclass282_0.imethod_1(binaryStream_0);
		this.gclass517_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass517);
		this.gclass517_0.imethod_1(binaryStream_0);
		this.gclass702_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass702);
		this.gclass702_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass391_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass391);
		this.gclass391_0.imethod_1(binaryStream_0);
		this.gclass416_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass416);
		this.gclass416_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4790);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23569);
		this.gclass600_0.imethod_2(binaryStream_0);
		this.gclass282_0.imethod_2(binaryStream_0);
		this.gclass517_0.imethod_2(binaryStream_0);
		this.gclass702_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(18293);
		this.gclass391_0.imethod_2(binaryStream_0);
		this.gclass416_0.imethod_2(binaryStream_0);
	}

	public GClass600 gclass600_0;

	public GClass282 gclass282_0;

	public GClass517 gclass517_0;

	public GClass702 gclass702_0;

	public GClass391 gclass391_0;

	public GClass416 gclass416_0;
}

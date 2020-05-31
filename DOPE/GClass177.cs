using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass177 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30398;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass177(GClass175 gclass175_1 = null, GClass557 gclass557_1 = null, GClass439 gclass439_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass175_1 == null)
		{
			this.gclass175_0 = new GClass175(null);
		}
		else
		{
			this.gclass175_0 = gclass175_1;
		}
		if (gclass557_1 == null)
		{
			this.gclass557_0 = new GClass557(false, false, false, false);
		}
		else
		{
			this.gclass557_0 = gclass557_1;
		}
		if (gclass439_1 == null)
		{
			this.gclass439_0 = new GClass439(false);
			return;
		}
		this.gclass439_0 = gclass439_1;
	}

	public virtual int vmethod_0()
	{
		return 30398;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass175_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass175);
		this.gclass175_0.HrqIugnatr8(binaryStream_0);
		this.gclass557_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass557);
		this.gclass557_0.HrqIugnatr8(binaryStream_0);
		this.gclass439_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass439);
		this.gclass439_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30398);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass175_0.imethod_1(binaryStream_0);
		this.gclass557_0.imethod_1(binaryStream_0);
		this.gclass439_0.imethod_1(binaryStream_0);
	}

	public GClass175 gclass175_0;

	public GClass557 gclass557_0;

	public GClass439 gclass439_0;
}

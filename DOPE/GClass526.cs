using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass526 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13746;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass526(GClass510 gclass510_1 = null, GClass460 gclass460_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass510_1 == null)
		{
			this.gclass510_0 = new GClass510(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass510_0 = gclass510_1;
		}
		if (gclass460_1 == null)
		{
			this.gclass460_0 = new GClass460(0, null, 0U, 0U, 0.0, false, null, null);
			return;
		}
		this.gclass460_0 = gclass460_1;
	}

	public virtual int vmethod_0()
	{
		return 13746;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass510_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass510);
		this.gclass510_0.HrqIugnatr8(binaryStream_0);
		this.gclass460_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass460);
		this.gclass460_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13746);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass510_0.imethod_1(binaryStream_0);
		this.gclass460_0.imethod_1(binaryStream_0);
	}

	public GClass510 gclass510_0;

	public GClass460 gclass460_0;
}

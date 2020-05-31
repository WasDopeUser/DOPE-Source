using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass410 : GClass409, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26880;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass410(GClass719 gclass719_1 = null, GClass651 gclass651_1 = null, GClass555 gclass555_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass719_1 == null)
		{
			this.gclass719_0 = new GClass719(0, 0, 0, 0.0);
		}
		else
		{
			this.gclass719_0 = gclass719_1;
		}
		if (gclass651_1 == null)
		{
			this.gclass651_0 = new GClass651(null);
		}
		else
		{
			this.gclass651_0 = gclass651_1;
		}
		if (gclass555_1 == null)
		{
			this.gclass555_0 = new GClass555("", 0.0, null);
			return;
		}
		this.gclass555_0 = gclass555_1;
	}

	public override int vmethod_0()
	{
		return 26880;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.gclass555_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass555);
		this.gclass555_0.HrqIugnatr8(binaryStream_0);
		this.gclass651_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass651);
		this.gclass651_0.HrqIugnatr8(binaryStream_0);
		this.gclass719_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass719);
		this.gclass719_0.HrqIugnatr8(binaryStream_0);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26880);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass555_0.imethod_1(binaryStream_0);
		this.gclass651_0.imethod_1(binaryStream_0);
		this.gclass719_0.imethod_1(binaryStream_0);
	}

	public GClass555 gclass555_0;

	public GClass651 gclass651_0;

	public GClass719 gclass719_0;
}

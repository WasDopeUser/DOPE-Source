using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass780 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13034;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass780(GClass562 gclass562_1 = null, GClass544 gclass544_1 = null, Vector<GClass661> vector_1 = null, GClass553 gclass553_1 = null, GClass351 gclass351_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass562_1 == null)
		{
			this.gclass562_0 = new GClass562(0, 0, 0);
		}
		else
		{
			this.gclass562_0 = gclass562_1;
		}
		if (gclass544_1 == null)
		{
			this.gclass544_0 = new GClass544(0);
		}
		else
		{
			this.gclass544_0 = gclass544_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass661>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass553_1 == null)
		{
			this.gclass553_0 = new GClass553(null, null, null, null, null);
		}
		else
		{
			this.gclass553_0 = gclass553_1;
		}
		if (gclass351_1 == null)
		{
			this.gclass351_0 = new GClass351(null, null);
			return;
		}
		this.gclass351_0 = gclass351_1;
	}

	public virtual int vmethod_0()
	{
		return 13034;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass661 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass661;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass562_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass562);
		this.gclass562_0.HrqIugnatr8(binaryStream_0);
		this.gclass351_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass351);
		this.gclass351_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass553_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass553);
		this.gclass553_0.HrqIugnatr8(binaryStream_0);
		this.gclass544_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass544);
		this.gclass544_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13034);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass661 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		this.gclass562_0.imethod_1(binaryStream_0);
		this.gclass351_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-29461);
		binaryStream_0.smethod_7(-14558);
		this.gclass553_0.imethod_1(binaryStream_0);
		this.gclass544_0.imethod_1(binaryStream_0);
	}

	public Vector<GClass661> vector_0;

	public GClass562 gclass562_0;

	public GClass351 gclass351_0;

	public GClass553 gclass553_0;

	public GClass544 gclass544_0;
}

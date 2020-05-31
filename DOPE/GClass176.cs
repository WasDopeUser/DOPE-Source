using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass176 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18021;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass176(GClass743 gclass743_1 = null, GClass598 gclass598_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass743_1 == null)
		{
			this.gclass743_0 = new GClass743(0, null);
		}
		else
		{
			this.gclass743_0 = gclass743_1;
		}
		if (gclass598_1 == null)
		{
			this.gclass598_0 = new GClass598(0, null);
			return;
		}
		this.gclass598_0 = gclass598_1;
	}

	public virtual int vmethod_0()
	{
		return 18021;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass598_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass598);
		this.gclass598_0.HrqIugnatr8(binaryStream_0);
		this.gclass743_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass743);
		this.gclass743_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18021);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass598_0.imethod_1(binaryStream_0);
		this.gclass743_0.imethod_1(binaryStream_0);
	}

	public GClass598 gclass598_0;

	public GClass743 gclass743_0;
}

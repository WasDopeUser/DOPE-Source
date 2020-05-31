using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass363 : GClass362, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12917;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass363(GClass442 gclass442_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass442_1 == null)
		{
			this.gclass442_0 = new GClass442(0U, "", null, null);
			return;
		}
		this.gclass442_0 = gclass442_1;
	}

	public override int vmethod_0()
	{
		return 12917;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.gclass442_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass442);
		this.gclass442_0.HrqIugnatr8(binaryStream_0);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12917);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass442_0.imethod_1(binaryStream_0);
	}

	public GClass442 gclass442_0;
}

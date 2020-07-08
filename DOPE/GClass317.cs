using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass317 : GClass316, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -4758;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass317(GClass139 gclass139_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0);
			return;
		}
		this.gclass139_0 = gclass139_1;
	}

	public override int vmethod_0()
	{
		return -4758;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.gclass139_0 = (GClass139)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass139_0 != null)
		{
			this.gclass139_0.imethod_1(binaryStream_0);
		}
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-4758);
		base.imethod_2(binaryStream_0);
		if (this.gclass139_0 != null)
		{
			this.gclass139_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass139 gclass139_0;
}

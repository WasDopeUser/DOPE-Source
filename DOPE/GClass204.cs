using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass204 : GClass196, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28116;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass204(GClass206 gclass206_1 = null, string string_0 = "", GClass197 gclass197_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.Name = "";
		base..ctor();
		if (gclass197_1 == null)
		{
			this.gclass197_0 = new GClass197(0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass197_0 = gclass197_1;
		}
		this.Name = string_0;
		if (gclass206_1 == null)
		{
			this.gclass206_0 = new GClass206(0);
			return;
		}
		this.gclass206_0 = gclass206_1;
	}

	public override int vmethod_0()
	{
		return 28116;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.gclass197_0 = (GClass197)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass197_0 != null)
		{
			this.gclass197_0.imethod_1(binaryStream_0);
		}
		this.Name = binaryStream_0.smethod_2();
		this.gclass206_0 = (GClass206)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass206_0 != null)
		{
			this.gclass206_0.imethod_1(binaryStream_0);
		}
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28116);
		base.imethod_2(binaryStream_0);
		if (this.gclass197_0 != null)
		{
			this.gclass197_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.Name);
		if (this.gclass206_0 != null)
		{
			this.gclass206_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass197 gclass197_0;

	public string Name;

	public GClass206 gclass206_0;
}

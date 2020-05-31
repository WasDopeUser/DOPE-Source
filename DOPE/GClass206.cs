using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass206 : GClass198, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12603;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass206(GClass208 gclass208_1 = null, string string_0 = "", GClass199 gclass199_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.Name = "";
		base..ctor();
		if (gclass208_1 == null)
		{
			this.gclass208_0 = new GClass208(0U);
		}
		else
		{
			this.gclass208_0 = gclass208_1;
		}
		this.Name = string_0;
		if (gclass199_1 == null)
		{
			this.gclass199_0 = new GClass199(0, 0, 0, 0, 0, 0);
			return;
		}
		this.gclass199_0 = gclass199_1;
	}

	public override int vmethod_0()
	{
		return 12603;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.gclass199_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass199);
		this.gclass199_0.HrqIugnatr8(binaryStream_0);
		this.gclass208_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass208);
		this.gclass208_0.HrqIugnatr8(binaryStream_0);
		this.Name = binaryStream_0.smethod_2();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12603);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass199_0.imethod_1(binaryStream_0);
		this.gclass208_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_3(this.Name);
	}

	public GClass199 gclass199_0;

	public GClass208 gclass208_0;

	public string Name;
}

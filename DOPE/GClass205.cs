using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass205 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 130;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass205(GClass207 gclass207_1 = null, string string_0 = "", GClass198 gclass198_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.Name = "";
		base..ctor();
		if (gclass207_1 == null)
		{
			this.gclass207_0 = new GClass207(0U);
		}
		else
		{
			this.gclass207_0 = gclass207_1;
		}
		this.Name = string_0;
		if (gclass198_1 == null)
		{
			this.gclass198_0 = new GClass198(0, 0, 0, 0, 0, 0);
			return;
		}
		this.gclass198_0 = gclass198_1;
	}

	public override int vmethod_0()
	{
		return 130;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass207_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass207);
		this.gclass207_0.imethod_1(binaryStream_0);
		this.Name = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass198_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass198);
		this.gclass198_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(130);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass207_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_7(-12264);
		this.gclass198_0.imethod_2(binaryStream_0);
	}

	public GClass207 gclass207_0;

	public string Name;

	public GClass198 gclass198_0;
}

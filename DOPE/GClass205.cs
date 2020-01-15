using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass205 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2650;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass205(GClass207 gclass207_1 = null, string string_0 = "", GClass198 gclass198_0 = null)
	{
		Class13.nIxas2ezryi9b();
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
		if (gclass198_0 == null)
		{
			this.kyLntditAM = new GClass198(0, 0, 0, 0, 0, 0);
			return;
		}
		this.kyLntditAM = gclass198_0;
	}

	public override int vmethod_0()
	{
		return 2650;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Name = binaryStream_0.smethod_2();
		this.gclass207_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass207);
		this.gclass207_0.imethod_1(binaryStream_0);
		this.kyLntditAM = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass198);
		this.kyLntditAM.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2650);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Name);
		this.gclass207_0.imethod_2(binaryStream_0);
		this.kyLntditAM.imethod_2(binaryStream_0);
	}

	public string Name;

	public GClass207 gclass207_0;

	public GClass198 kyLntditAM;
}

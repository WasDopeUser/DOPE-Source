using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass194 : GClass187, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29959;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass194(GClass195 gclass195_1 = null, string string_0 = "", GClass188 gclass188_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.Name = "";
		base..ctor();
		if (gclass195_1 == null)
		{
			this.gclass195_0 = new GClass195(0U);
		}
		else
		{
			this.gclass195_0 = gclass195_1;
		}
		this.Name = string_0;
		if (gclass188_1 == null)
		{
			this.gclass188_0 = new GClass188(0, 0, 0, 0, 0, 0);
			return;
		}
		this.gclass188_0 = gclass188_1;
	}

	public override int vmethod_0()
	{
		return 29959;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.gclass195_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass195);
		this.gclass195_0.imethod_1(binaryStream_0);
		this.Name = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass188_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass188);
		this.gclass188_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(29959);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		this.gclass195_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_5(-20153);
		this.gclass188_0.imethod_2(binaryStream_0);
	}

	public GClass195 gclass195_0;

	public string Name;

	public GClass188 gclass188_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass205 : GClass197, GInterface0
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

	public GClass205(GClass207 gclass207_1 = null, string string_0 = "", GClass198 gclass198_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.Name = "";
		base..ctor();
		if (gclass198_1 == null)
		{
			this.gclass198_0 = new GClass198(0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass198_0 = gclass198_1;
		}
		this.Name = string_0;
		if (gclass207_1 == null)
		{
			this.gclass207_0 = new GClass207(0);
			return;
		}
		this.gclass207_0 = gclass207_1;
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
		this.gclass198_0 = (GClass198)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass198_0 != null)
		{
			this.gclass198_0.imethod_1(binaryStream_0);
		}
		this.Name = binaryStream_0.smethod_2();
		this.gclass207_0 = (GClass207)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass207_0 != null)
		{
			this.gclass207_0.imethod_1(binaryStream_0);
		}
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28116);
		base.imethod_2(binaryStream_0);
		if (this.gclass198_0 != null)
		{
			this.gclass198_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.Name);
		if (this.gclass207_0 != null)
		{
			this.gclass207_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass198 gclass198_0;

	public string Name;

	public GClass207 gclass207_0;
}

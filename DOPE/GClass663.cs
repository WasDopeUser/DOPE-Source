using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass663 : GClass660, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28075;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass663(string string_1 = "", double double_1 = 0.0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor(string_1);
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 28075;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.double_0 = (double)binaryStream_0.smethod_10();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28075);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_7(-17101);
	}

	public double double_0;
}

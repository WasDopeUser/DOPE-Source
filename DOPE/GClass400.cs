using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass400 : GClass396, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31249;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass400()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 31249;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31249);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(2922);
		binaryStream_0.smethod_7(-25756);
	}
}

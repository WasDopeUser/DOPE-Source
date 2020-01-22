using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass489 : GClass488, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7375;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass489()
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 7375;
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
		binaryStream_0.smethod_7(7375);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(1042);
		binaryStream_0.smethod_7(5824);
	}
}

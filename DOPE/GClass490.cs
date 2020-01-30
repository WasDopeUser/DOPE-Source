using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass490 : GClass489, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31990;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass490()
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 31990;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31990);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(9385);
	}
}

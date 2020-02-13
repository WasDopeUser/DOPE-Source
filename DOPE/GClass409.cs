using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass409 : GClass403, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31937;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass409()
	{
		Class13.igxcIukzfpare();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 31937;
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
		binaryStream_0.smethod_6(31937);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-9773);
	}
}

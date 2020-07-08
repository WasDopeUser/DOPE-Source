using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass506 : GClass501, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -31486;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass506()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return -31486;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-31486);
		base.imethod_2(binaryStream_0);
	}
}

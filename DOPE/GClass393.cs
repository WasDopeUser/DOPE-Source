using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass393 : GClass387, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9941;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass393()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}

	public override int vmethod_0()
	{
		return 9941;
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
		binaryStream_0.smethod_5(9941);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_5(10381);
		binaryStream_0.smethod_5(-8065);
	}
}

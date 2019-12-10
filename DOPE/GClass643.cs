using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass643 : GClass640, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19837;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass643(int int_0 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 19837;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.Value = binaryStream_0.smethod_0();
		this.Value = (this.Value << 1 | U.smethod_0(this.Value, 31));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(19837);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-21540);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.Value, 1) | this.Value << 31);
	}

	public int Value;
}

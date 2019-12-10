using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass478 : GClass476, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24088;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass478(int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 24088;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(24088);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_5(26198);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
	}

	public int int_0;
}

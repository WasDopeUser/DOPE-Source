using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass203 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20718;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass203(int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 20718;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(20718);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_6(20001);
	}

	public int int_0;
}

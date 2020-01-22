using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass494 : GClass488, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9331;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass494(int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 9331;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9331);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_7(-7206);
	}

	public int int_0;
}

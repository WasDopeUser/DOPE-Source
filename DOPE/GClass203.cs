using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass203 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6757;
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
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 6757;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6757);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_7(-14285);
	}

	public int int_0;
}

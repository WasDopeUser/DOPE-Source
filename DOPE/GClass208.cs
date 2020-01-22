using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass208 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29618;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass208(bool bool_1 = false, int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.bool_0 = bool_1;
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 29618;
	}

	public override int vmethod_1()
	{
		return 5;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29618);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(-21260);
	}

	public int int_0;

	public bool bool_0;
}

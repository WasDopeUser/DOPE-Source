using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass208 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2338;
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
		Class13.igxcIukzfpare();
		base..ctor();
		this.bool_0 = bool_1;
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 2338;
	}

	public override int vmethod_1()
	{
		return 5;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(2338);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(-27747);
		binaryStream_0.smethod_3(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
	}

	public bool bool_0;

	public int int_0;
}

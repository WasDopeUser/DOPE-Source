using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass664 : GClass662, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25991;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass664(string string_1 = "", int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor(string_1);
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 25991;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25991);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(13681);
		binaryStream_0.smethod_3(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
	}

	public int int_0;
}

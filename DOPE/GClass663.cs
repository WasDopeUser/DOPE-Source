using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass663 : GClass662, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23105;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass663(string string_1 = "", int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor(string_1);
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 23105;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(23105);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_6(-26031);
		binaryStream_0.smethod_6(31722);
	}

	public int int_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass664 : GClass660, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12433;
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
		Class13.plZSWFPzBWWEZ();
		base..ctor(string_1);
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 12433;
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
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12433);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(18178);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
	}

	public int int_0;
}

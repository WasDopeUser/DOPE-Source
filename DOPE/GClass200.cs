using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass200 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8915;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass200(int int_1 = 0, string string_1 = "")
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_1;
		this.string_0 = string_1;
	}

	public override int vmethod_0()
	{
		return 8915;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8915);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(5845);
	}

	public int int_0;

	public string string_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass591 : GClass585, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4025;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass591(string string_1 = "", string string_2 = "")
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor(string_1);
		this.string_0 = string_2;
	}

	public override int vmethod_0()
	{
		return 4025;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4025);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(3859);
	}

	public string string_0;
}

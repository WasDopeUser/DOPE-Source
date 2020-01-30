using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass314 : GClass307, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10076;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass314(string string_1 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
	}

	public override int vmethod_0()
	{
		return 10076;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10076);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-9738);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-10721);
	}

	public string string_0;
}

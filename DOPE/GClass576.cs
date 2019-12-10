using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass576 : GClass573, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25847;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass576(string string_0 = "", int int_0 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(string_0);
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 25847;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (this.Value << 8 | U.smethod_0(this.Value, 24));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(25847);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.Value, 8) | this.Value << 24);
	}

	public int Value;
}

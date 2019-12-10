using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass258 : GClass257, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9955;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass258(string string_1 = "", int int_0 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(string_1);
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 9955;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (U.smethod_0(this.Value, 1) | this.Value << 31);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(9955);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.Value << 1 | U.smethod_0(this.Value, 31));
		binaryStream_0.smethod_5(27233);
	}

	public int Value;
}

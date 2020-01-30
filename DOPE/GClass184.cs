using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass184 : GClass179, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9267;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass184(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(string_1, int_3, int_4);
		this.int_2 = int_5;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	public override int vmethod_0()
	{
		return 9267;
	}

	public override int vmethod_1()
	{
		return 26;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9267);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public int int_2;

	public bool bool_0;

	public bool bool_1;
}

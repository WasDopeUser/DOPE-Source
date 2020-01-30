using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass398 : GClass395, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31663;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass398(int int_2 = 0, int int_3 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public override int vmethod_0()
	{
		return 31663;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31663);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
	}

	public int int_0;

	public int int_1;
}

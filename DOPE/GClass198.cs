using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass198 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22954;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass198(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_0 = int_5;
		this.int_4 = int_6;
		this.int_1 = int_7;
		this.int_3 = int_8;
		this.PpKipIxvnM = int_9;
		this.int_2 = int_10;
	}

	public override int vmethod_0()
	{
		return 22954;
	}

	public override int vmethod_1()
	{
		return 24;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 10) | this.int_3 << 22);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 2) | this.int_4 << 30);
		this.PpKipIxvnM = binaryStream_0.smethod_0();
		this.PpKipIxvnM = (U.smethod_0(this.PpKipIxvnM, 5) | this.PpKipIxvnM << 27);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22954);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_4(this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		binaryStream_0.smethod_4(this.int_3 << 10 | U.smethod_0(this.int_3, 22));
		binaryStream_0.smethod_4(this.int_4 << 2 | U.smethod_0(this.int_4, 30));
		binaryStream_0.smethod_4(this.PpKipIxvnM << 5 | U.smethod_0(this.PpKipIxvnM, 27));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int PpKipIxvnM;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass641 : GClass640, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3278;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass641(int int_1 = 0, uint uint_1 = 0U)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
		this.uint_0 = uint_1;
	}

	public override int vmethod_0()
	{
		return 3278;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(3278);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
	}

	public int int_0;

	public uint uint_0;
}

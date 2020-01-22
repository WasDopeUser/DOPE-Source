using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass409 : GClass402, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6484;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass409(int int_1 = 0, GClass363 gclass363_0 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
		if (gclass363_0 == null)
		{
			this.mYcAybjxpE = new GClass363(false);
			return;
		}
		this.mYcAybjxpE = gclass363_0;
	}

	public override int vmethod_0()
	{
		return 6484;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.mYcAybjxpE = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass363);
		this.mYcAybjxpE.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6484);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(9347);
		this.mYcAybjxpE.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
	}

	public GClass363 mYcAybjxpE;

	public int int_0;
}

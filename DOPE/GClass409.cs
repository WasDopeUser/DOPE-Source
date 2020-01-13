using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass409 : GClass402, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16123;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass409(int int_1 = 0, GClass363 gclass363_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_0 = int_1;
		if (gclass363_1 == null)
		{
			this.gclass363_0 = new GClass363(false);
			return;
		}
		this.gclass363_0 = gclass363_1;
	}

	public override int vmethod_0()
	{
		return 16123;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.gclass363_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass363);
		this.gclass363_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16123);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.gclass363_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass363 gclass363_0;
}

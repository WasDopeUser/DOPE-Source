using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass394 : GClass387, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6583;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass394(int int_1 = 0, GClass347 gclass347_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
		if (gclass347_1 == null)
		{
			this.gclass347_0 = new GClass347(false);
			return;
		}
		this.gclass347_0 = gclass347_1;
	}

	public override int vmethod_0()
	{
		return 6583;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.gclass347_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass347);
		this.gclass347_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6583);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.gclass347_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-12755);
	}

	public int int_0;

	public GClass347 gclass347_0;
}

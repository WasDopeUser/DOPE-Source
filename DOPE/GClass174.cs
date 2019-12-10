using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass174 : GClass172, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4631;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass174(string string_1 = "", int int_2 = 0, int int_3 = 0, GClass247 gclass247_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(string_1, int_2, int_3);
		if (gclass247_1 == null)
		{
			this.gclass247_0 = new GClass247(0U);
			return;
		}
		this.gclass247_0 = gclass247_1;
	}

	public override int vmethod_0()
	{
		return 4631;
	}

	public override int vmethod_1()
	{
		return 20;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass247_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass247);
		this.gclass247_0.imethod_1(binaryStream_0);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(4631);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-14110);
		binaryStream_0.smethod_5(3787);
		this.gclass247_0.imethod_2(binaryStream_0);
	}

	public GClass247 gclass247_0;
}

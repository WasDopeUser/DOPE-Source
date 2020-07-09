using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass182 : GClass180, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 147;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass182(string string_1 = "", int int_2 = 0, int int_3 = 0, GClass260 gclass260_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor(string_1, int_2, int_3);
		if (gclass260_1 == null)
		{
			this.gclass260_0 = new GClass260(0);
			return;
		}
		this.gclass260_0 = gclass260_1;
	}

	public override int vmethod_0()
	{
		return 147;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.gclass260_0 = (GClass260)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass260_0 != null)
		{
			this.gclass260_0.imethod_1(binaryStream_0);
		}
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(147);
		base.imethod_2(binaryStream_0);
		if (this.gclass260_0 != null)
		{
			this.gclass260_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass260 gclass260_0;
}

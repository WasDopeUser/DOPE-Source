using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass711 : GClass708, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -22984;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass711(string string_1 = "", double double_1 = 0.0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor(string_1);
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return -22984;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.double_0 = (double)binaryStream_0.smethod_10();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-22984);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_9(this.double_0);
	}

	public double double_0;
}

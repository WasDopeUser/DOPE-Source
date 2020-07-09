using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass394 : GClass392, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22640;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass394(int int_1 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 22640;
	}

	public override int vmethod_1()
	{
		return 0;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22640);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(this.int_0);
	}

	public int int_0;
}

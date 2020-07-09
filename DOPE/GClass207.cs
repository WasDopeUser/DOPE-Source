using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass207 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 692;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass207(int int_1 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 692;
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
		binaryStream_0.smethod_7(692);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(this.int_0);
	}

	public int int_0;
}

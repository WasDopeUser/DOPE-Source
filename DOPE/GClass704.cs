using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass704 : GClass701, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -18225;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass704(int int_0 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return -18225;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (U.smethod_0(this.Value, 2) | this.Value << 30);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-18225);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.Value << 2 | U.smethod_0(this.Value, 30));
	}

	public int Value;
}

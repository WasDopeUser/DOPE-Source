using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass202 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30411;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass202(bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public override int vmethod_0()
	{
		return 30411;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(30411);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-7596);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public bool bool_0;
}

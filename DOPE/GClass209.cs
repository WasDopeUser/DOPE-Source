using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass209 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14129;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass209(bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public override int vmethod_0()
	{
		return 14129;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14129);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(5614);
	}

	public bool bool_0;
}

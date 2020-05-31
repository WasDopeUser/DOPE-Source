using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass210 : GClass198, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1672;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass210(bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public override int vmethod_0()
	{
		return 1672;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1672);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(11058);
	}

	public bool bool_0;
}

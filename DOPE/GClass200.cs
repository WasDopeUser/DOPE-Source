using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass200 : GClass198, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21488;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass200(bool bool_0 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.jvLsprvaoU = bool_0;
	}

	public override int vmethod_0()
	{
		return 21488;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.jvLsprvaoU = binaryStream_0.ReadBoolean();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21488);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-11168);
		binaryStream_0.WriteBoolean(this.jvLsprvaoU);
	}

	public bool jvLsprvaoU;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass739 : GClass738, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26881;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass739(double double_1 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.double_0 = double_1;
	}

	public override int vmethod_0()
	{
		return 26881;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26881);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public double double_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass623 : GClass622, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14002;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass623(double double_0 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.fIteamRfud = double_0;
	}

	public override int vmethod_0()
	{
		return 14002;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.fIteamRfud = binaryStream_0.ReadDouble();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14002);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.fIteamRfud);
	}

	public double fIteamRfud;
}

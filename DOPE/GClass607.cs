using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass607 : GClass602, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29762;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass607(string string_0 = "", bool bool_0 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(string_0);
		this.Value = bool_0;
	}

	public override int vmethod_0()
	{
		return 29762;
	}

	public override int vmethod_1()
	{
		return 5;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.Value = binaryStream_0.ReadBoolean();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29762);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.Value);
	}

	public bool Value;
}

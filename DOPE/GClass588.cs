﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass588 : GClass586, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23231;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass588(string string_0 = "", int int_0 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor(string_0);
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return 23231;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (U.smethod_0(this.Value, 11) | this.Value << 21);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23231);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.Value << 11 | U.smethod_0(this.Value, 21));
	}

	public int Value;
}

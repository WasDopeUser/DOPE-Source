﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass200 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8246;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass200(int int_1 = 0, string string_0 = "")
	{
		Class13.nIxas2ezryi9b();
		this.QoknwFxgiS = "";
		base..ctor();
		this.int_0 = int_1;
		this.QoknwFxgiS = string_0;
	}

	public override int vmethod_0()
	{
		return 8246;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.QoknwFxgiS = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8246);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(23475);
		binaryStream_0.smethod_3(this.QoknwFxgiS);
		binaryStream_0.smethod_7(28159);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
	}

	public string QoknwFxgiS;

	public int int_0;
}

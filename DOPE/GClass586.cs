﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass586 : GClass585, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20422;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass586(string string_0 = "", string string_1 = "")
	{
		Class13.tMHx78BzgCM8j();
		this.Value = "";
		base..ctor(string_0);
		this.Value = string_1;
	}

	public override int vmethod_0()
	{
		return 20422;
	}

	public override int vmethod_1()
	{
		return 6;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Value = binaryStream_0.smethod_2();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20422);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(9698);
		binaryStream_0.smethod_7(-9170);
		binaryStream_0.smethod_3(this.Value);
	}

	public string Value;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass323 : GClass316, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5602;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass323(string string_1 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
	}

	public override int vmethod_0()
	{
		return 5602;
	}

	public override int vmethod_1()
	{
		return 2;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5602);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public string string_0;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass199 : GClass197, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2363;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass199(bool bool_1 = false)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public override int vmethod_0()
	{
		return 2363;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2363);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-31524);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public bool bool_0;
}

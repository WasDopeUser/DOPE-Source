﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass619 : GClass618, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29203;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass619(string string_0 = "", bool bool_0 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor(string_0);
		this.Value = bool_0;
	}

	public override int vmethod_0()
	{
		return 29203;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.ReadBoolean();
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29203);
		base.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.Value);
	}

	public bool Value;
}

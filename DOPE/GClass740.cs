﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass740 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16113;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass740(string string_1 = "", double double_0 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.Value = double_0;
	}

	public virtual int vmethod_0()
	{
		return 16113;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.Value = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16113);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_9(this.Value);
	}

	public string string_0;

	public double Value;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass543 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28767;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass543(string string_1 = "", string string_2 = "")
	{
		Class13.nIxas2ezryi9b();
		this.Value = "";
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.Value = string_2;
	}

	public virtual int vmethod_0()
	{
		return 28767;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Value = binaryStream_0.smethod_2();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28767);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Value);
		binaryStream_0.smethod_3(this.string_0);
	}

	public string Value;

	public string string_0;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass425 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7921;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass425(string string_1 = "", bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 7921;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7921);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-19721);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-20554);
	}

	public bool bool_0;

	public string string_0;
}

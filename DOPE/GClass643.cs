﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass643 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15416;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass643(string string_1 = "")
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 15416;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15416);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2834);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(16900);
	}

	public string string_0;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass156 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28428;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass156(int int_1 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 28428;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28428);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
	}

	public int int_0;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass454 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31333;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass454(int int_1 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 31333;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31333);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
	}

	public int int_0;
}

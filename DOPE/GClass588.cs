﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass588 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18669;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass588(int int_1 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 18669;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18669);
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
	}

	public int int_0;
}

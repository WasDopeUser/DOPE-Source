﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass681 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 35;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass681(int int_1 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 35;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_0 = (65535 & ((65535 & this.int_0) << 2 | U.smethod_0(65535 & this.int_0, 14)));
		this.int_0 = ((this.int_0 > 32767) ? (this.int_0 - 65536) : this.int_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(35);
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_0, 2) | (65535 & this.int_0) << 14));
	}

	public int int_0;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass704 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16421;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass704(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.int_0 = int_3;
		this.int_2 = int_4;
		this.int_1 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 16421;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 4 | U.smethod_0(this.int_2, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16421);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 4) | this.int_2 << 28);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

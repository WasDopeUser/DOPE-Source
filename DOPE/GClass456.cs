﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass456 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 191;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass456(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 191;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(191);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_4(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

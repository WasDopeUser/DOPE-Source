﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass487 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 186;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass487(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 186;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 6 | U.smethod_0(this.int_2, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(186);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 6) | this.int_2 << 26);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass265 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 90;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass265(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.int_3 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 90;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 14 | U.smethod_0(this.int_3, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(90);
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 14) | this.int_3 << 18);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}

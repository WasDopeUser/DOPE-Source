﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass239 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass239(int int_3 = 0, int int_4 = 0, string string_2 = "", string string_3 = "", int int_5 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.string_0 = string_2;
		this.string_1 = string_3;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 7;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.int_1 = (65535 & ((65535 & this.int_1) << 9 | U.smethod_0(65535 & this.int_1, 7)));
		this.int_1 = ((this.int_1 > 32767) ? (this.int_1 - 65536) : this.int_1);
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 12) | this.int_2 << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7);
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.smethod_7(65535 & (U.smethod_0(65535 & this.int_1, 9) | (65535 & this.int_1) << 7));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.int_2 << 12 | U.smethod_0(this.int_2, 20));
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public string string_1;

	public int int_2;
}

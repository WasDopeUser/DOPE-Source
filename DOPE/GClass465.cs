﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass465 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29997;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 32;
		}
	}

	public GClass465(int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, string string_2 = "", int int_12 = 0, string string_3 = "", int int_13 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_7;
		this.int_2 = int_8;
		this.int_4 = int_9;
		this.int_1 = int_10;
		this.int_3 = int_11;
		this.string_1 = string_2;
		this.int_6 = int_12;
		this.string_0 = string_3;
		this.int_5 = int_13;
	}

	public virtual int vmethod_0()
	{
		return 29997;
	}

	public virtual int vmethod_1()
	{
		return 32;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 16) | this.int_3 << 16);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 8) | this.int_4 << 24);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 6) | this.int_5 << 26);
		binaryStream_0.smethod_1();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 10) | this.int_6 << 22);
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29997);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		binaryStream_0.smethod_4(this.int_3 << 16 | U.smethod_0(this.int_3, 16));
		binaryStream_0.smethod_4(this.int_4 << 8 | U.smethod_0(this.int_4, 24));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_5 << 6 | U.smethod_0(this.int_5, 26));
		binaryStream_0.smethod_7(12005);
		binaryStream_0.smethod_4(this.int_6 << 10 | U.smethod_0(this.int_6, 22));
		binaryStream_0.smethod_3(this.string_1);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public string string_0;

	public int int_5;

	public int int_6;

	public string string_1;
}

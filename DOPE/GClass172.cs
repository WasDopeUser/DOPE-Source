﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass172 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29687;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass172(string string_1 = "", int int_2 = 0, int int_3 = 0)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 29687;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(29687);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_5(-9209);
		binaryStream_0.fUeiimuocMk(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
	}

	public int int_0;

	public string string_0;

	public int int_1;
}
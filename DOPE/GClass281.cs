﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass281 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25596;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass281(int int_2 = 0, int int_3 = 0, uint uint_1 = 0U)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 25596;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(25596);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_5(13457);
	}

	public int int_0;

	public uint uint_0;

	public int int_1;
}
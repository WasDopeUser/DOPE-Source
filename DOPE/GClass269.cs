﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass269 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11519;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass269(uint uint_1 = 0U, int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 11519;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(11519);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-25997);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
	}

	public int int_0;

	public uint uint_0;
}
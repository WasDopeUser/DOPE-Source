﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass302 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27721;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass302(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 27721;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27721);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_4(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
	}

	public int int_0;

	public int int_1;

	public int int_2;
}

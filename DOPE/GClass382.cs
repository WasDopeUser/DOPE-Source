﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass382 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28355;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass382(int int_1 = 0, int int_2 = 0, Vector<int> vector_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.int_0 = int_1;
		this.jccIinPsGy = int_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 28355;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.jccIinPsGy = binaryStream_0.smethod_0();
		this.jccIinPsGy = (U.smethod_0(this.jccIinPsGy, 15) | this.jccIinPsGy << 17);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 9 | U.smethod_0(num3, 23));
			this.vector_0.method_0(num3);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28355);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.jccIinPsGy << 15 | U.smethod_0(this.jccIinPsGy, 17));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 9) | num << 23);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_7(883);
	}

	public int jccIinPsGy;

	public Vector<int> vector_0;

	public int int_0;
}

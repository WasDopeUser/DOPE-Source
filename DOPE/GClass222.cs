﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass222 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12439;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass222(uint uint_0 = 0U, int int_1 = 0, Vector<int> vector_0 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.State = uint_0;
		this.int_0 = int_1;
		if (vector_0 == null)
		{
			this.GpbcoInvRv = new Vector<int>();
			return;
		}
		this.GpbcoInvRv = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 12439;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		while (this.GpbcoInvRv.Length > 0)
		{
			this.GpbcoInvRv.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 14 | U.smethod_0(num3, 18));
			this.GpbcoInvRv.method_0(num3);
			num++;
		}
		this.State = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12439);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_7(-25729);
		binaryStream_0.smethod_4(this.GpbcoInvRv.Length);
		foreach (int num in this.GpbcoInvRv)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 14) | num << 18);
		}
		binaryStream_0.smethod_6(this.State);
	}

	public int int_0;

	public Vector<int> GpbcoInvRv;

	public uint State;
}

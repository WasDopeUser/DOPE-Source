﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass729 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14334;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass729(int int_1 = 0, Vector<GClass307> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass307>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 14334;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass307 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass307;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14334);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_7(3238);
		binaryStream_0.smethod_7(29403);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass307 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public Vector<GClass307> vector_0;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass602 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7718;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass602(Vector<GClass137> vector_0 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (vector_0 == null)
		{
			this.Commands = new Vector<GClass137>();
			return;
		}
		this.Commands = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 7718;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.Commands.Length > 0)
		{
			this.Commands.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass137 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass137;
			gclass.imethod_1(binaryStream_0);
			this.Commands.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7718);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.Commands.Length);
		foreach (GClass137 gclass in this.Commands)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(-17420);
	}

	public Vector<GClass137> Commands;
}

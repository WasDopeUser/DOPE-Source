﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass325 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27576;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass325(Vector<GClass342> vector_1 = null, GClass342 gclass342_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass342>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass342_1 == null)
		{
			this.gclass342_0 = new GClass342(0, "", "", 0);
			return;
		}
		this.gclass342_0 = gclass342_1;
	}

	public virtual int vmethod_0()
	{
		return 27576;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass342_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass342);
		this.gclass342_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass342 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass342;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27576);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass342_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass342 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public GClass342 gclass342_0;

	public Vector<GClass342> vector_0;
}

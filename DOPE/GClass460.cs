﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass460 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2190;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass460(uint uint_1 = 0U, Vector<GClass652> vector_1 = null, bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.uint_0 = uint_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass652>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 2190;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass652 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass652;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2190);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass652 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public Vector<GClass652> vector_0;

	public bool bool_0;

	public uint uint_0;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass584 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -19366;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass584(Vector<GClass633> vector_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass633>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return -19366;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = (int)binaryStream_0.smethod_1();
		while (i < num)
		{
			GClass633 gclass = (GClass633)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-19366);
		binaryStream_0.smethod_7(this.vector_0.Length);
		foreach (GClass633 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass633> vector_0;
}

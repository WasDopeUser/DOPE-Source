﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass528 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28256;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass528(GClass497 gclass497_1 = null, Vector<GClass692> vector_2 = null, Vector<GClass692> vector_3 = null, double double_2 = 0.0, double double_3 = 0.0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass497_1 == null)
		{
			this.gclass497_0 = new GClass497(0, 0, 0);
		}
		else
		{
			this.gclass497_0 = gclass497_1;
		}
		this.double_0 = double_2;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass692>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass692>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		this.double_1 = double_3;
	}

	public virtual int vmethod_0()
	{
		return 28256;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass497_0 = (GClass497)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass497_0 != null)
		{
			this.gclass497_0.imethod_1(binaryStream_0);
		}
		this.double_0 = binaryStream_0.ReadDouble();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass692 gclass = (GClass692)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass692 gclass2 = (GClass692)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			i++;
		}
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28256);
		if (this.gclass497_0 != null)
		{
			this.gclass497_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass692 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass692 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.double_1);
	}

	public GClass497 gclass497_0;

	public double double_0;

	public Vector<GClass692> vector_0;

	public Vector<GClass692> vector_1;

	public double double_1;
}

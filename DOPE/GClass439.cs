﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass439 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -17432;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass439(int int_1 = 0, string string_1 = "", GClass342 gclass342_1 = null, Vector<GClass817> vector_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass817>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass342_1 == null)
		{
			this.gclass342_0 = new GClass342(0);
		}
		else
		{
			this.gclass342_0 = gclass342_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -17432;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass817 gclass = (GClass817)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass342_0 = (GClass342)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass342_0 != null)
		{
			this.gclass342_0.imethod_1(binaryStream_0);
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-17432);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass817 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass342_0 != null)
		{
			this.gclass342_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_0);
	}

	public string string_0;

	public Vector<GClass817> vector_0;

	public GClass342 gclass342_0;

	public int int_0;
}

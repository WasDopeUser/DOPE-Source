﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass278 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 801;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass278(Vector<GClass237> vector_1 = null, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass237>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 801;
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
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass237 gclass = (GClass237)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(801);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass237 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public Vector<GClass237> vector_0;

	public bool bool_0;
}

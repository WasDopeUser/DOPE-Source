﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass217 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14280;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass217(string string_3 = "", string string_4 = "", string string_5 = "", GClass616 gclass616_0 = null, Vector<GClass558> vector_1 = null)
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_0 = string_3;
		this.string_1 = string_4;
		this.string_2 = string_5;
		if (gclass616_0 == null)
		{
			this.oycnjfslHJ = new GClass616(0U);
		}
		else
		{
			this.oycnjfslHJ = gclass616_0;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass558>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 14280;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass558 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass558;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_2 = binaryStream_0.smethod_2();
		this.oycnjfslHJ = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass616);
		this.oycnjfslHJ.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14280);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass558 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_2);
		this.oycnjfslHJ.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-10354);
	}

	public string string_0;

	public string string_1;

	public Vector<GClass558> vector_0;

	public string string_2;

	public GClass616 oycnjfslHJ;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass500 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 254;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass500(string string_1 = "", GClass334 gclass334_1 = null, Vector<GClass317> vector_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass334_1 == null)
		{
			this.gclass334_0 = new GClass334(0U);
		}
		else
		{
			this.gclass334_0 = gclass334_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass317>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 254;
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
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass317 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass317;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.gclass334_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass334);
		this.gclass334_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(254);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass317 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(-13674);
		this.gclass334_0.imethod_2(binaryStream_0);
	}

	public string string_0;

	public Vector<GClass317> vector_0;

	public GClass334 gclass334_0;
}

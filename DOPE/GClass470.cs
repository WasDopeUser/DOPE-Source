﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass470 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9221;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass470(GClass631 gclass631_1 = null, string string_1 = "", GClass581 gclass581_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		if (gclass631_1 == null)
		{
			this.gclass631_0 = new GClass631(0U);
		}
		else
		{
			this.gclass631_0 = gclass631_1;
		}
		this.string_0 = string_1;
		if (gclass581_1 == null)
		{
			this.gclass581_0 = new GClass581(0U);
			return;
		}
		this.gclass581_0 = gclass581_1;
	}

	public virtual int vmethod_0()
	{
		return 9221;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass581_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass581);
		this.gclass581_0.imethod_1(binaryStream_0);
		this.gclass631_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass631);
		this.gclass631_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9221);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8341);
		this.gclass581_0.imethod_2(binaryStream_0);
		this.gclass631_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-24063);
	}

	public GClass581 gclass581_0;

	public GClass631 gclass631_0;

	public string string_0;
}

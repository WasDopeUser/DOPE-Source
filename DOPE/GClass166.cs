﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass166 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19565;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass166(GClass135 gclass135_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass135_1 == null)
		{
			this.gclass135_0 = new GClass135(null, 0.0);
			return;
		}
		this.gclass135_0 = gclass135_1;
	}

	public virtual int vmethod_0()
	{
		return 19565;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass135_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass135);
		this.gclass135_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19565);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass135_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(8477);
	}

	public GClass135 gclass135_0;
}

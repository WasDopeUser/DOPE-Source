﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass413 : GClass406, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -31248;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass413(int int_1 = 0, GClass365 gclass365_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_1;
		if (gclass365_1 == null)
		{
			this.gclass365_0 = new GClass365(false);
			return;
		}
		this.gclass365_0 = gclass365_1;
	}

	public override int vmethod_0()
	{
		return -31248;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.gclass365_0 = (GClass365)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass365_0 != null)
		{
			this.gclass365_0.imethod_1(binaryStream_0);
		}
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-31248);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		if (this.gclass365_0 != null)
		{
			this.gclass365_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public GClass365 gclass365_0;
}

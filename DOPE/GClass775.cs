﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass775 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9384;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass775(int int_0 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 9384;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 13 | U.smethod_0(this.MapId, 19));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9384);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22556);
		binaryStream_0.smethod_7(-16980);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 13) | this.MapId << 19);
	}

	public int MapId;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass741 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16104;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass741(bool bool_0 = false)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.NgyBhnmmaH = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 16104;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.NgyBhnmmaH = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16104);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30110);
		binaryStream_0.WriteBoolean(this.NgyBhnmmaH);
	}

	public bool NgyBhnmmaH;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass504 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28106;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass504(uint uint_1 = 0U)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 28106;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28106);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(28242);
		binaryStream_0.smethod_7(27193);
	}

	public uint uint_0;
}

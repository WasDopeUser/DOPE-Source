﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass378 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11083;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass378(double double_1 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 11083;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(11083);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_5(-17565);
		binaryStream_0.smethod_5(-18107);
	}

	public double double_0;
}
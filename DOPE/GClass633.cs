﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass633 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27871;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass633(GClass201 gclass201_1 = null, int int_1 = 0, int int_2 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		this.wCnkUsatqs = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 27871;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.wCnkUsatqs = binaryStream_0.smethod_0();
		this.wCnkUsatqs = (this.wCnkUsatqs << 5 | U.smethod_0(this.wCnkUsatqs, 27));
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_1();
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27871);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.wCnkUsatqs, 5) | this.wCnkUsatqs << 27);
		binaryStream_0.smethod_7(-30759);
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.smethod_7(-22233);
		this.gclass201_0.imethod_2(binaryStream_0);
	}

	public int wCnkUsatqs;

	public int int_0;

	public GClass201 gclass201_0;
}

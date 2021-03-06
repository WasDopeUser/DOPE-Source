﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass256 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 234;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass256(GClass257 gclass257_1 = null, int int_2 = 0, int int_3 = 0, bool bool_0 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass257_1 == null)
		{
			this.gclass257_0 = new GClass257(0);
		}
		else
		{
			this.gclass257_0 = gclass257_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.Enabled = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 234;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass257_0 = (GClass257)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass257_0 != null)
		{
			this.gclass257_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.Enabled = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(234);
		if (this.gclass257_0 != null)
		{
			this.gclass257_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_4(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.WriteBoolean(this.Enabled);
	}

	public GClass257 gclass257_0;

	public int int_0;

	public int int_1;

	public bool Enabled;
}

﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass844 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 342;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass844(GClass352 gclass352_1 = null, int int_2 = 0, int int_3 = 0, bool bool_1 = false)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass352_1 == null)
		{
			this.gclass352_0 = new GClass352(0);
		}
		else
		{
			this.gclass352_0 = gclass352_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 342;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass352_0 = (GClass352)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass352_0 != null)
		{
			this.gclass352_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(342);
		if (this.gclass352_0 != null)
		{
			this.gclass352_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass352 gclass352_0;

	public int int_0;

	public int int_1;

	public bool bool_0;
}

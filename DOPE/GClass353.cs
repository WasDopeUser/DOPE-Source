﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass353 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28805;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass353(int int_3 = 0, int int_4 = 0, bool bool_1 = false, int int_5 = 0, GClass318 gclass318_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.bool_0 = bool_1;
		this.int_2 = int_5;
		if (gclass318_1 == null)
		{
			this.gclass318_0 = new GClass318(0U);
			return;
		}
		this.gclass318_0 = gclass318_1;
	}

	public virtual int vmethod_0()
	{
		return 28805;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.gclass318_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass318);
		this.gclass318_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28805);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.gclass318_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_7(4071);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public GClass318 gclass318_0;

	public int int_1;

	public int int_2;

	public bool bool_0;
}

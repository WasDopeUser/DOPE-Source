﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass551 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13236;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass551(bool bool_1 = false, GClass365 gclass365_2 = null, GClass365 gclass365_3 = null, GClass512 gclass512_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.bool_0 = bool_1;
		if (gclass365_2 == null)
		{
			this.gclass365_1 = new GClass365("", 0, 0, 0, 0, 0, 0, 0.0);
		}
		else
		{
			this.gclass365_1 = gclass365_2;
		}
		if (gclass365_3 == null)
		{
			this.gclass365_0 = new GClass365("", 0, 0, 0, 0, 0, 0, 0.0);
		}
		else
		{
			this.gclass365_0 = gclass365_3;
		}
		if (gclass512_1 == null)
		{
			this.gclass512_0 = new GClass512("");
			return;
		}
		this.gclass512_0 = gclass512_1;
	}

	public virtual int vmethod_0()
	{
		return 13236;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass365_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass365);
		this.gclass365_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass512_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass512);
		this.gclass512_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass365_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass365);
		this.gclass365_1.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13236);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass365_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(16820);
		this.gclass512_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-6187);
		this.gclass365_1.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass365 gclass365_0;

	public GClass512 gclass512_0;

	public GClass365 gclass365_1;

	public bool bool_0;
}

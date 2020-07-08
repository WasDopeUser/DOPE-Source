using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass164 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -18919;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass164(GClass256 gclass256_1 = null, bool bool_1 = false)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass256_1 == null)
		{
			this.gclass256_0 = new GClass256(0);
		}
		else
		{
			this.gclass256_0 = gclass256_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return -18919;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass256_0 = (GClass256)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass256_0 != null)
		{
			this.gclass256_0.imethod_1(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-18919);
		if (this.gclass256_0 != null)
		{
			this.gclass256_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass256 gclass256_0;

	public bool bool_0;
}

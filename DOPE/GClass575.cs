using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass575 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1283;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass575(bool bool_1 = false, GClass368 gclass368_2 = null, GClass368 gclass368_3 = null, GClass527 gclass527_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass368_3 == null)
		{
			this.gclass368_0 = new GClass368("", 0, 0, 0, 0, 0, 0, 0.0);
		}
		else
		{
			this.gclass368_0 = gclass368_3;
		}
		this.bool_0 = bool_1;
		if (gclass527_1 == null)
		{
			this.gclass527_0 = new GClass527("");
		}
		else
		{
			this.gclass527_0 = gclass527_1;
		}
		if (gclass368_2 == null)
		{
			this.gclass368_1 = new GClass368("", 0, 0, 0, 0, 0, 0, 0.0);
			return;
		}
		this.gclass368_1 = gclass368_2;
	}

	public virtual int vmethod_0()
	{
		return 1283;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass368_0 = (GClass368)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass368_0 != null)
		{
			this.gclass368_0.imethod_1(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass527_0 = (GClass527)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass527_0 != null)
		{
			this.gclass527_0.imethod_1(binaryStream_0);
		}
		this.gclass368_1 = (GClass368)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass368_1 != null)
		{
			this.gclass368_1.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1283);
		if (this.gclass368_0 != null)
		{
			this.gclass368_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.gclass527_0 != null)
		{
			this.gclass527_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass368_1 != null)
		{
			this.gclass368_1.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass368 gclass368_0;

	public bool bool_0;

	public GClass527 gclass527_0;

	public GClass368 gclass368_1;
}

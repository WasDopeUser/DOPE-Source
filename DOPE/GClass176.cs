using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass176 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15783;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass176(GClass790 gclass790_1 = null, GClass615 gclass615_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass615_1 == null)
		{
			this.gclass615_0 = new GClass615(0, null);
		}
		else
		{
			this.gclass615_0 = gclass615_1;
		}
		if (gclass790_1 == null)
		{
			this.gclass790_0 = new GClass790(0, null);
			return;
		}
		this.gclass790_0 = gclass790_1;
	}

	public virtual int vmethod_0()
	{
		return 15783;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass615_0 = (GClass615)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass615_0 != null)
		{
			this.gclass615_0.imethod_1(binaryStream_0);
		}
		this.gclass790_0 = (GClass790)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass790_0 != null)
		{
			this.gclass790_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15783);
		if (this.gclass615_0 != null)
		{
			this.gclass615_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass790_0 != null)
		{
			this.gclass790_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass615 gclass615_0;

	public GClass790 gclass790_0;
}

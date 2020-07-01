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

	public GClass176(GClass790 gclass790_1 = null, GClass614 gclass614_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass614_1 == null)
		{
			this.gclass614_0 = new GClass614(0, null);
		}
		else
		{
			this.gclass614_0 = gclass614_1;
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

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass614_0 = (GClass614)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass614_0 != null)
		{
			this.gclass614_0.imethod_0(binaryStream_0);
		}
		this.gclass790_0 = (GClass790)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass790_0 != null)
		{
			this.gclass790_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15783);
		if (this.gclass614_0 != null)
		{
			this.gclass614_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass790_0 != null)
		{
			this.gclass790_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass614 gclass614_0;

	public GClass790 gclass790_0;
}

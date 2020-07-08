using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass175 : GInterface0
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

	public GClass175(GClass789 gclass789_1 = null, GClass614 gclass614_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass614_1 == null)
		{
			this.gclass614_0 = new GClass614(0, null);
		}
		else
		{
			this.gclass614_0 = gclass614_1;
		}
		if (gclass789_1 == null)
		{
			this.gclass789_0 = new GClass789(0, null);
			return;
		}
		this.gclass789_0 = gclass789_1;
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
		this.gclass614_0 = (GClass614)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass614_0 != null)
		{
			this.gclass614_0.imethod_1(binaryStream_0);
		}
		this.gclass789_0 = (GClass789)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass789_0 != null)
		{
			this.gclass789_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15783);
		if (this.gclass614_0 != null)
		{
			this.gclass614_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass789_0 != null)
		{
			this.gclass789_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass614 gclass614_0;

	public GClass789 gclass789_0;
}

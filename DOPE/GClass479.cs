using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass479 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -17051;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass479(GClass673 gclass673_1 = null, string string_1 = "", GClass614 gclass614_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		if (gclass673_1 == null)
		{
			this.gclass673_0 = new GClass673(0);
		}
		else
		{
			this.gclass673_0 = gclass673_1;
		}
		if (gclass614_1 == null)
		{
			this.gclass614_0 = new GClass614(0);
		}
		else
		{
			this.gclass614_0 = gclass614_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return -17051;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass673_0 = (GClass673)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass673_0 != null)
		{
			this.gclass673_0.imethod_1(binaryStream_0);
		}
		this.gclass614_0 = (GClass614)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass614_0 != null)
		{
			this.gclass614_0.imethod_1(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-17051);
		if (this.gclass673_0 != null)
		{
			this.gclass673_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass614_0 != null)
		{
			this.gclass614_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
	}

	public GClass673 gclass673_0;

	public GClass614 gclass614_0;

	public string string_0;
}

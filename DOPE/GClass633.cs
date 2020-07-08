using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass633 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8128;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass633(string string_1 = "", double double_1 = 0.0, GClass664 gclass664_1 = null, GClass783 gclass783_0 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		if (gclass783_0 == null)
		{
			this.Status = new GClass783();
		}
		else
		{
			this.Status = gclass783_0;
		}
		if (gclass664_1 == null)
		{
			this.gclass664_0 = new GClass664();
		}
		else
		{
			this.gclass664_0 = gclass664_1;
		}
		this.string_0 = string_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 8128;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Status = (GClass783)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Status != null)
		{
			this.Status.imethod_1(binaryStream_0);
		}
		this.gclass664_0 = (GClass664)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass664_0 != null)
		{
			this.gclass664_0.imethod_1(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8128);
		if (this.Status != null)
		{
			this.Status.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass664_0 != null)
		{
			this.gclass664_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public GClass783 Status;

	public GClass664 gclass664_0;

	public string string_0;

	public double double_0;
}

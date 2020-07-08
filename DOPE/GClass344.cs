using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass344 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -23120;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass344(string string_1 = "", double double_1 = 0.0, GClass783 gclass783_0 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.double_0 = double_1;
		if (gclass783_0 == null)
		{
			this.Status = new GClass783();
		}
		else
		{
			this.Status = gclass783_0;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return -23120;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.Status = (GClass783)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Status != null)
		{
			this.Status.imethod_1(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-23120);
		binaryStream_0.WriteDouble(this.double_0);
		if (this.Status != null)
		{
			this.Status.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
	}

	public double double_0;

	public GClass783 Status;

	public string string_0;
}

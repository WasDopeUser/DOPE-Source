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

	public GClass633(string string_1 = "", double double_1 = 0.0, GClass665 gclass665_1 = null, GClass784 gclass784_0 = null)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		if (gclass784_0 == null)
		{
			this.Status = new GClass784();
		}
		else
		{
			this.Status = gclass784_0;
		}
		if (gclass665_1 == null)
		{
			this.gclass665_0 = new GClass665();
		}
		else
		{
			this.gclass665_0 = gclass665_1;
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

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Status = (GClass784)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Status != null)
		{
			this.Status.imethod_0(binaryStream_0);
		}
		this.gclass665_0 = (GClass665)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass665_0 != null)
		{
			this.gclass665_0.imethod_0(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8128);
		if (this.Status != null)
		{
			this.Status.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass665_0 != null)
		{
			this.gclass665_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public GClass784 Status;

	public GClass665 gclass665_0;

	public string string_0;

	public double double_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass586 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24869;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass586(string string_1 = "", double double_1 = 0.0, GClass609 gclass609_1 = null, GClass712 gclass712_0 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
		if (gclass609_1 == null)
		{
			this.gclass609_0 = new GClass609();
		}
		else
		{
			this.gclass609_0 = gclass609_1;
		}
		if (gclass712_0 == null)
		{
			this.Status = new GClass712();
			return;
		}
		this.Status = gclass712_0;
	}

	public virtual int vmethod_0()
	{
		return 24869;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass712);
		this.Status.imethod_1(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
		this.gclass609_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass609);
		this.gclass609_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(24869);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.Status.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		this.gclass609_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public GClass712 Status;

	public double double_0;

	public GClass609 gclass609_0;

	public string string_0;
}

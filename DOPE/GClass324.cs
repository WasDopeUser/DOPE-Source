using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass324 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15980;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass324(string string_1 = "", double double_1 = 0.0, GClass712 gclass712_0 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
		if (gclass712_0 == null)
		{
			this.Status = new GClass712();
			return;
		}
		this.Status = gclass712_0;
	}

	public virtual int vmethod_0()
	{
		return 15980;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass712);
		this.Status.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(15980);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_5(-13400);
		binaryStream_0.smethod_3(this.string_0);
		this.Status.imethod_2(binaryStream_0);
	}

	public double double_0;

	public string string_0;

	public GClass712 Status;
}

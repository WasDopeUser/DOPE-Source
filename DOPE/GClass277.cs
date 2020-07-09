using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass277 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23376;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass277(string string_0 = "", GClass814 gclass814_1 = null, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		this.Id = "";
		base..ctor();
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.bool_0 = bool_1;
		this.Id = string_0;
		if (gclass814_1 == null)
		{
			this.gclass814_0 = new GClass814(0);
			return;
		}
		this.gclass814_0 = gclass814_1;
	}

	public virtual int vmethod_0()
	{
		return 23376;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Id = binaryStream_0.smethod_2();
		this.gclass814_0 = (GClass814)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass814_0 != null)
		{
			this.gclass814_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23376);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.Id);
		if (this.gclass814_0 != null)
		{
			this.gclass814_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public double double_0;

	public double double_1;

	public bool bool_0;

	public string Id;

	public GClass814 gclass814_0;
}

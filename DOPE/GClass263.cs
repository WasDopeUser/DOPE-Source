using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass263 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10867;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass263(string string_0 = "", GClass743 gclass743_1 = null, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		this.Id = "";
		base..ctor();
		this.Id = string_0;
		if (gclass743_1 == null)
		{
			this.gclass743_0 = new GClass743(0U);
		}
		else
		{
			this.gclass743_0 = gclass743_1;
		}
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 10867;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		this.gclass743_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass743);
		this.gclass743_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.double_1 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(10867);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Id);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_5(18420);
		this.gclass743_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(21690);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteDouble(this.double_1);
	}

	public string Id;

	public double double_0;

	public GClass743 gclass743_0;

	public bool bool_0;

	public double double_1;
}

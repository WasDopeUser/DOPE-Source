using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass277 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16582;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass277(string string_0 = "", GClass754 gclass754_1 = null, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		this.Id = "";
		base..ctor();
		this.Id = string_0;
		if (gclass754_1 == null)
		{
			this.gclass754_0 = new GClass754(0U);
		}
		else
		{
			this.gclass754_0 = gclass754_1;
		}
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 16582;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.Id = binaryStream_0.smethod_2();
		this.gclass754_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass754);
		this.gclass754_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(16582);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.MoioCjQkqp0(this.Id);
		this.gclass754_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-9777);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public double double_0;

	public double double_1;

	public string Id;

	public GClass754 gclass754_0;

	public bool bool_0;
}

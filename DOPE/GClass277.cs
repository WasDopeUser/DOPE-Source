using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass277 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4131;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass277(string string_0 = "", GClass752 gclass752_1 = null, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		this.Id = "";
		base..ctor();
		this.Id = string_0;
		if (gclass752_1 == null)
		{
			this.gclass752_0 = new GClass752(0U);
		}
		else
		{
			this.gclass752_0 = gclass752_1;
		}
		this.double_1 = double_2;
		this.double_0 = double_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 4131;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.double_1 = binaryStream_0.ReadDouble();
		this.gclass752_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass752);
		this.gclass752_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4131);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_7(-5175);
		binaryStream_0.smethod_7(-8549);
		binaryStream_0.smethod_3(this.Id);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteDouble(this.double_1);
		this.gclass752_0.imethod_2(binaryStream_0);
	}

	public double double_0;

	public string Id;

	public bool bool_0;

	public double double_1;

	public GClass752 gclass752_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass281 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8019;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass281(string string_0 = "", GClass767 gclass767_0 = null, double double_1 = 0.0, double double_2 = 0.0, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		this.Id = "";
		base..ctor();
		this.Id = string_0;
		if (gclass767_0 == null)
		{
			this.tMxjqgdyoA = new GClass767(0U);
		}
		else
		{
			this.tMxjqgdyoA = gclass767_0;
		}
		this.cYhjMitRnR = double_1;
		this.double_0 = double_2;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 8019;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.cYhjMitRnR = binaryStream_0.ReadDouble();
		this.Id = binaryStream_0.smethod_2();
		this.tMxjqgdyoA = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass767);
		this.tMxjqgdyoA.HrqIugnatr8(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8019);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.cYhjMitRnR);
		binaryStream_0.smethod_3(this.Id);
		this.tMxjqgdyoA.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public double double_0;

	public double cYhjMitRnR;

	public string Id;

	public GClass767 tMxjqgdyoA;

	public bool bool_0;
}

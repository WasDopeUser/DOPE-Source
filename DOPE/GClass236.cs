using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass236 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31162;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass236(GClass178 gclass178_1 = null, GClass767 gclass767_1 = null, double double_1 = 0.0, double double_2 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0U);
		}
		else
		{
			this.gclass178_0 = gclass178_1;
		}
		if (gclass767_1 == null)
		{
			this.gclass767_0 = new GClass767(0U);
		}
		else
		{
			this.gclass767_0 = gclass767_1;
		}
		this.double_0 = double_1;
		this.JylwbjKjnn = double_2;
	}

	public virtual int vmethod_0()
	{
		return 31162;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass178_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass178);
		this.gclass178_0.HrqIugnatr8(binaryStream_0);
		this.JylwbjKjnn = binaryStream_0.ReadDouble();
		this.double_0 = binaryStream_0.ReadDouble();
		this.gclass767_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass767);
		this.gclass767_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31162);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass178_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteDouble(this.JylwbjKjnn);
		binaryStream_0.WriteDouble(this.double_0);
		this.gclass767_0.imethod_1(binaryStream_0);
	}

	public GClass178 gclass178_0;

	public double JylwbjKjnn;

	public double double_0;

	public GClass767 gclass767_0;
}

using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass433 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30086;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass433(GClass776 gclass776_1 = null, uint uint_1 = 0U, double double_1 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass776_1 == null)
		{
			this.gclass776_0 = new GClass776(0U);
		}
		else
		{
			this.gclass776_0 = gclass776_1;
		}
		this.uint_0 = uint_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 30086;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass776_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass776);
		this.gclass776_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30086);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass776_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-12176);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public GClass776 gclass776_0;

	public uint uint_0;

	public double double_0;
}

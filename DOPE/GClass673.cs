using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass673 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28082;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass673(GClass776 gclass776_1 = null, uint uint_1 = 0U)
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
	}

	public virtual int vmethod_0()
	{
		return 28082;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass776_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass776);
		this.gclass776_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28082);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass776_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(13865);
	}

	public uint uint_0;

	public GClass776 gclass776_0;
}

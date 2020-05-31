using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass757 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 317;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass757(GClass570 gclass570_1 = null, uint uint_0 = 0U)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass570_1 == null)
		{
			this.gclass570_0 = new GClass570(null, 0U);
		}
		else
		{
			this.gclass570_0 = gclass570_1;
		}
		this.rbqreijhpI = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 317;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass570_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass570);
		this.gclass570_0.HrqIugnatr8(binaryStream_0);
		this.rbqreijhpI = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(317);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21547);
		binaryStream_0.smethod_7(-19161);
		this.gclass570_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_6(this.rbqreijhpI);
	}

	public GClass570 gclass570_0;

	public uint rbqreijhpI;
}

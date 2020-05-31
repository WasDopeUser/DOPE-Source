using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass350 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10826;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass350(GClass355 gclass355_1 = null, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass355_1 == null)
		{
			this.gclass355_0 = new GClass355(0U);
		}
		else
		{
			this.gclass355_0 = gclass355_1;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 10826;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass355_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass355);
		this.gclass355_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10826);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20343);
		binaryStream_0.smethod_7(23032);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass355_0.imethod_1(binaryStream_0);
	}

	public bool bool_0;

	public GClass355 gclass355_0;
}

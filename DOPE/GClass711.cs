using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass711 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9922;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass711(GClass201 gclass201_1 = null, GClass472 gclass472_1 = null, double double_1 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (gclass472_1 == null)
		{
			this.gclass472_0 = new GClass472(0U);
		}
		else
		{
			this.gclass472_0 = gclass472_1;
		}
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 9922;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_10();
		binaryStream_0.smethod_1();
		this.gclass472_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass472);
		this.gclass472_0.imethod_1(binaryStream_0);
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9922);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_7(-29596);
		this.gclass472_0.imethod_2(binaryStream_0);
		this.gclass201_0.imethod_2(binaryStream_0);
	}

	public double double_0;

	public GClass472 gclass472_0;

	public GClass201 gclass201_0;
}

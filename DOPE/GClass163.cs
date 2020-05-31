using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass163 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27299;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass163(GClass262 gclass262_1 = null, int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass262_1 == null)
		{
			this.gclass262_0 = new GClass262(0U);
		}
		else
		{
			this.gclass262_0 = gclass262_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 27299;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass262_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass262);
		this.gclass262_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27299);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7161);
		this.gclass262_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(16111);
		binaryStream_0.smethod_7(this.int_0);
	}

	public GClass262 gclass262_0;

	public int int_0;
}

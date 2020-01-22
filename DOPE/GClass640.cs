using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass640 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1953;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass640(GClass139 gclass139_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0U);
		}
		else
		{
			this.gclass139_0 = gclass139_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 1953;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.gclass139_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass139);
		this.gclass139_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1953);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_7(3382);
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.gclass139_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public int int_1;

	public GClass139 gclass139_0;
}

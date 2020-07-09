using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass688 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8725;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass688(GClass139 gclass139_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_3;
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0);
		}
		else
		{
			this.gclass139_0 = gclass139_1;
		}
		this.int_1 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 8725;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.gclass139_0 = (GClass139)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass139_0 != null)
		{
			this.gclass139_0.imethod_1(binaryStream_0);
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8725);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		if (this.gclass139_0 != null)
		{
			this.gclass139_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
	}

	public int int_0;

	public GClass139 gclass139_0;

	public int int_1;
}
